using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataModels;
using thinger.ToolLib;

namespace thinger.MTHProject
{
    public partial class FrmRecipe : Form
    {
        public FrmRecipe()
        {
            InitializeComponent();

            //禁止生成自动列
            this.dgv_RecipeList.AutoGenerateColumns = false;
            GetRecipeList();
        }
        //所有配方的集合
        private List<RecipeInfo> recipeList = new List<RecipeInfo>();
        //ini配方文件路径
        private string recipePath = Application.StartupPath + ConfigurationManager.AppSettings["recipePath"].ToString();

        #region 新增配方
        //私有对象：封装配方实体对象
        private RecipeInfo GetNewRecipeInfo()
        {
            RecipeInfo recipeInfo = new RecipeInfo()
            {
                RecipeName = this.txt_SelectdRecipeName.Text.Trim(),
                RecipeParams = new List<RecipeParam>()//封装配方6个站点的参数
                {
                    this.recipeControl1.RecipeParam,
                    this.recipeControl2.RecipeParam,
                    this.recipeControl3.RecipeParam,
                    this.recipeControl4.RecipeParam,
                    this.recipeControl5.RecipeParam,
                    this.recipeControl6.RecipeParam
                }
            };
            return recipeInfo;
        }

        //写入配方文件
        private bool WriteRecipeFile(RecipeInfo recipeInfo)
        {
            //把配方实体对象，转换成Josh字符串
            string joshRecipe = JSONHelper.EntityToJSON<RecipeInfo>(recipeInfo);
            //保存ini文件路径
            string filePaeh = recipePath + "\\" + recipeInfo.RecipeName + ".ini";
            //把JOSH字符串写入ini文件
            return IniConfigHelper.WriteIniData("配方", "配方数据", joshRecipe, filePaeh);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (this.txt_SelectdRecipeName.Text.Trim().Length == 0)
            {
                MessageBox.Show("配方名称不能为空", "提示信息");
                this.txt_SelectdRecipeName.Focus();//让文本框再次获得焦点
                return;
            }

            var recipe = recipeList.Where(c => c.RecipeName == this.txt_SelectdRecipeName.Text.Trim()).FirstOrDefault();
            if (recipe != null)
            {
                MessageBox.Show("配方名称不能重复", "提示信息");
                this.txt_SelectdRecipeName.SelectAll();//选中文本框中的所有文本
                return;
            }
            //封装一个新的配方对象
            RecipeInfo recipeInfo = GetNewRecipeInfo();

            try
            {
                //写入配方文件
                bool result = WriteRecipeFile(recipeInfo);
                if (result)
                {
                    MessageBox.Show("配方保存成功", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    //把配方添加到配方列表
                    recipeList.Add(recipeInfo);
                    //添加配方成功后，应该要配方显示到配方列表中
                }
                else
                {
                    MessageBox.Show("配方保存失败,请检查配方格式和保存路径", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("配方保存失败" + ex.Message, "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region 加载所有配方,并显示到dgv列表里
        private void GetRecipeList()
        {
            //获取配方文件夹下所有的配方文件信息
            List<FileInfo> fileList = new DirectoryInfo(recipePath).GetFiles("*.ini").ToList();
            this.recipeList.Clear();
            //遍历所有的配方文件集合
            foreach (FileInfo file in fileList)
            {
                //ini配方文件=>json字符串=>数据对象
                //获取当前文件下面的所有json数据
                string jsonContent = IniConfigHelper.ReadIniData("配方", "配方数据", "", file.FullName);
                //把json字符串格式转换成配方实体对象
                RecipeInfo recipeInfo = JSONHelper.JSONToEntity<RecipeInfo>(jsonContent);
                //把配方实体对象添加到对象集合
                this.recipeList.Add(recipeInfo);
            }
            this.dgv_RecipeList.DataSource = null;
            this.dgv_RecipeList.DataSource = recipeList;
            
        }
        #endregion
    }
}

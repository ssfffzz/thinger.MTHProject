using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataModels;

namespace thinger.MTHProject
{
    public partial class FrmRecipe : Form
    {
        public FrmRecipe()
        {
            InitializeComponent();
        }
        //所有配方的集合
        private List<RecipeInfo> recipeList = new List<RecipeInfo>();

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (this.txt_SelectdRecipeName.Text.Trim().Length == 0)
            {
                MessageBox.Show("配方名称不能为空", "提示信息");
                return;
            }

            var recipe = recipeList.Where(c => c.RecipeName == this.txt_SelectdRecipeName.Text.Trim()).FirstOrDefault();
            if (recipe != null)
            {
                MessageBox.Show("配方名称不能重复", "提示信息");
                return;
            }
            //封装一个新的配方对象
            RecipeInfo recipeInfo = GetNewRecipeInfo();
            //写入配方文件



        }
    }
}

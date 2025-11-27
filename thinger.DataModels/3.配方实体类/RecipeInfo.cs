using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.DataModels
{
    /// <summary>
    /// 配方实体信息类
    /// </summary>
    public class RecipeInfo
    {
        public string RecipeName { get; set; }

        public List<RecipeParam> RecipeParams { get; set; } = new List<RecipeParam>();
    }
}

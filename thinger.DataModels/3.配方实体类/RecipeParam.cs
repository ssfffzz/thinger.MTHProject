using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace thinger.DataModels
{
    public class RecipeParam
    {
        public float TempMax { get; set; }
        public float TempMin { get; set; }
        public float HumidityMax { get; set; }
        public float HumidityMin { get; set; }
        public bool TempAlarmEnable { get; set; }
        public bool HumidityAlarmEnable { get; set; }
    }
}

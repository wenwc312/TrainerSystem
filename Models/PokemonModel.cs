using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 訓練家管理系統.Models
{
    public class PokemonModel
    {
        public int ID { get; set; }
        public string PokemonNo { get; set; }
        public string PokemonName { get; set; }
        public string nickname { get; set; }
        public int Owner { get; set; }
        public int Level { get; set; }
        public string Sex { get; set; }
        public string firstMove { get; set; }
        public string secondMove { get; set; }
        public string thirdMove { get; set; }
        public string fourthMove { get; set; }

        public int hpIV { get; set; }
        public int atkIV { get; set; }
        public int defIV { get; set; }
        public int spIV { get; set; }
        public int velIV { get; set; }
        public string UpdatedBy { get; set; }
        public string Updatetime { get; set; }
    }
}

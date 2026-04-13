using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 訓練家管理系統.Models
{
    public class PokemonSpeciesModel
    {
        public int ID { get; set; }
        public string PokemonNo { get; set; }
        public string Name { get; set; }
        public int Hp {  get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Sp { get; set; }
        public int Vel { get; set; }
        public string Type { get; set; }
    }
}

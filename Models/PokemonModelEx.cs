using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 訓練家管理系統.Models
{
    public class PokemonModelEx : PokemonModel
    {
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Sp { get; set; }
        public int Vel { get; set; }
        public string Type { get; set; }

        // 💥 透過 C# 屬性 (Property) 直接幫你計算最終能力值！
        // 這裡我們用簡化版的寶可夢能力值公式：
        public int TotalHP => ((Hp * 2 + hpIV) * Level / 100) + Level + 10;

        public int TotalAtk => ((Atk * 2 + atkIV) * Level / 100) + 5;
        public int TotalDef => ((Def * 2 + defIV) * Level / 100) + 5;
        public int TotalSp => ((Sp * 2 + spIV) * Level / 100) + 5;
        public int TotalVel => ((Vel * 2 + velIV) * Level / 100) + 5;
    }
}

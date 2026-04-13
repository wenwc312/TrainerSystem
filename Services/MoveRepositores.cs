using 訓練家管理系統.Data;
using 訓練家管理系統.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 訓練家管理系統.Services
{
    public class MoveRepositores
    {
        private readonly DataBaseHelper _db = new DataBaseHelper();

        public List<MoveDTOs> GetAllMoves(string pokemonNo, int level)
        { 
            string sql = @"SELECT m1.招式編號 AS MoveID, m.屬性 AS MoveType, m.中文名 AS MoveCName, m1.學習等級 AS LearnLevel
                            FROM 第一世代學習招式關聯表 m1
                            LEFT JOIN 第一世代招式表 m ON m.編號 = m1.招式編號
                            WHERE m1.寶可夢編號 = @PokemonNo AND m1.學習等級 <= @Level";
            var parameters = new Dictionary<string, object>
            {
                { "PokemonNo", pokemonNo },
                { "Level", level }
            };
            return _db.Query<MoveDTOs>(sql, parameters);
        }
    }
}

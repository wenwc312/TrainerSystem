using 訓練家管理系統.Data;
using 訓練家管理系統.DTOs;
using 訓練家管理系統.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 訓練家管理系統.Services
{
    public class PokemonRepositores
    {
        private readonly DataBaseHelper _db = new DataBaseHelper();

        public List<PokemonModel> SearchPokemonInfo(int OwnerID)
        {
            string sql = @"SELECT t.TrainerName,p.* FROM 寶可夢資訊 p
                           LEFT JOIN 訓練家資料 t ON p.Owner = t.ID
                           WHERE p.Owner = @Owner";

            var para = new Dictionary<string, object>{{"Owner", OwnerID }};

            return _db.Query<PokemonModel>(sql, para);
        }

        public PokemonModelEx SearchPokemonDetail(int PokemonID)
        {
            string sql = @"SELECT p.*, pl.* 
                           FROM 寶可夢資訊 p 
                           LEFT JOIN 第一世代寶可夢總族值 pl ON p.PokemonNo = pl.PokemonNo
                           WHERE p.ID = @ID";
            var para = new Dictionary<string, object> { { "ID", PokemonID } };

            return _db.Query<PokemonModelEx>(sql, para).FirstOrDefault();
        }

        public bool NewPokemon(PokemonDetailDTOs detailDTOs)
        {
            string sql = @"INSERT INTO 寶可夢資訊 (PokemonNo, PokemonName, nickname, Owner, Level, Sex, firstMove, secondMove, thirdMove, fourthMove, hpIV, atkIV, defIV, spIV, velIV)
                           VALUES (@PokemonNo, @PokemonName, @nickname, @Owner, @Level, @Sex, @firstMove, @secondMove, @thirdMove, @fourthMove, @hpIV, @atkIV, @defIV, @spIV, @velIV)";

            var para = new Dictionary<string, object>();
            foreach (var prop in detailDTOs.GetType().GetProperties())
            {
                //  防呆：如果是自動遞增的 ID，就不加入 Insert 的參數中
                if (prop.Name.Equals("ID", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                object value = prop.GetValue(detailDTOs);
                if (value != null)
                {
                    para.Add("@"+prop.Name, value ?? DBNull.Value);
                }
            }
            return _db.Execute(sql,para)>0;
        }
        public bool UpdatePokemon(PokemonDetailDTOs detailDTOs)
        {
            string sql = @"UPDATE 寶可夢資訊 
                           SET nickname = @nickname, Level = @Level, Sex = @Sex,
                               firstMove = @firstMove, secondMove = @secondMove, 
                               thirdMove = @thirdMove, fourthMove = @fourthMove,
                               hpIV = @hpIV, atkIV = @atkIV, defIV = @defIV, 
                               spIV = @spIV, velIV = @velIV , UpdatedBy = @UpdatedBy
                               WHERE ID = @ID";
            var paras = new Dictionary<string, object>();
            foreach(var prop in detailDTOs.GetType().GetProperties())
            {
                paras.Add(prop.Name, prop.GetValue(detailDTOs)??DBNull.Value);
            }
            return _db.Execute(sql, paras)>0;
        }

        public List<PokemonSpeciesModel> GetPokemonSpecies()
        {
            string sql = "SELECT * FROM 第一世代寶可夢總族值 ORDER BY PokemonNo ASC";
            var para = new Dictionary<string, object>();
            return _db.Query<PokemonSpeciesModel>(sql, para);
        }

        public bool DeletePokemon(int PID) 
        {
            string sql = "DELETE FROM 寶可夢資訊 WHERE ID = @ID";
            var para = new Dictionary<string, object> { { "ID",PID} };
            return _db.Execute(sql, para) > 0;
        }
    }
}

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
    public class UserRepositores
    {
        private readonly DataBaseHelper _db = new DataBaseHelper();

        public bool Register(RegisterDTOs registerDT)
        {
            string sql = @"INSERT INTO 訓練家資料 (TrainerName, TrainerAccount, TrainerPassword, TID, Role) 
                           VALUES (@TrainerName, @TrainerAccount, @TrainerPassword, @TID, @Role)";
            var para = new Dictionary<string, object>();
            foreach (var p in registerDT.GetType().GetProperties())
            {
                para.Add(p.Name, p.GetValue(registerDT)??DBNull.Value);
            }
            return _db.Execute(sql, para)>0;
        }
        public UserModel Login(LoginDTO login)
        {
            string sql = @"SELECT * FROM 訓練家資料 WHERE TrainerAccount = @TrainerAccount 
                                                      AND TrainerPassword = @TrainerPassword";

            var para = new Dictionary<string, object>
            {
                {"TrainerAccount",login.Account },{"TrainerPassword",login.Password}
            };

            List<UserModel> result = _db.Query<UserModel>(sql, para);

            return result.FirstOrDefault();
        }

        public bool UpdateUserInfo(UserModel user)
        {
            string sql = @"UPDATE 訓練家資料
                           SET TrainerName = @TrainerName,
                               Title = @Title,
                               TrainerAccount = @TrainerAccount,
                               TrainerPassword = @TrainerPassword,
                               Gender = @Gender,
                               Birthdate = @Birthdate,
                               PhoneNumber = @PhoneNumber,
                               BadgeNumber = @BadgeNumber,
                               Address = @Address,
                               UpdatedBy = @UpdatedBy
                           WHERE ID = @ID";

            var para = new Dictionary<string, object>
            {
                {"TrainerName",user.TrainerName },{"Title",user.Title},{"TrainerAccount",user.TrainerAccount},
                {"TrainerPassword",user.TrainerPassword },{"Gender",user.Gender},{"Birthdate",user.Birthdate},
                {"PhoneNumber",user.PhoneNumber },{"BadgeNumber",user.BadgeNumber},{"Address",user.Address},
                {"UpdatedBy",user.UpdatedBy },{"ID",user.ID}
            };

            return _db.Execute(sql, para)>0;
        }

        public List<UserModel> SearchTrainer(TrainerSearchDTOs searchDTOs)
        {
            searchDTOs = searchDTOs ?? new TrainerSearchDTOs();

            //string sql = @"SELECT * FROM Trainer_List 
            //               WHERE (TrainerName LIKE @TrainerName OR @TrainerName = '')
            //               AND (TID LIKE @TID OR @TID = '')
            //               AND (PhoneNumber LIKE @PhoneNumber OR @PhoneNumber = '')";

            // 建議使用更直覺的 SQLite 寫法
            string sql = @"SELECT * FROM 訓練家資料 
                   WHERE (@TrainerName = '%%' OR TrainerName LIKE @TrainerName)
                   AND (@TID = '%%' OR TID LIKE @TID)
                   AND (@PhoneNumber = '%%' OR PhoneNumber LIKE @PhoneNumber)";

            var para = new Dictionary<string, object>
            {
                {"TrainerName",$"%{searchDTOs.TrainerName}%" },
                {"TID", $"%{searchDTOs.TID}%" },
                {"PhoneNumber",$"%{searchDTOs.Phone}%" }
            };

            return _db.Query<UserModel>(sql,para);
        }

        public bool checkAccountExisted(string  account)
        {
            // 修改成 SQLite 寫法
            string sql = "SELECT ID FROM 訓練家資料 WHERE TrainerAccount = @TrainerAccount LIMIT 1";
            var para = new Dictionary<string, object> { { "TrainerAccount", account } };
            List<UserModel> result = _db.Query<UserModel>(sql, para);
            return result.Any();
        }

        public string GetNextTID()
        {
            // 修改成 SQLite 寫法
            string sql = "SELECT TID FROM 訓練家資料 ORDER BY ID DESC LIMIT 1";

            var lastTID = _db.ExcuteScalar(sql)?.ToString();

            
            if (string.IsNullOrEmpty(lastTID)) return "TID0001";

            int nextNumber = int.Parse(lastTID.Substring(3))+1;

            return "TID"+nextNumber.ToString("D4");
        }
    }
}

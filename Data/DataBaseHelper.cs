using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訓練家管理系統.Data
{
    public class DataBaseHelper
    {
        public string ConnectString { get { return connString; } }


        //string connString = @"Server=I30867\SQLEXPRESS;Database=PokemonDB;Integrated Security=True";

        // 修改連線字串格式 (SQLite 只需要路徑)
        string connString = @"Data Source=PokemonDB.db;Version=3;";

        public List<T> Query<T> (string sql, Dictionary<string, object> parameters = null) where T : class, new()
        {
            List<T> list = new List<T>();

            //using (SqlConnection conn = new SqlConnection(connString))
            //{
            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        // 處理參數 防止SQL injection
            //        if (parameters.Values != null)
            //        {
            //            foreach (var param in parameters)
            //            {
            //                cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            //            }
            //        }

            //        conn.Open();
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            // 取得T(Model)的所有公開屬性
            //            PropertyInfo[] properties = typeof(T).GetProperties();

            //            while (reader.Read())
            //            {
            //                T model = new T(); // 建立一個新的model實例

            //                // 遍歷資料庫查詢出來的每一個欄位
            //                for (int i = 0; i < reader.FieldCount; i++)
            //                {
            //                    string columnName = reader.GetName(i); // 取得資料庫欄位名
            //                    object columnValue = reader[i]; // 取得資料庫的值

            //                    if (columnValue == DBNull.Value) continue;

            //                    // 比對 Model 屬性名稱與資料庫欄位名稱(忽略大小寫
            //                    var prop = properties.FirstOrDefault(p => p.Name.Equals(columnName, StringComparison.OrdinalIgnoreCase));

            //                    if (prop != null && prop.CanWrite)
            //                    {
            //                        prop.SetValue(model, columnValue);
            //                    }
            //                }
            //                list.Add(model);
            //            }
            //        }
            //    }
            //}

            // 修改為 SQLite 的寫法
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                // 將 SqlCommand 改為 SQLiteCommand
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    // 此處參數處理逻辑不變，但 AddWithValue 同樣來自 SQLiteParameterCollection
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    conn.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        PropertyInfo[] properties = typeof(T).GetProperties();
                        while (reader.Read())
                        {
                            T model = new T();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string columnName = reader.GetName(i);
                                object columnValue = reader[i];
                                if (columnValue == DBNull.Value) continue;

                                var prop = properties.FirstOrDefault(p => p.Name.Equals(columnName, StringComparison.OrdinalIgnoreCase));
                                if (prop != null && prop.CanWrite)
                                {
                                    // SQLite 常將數字讀取為 Int64，在此進行安全轉型
                                    Type targetType = prop.PropertyType;
                                    // 注意：SQLite 的數字型別有時需要轉型處理
                                    prop.SetValue(model, Convert.ChangeType(columnValue, prop.PropertyType));
                                }
                            }
                            list.Add(model);
                        }
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 新增：簡化版的 Execute (支援 Dictionary)，回傳影響列數
        /// 用於 INSERT, UPDATE, DELETE
        /// </summary>
        public int Execute(string sql, Dictionary<string,object> parameters = null)
        {
            try
            {
                //using (SqlConnection conn = new SqlConnection(ConnectString))
                //using (SqlCommand cmd = new SqlCommand(sql, conn))

                // 修改成SQLite的版本
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    AttachParameters(cmd, parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }                
                
            }catch (Exception ex)
            {
                throw new Exception("資料庫執行失敗，請檢查 SQL 指令或參數", ex);
            }
        }

        /// <summary>
        /// 統一處理參數附加邏輯，自動處理 null 轉 DBNull
        /// </summary>

        // 建議直接將 AttachParameters 的參數類型也改成 SQLiteCommand
        //public void AttachParameters(SqlCommand cmd, Dictionary<string,object> parameters)
        public void AttachParameters(SQLiteCommand cmd, Dictionary<string, object> parameters)
        {
            if (parameters != null)
            {
                foreach(var para in parameters)
                {
                    // 自動判定參數名是否漏掉 '@'，漏掉就幫他補上
                    string paraName = para.Key.StartsWith("@") ? para.Key : "@" + para.Key;
                    cmd.Parameters.AddWithValue(paraName, para.Value ?? DBNull.Value);
                }
            }
        }

        /// <summary>
        /// 執行查詢，並回傳結果集的第一個資料列的第一個資料欄。
        /// 忽略其他資料列或資料欄。常用於聚合函數 (如 COUNT, MAX)。
        /// </summary>
        public object ExcuteScalar(string sql, Dictionary<string, object> parameters = null)
        {
            try
            {
                //using (SqlConnection con = new SqlConnection(ConnectString))
                //using (SqlCommand cmd = new SqlCommand(sql, con))

                // 修改成SQLite的版本
                using (SQLiteConnection con = new SQLiteConnection(connString))
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    AttachParameters(cmd,parameters);
                    con.Open();
                    return cmd.ExecuteScalar(); //核心方法
                }
            }
            catch (Exception ex)
            {
                throw new Exception("資料庫執行失敗 (ExecuteScalar)，請檢查 SQL 指令或參數", ex);
            }
        }
    }
}

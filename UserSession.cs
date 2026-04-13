using 訓練家管理系統.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 訓練家管理系統
{
    public class UserSession
    {
        public static UserModel currentUser {  get; set; }
    }
}

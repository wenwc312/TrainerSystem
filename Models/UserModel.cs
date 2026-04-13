using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 訓練家管理系統.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string TrainerName { get; set; }
        public string TrainerAccount { get; set; }
        public string TrainerPassword { get; set; }
        public string TID { get; set; }
        public string Gender { get; set; }
        public int Role { get; set; }
        public string PhoneNumber { get; set; }
        public int BadgeNumber { get; set; }
        public string Title { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public string Updatetime { get; set; }
        public string UpdatedBy { get; set; }
    }
}

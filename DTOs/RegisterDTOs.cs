using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 訓練家管理系統.DTOs
{
    public class RegisterDTOs
    {
        public string TrainerName { get; set; }
        public string TrainerAccount {  get; set; }
        public string TrainerPassword { get; set; }
        public string TID { get; set; }
        public int Role {  get; set; }
    }
}

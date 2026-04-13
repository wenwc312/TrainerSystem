using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 訓練家管理系統.DTOs
{
    public class TrainerSearchDTOs
    {
        [Required(ErrorMessage = "姓名不能為空")]
        public string TrainerName { get; set; } = string.Empty;

        [Required(ErrorMessage = "登入ID不能為空")]
        public string TID { get; set; } = string.Empty;

        [Required(ErrorMessage = "手機號碼不能為空")]
        public string Phone { get; set; } = string.Empty;

        public bool isEmpty => string.IsNullOrEmpty(TrainerName) && string.IsNullOrEmpty(TID) && string.IsNullOrEmpty(Phone);
    }
}

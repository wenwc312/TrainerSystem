using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // 直接在 DTO 上定義驗證邏輯，這樣就不必在 UI 層寫一堆 if (string.IsNullOrEmpty)

namespace 訓練家管理系統.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "帳號不能為空")]
        public string Account {  get; set; } = string.Empty;

        [Required(ErrorMessage = "密碼不能為空")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "密碼長度需在 8-16 字元之間")]
        public string Password { get; set; } = string.Empty;
    }
}

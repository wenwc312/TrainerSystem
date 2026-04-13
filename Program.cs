using 訓練家管理系統.AllForms;
using 訓練家管理系統.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訓練家管理系統
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isRunning = true;
            while (isRunning)
            {
                using(LoginPage login = new LoginPage())
                {
                    // 顯示登入畫面
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        // 登入成功，開啟主畫面
                        // 注意：這裡是用 Application.Run，所以當 HomePage 關閉時，才會執行下一行
                        Application.Run(new HomePage());

                        // 如果是正常關閉 HomePage（例如按登出），會回到這裡再次循環顯示登入視窗
                    }
                    else
                    {
                        // 使用者在登入頁按了取消或 X，直接結束程式
                        isRunning = false;
                    }
                }
                
            }
        }
    }
}

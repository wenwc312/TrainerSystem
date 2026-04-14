using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訓練家管理系統.MyControls.pokemonCard
{
    public partial class ucCard1 : UserControl
    {
        // 💥 引入 Windows 系統底層的「隱藏游標」功能
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        public ucCard1()
        {
            InitializeComponent();

            // 💥 關鍵 1：初始化時，掛載事件轉接
            AttachClickEventToControls(this);

            // 💥 關鍵 4：加入滑鼠視覺反饋
            // 滑鼠移入：改變底色或加入外框
            this.MouseEnter += (s, e) => {
                this.BackColor = Color.LightYellow; // 變色
                this.Cursor = Cursors.Hand;        // 滑鼠變成「手」形
            };

            // 滑鼠移出：還原底色
            this.MouseLeave += (s, e) => {
                // 還原為你在設計視窗設的原本底色
                this.BackColor = Color.WhiteSmoke;
                this.Cursor = Cursors.Default;
            };
        }

        private void ucCard1_Load(object sender, EventArgs e)
        {

        }

        // 💥 關鍵 2：遞迴方法，把卡片上（包括 Panel 裡）的所有控制項都加上轉接
        private void AttachClickEventToControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // 如果這個控制項不是 TextBox (因為 TextBox 可能需要複製文字，不要攔截)
                // 且不是這個 ucCard1 本體
                if (!(ctrl is TextBox) && ctrl != this)
                {
                    // 把這個控制項的點擊事件掛到 ucCard1_ControlClick 上
                    ctrl.Click += (s, e) => { this.InvokeOnClick(this, EventArgs.Empty); };
                }
                // 滑鼠移到卡片內任何地方，滑鼠游標都變成「手形」
                ctrl.Cursor = Cursors.Hand;

                // 如果控制項裡面還有子控制項（例如 Panel），繼續進去加事件
                if (ctrl.HasChildren)
                {
                    AttachClickEventToControls(ctrl);
                }
            }
        }

        public void SetData(string Name, string Sex , int Level, string PokeNo,int count)
        {
            txtPName.Text = Name;
            txtSex.Text = Sex;
            txtLv.Text = Level.ToString();
            lblNo.Text = "No."+(count+1).ToString();

            // 從 Resources 動態撈圖
            string resourceName = $"_{PokeNo}";
            
            object imgObj = Properties.Resources.ResourceManager.GetObject(resourceName);

            if (imgObj != null)
            {
                pictureBoxPokemon.Image = (Image)imgObj; // 假設你卡片裡的 PictureBox 叫這個
                pictureBoxPokemon.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void DisableCaret_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                // 只有當 TextBox 是唯讀時，才把焦點移走
                if (tb.ReadOnly == true)
                {
                    // 💥 呼叫 Windows API 隱藏游標，既能保持焦點（可以反白複製），又不會有閃爍游標！
                    HideCaret(tb.Handle);
                }
            }
        }
    }
}

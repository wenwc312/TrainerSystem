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
    public partial class ucCard2 : UserControl
    {
        // 💥 引入 Windows 系統底層的「隱藏游標」功能
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        public ucCard2()
        {
            InitializeComponent();

            AttachClickEventToControls(this);

            this.MouseEnter += (s, e) =>
            {
                this.BackColor = Color.LightYellow;
                this.Cursor = Cursors.Hand;
            };

            this.MouseLeave += (s, e) =>
            {
                this.BackColor = Color.WhiteSmoke;
                this.Cursor = Cursors.Default;
            };
        }

        private void ucCard2_Load(object sender, EventArgs e)
        {

        }

        public void SetData(string pNo , string pName, string pNickname, string gender, int lv)
        {
            txtpNo.Text = pNo;
            txtpName.Text = pName;
            if (pNickname == "")
            {
                txtNickname.Text = pName;
            }
            else
            {
                txtNickname.Text = pNickname;
            }
            txtgender.Text = gender;
            txtLv.Text = lv.ToString();

            // 動態從Resource撈圖
            string resourceName = $"_{pNo}";
            object imageObj = Properties.Resources.ResourceManager.GetObject(resourceName);

            if (imageObj != null)
            {
                pictureBoxPokemon.Image = (Image)imageObj;
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
        private void AttachClickEventToControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if(!(control is TextBox) && control != this)
                {
                    control.Click += (s, e) => { this.InvokeOnClick(this, EventArgs.Empty); };
                }
                control.Cursor = Cursors.Hand;

                if (control.HasChildren)
                {
                    AttachClickEventToControls(control);
                }
            }
        }
    }
}

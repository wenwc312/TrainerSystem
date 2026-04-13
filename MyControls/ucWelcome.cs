using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訓練家管理系統.MyControls
{
    public partial class ucWelcome : UserControl
    {
        private Random random = new Random();
        public ucWelcome()
        {
            InitializeComponent();
        }

        private void ucWelcome_Load(object sender, EventArgs e)
        {
            lblWelcom.Text = $"{UserSession.currentUser.TrainerName}您好!歡迎來到訓練家管理中心!!";
            try
            {
                string folderPath = Path.Combine(Application.StartupPath, "PokemonWallpaper");
                if(Directory.Exists(folderPath) )
                {
                    // 💥 抓取資料夾內所有的圖片檔案 (支援 jpg, png, gif)
                    string[] files = Directory.GetFiles(folderPath, "*.*")
                        .Where(s => s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".gif"))
                        .ToArray();

                    if(files.Length > 0 )
                    {
                        // 💥  隨機挑選一個陣列索引
                        int fileIndex = random.Next(0, files.Length);
                        string targetFilePath = files[fileIndex];

                        /// <summary>
                        /// 實務上在 Windows Forms 中，如果使用 Image.FromFile()，
                        /// C# 會把該圖片檔案完全鎖定（Lock）。
                        /// 這會導致一個很嚴重的問題：當你的程式開著、背景正顯示著這張圖時，
                        /// 使用者如果去資料夾想把這張圖片刪除、更名或覆蓋，Windows 就會彈出「檔案已在另一程式中開啟」的錯誤警告。
                        /// </summary>

                        // 💥  從檔案載入圖片(FromFile 方法)
                        // 💡 註：使用 FromFile 有時會鎖住檔案，實務上常改用 FromStream，這裡先用簡單版
                        //pictureBoxbackground.Image = Image.FromFile(targetFilePath);


                        /// <summary>
                        /// 如果今天這個資料夾是給「一般使用者」放他自己喜歡的桌布、照片：
                        /// 當他開啟你的程式，程式鎖定了 A.jpg。他突然覺得 A.jpg 不好看，
                        /// 順手在檔案總管按了「刪除」，結果 Windows 跳出冷冰冰的「檔案已在另一程式中開啟，無法刪除」。
                        /// 這時候使用者通常不會覺得是自己不對，
                        /// 而是會覺得：「這程式寫得真爛，我只是想刪除我電腦裡的一張照片，它憑什麼霸佔著不放？」
                        /// 為了這種單機版、高互動性的桌面軟體，我們才會用 FromStream 來換取最好的使用者體驗（UX）。
                        /// </summary>
                        // FromStream 方法
                        byte[] imageByte = File.ReadAllBytes(targetFilePath);
                        using(MemoryStream ms  = new MemoryStream(imageByte))
                        {
                            // 從記憶體流中建立 Image 物件
                            Image img = Image.FromStream(ms);

                            // 💥 注意：如果是動態 GIF，FromStream 讀出來的 Image 
                            // 必須「複製一份」給 PictureBox，否則有些電腦在 GC 回收 MemoryStream 後 GIF 會靜止不動。
                            pictureBoxbackground.Image = new Bitmap(img);
                        }

                        pictureBoxbackground.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBoxbackground.SendToBack();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("待機畫面載入失敗" + ex.Message);
            }
        }


    }
}

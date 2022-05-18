using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoWatermarker
{
    public partial class Form1 : Form
    {

        string _textMode = "Customization";
        List<Hashtable> _ImageDisplay;

        public string TextMode { get => _textMode; set => _textMode = value; }
        public List<Hashtable> ImageDisplay { get => _ImageDisplay; set => _ImageDisplay = value; }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLocation_text_watermark.SelectedIndex = 0;
            cbLocation_image_watermark.SelectedIndex = 0;
        }




        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            //選擇資料夾路徑
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtPath.Text = path.SelectedPath;
        }

        private void btnSelectSavePath_Click(object sender, EventArgs e)
        {
            //選擇資料夾路徑
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtImgPath.Text = path.SelectedPath;
        }

        /// <summary>
        /// 執行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcess_Click(object sender, EventArgs e)
        {
            
            var imageInfos = this.ProcessImage();

            foreach (Hashtable imageInfo in imageInfos) {
                var strSaveName = imageInfo["saveName"].ToString();
                var image = (Image)imageInfo["image"];
                image.Save(strSaveName);
            }

            MessageBox.Show("完成了!");
        }

        /// <summary>
        /// 模擬
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimulation_Click(object sender, EventArgs e)
        {
            var imageInfos = this.ProcessImage();
            this.ImageDisplay = imageInfos;
            var watermark = new Watermark();
            
            pictureBox1.Image = watermark.ResizeImage((Image)imageInfos[0]["image"], pictureBox1.Size); ;
            lblPageMax.Text = imageInfos.Count.ToString();
            lblPageNow.Text = 1.ToString();
        }

        private void ChangPage(String action) {
            int iPageNow = 1;
            int.TryParse(lblPageNow.Text.Trim(), out iPageNow);
            int iPageMax = 1;
            int.TryParse(lblPageMax.Text.Trim(), out iPageMax);

            switch (action) {
                case "prev":
                    iPageNow = (iPageNow - 1) > 1 ? iPageNow-1 : 1;
                    break;
                case "next":
                    iPageNow = (iPageNow + 1) > iPageMax ? iPageMax : iPageNow+1;
                    break;
            }
            
            var watermark = new Watermark();
            pictureBox1.Image = watermark.ResizeImage( (Image)this.ImageDisplay[iPageNow-1]["image"], pictureBox1.Size); ;
            lblPageNow.Text = iPageNow.ToString();
        }


        public List<Hashtable> ProcessImage() {
            List<Hashtable> imageInfos = new List<Hashtable>();

            //檔案位置下所有檔案
            string[] files = Directory.GetFiles(this.txtPath.Text);


            Hashtable ht = new Hashtable();
            var myWatermark = new Watermark();

            //編號起始
            var index = 1;
            int.TryParse(txtTextIndex.Text.Trim(), out index);

            foreach (var file in files)
            {
                Image img = null;
                var text = "";  //浮水印文字
                var saveFileName = Path.GetFileNameWithoutExtension(file);  //存檔名稱(預設用檔案名稱)

                //使用文字浮水印
                if (cbxIsUseTextWatermark.Checked)
                {
                    //編號開頭
                    var textStart = this.txtTextStart.Text.Trim();

                    //透明度
                    int alpha = 0;
                    int.TryParse(txtAlpha.Text.Trim(), out alpha);

                    //字形大小
                    int fontSize = 50;
                    int.TryParse(txtTextSize.Text.Trim(), out fontSize);

                    //位置
                    var location = cbLocation_text_watermark.GetItemText(cbLocation_text_watermark.SelectedItem);


                    switch (this.TextMode)
                    {
                        case "Customization":   //自訂編號
                            text = textStart + index.ToString();
                            saveFileName = text;
                            break;
                        case "CustomizationText": //自訂文字
                            text = txtCustomizationText.Text.Trim();
                            break;
                        case "Default": //使用檔名
                            text = Path.GetFileNameWithoutExtension(file);
                            break;
                    }


                    ht["filePath"] = file;
                    ht["markText"] = text;
                    ht["fontSize"] = fontSize;
                    ht["alpha"] = alpha;
                    ht["location"] = location;


                    img = myWatermark.Img_text_WatermarkImg(ht);
                }


                //使用圖片浮水印
                if (cbxIsUseImgWatermark.Checked)
                {
                    ht = new Hashtable();
                    if (img != null)
                        ht["image"] = img;
                    else
                        ht["filePath"] = file;

                    ht["filePath_watermark"] = txtSelectImgPath.Text.Trim();
                    if (ckbReSzie.Checked)
                    {
                        int w = int.Parse(txtWatermark_width.Text.Trim());
                        int h = int.Parse(txtWatermark_width.Text.Trim());
                        Size size = new Size(w, h);
                        ht["watermark_size"] = size;
                    }
                    //透明度
                    ht["opacity"] = float.Parse(textWatermark_opacity.Text.Trim());

                    //位置
                    var location = cbLocation_image_watermark.GetItemText(cbLocation_image_watermark.SelectedItem);
                    ht["location"] = location;

                    img = myWatermark.Img_image_WatermarkImg(ht);
                }


                //取得副檔名
                var extension = Path.GetExtension(file);

                Hashtable htImageInfo = new Hashtable();
                htImageInfo["saveName"] = this.txtImgPath.Text + @"\" + saveFileName + extension;   //儲存位置
                htImageInfo["image"] = img; //圖片
                imageInfos.Add(htImageInfo);

                index++;
            }

            return imageInfos;
        }


        

        private void rdBtnGroupChange(object sender, EventArgs e)
        {
            var rdBtn = (RadioButton)sender;
            
            if (!rdBtn.Checked)
                return;

            if ((string)rdBtn.Tag == "Customization")
            {
                panel_Customization.Visible = true;
                panel_CustomizationText.Visible = false;
            }
            else if ((string)rdBtn.Tag == "CustomizationText") 
            {
                panel_Customization.Visible = false;
                panel_CustomizationText.Visible = true;
            }
            else if ((string)rdBtn.Tag == "Default")
            {
                panel_Customization.Visible = false;
                panel_CustomizationText.Visible = false;
            }


            this.TextMode = (string)rdBtn.Tag;


        }

        private void btnSelectImgPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "Files|*.jpg;*.jpeg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtSelectImgPath.Text = dialog.FileName;
            }
        }

        private void cbxIsUseImgWatermark_CheckedChanged(object sender, EventArgs e)
        {
            panel_image_watermark.Visible = cbxIsUseImgWatermark.Checked;
        }

        private void cbxIsUseTextWatermark_CheckedChanged(object sender, EventArgs e)
        {
            panel_text_watermark.Visible = cbxIsUseTextWatermark.Checked;
        }

        private void ckbReSzie_CheckedChanged(object sender, EventArgs e)
        {
            txtWatermark_width.ReadOnly = !ckbReSzie.Checked;
            txtWatermark_heigh.ReadOnly = !ckbReSzie.Checked;
        }

        private void ChangPage(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            this.ChangPage(btn.Tag.ToString());
        }
    }
}

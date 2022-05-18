using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoWatermarker
{
    public class Watermark
    {

        String _errMsg = "";

        public string ErrMsg { get => _errMsg; }



        /// <summary>
        /// 繪製浮水印，利用HashTable丟入參數
        /// </summary>
        /// <param name="ht"></param>
        /// <returns></returns>
        public Bitmap Img_text_WatermarkImg(Hashtable ht)
        {

            try
            {
                //==========參數設定==================================================//
                String filePath = "";    //檔案路徑(圖片與檔案路徑擇一)
                Image img;          //圖片(圖片與檔案路徑擇一)
                String markText;    //浮水印字
                int fontSize = 50;  //字形大小
                var font_color = Brushes.White; //背景顏色
                int alpha = 255;    //透明度(0~255)
                String location = "bottom right"; //位置: bottom right(右下) bottom left(左下) top right(右上) top left(左上)
                var background_color = Color.Black; //背景顏色
                //==========參數設定==================================================//

                //==========載入參數設定==================================================//
                if (ht.Contains("filePath")) filePath = (string)ht["filePath"];
                markText = ht["markText"].ToString(); ;
                if (ht.Contains("fontSize")) fontSize = (int)ht["fontSize"];
                if (ht.Contains("alpha")) alpha = (int)ht["alpha"];
                if (ht.Contains("font_color")) font_color = (Brush)ht["font_color"];
                if (ht.Contains("location")) location = ht["location"].ToString();
                if (ht.Contains("background_color")) background_color = (Color)ht["background_color"];

                if (!String.IsNullOrEmpty(filePath))
                    img = Bitmap.FromFile(filePath);
                else if (ht.Contains("img"))
                    img = (Image)ht["img"];
                else
                    throw new Exception("請放入 filePath 或 img 參數!");
                //==========載入參數設定==================================================//







                var g = Graphics.FromImage(img);
                //设置画布平滑性
                g.SmoothingMode = SmoothingMode.AntiAlias;

                //填充半透明三角形
                var triggleLeg = (img.Width > img.Height ? img.Height : img.Width) / 3;
                var path = new GraphicsPath();

                switch (location)
                {
                    case "bottom right": //右下
                        path.AddLine(img.Width - triggleLeg, img.Height, img.Width, img.Height - triggleLeg); // /
                        path.AddLine(img.Width, img.Height - triggleLeg, img.Width, img.Height); // |
                        path.AddLine(img.Width, img.Height, img.Width - triggleLeg, img.Height); // _
                        break;
                    case "bottom left": //左下
                        path.AddLine(0, img.Height - triggleLeg, 0 + triggleLeg, img.Height); // \
                        path.AddLine(0, img.Height - triggleLeg, 0, img.Height); // |
                        path.AddLine(0, img.Height, triggleLeg, img.Height); // _
                        break;
                    case "top left": //左上
                        path.AddLine(0 + triggleLeg, 0, 0, triggleLeg); // /
                        path.AddLine(0, 0, 0, triggleLeg); // |
                        path.AddLine(0, 0, triggleLeg, 0); // _
                        break;
                    case "top right": //右上
                        path.AddLine(img.Width - triggleLeg, 0, img.Width, triggleLeg); // \
                        path.AddLine(img.Width, 0, img.Width, triggleLeg); // |
                        path.AddLine(img.Width, 0, img.Width - triggleLeg, 0); // _
                        break;
                }
                //填滿三角形
                g.FillPath(new SolidBrush(Color.FromArgb(alpha, background_color)), path);


                //将原点移动到三角形斜边的中间位置
                switch (location)
                {
                    case "bottom right": //右下
                        g.TranslateTransform(img.Width - triggleLeg / 2, img.Height - triggleLeg / 2);
                        break;
                    case "bottom left": //左下
                        g.TranslateTransform(triggleLeg / 2, img.Height - triggleLeg / 2);
                        break;
                    case "top left": //左上
                        g.TranslateTransform(triggleLeg / 2, triggleLeg / 2);
                        break;
                    case "top right": //右上
                        g.TranslateTransform(img.Width - triggleLeg / 2, triggleLeg / 2);
                        break;
                }


                //旋转45度
                g.RotateTransform(-45);


                //Math.Acos返回值是相对PI的值，因此需要转换为度数
                var a = img.Width;
                var b = img.Height;

                var angle = Math.Acos(a / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) / Math.PI * 180;
                g.RotateTransform((float)-angle);

                //選轉畫布
                g.RotateTransform(45);
                //绘制水印文字
                var font = new Font("Microsoft JhengHei", fontSize, FontStyle.Bold);
                string text = markText;
                //测量文字长度
                var size = g.MeasureString(text, font);
                //绘制文字时，以文字长度的中间位置为中心，因此绘制的起点为：0-长度/2；并设置高度距离原点半行高



                switch (location)
                {
                    case "bottom right": //右下
                        g.DrawString(text, font, font_color, -size.Width / 2, size.Height / 2);
                        break;
                    case "bottom left": //左下
                        g.RotateTransform(90);
                        g.DrawString(text, font, font_color, -size.Width / 2, size.Height * 2 / 3);
                        break;
                    case "top left": //左上
                        g.DrawString(text, font, font_color, -size.Width / 2, -size.Height * 3 / 2);
                        break;
                    case "top right": //右上
                        g.RotateTransform(90);
                        g.DrawString(text, font, font_color, -size.Width / 2, -size.Height * 3 / 2);
                        break;
                }
                g.Dispose();
                return (Bitmap)img;
            }
            catch (Exception ex) {
                this._errMsg = ex.Message;
                return null;
            }

            
        }



        /// <summary>
        /// 繪製圖片浮水印，利用HashTable丟入參數
        /// </summary>
        /// <param name="ht"></param>
        /// <returns></returns>
        public Bitmap Img_image_WatermarkImg(Hashtable ht)
        {
            //==========參數設定==================================================//
            String filePath = "";    //檔案路徑(圖片與檔案路徑擇一)
            Image image;        //圖片(圖片與檔案路徑擇一) 

            String location = "middle"; //位置: middle(中間) bottom right(右下) bottom left(左下) top right(右上) top left(左上)
            String filePath_watermark = "";   //浮水印檔案路徑(圖片與檔案路徑擇一)
            Image image_watermark;  //浮水印圖片(圖片與檔案路徑擇一) 
            Size watermark_size;    //浮水印Size
            float opacity = 0;      //透明度
            //==========參數設定==================================================//


            //==========載入參數設定==================================================//
            if (ht.Contains("filePath"))
                filePath = ht["filePath"].ToString();

            if (!String.IsNullOrEmpty(filePath))
                image = Image.FromFile(filePath);
            else if (ht.Contains("image"))
                image = (Image)ht["image"];
            else
                throw new Exception("請放入 filePath 或 image 參數!");

            if (ht.Contains("filePath_watermark"))
                filePath_watermark = ht["filePath_watermark"].ToString();

            if (!String.IsNullOrEmpty(filePath_watermark))
                image_watermark = Image.FromFile(filePath_watermark);
            else if (ht.Contains("image_watermark"))
                image_watermark = (Image)ht["image_watermark"];
            else
                throw new Exception("請放入 filePath_watermark 或 image_watermark 參數!");
            //調整圖片大小
            if (ht.Contains("watermark_size")) {
                watermark_size = (Size)ht["watermark_size"];
                image_watermark = this.ResizeImage(image_watermark, watermark_size);
            }

            //調整圖片透明度
            if (ht.Contains("opacity"))
            {
                opacity = (float)ht["opacity"];
                image_watermark = this.SetImageOpacity(image_watermark, opacity);
            }

            //設定位置
            if (ht.Contains("location")) location = ht["location"].ToString();
            int poiont_x = 0;
            int poiont_y = 0;
            switch (location)
            {
                case "middle": //中間
                    poiont_x = image.Width / 2 - image_watermark.Width / 2;
                    poiont_y = image.Height / 2 - image_watermark.Height / 2;
                    break;
                case "bottom right": //右下
                    poiont_x = image.Width - image_watermark.Width;
                    poiont_y = image.Height - image_watermark.Height;
                    break;
                case "bottom left": //左下
                    poiont_x = 0;
                    poiont_y = image.Height - image_watermark.Height;
                    break;
                case "top left": //左上
                    poiont_x = 0;
                    poiont_y = 0;
                    break;
                case "top right": //右上
                    poiont_x = image.Width - image_watermark.Width;
                    poiont_y = 0;
                    break;
            }
            //==========載入參數設定==================================================//


            Graphics g = Graphics.FromImage(image);
            var point = new Point(poiont_x, poiont_y);
            g.DrawImage(image_watermark, point);

            //g.DrawImage(image_watermark
            //    , new Rectangle(
            //        image.Width - image_watermark.Width
            //        , image.Height - image_watermark.Height
            //        , image_watermark.Width, image_watermark.Height)
            //        , 0
            //        , 0
            //        , image_watermark.Width
            //        , image_watermark.Height
            //        , GraphicsUnit.Pixel
            //        );

            

            g.Dispose();

            return (Bitmap)image;
        }


        /// <summary>
        /// 調整圖片大小
        /// </summary>
        /// <param name="imgToResize"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private const int bytesPerPixel = 4;
        public Image SetImageOpacity(Image originalImage, double opacity)
        {
            if ((originalImage.PixelFormat & PixelFormat.Indexed) == PixelFormat.Indexed)
            {
                // Cannot modify an image with indexed colors
                return originalImage;
            }

            Bitmap bmp = (Bitmap)originalImage.Clone();

            // Specify a pixel format.
            PixelFormat pxf = PixelFormat.Format32bppArgb;

            // Lock the bitmap's bits.
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            // This code is specific to a bitmap with 32 bits per pixels 
            // (32 bits = 4 bytes, 3 for RGB and 1 byte for alpha).
            int numBytes = bmp.Width * bmp.Height * bytesPerPixel;
            byte[] argbValues = new byte[numBytes];

            // Copy the ARGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, argbValues, 0, numBytes);

            // Manipulate the bitmap, such as changing the
            // RGB values for all pixels in the the bitmap.
            for (int counter = 0; counter < argbValues.Length; counter += bytesPerPixel)
            {
                // argbValues is in format BGRA (Blue, Green, Red, Alpha)

                // If 100% transparent, skip pixel
                if (argbValues[counter + bytesPerPixel - 1] == 0)
                    continue;

                int pos = 0;
                pos++; // B value
                pos++; // G value
                pos++; // R value

                argbValues[counter + pos] = (byte)(argbValues[counter + pos] * opacity);
            }

            // Copy the ARGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(argbValues, 0, ptr, numBytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);

            return bmp;
        }

    }
}

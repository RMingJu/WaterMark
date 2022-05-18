
namespace PhotoWatermarker
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblSelectPath_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTextStart = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblSelectSavePath_title = new System.Windows.Forms.Label();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.btnSelectSavePath = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblAlpha_title = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.cbLocation_text_watermark = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTextIndex = new System.Windows.Forms.TextBox();
            this.panel_Customization = new System.Windows.Forms.Panel();
            this.rdBtnCustomization = new System.Windows.Forms.RadioButton();
            this.rdBtnDefault = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBtnCustomizationText = new System.Windows.Forms.RadioButton();
            this.cbxIsUseImgWatermark = new System.Windows.Forms.CheckBox();
            this.panel_image_watermark = new System.Windows.Forms.Panel();
            this.cbLocation_image_watermark = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWatermark_heigh = new System.Windows.Forms.TextBox();
            this.txtWatermark_width = new System.Windows.Forms.TextBox();
            this.textWatermark_opacity = new System.Windows.Forms.TextBox();
            this.ckbReSzie = new System.Windows.Forms.CheckBox();
            this.txtSelectImgPath = new System.Windows.Forms.TextBox();
            this.btnSelectImgPath = new System.Windows.Forms.Button();
            this.panel_CustomizationText = new System.Windows.Forms.Panel();
            this.txtCustomizationText = new System.Windows.Forms.TextBox();
            this.lblText_title = new System.Windows.Forms.Label();
            this.cbxIsUseTextWatermark = new System.Windows.Forms.CheckBox();
            this.panel_text_watermark = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSimulation = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageMax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPageNow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel_Customization.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_image_watermark.SuspendLayout();
            this.panel_CustomizationText.SuspendLayout();
            this.panel_text_watermark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(477, 36);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPath.TabIndex = 0;
            this.btnSelectPath.Text = "選擇路徑";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(38, 38);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(433, 22);
            this.txtPath.TabIndex = 1;
            // 
            // lblSelectPath_title
            // 
            this.lblSelectPath_title.AutoSize = true;
            this.lblSelectPath_title.Location = new System.Drawing.Point(38, 13);
            this.lblSelectPath_title.Name = "lblSelectPath_title";
            this.lblSelectPath_title.Size = new System.Drawing.Size(56, 12);
            this.lblSelectPath_title.TabIndex = 3;
            this.lblSelectPath_title.Text = "執行路徑:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "編號開頭:";
            // 
            // txtTextStart
            // 
            this.txtTextStart.Location = new System.Drawing.Point(65, 12);
            this.txtTextStart.Name = "txtTextStart";
            this.txtTextStart.Size = new System.Drawing.Size(102, 22);
            this.txtTextStart.TabIndex = 4;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProcess.Location = new System.Drawing.Point(38, 542);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(1013, 57);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "執行";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblSelectSavePath_title
            // 
            this.lblSelectSavePath_title.AutoSize = true;
            this.lblSelectSavePath_title.Location = new System.Drawing.Point(38, 72);
            this.lblSelectSavePath_title.Name = "lblSelectSavePath_title";
            this.lblSelectSavePath_title.Size = new System.Drawing.Size(56, 12);
            this.lblSelectSavePath_title.TabIndex = 8;
            this.lblSelectSavePath_title.Text = "存取路徑:";
            // 
            // txtImgPath
            // 
            this.txtImgPath.Location = new System.Drawing.Point(38, 87);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.Size = new System.Drawing.Size(433, 22);
            this.txtImgPath.TabIndex = 7;
            // 
            // btnSelectSavePath
            // 
            this.btnSelectSavePath.Location = new System.Drawing.Point(477, 85);
            this.btnSelectSavePath.Name = "btnSelectSavePath";
            this.btnSelectSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSavePath.TabIndex = 6;
            this.btnSelectSavePath.Text = "選擇路徑";
            this.btnSelectSavePath.UseVisualStyleBackColor = true;
            this.btnSelectSavePath.Click += new System.EventHandler(this.btnSelectSavePath_Click);
            // 
            // lblAlpha_title
            // 
            this.lblAlpha_title.AutoSize = true;
            this.lblAlpha_title.Location = new System.Drawing.Point(185, 15);
            this.lblAlpha_title.Name = "lblAlpha_title";
            this.lblAlpha_title.Size = new System.Drawing.Size(94, 12);
            this.lblAlpha_title.TabIndex = 5;
            this.lblAlpha_title.Text = "不透明度(0~255):";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(285, 12);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(46, 22);
            this.txtAlpha.TabIndex = 4;
            this.txtAlpha.Text = "255";
            this.txtAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbLocation_text_watermark
            // 
            this.cbLocation_text_watermark.FormattingEnabled = true;
            this.cbLocation_text_watermark.Items.AddRange(new object[] {
            "bottom right",
            "bottom left",
            "top right",
            "top left"});
            this.cbLocation_text_watermark.Location = new System.Drawing.Point(394, 12);
            this.cbLocation_text_watermark.Name = "cbLocation_text_watermark";
            this.cbLocation_text_watermark.Size = new System.Drawing.Size(121, 20);
            this.cbLocation_text_watermark.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "位置:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "字形大小:";
            // 
            // txtTextSize
            // 
            this.txtTextSize.Location = new System.Drawing.Point(75, 12);
            this.txtTextSize.Name = "txtTextSize";
            this.txtTextSize.Size = new System.Drawing.Size(102, 22);
            this.txtTextSize.TabIndex = 11;
            this.txtTextSize.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "編號起始值:";
            // 
            // txtTextIndex
            // 
            this.txtTextIndex.Location = new System.Drawing.Point(261, 12);
            this.txtTextIndex.Name = "txtTextIndex";
            this.txtTextIndex.Size = new System.Drawing.Size(29, 22);
            this.txtTextIndex.TabIndex = 12;
            this.txtTextIndex.Text = "1";
            this.txtTextIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel_Customization
            // 
            this.panel_Customization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Customization.Controls.Add(this.label1);
            this.panel_Customization.Controls.Add(this.label4);
            this.panel_Customization.Controls.Add(this.txtTextStart);
            this.panel_Customization.Controls.Add(this.txtTextIndex);
            this.panel_Customization.Location = new System.Drawing.Point(12, 72);
            this.panel_Customization.Name = "panel_Customization";
            this.panel_Customization.Size = new System.Drawing.Size(433, 54);
            this.panel_Customization.TabIndex = 14;
            // 
            // rdBtnCustomization
            // 
            this.rdBtnCustomization.AutoSize = true;
            this.rdBtnCustomization.Checked = true;
            this.rdBtnCustomization.Location = new System.Drawing.Point(7, 3);
            this.rdBtnCustomization.Name = "rdBtnCustomization";
            this.rdBtnCustomization.Size = new System.Drawing.Size(71, 16);
            this.rdBtnCustomization.TabIndex = 15;
            this.rdBtnCustomization.TabStop = true;
            this.rdBtnCustomization.Tag = "Customization";
            this.rdBtnCustomization.Text = "自訂編號";
            this.rdBtnCustomization.UseVisualStyleBackColor = true;
            this.rdBtnCustomization.CheckedChanged += new System.EventHandler(this.rdBtnGroupChange);
            // 
            // rdBtnDefault
            // 
            this.rdBtnDefault.AutoSize = true;
            this.rdBtnDefault.Location = new System.Drawing.Point(163, 3);
            this.rdBtnDefault.Name = "rdBtnDefault";
            this.rdBtnDefault.Size = new System.Drawing.Size(71, 16);
            this.rdBtnDefault.TabIndex = 16;
            this.rdBtnDefault.Tag = "Default";
            this.rdBtnDefault.Text = "使用檔名";
            this.rdBtnDefault.UseVisualStyleBackColor = true;
            this.rdBtnDefault.CheckedChanged += new System.EventHandler(this.rdBtnGroupChange);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdBtnCustomizationText);
            this.panel2.Controls.Add(this.rdBtnCustomization);
            this.panel2.Controls.Add(this.rdBtnDefault);
            this.panel2.Location = new System.Drawing.Point(12, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 24);
            this.panel2.TabIndex = 17;
            // 
            // rdBtnCustomizationText
            // 
            this.rdBtnCustomizationText.AutoSize = true;
            this.rdBtnCustomizationText.Location = new System.Drawing.Point(86, 3);
            this.rdBtnCustomizationText.Name = "rdBtnCustomizationText";
            this.rdBtnCustomizationText.Size = new System.Drawing.Size(71, 16);
            this.rdBtnCustomizationText.TabIndex = 17;
            this.rdBtnCustomizationText.Tag = "CustomizationText";
            this.rdBtnCustomizationText.Text = "自訂文字";
            this.rdBtnCustomizationText.UseVisualStyleBackColor = true;
            this.rdBtnCustomizationText.CheckedChanged += new System.EventHandler(this.rdBtnGroupChange);
            // 
            // cbxIsUseImgWatermark
            // 
            this.cbxIsUseImgWatermark.AutoSize = true;
            this.cbxIsUseImgWatermark.Location = new System.Drawing.Point(38, 310);
            this.cbxIsUseImgWatermark.Name = "cbxIsUseImgWatermark";
            this.cbxIsUseImgWatermark.Size = new System.Drawing.Size(108, 16);
            this.cbxIsUseImgWatermark.TabIndex = 18;
            this.cbxIsUseImgWatermark.Text = "使用圖片浮水印";
            this.cbxIsUseImgWatermark.UseVisualStyleBackColor = true;
            this.cbxIsUseImgWatermark.CheckedChanged += new System.EventHandler(this.cbxIsUseImgWatermark_CheckedChanged);
            // 
            // panel_image_watermark
            // 
            this.panel_image_watermark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_image_watermark.Controls.Add(this.cbLocation_image_watermark);
            this.panel_image_watermark.Controls.Add(this.label6);
            this.panel_image_watermark.Controls.Add(this.label7);
            this.panel_image_watermark.Controls.Add(this.label5);
            this.panel_image_watermark.Controls.Add(this.txtWatermark_heigh);
            this.panel_image_watermark.Controls.Add(this.txtWatermark_width);
            this.panel_image_watermark.Controls.Add(this.textWatermark_opacity);
            this.panel_image_watermark.Controls.Add(this.ckbReSzie);
            this.panel_image_watermark.Controls.Add(this.txtSelectImgPath);
            this.panel_image_watermark.Controls.Add(this.btnSelectImgPath);
            this.panel_image_watermark.Location = new System.Drawing.Point(38, 329);
            this.panel_image_watermark.Name = "panel_image_watermark";
            this.panel_image_watermark.Size = new System.Drawing.Size(530, 129);
            this.panel_image_watermark.TabIndex = 19;
            this.panel_image_watermark.Visible = false;
            // 
            // cbLocation_image_watermark
            // 
            this.cbLocation_image_watermark.FormattingEnabled = true;
            this.cbLocation_image_watermark.Items.AddRange(new object[] {
            "middle",
            "bottom right",
            "bottom left",
            "top right",
            "top left"});
            this.cbLocation_image_watermark.Location = new System.Drawing.Point(43, 90);
            this.cbLocation_image_watermark.Name = "cbLocation_image_watermark";
            this.cbLocation_image_watermark.Size = new System.Drawing.Size(121, 20);
            this.cbLocation_image_watermark.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "位置:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "透明度(0~255):";
            // 
            // txtWatermark_heigh
            // 
            this.txtWatermark_heigh.Location = new System.Drawing.Point(176, 35);
            this.txtWatermark_heigh.Name = "txtWatermark_heigh";
            this.txtWatermark_heigh.ReadOnly = true;
            this.txtWatermark_heigh.Size = new System.Drawing.Size(46, 22);
            this.txtWatermark_heigh.TabIndex = 22;
            this.txtWatermark_heigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWatermark_width
            // 
            this.txtWatermark_width.Location = new System.Drawing.Point(105, 35);
            this.txtWatermark_width.Name = "txtWatermark_width";
            this.txtWatermark_width.ReadOnly = true;
            this.txtWatermark_width.Size = new System.Drawing.Size(46, 22);
            this.txtWatermark_width.TabIndex = 22;
            this.txtWatermark_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textWatermark_opacity
            // 
            this.textWatermark_opacity.Location = new System.Drawing.Point(105, 61);
            this.textWatermark_opacity.Name = "textWatermark_opacity";
            this.textWatermark_opacity.Size = new System.Drawing.Size(46, 22);
            this.textWatermark_opacity.TabIndex = 22;
            this.textWatermark_opacity.Text = "100";
            this.textWatermark_opacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ckbReSzie
            // 
            this.ckbReSzie.AutoSize = true;
            this.ckbReSzie.Location = new System.Drawing.Point(5, 35);
            this.ckbReSzie.Name = "ckbReSzie";
            this.ckbReSzie.Size = new System.Drawing.Size(72, 16);
            this.ckbReSzie.TabIndex = 21;
            this.ckbReSzie.Text = "自訂大小";
            this.ckbReSzie.UseVisualStyleBackColor = true;
            this.ckbReSzie.CheckedChanged += new System.EventHandler(this.ckbReSzie_CheckedChanged);
            // 
            // txtSelectImgPath
            // 
            this.txtSelectImgPath.Location = new System.Drawing.Point(3, 7);
            this.txtSelectImgPath.Name = "txtSelectImgPath";
            this.txtSelectImgPath.Size = new System.Drawing.Size(433, 22);
            this.txtSelectImgPath.TabIndex = 21;
            // 
            // btnSelectImgPath
            // 
            this.btnSelectImgPath.Location = new System.Drawing.Point(442, 5);
            this.btnSelectImgPath.Name = "btnSelectImgPath";
            this.btnSelectImgPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImgPath.TabIndex = 20;
            this.btnSelectImgPath.Text = "選擇圖片";
            this.btnSelectImgPath.UseVisualStyleBackColor = true;
            this.btnSelectImgPath.Click += new System.EventHandler(this.btnSelectImgPath_Click);
            // 
            // panel_CustomizationText
            // 
            this.panel_CustomizationText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CustomizationText.Controls.Add(this.txtCustomizationText);
            this.panel_CustomizationText.Controls.Add(this.lblText_title);
            this.panel_CustomizationText.Location = new System.Drawing.Point(12, 72);
            this.panel_CustomizationText.Name = "panel_CustomizationText";
            this.panel_CustomizationText.Size = new System.Drawing.Size(433, 54);
            this.panel_CustomizationText.TabIndex = 20;
            this.panel_CustomizationText.Visible = false;
            // 
            // txtCustomizationText
            // 
            this.txtCustomizationText.Location = new System.Drawing.Point(65, 12);
            this.txtCustomizationText.Name = "txtCustomizationText";
            this.txtCustomizationText.Size = new System.Drawing.Size(327, 22);
            this.txtCustomizationText.TabIndex = 22;
            // 
            // lblText_title
            // 
            this.lblText_title.AutoSize = true;
            this.lblText_title.Location = new System.Drawing.Point(3, 15);
            this.lblText_title.Name = "lblText_title";
            this.lblText_title.Size = new System.Drawing.Size(56, 12);
            this.lblText_title.TabIndex = 5;
            this.lblText_title.Text = "自訂文字:";
            // 
            // cbxIsUseTextWatermark
            // 
            this.cbxIsUseTextWatermark.AutoSize = true;
            this.cbxIsUseTextWatermark.Location = new System.Drawing.Point(38, 124);
            this.cbxIsUseTextWatermark.Name = "cbxIsUseTextWatermark";
            this.cbxIsUseTextWatermark.Size = new System.Drawing.Size(108, 16);
            this.cbxIsUseTextWatermark.TabIndex = 18;
            this.cbxIsUseTextWatermark.Text = "使用文字浮水印";
            this.cbxIsUseTextWatermark.UseVisualStyleBackColor = true;
            this.cbxIsUseTextWatermark.CheckedChanged += new System.EventHandler(this.cbxIsUseTextWatermark_CheckedChanged);
            // 
            // panel_text_watermark
            // 
            this.panel_text_watermark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_text_watermark.Controls.Add(this.label3);
            this.panel_text_watermark.Controls.Add(this.panel_CustomizationText);
            this.panel_text_watermark.Controls.Add(this.txtAlpha);
            this.panel_text_watermark.Controls.Add(this.lblAlpha_title);
            this.panel_text_watermark.Controls.Add(this.cbLocation_text_watermark);
            this.panel_text_watermark.Controls.Add(this.label2);
            this.panel_text_watermark.Controls.Add(this.txtTextSize);
            this.panel_text_watermark.Controls.Add(this.panel_Customization);
            this.panel_text_watermark.Controls.Add(this.panel2);
            this.panel_text_watermark.Location = new System.Drawing.Point(38, 146);
            this.panel_text_watermark.Name = "panel_text_watermark";
            this.panel_text_watermark.Size = new System.Drawing.Size(530, 141);
            this.panel_text_watermark.TabIndex = 21;
            this.panel_text_watermark.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(587, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 399);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnSimulation
            // 
            this.btnSimulation.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSimulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimulation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSimulation.Location = new System.Drawing.Point(38, 479);
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.Size = new System.Drawing.Size(1013, 57);
            this.btnSimulation.TabIndex = 0;
            this.btnSimulation.Text = "模擬";
            this.btnSimulation.UseVisualStyleBackColor = false;
            this.btnSimulation.Click += new System.EventHandler(this.btnSimulation_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Location = new System.Drawing.Point(587, 442);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 23;
            this.btnPrev.Tag = "prev";
            this.btnPrev.Text = "←";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.ChangPage);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(668, 442);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 23;
            this.btnNext.Tag = "next";
            this.btnNext.Text = "→";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.ChangPage);
            // 
            // lblPageMax
            // 
            this.lblPageMax.AutoSize = true;
            this.lblPageMax.Location = new System.Drawing.Point(838, 453);
            this.lblPageMax.Name = "lblPageMax";
            this.lblPageMax.Size = new System.Drawing.Size(11, 12);
            this.lblPageMax.TabIndex = 24;
            this.lblPageMax.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(811, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(8, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "/";
            // 
            // lblPageNow
            // 
            this.lblPageNow.AutoSize = true;
            this.lblPageNow.Location = new System.Drawing.Point(776, 453);
            this.lblPageNow.Name = "lblPageNow";
            this.lblPageNow.Size = new System.Drawing.Size(11, 12);
            this.lblPageNow.TabIndex = 24;
            this.lblPageNow.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 611);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPageNow);
            this.Controls.Add(this.lblPageMax);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_text_watermark);
            this.Controls.Add(this.txtImgPath);
            this.Controls.Add(this.btnSelectSavePath);
            this.Controls.Add(this.panel_image_watermark);
            this.Controls.Add(this.cbxIsUseTextWatermark);
            this.Controls.Add(this.cbxIsUseImgWatermark);
            this.Controls.Add(this.lblSelectSavePath_title);
            this.Controls.Add(this.lblSelectPath_title);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSimulation);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnSelectPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "浮水印小程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel_Customization.ResumeLayout(false);
            this.panel_Customization.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_image_watermark.ResumeLayout(false);
            this.panel_image_watermark.PerformLayout();
            this.panel_CustomizationText.ResumeLayout(false);
            this.panel_CustomizationText.PerformLayout();
            this.panel_text_watermark.ResumeLayout(false);
            this.panel_text_watermark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblSelectPath_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTextStart;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblSelectSavePath_title;
        private System.Windows.Forms.TextBox txtImgPath;
        private System.Windows.Forms.Button btnSelectSavePath;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblAlpha_title;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.ComboBox cbLocation_text_watermark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTextSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTextIndex;
        private System.Windows.Forms.Panel panel_Customization;
        private System.Windows.Forms.RadioButton rdBtnCustomization;
        private System.Windows.Forms.RadioButton rdBtnDefault;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbxIsUseImgWatermark;
        private System.Windows.Forms.Panel panel_image_watermark;
        private System.Windows.Forms.TextBox txtSelectImgPath;
        private System.Windows.Forms.Button btnSelectImgPath;
        private System.Windows.Forms.RadioButton rdBtnCustomizationText;
        private System.Windows.Forms.Panel panel_CustomizationText;
        private System.Windows.Forms.TextBox txtCustomizationText;
        private System.Windows.Forms.Label lblText_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textWatermark_opacity;
        private System.Windows.Forms.CheckBox ckbReSzie;
        private System.Windows.Forms.CheckBox cbxIsUseTextWatermark;
        private System.Windows.Forms.Panel panel_text_watermark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWatermark_heigh;
        private System.Windows.Forms.TextBox txtWatermark_width;
        private System.Windows.Forms.ComboBox cbLocation_image_watermark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSimulation;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPageNow;
    }
}


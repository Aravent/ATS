namespace ATS.View
{
    partial class FrmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.BtnOK = new DSkin.Controls.DSkinButton();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.dSkinTextBox1 = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel2 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel3 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel4 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel5 = new DSkin.Controls.DSkinLabel();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.ButtonBorderColor = System.Drawing.Color.LightSteelBlue;
            this.BtnOK.ButtonBorderWidth = 1;
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnOK.HoverColor = System.Drawing.Color.Empty;
            this.BtnOK.HoverImage = null;
            this.BtnOK.Location = new System.Drawing.Point(573, 385);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.NormalImage = null;
            this.BtnOK.PressColor = System.Drawing.Color.Empty;
            this.BtnOK.PressedImage = null;
            this.BtnOK.Radius = 0;
            this.BtnOK.ShowButtonBorder = true;
            this.BtnOK.Size = new System.Drawing.Size(97, 33);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "确定";
            this.BtnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnOK.TextPadding = 0;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dSkinLabel1.Location = new System.Drawing.Point(30, 50);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(466, 18);
            this.dSkinLabel1.TabIndex = 1;
            this.dSkinLabel1.Text = "Testing Studio Sample 2020 开发者预览版 (Developer Preview 1.0.172) 32位";
            // 
            // dSkinTextBox1
            // 
            this.dSkinTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinTextBox1.BackColor = System.Drawing.Color.White;
            this.dSkinTextBox1.BitmapCache = false;
            this.dSkinTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dSkinTextBox1.Location = new System.Drawing.Point(30, 156);
            this.dSkinTextBox1.Multiline = true;
            this.dSkinTextBox1.Name = "dSkinTextBox1";
            this.dSkinTextBox1.ReadOnly = true;
            this.dSkinTextBox1.Size = new System.Drawing.Size(640, 190);
            this.dSkinTextBox1.TabIndex = 2;
            this.dSkinTextBox1.Text = resources.GetString("dSkinTextBox1.Text");
            this.dSkinTextBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.dSkinTextBox1.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinTextBox1.WaterText = "";
            this.dSkinTextBox1.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel2
            // 
            this.dSkinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dSkinLabel2.Location = new System.Drawing.Point(30, 74);
            this.dSkinLabel2.Name = "dSkinLabel2";
            this.dSkinLabel2.Size = new System.Drawing.Size(230, 18);
            this.dSkinLabel2.TabIndex = 3;
            this.dSkinLabel2.Text = "内核版本：1.2.108 (Release 5/14/2020)";
            // 
            // dSkinLabel3
            // 
            this.dSkinLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dSkinLabel3.Location = new System.Drawing.Point(30, 98);
            this.dSkinLabel3.Name = "dSkinLabel3";
            this.dSkinLabel3.Size = new System.Drawing.Size(269, 18);
            this.dSkinLabel3.TabIndex = 4;
            this.dSkinLabel3.Text = "许可证ID：ADF3F2-3FAQ2F-QJFYH7-545GD4";
            // 
            // dSkinLabel4
            // 
            this.dSkinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dSkinLabel4.Location = new System.Drawing.Point(30, 136);
            this.dSkinLabel4.Name = "dSkinLabel4";
            this.dSkinLabel4.Size = new System.Drawing.Size(259, 18);
            this.dSkinLabel4.TabIndex = 5;
            this.dSkinLabel4.Text = "Anycen APC 行业软件授权条款 授权给 Aiofm";
            // 
            // dSkinLabel5
            // 
            this.dSkinLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dSkinLabel5.Location = new System.Drawing.Point(30, 352);
            this.dSkinLabel5.Name = "dSkinLabel5";
            this.dSkinLabel5.Size = new System.Drawing.Size(328, 18);
            this.dSkinLabel5.TabIndex = 6;
            this.dSkinLabel5.Text = "© 2020 中国科学院安徽光学精密机械研究所 保留所有权利";
            // 
            // FrmAbout
            // 
            this.AnimationType = DSkin.Forms.AnimationTypes.Custom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9F);
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.CloseBox.NormalColor = System.Drawing.Color.DimGray;
            this.CloseBox.PressColor = System.Drawing.Color.White;
            this.CloseBox.RoundStyle = DSkin.Common.RoundStyle.None;
            this.CloseBox.Size = new System.Drawing.Size(40, 30);
            this.Controls.Add(this.dSkinLabel5);
            this.Controls.Add(this.dSkinLabel4);
            this.Controls.Add(this.dSkinLabel3);
            this.Controls.Add(this.dSkinLabel2);
            this.Controls.Add(this.dSkinTextBox1);
            this.Controls.Add(this.dSkinLabel1);
            this.Controls.Add(this.BtnOK);
            this.DoubleClickMaximized = false;
            this.DragChangeBackImage = false;
            this.DrawIcon = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MoveMode = DSkin.Forms.MoveModes.Title;
            this.Name = "FrmAbout";
            this.ShadowColor = System.Drawing.Color.DimGray;
            this.ShowInTaskbar = false;
            this.ShowShadow = true;
            this.Text = "关于 Testing Studio Sample 2020";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSkin.Controls.DSkinButton BtnOK;
        private DSkin.Controls.DSkinLabel dSkinLabel1;
        private DSkin.Controls.DSkinTextBox dSkinTextBox1;
        private DSkin.Controls.DSkinLabel dSkinLabel2;
        private DSkin.Controls.DSkinLabel dSkinLabel3;
        private DSkin.Controls.DSkinLabel dSkinLabel4;
        private DSkin.Controls.DSkinLabel dSkinLabel5;
    }
}
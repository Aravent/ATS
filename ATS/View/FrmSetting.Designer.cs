namespace ATS.View
{
    partial class FrmSetting
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
            this.dSkinTextBox2 = new DSkin.Controls.DSkinTextBox();
            this.dSkinButton2 = new DSkin.Controls.DSkinButton();
            this.SuspendLayout();
            // 
            // dSkinTextBox2
            // 
            this.dSkinTextBox2.BitmapCache = false;
            this.dSkinTextBox2.Location = new System.Drawing.Point(173, 75);
            this.dSkinTextBox2.Name = "dSkinTextBox2";
            this.dSkinTextBox2.Size = new System.Drawing.Size(395, 21);
            this.dSkinTextBox2.TabIndex = 0;
            this.dSkinTextBox2.TransparencyKey = System.Drawing.Color.Empty;
            this.dSkinTextBox2.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinTextBox2.WaterText = "";
            this.dSkinTextBox2.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinButton2
            // 
            this.dSkinButton2.ButtonBorderWidth = 1;
            this.dSkinButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton2.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton2.HoverImage = null;
            this.dSkinButton2.Location = new System.Drawing.Point(214, 139);
            this.dSkinButton2.Name = "dSkinButton2";
            this.dSkinButton2.NormalImage = null;
            this.dSkinButton2.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton2.PressedImage = null;
            this.dSkinButton2.Radius = 10;
            this.dSkinButton2.ShowButtonBorder = true;
            this.dSkinButton2.Size = new System.Drawing.Size(328, 111);
            this.dSkinButton2.TabIndex = 1;
            this.dSkinButton2.Text = "dSkinButton2";
            this.dSkinButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton2.TextPadding = 0;
            // 
            // FrmSetting
            // 
            this.ClientSize = new System.Drawing.Size(759, 483);
            this.Controls.Add(this.dSkinButton2);
            this.Controls.Add(this.dSkinTextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSetting";
            this.Tag = "InnerExtension";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSkin.Controls.DSkinTextBox dSkinTextBox2;
        private DSkin.Controls.DSkinButton dSkinButton2;
    }
}
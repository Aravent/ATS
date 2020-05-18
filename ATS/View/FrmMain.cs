using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSkin.Controls;
using DSkin.Forms;

namespace ATS.View
{
    public partial class FrmMain : DSkinForm
    {
        FrmSetting frm = new FrmSetting();
        FrmTest frmTest = new FrmTest();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void dSkinTabControl2_ControlRemoved(object sender, ControlEventArgs e)
        {
            MessageBox.Show(e.Control.Name);
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            frm.Size = DockerPageDefault.Size;
            frmTest.Size = dSkinTabPage1.Size;
        }

        private void ShowInnerForm(Form form, DSkinTabPage tabPage)
        {
            if ((string)form.Tag == "InnerExtension")
            {
                DSkinForm dSkinForm = form as DSkinForm;
                dSkinForm.TopLevel = false;
                dSkinForm.CanResize = false;
                dSkinForm.DoubleClickMaximized = false;
                dSkinForm.EnableAnimation = false;
                dSkinForm.IsLayeredWindowForm = false;
                dSkinForm.MoveMode = MoveModes.None;
                dSkinForm.ShowSystemButtons = false;
                dSkinForm.CaptionShowMode = DSkin.TextShowModes.None;
                dSkinForm.DrawIcon = false;
                dSkinForm.Parent = tabPage;
                dSkinForm.Show();
                dSkinForm.Size = tabPage.Size;
            }
            else
            {
                ControlHost controlHost = new ControlHost()
                {
                    Dock = DockStyle.Fill
                };
                tabPage.Controls.Add(controlHost);
                Panel panel = new Panel()
                {
                    Dock = DockStyle.Fill
                };
                controlHost.Controls.Add(panel);
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Parent = panel;
                form.Show();
                form.Size = panel.Size;
            }
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            ShowInnerForm(frm, DockerPageDefault);
            ShowInnerForm(frmTest, dSkinTabPage1);
        }
    }
}

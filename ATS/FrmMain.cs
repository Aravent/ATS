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

namespace ATS
{
    public partial class FrmMain : DSkinForm
    {
        FrmSplash frm = new FrmSplash();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //ShowInnerForm(frm, dSkinTabPage5);
        }

        private void dSkinTabControl2_ControlRemoved(object sender, ControlEventArgs e)
        {
            MessageBox.Show(e.Control.Name);
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            frm.Size = DockerPageDefault.Size;
        }

        private void ShowInnerForm(Form form, DSkinTabPage tabPage)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Parent = tabPage;
            form.Show();
            form.Size = tabPage.Size;
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSkin.Forms;

namespace ATS.View
{
    public partial class FrmSplash : DSkinForm
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dSkinLabel1.Width += 10;
            if (dSkinLabel1.Width >= 700)
            {
                timer1.Stop();
                DialogResult = DialogResult.OK;
            }
        }
    }
}

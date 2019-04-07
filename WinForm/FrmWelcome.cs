using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void cirularButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTrnspMng frmTrnspMng = new FrmTrnspMng();
            frmTrnspMng.ShowDialog();

            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAppCsharp
{
    public partial class FrmFirstApp : Form
    {
        public FrmFirstApp()
        {
            InitializeComponent();
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + TxtName.Text);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PicOne.Visible = true;
            PicTwo.Visible = false;
            LblQuestion.Visible = false;
            LblAnswer.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PicOne.Visible = false;
            PicTwo.Visible = true;
            LblQuestion.Visible = false;
            LblAnswer.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            PicOne.Visible = true;
            PicTwo.Visible = true;
            LblAnswer.Visible = false;
            LblQuestion.Visible = false;
        }

        private void RdConfused_CheckedChanged(object sender, EventArgs e)
        {
            PicOne.Visible = false;
            PicTwo.Visible = false;
            LblQuestion.Visible = true;
            LblAnswer.Visible = true;
        }
    }
}

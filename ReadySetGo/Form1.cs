using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ReadySetGo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BackroundLabel_Click(object sender, EventArgs e)
        {

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;

            Thread.Sleep(1000);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            Refresh();
            Thread.Sleep(1000);
            number3.Text = "2";
            Refresh();
            Thread.Sleep(1000);
            number3.Text = "1";
        }

        private void GameCounter_Click(object sender, EventArgs e)
        {

        }
    }
}

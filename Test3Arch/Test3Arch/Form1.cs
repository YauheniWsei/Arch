using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3Arch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "CalcIT";
        }
        
        //Open CalcIT
        private void start_but_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.FormClosed += Main_FormClosed;
            main.Show();
            this.Hide();
            main.FormClosed += Main_FormClosed;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Close app
        private void close_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Open guide
        private void guide_but_Click(object sender, EventArgs e)
        {
            Guid guide = new Guid();
            this.Hide();
            guide.Show();
        }
    }
}

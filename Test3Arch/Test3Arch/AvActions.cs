using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3Arch
{
    //Form with actions
    public partial class AvActions : Form
    {
        public AvActions()
        {
            InitializeComponent();
        }

        private void AvActions_Load(object sender, EventArgs e)
        {

        }

        private void close_actions_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

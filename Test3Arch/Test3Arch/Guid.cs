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
    public partial class Guid : Form
    {
        //Form with guide
        public Guid()
        {
            InitializeComponent();
        }
        //Back to main menu
        private void back_guide_but_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        //Open table HEX to BIN
        private void table_hextobin_but_Click(object sender, EventArgs e)
        {
            TableHEXtoBIN tableHEXtoBIN = new TableHEXtoBIN();
            tableHEXtoBIN.Show();
        }
        //Open available actions
        private void available_actions_but_Click(object sender, EventArgs e)
        {
            AvActions avActions = new AvActions();
            avActions.Show();
        }
    }
}

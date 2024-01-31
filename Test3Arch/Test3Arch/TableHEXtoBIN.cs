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

    //Form with table HEX to BIN

    public partial class TableHEXtoBIN : Form
    {
        public TableHEXtoBIN()
        {
            InitializeComponent();
        }

        private void close_table_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

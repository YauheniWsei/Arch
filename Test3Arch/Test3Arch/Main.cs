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
    public partial class Main : Form
    {
        // Creating an instance
        Test1_Reg regs = new Test1_Reg();

        //Constructor
        public Main()
        {
            InitializeComponent();
            this.Text = "CalcIT";
            //Reg1 box 
            AH1.Click += Button_Click_answ_reg1;
            BH1.Click += Button_Click_answ_reg1;
            CH1.Click += Button_Click_answ_reg1;
            DH1.Click += Button_Click_answ_reg1;
            AL1.Click += Button_Click_answ_reg1;
            BL1.Click += Button_Click_answ_reg1;
            CL1.Click += Button_Click_answ_reg1;
            DL1.Click += Button_Click_answ_reg1;
            //Reg2 box
            AH2.Click += Button_Click_answ_reg2;
            BH2.Click += Button_Click_answ_reg2;
            CH2.Click += Button_Click_answ_reg2;
            DH2.Click += Button_Click_answ_reg2;
            AL2.Click += Button_Click_answ_reg2;
            BL2.Click += Button_Click_answ_reg2;
            CL2.Click += Button_Click_answ_reg2;
            DL2.Click += Button_Click_answ_reg2;
            //Actions box
            MOV_act.Click += Button_Click_action;
            ADD_act.Click += Button_Click_action;
            SUB_act.Click += Button_Click_action;
            XCHG_act.Click += Button_Click_action;
            INC_act.Click += Button_Click_action;
            DEC_act.Click += Button_Click_action;
            DIV_act.Click += Button_Click_action;
            MUL_act.Click += Button_Click_action;
            NEG_act.Click += Button_Click_action;

        }

        //Event handler for the "Available Actions" button
        private void available_actions_but_Click(object sender, EventArgs e)
        {
            AvActions avActions = new AvActions();
            avActions.Show();
        }

        //Event handler for the "Table" button
        private void table_main_but_Click(object sender, EventArgs e)
        {
            TableHEXtoBIN tableHEXtoBIN = new TableHEXtoBIN();
            tableHEXtoBIN.Show();
        }

        //Event handler for the "Close" button
        private void close_main_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Event handler for the "Back" button
        private void back_main_but_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        // These three methods handle button clicks in the form interface,
        //  updating specific label texts based on the buttons clicked for
        //  register selection and action choices.
        //        1
        private void Button_Click_answ_reg1(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            answ_reg_label1.Text = clickedButton.Text;
        }
        //        2
        private void Button_Click_answ_reg2(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            answ_reg_label2.Text = clickedButton.Text;
        }
        //        3
        private void Button_Click_action(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            answ_label_act.Text = clickedButton.Text;
        }

        //  The `do_it_but_Click` method performs arithmetic
        // or logical operations based on the selected action,
        // registers, and input values. It executes the
        // operation, updates the result label, and provides
        // feedback to the user. The `value_reg_label_Click`
        // method updates the value label based on the selected register.
        private void do_it_but_Click(object sender, EventArgs e)
        {
            //reg1


            if (long.TryParse(textBox_value1.Text, out long num1))
            {

                switch (answ_reg_label1.Text)
                {
                    case "AH":
                        regs.SetRegisterValue("AH", num1);
                        break;
                    case "BH":
                        regs.BH = num1;
                        break;
                    case "CH":
                        regs.CH = num1;
                        break;
                    case "DH":
                        regs.DH = num1;
                        break;
                    case "AL":
                        regs.AL = num1;
                        break;
                    case "BL":
                        regs.BL = num1;
                        break;
                    case "CL":
                        regs.CL = num1;
                        break;
                    case "DL":
                        regs.DL = num1;
                        break;
                }
            }
            else { MessageBox.Show($"Wrong value {answ_reg_label1.Text}!"); }

            //reg2

            if(long.TryParse(textBox_value2.Text, out long num2))
            {
                switch (answ_reg_label2.Text)
                {
                    case "AH":
                        regs.AH = num2;
                        break;
                    case "BH":
                        regs.BH = num2;
                        break;
                    case "CH":
                        regs.CH = num2;
                        break;
                    case "DH":
                        regs.DH = num2;
                        break;
                    case "AL":
                        regs.AL = num2;
                        break;
                    case "BL":
                        regs.BL = num2;
                        break;
                    case "CL":
                        regs.CL = num2;
                        break;
                    case "DL":
                        regs.DL = num2;
                        break;
                }
            }
            else { MessageBox.Show($"Wrong value {answ_reg_label2.Text}!"); }

            //action
            TestActions act = new TestActions();

            switch (answ_label_act.Text)
            {
                case "ADD":
                    regs.SetRegisterValue(answ_reg_label1.Text, act.ADD(num1, num2));
                    answ_label.Text = act.ADD(num1, num2).ToString();
                    break;

                case "SUB":
                    regs.SetRegisterValue(answ_reg_label1.Text, act.SUB(num1, num2));
                    answ_label.Text = act.SUB(num1, num2).ToString();
                    break;

                case "MUL":
                    regs.SetRegisterValue(answ_reg_label1.Text, act.MUL(num1, num2));
                    answ_label.Text = act.MUL(num1, num2).ToString();
                    break;

                case "DIV":
                    regs.SetRegisterValue(answ_reg_label1.Text, act.DIV(num1, num2));
                    answ_label.Text = act.DIV(num1, num2).ToString();
                    break;

                case "AND":
                    regs.SetRegisterValue(answ_reg_label1.Text, act.AND(num1, num2));
                    answ_label.Text = act.AND(num1, num2).ToString();
                    break;

                case "OR":
                    regs.SetRegisterValue(answ_reg_label1.Text, act.OR(num1, num2));
                    answ_label.Text = act.OR(num1, num2).ToString();
                    break;

                case "XOR":
                    regs.SetRegisterValue(answ_reg_label1.Text, act.XOR(num1, num2));
                    answ_label.Text = act.XOR(num1, num2).ToString();
                    break;

                case "INC":
                    regs.SetRegisterValue(answ_reg_label1.Text, act.INC(num1));
                    answ_label.Text = act.INC(num1).ToString();
                    break;

                case "DEC":
                    regs.SetRegisterValue(answ_reg_label1.Text, act.DEC(num1));
                    answ_label.Text = act.DEC(num1).ToString();
                    break;

                case "NOT":
                    regs.SetRegisterValue(answ_reg_label1.Text, act.NOT(num1));
                    answ_label.Text = act.NOT(num1).ToString();
                    break;

                case "NEG":
                    regs.SetRegisterValue(answ_reg_label1.Text, act.NEG(num1));
                    answ_label.Text = act.NEG(num1).ToString();
                    break;

                case "MOV":
                    act.MOV(num1, num2);
                    regs.SetRegisterValue(answ_reg_label1.Text, act.MOV(num1, num2));
                    MessageBox.Show($"Value {num2} moved to register {answ_reg_label1.Text}.");
                    break;

                case "XCHG":
                    long temp = num1;
                    num1 = num2;
                    num2 = temp;
                    regs.SetRegisterValue(answ_reg_label1.Text, num1);
                    regs.SetRegisterValue(answ_reg_label2.Text, num2);
                    MessageBox.Show($"Values {num1} and {num2} exchanged.");
                    break;
            }
        }
        private void value_reg_label_Click(object sender, EventArgs e)
        {
            //check value 

            switch (choose_reg_box.Text)
            {
                case "AH":
                    value_label.Text = regs.AH.ToString();
                    break;
                case "BH":
                    value_label.Text = regs.BH.ToString();
                    break;
                case "CH":
                    value_label.Text = regs.CH.ToString();
                    break;
                case "DH":
                    value_label.Text = regs.DH.ToString();
                    break;
                case "AL":
                    value_label.Text = regs.AL.ToString();
                    break;
                case "BL":
                    value_label.Text = regs.BL.ToString();
                    break;
                case "CL":
                    value_label.Text = regs.CL.ToString();
                    break;
                case "DL":
                    value_label.Text = regs.DL.ToString();
                    break;
            }
        }

        //  The write_value_but_Click method saves a value
        // entered in textBox_value1 to the selected register
        // (answ_reg_label1.Text). It checks if a register is
        // selected, parses the value, and displays messages for success or failure.
        private void write_value_but_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(answ_reg_label1.Text))
            {
                MessageBox.Show("Select a register first!");
                return;
            }

            if (long.TryParse(textBox_value1.Text, out long num))
            {
                switch (answ_reg_label1.Text)
                {
                    case "AH":
                        regs.AH = num;
                        break;
                    case "BH":
                        regs.BH = num;
                        break;
                    case "CH":
                        regs.CH = num;
                        break;
                    case "DH":
                        regs.DH = num;
                        break;
                    case "AL":
                        regs.AL = num;
                        break;
                    case "BL":
                        regs.BL = num;
                        break;
                    case "CL":
                        regs.CL = num;
                        break;
                    case "DL":
                        regs.DL = num;
                        break;
                }
                MessageBox.Show($"Value {num} saved in register {answ_reg_label1.Text}.");
            }
            else
            {
                MessageBox.Show($"Wrong value {textBox_value1.Text}!");
            }
        }
        //  The toHEX_but_Click method is triggered when the "toHEX_but" button is clicked.
        // It checks if the value_label text is not null or empty. If it's not, it
        // converts the text to its hexadecimal representation using Convert.ToInt32()
        // and Convert.ToString(), and then sets the value_label.Text to the resulting
        // hexadecimal value in uppercase.
        private void toHEX_but_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value_label.Text)) 
            { 
            value_label.Text = Convert.ToString(Convert.ToInt32(value_label.Text), 16).ToUpper();
            } else { MessageBox.Show("Select a register first!"); }
        }
        //The toBIN_but_Click method is triggered when the "toBIN_but"
        //button is clicked. It attempts to convert the text in the value_label
        //control from decimal to binary format. It tries to perform the
        //conversion using Convert.ToInt32() and Convert.ToString(). If an
        //exception occurs during the conversion, it displays a message asking
        //the user to check the value again before using the button.
        private void toBIN_but_Click(object sender, EventArgs e)
        {
            try
            {
                value_label.Text = Convert.ToString(Convert.ToInt32(value_label.Text), 2);
            }
            catch (Exception)
            {
                MessageBox.Show("Please, again click Check value, later use your button!");
            }
        }
        // This event handler is triggered when the "toDEC_but" button is clicked. It attempts to convert
        //  the text in the value_label control from binary to decimal format. It first checks if
        //  the text contains only '0' and '1' characters, displaying a message if not. Then, it tries to
        //  convert the binary value to its decimal equivalent using Convert.ToInt32().
        //  If an exception occurs during the conversion, it displays a message prompting the user to try again.
        private void toDEC_but_Click(object sender, EventArgs e)
        {
            try
            {
                if(value_label.Text.All(c => "01".Contains(c)))
                {
                    MessageBox.Show("Please, again click Check value, later use your button!");
                }
                value_label.Text = Convert.ToString(Convert.ToInt32(value_label.Text), 10);
            }
            catch (Exception)
            {
                MessageBox.Show("Please, again click Check value, later use your button!");
            }
        }
        // This block of code clears the text of several TextBoxes,
        //  labels,and then calls the Clear() method of the
        //  regs object to clear its content or reset its state.
        private void clear_act_Click(object sender, EventArgs e)
        {
            textBox_value1.Text = string.Empty;
            textBox_value2.Text = string.Empty;
            value_label.Text = string.Empty;
            answ_reg_label1.Text = string.Empty;
            answ_reg_label2.Text = string.Empty;
            answ_label_act.Text = string.Empty;
            main_label.Text = string.Empty;
            answ_label.Text = string.Empty;
            regs.Clear();
        }
    }
}

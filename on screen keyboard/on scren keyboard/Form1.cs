using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace on_scren_keyboard
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }


        //protected override CreateParams CreateParams
        //{

        //    get
        //    {
        //        CreateParams param = base.CreateParams;
        //        param.ExStyle |= 0x08000000;
        //        return param;
        //    }
        //}

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }



        private void Btna_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }


        private void button11_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("¬");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("`");
        }
        bool Lshift = false;
        bool Rshift = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Lshift == false)
            {
                LeftShift.BackColor = Color.Black;
                RightShift.BackColor = Color.Black;
            }
            else 
            { 
                LeftShift.BackColor = Color.DimGray;
                RightShift.BackColor = Color.DimGray;
            }
                
        }
        private void LeftShift_CheckedChanged(object sender, EventArgs e)
        {
            if (Lshift == false)
            {
                Lshift = true;
               
            }
            else if (Lshift == true)
            {
                Lshift = false;
                
            } 
        }
        private void RightShift_CheckedChanged(object sender, EventArgs e)
        {
            if (Lshift == false)
                Lshift = true;
            else if (Lshift == true)
                Lshift = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("!");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("\"");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("2");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("£");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("3");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("$");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("4");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("{%}");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("{^}");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("6");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("{&}");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("7");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("{*}");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("8");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("{(}");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("9");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("{)}");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("0");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("_");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("-");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("=");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("{+}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BS}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }


        bool caps = false;
        bool caps_light = false;
        private void capslocak_CheckedChanged(object sender, EventArgs e)
        {
            if (caps_light == false)
            {
                capslight.Visible = true;
                caps_light = true;
                caps = true;
            }
            else if (caps_light == true)
            {
                capslight.Visible = false;
                caps_light = false;
                caps = false;
            }

        }
        protected bool caps_shift_checked()
        {
            if (Lshift == false && caps == true || Lshift == true && caps == false)

            {
                if (Lshift == true)
                {
                    Lshift = false;
                } 

                return true;
            }
            else
            {
                if (Lshift == true)
                {
                    Lshift = false;
                }
                return false;
            } 
        }
        private void button15_Click(object sender, EventArgs e)
        {

            if(caps_shift_checked()==true)
            {
                SendKeys.Send("Q");
            }
            else
                SendKeys.Send("q");
          
        }
       
        private void button35_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("W");
            }
            else
                SendKeys.Send("w");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("E");
            }
            else
                SendKeys.Send("e");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("R");
            }
            else
                SendKeys.Send("r");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("T");
            }
            else
                SendKeys.Send("t");
        }

        private void Btnb_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("Y");
            }
            else
                SendKeys.Send("y");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("U");
            }
            else
                SendKeys.Send("u");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("I");
            }
            else
                SendKeys.Send("i");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("O");
            }
            else
                SendKeys.Send("o");
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("P");
            }
            else
                SendKeys.Send("p");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("{");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("[");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("}");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("]");
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("A");
            }
            else
                SendKeys.Send("a");
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("S");
            }
            else
                SendKeys.Send("s");
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("D");
            }
            else
                SendKeys.Send("d");
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("F");
            }
            else
                SendKeys.Send("f");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("G");
            }
            else
                SendKeys.Send("g");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("H");
            }
            else
                SendKeys.Send("h");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("J");
            }
            else
                SendKeys.Send("j");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("K");
            }
            else
                SendKeys.Send("k");
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("L");
            }
            else
                SendKeys.Send("l");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send(":");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send(";");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("@");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("'");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("{~}");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("#");
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("|");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("{\\}");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("Z");
            }
            else
                SendKeys.Send("z");
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("X");
            }
            else
                SendKeys.Send("x");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("C");
            }
            else
                SendKeys.Send("c");
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("V");
            }
            else
                SendKeys.Send("v");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("B");
            }
            else
                SendKeys.Send("b");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("N");
            }
            else
                SendKeys.Send("n");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (caps_shift_checked() == true)
            {
                SendKeys.Send("M");
            }
            else
                SendKeys.Send("m");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("<");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send(",");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send(">");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send(".");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (LeftShift.Checked || RightShift.Checked)
            {
                SendKeys.Send("?");
                LeftShift.Checked = false;
                RightShift.Checked = false;
            }
            else
                SendKeys.Send("{/}");
        }


    
        private void button53_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^");
        }

      
     
       

        private void button74_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void button73_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void button79_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void button75_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

      
        private void button82_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("^");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
        }

        private void button80_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void button81_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //  SendKeys.Send("{mouse y}");
            SendKeys.Send("+({F10})");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^({ESC}E)");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

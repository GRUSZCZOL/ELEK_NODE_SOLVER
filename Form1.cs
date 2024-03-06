using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEK_NODE_SOLVER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Przyciski funkcyjne poniżej Raportu
        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Raport.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox_Raport.Text);
            }
        }
        private void button_Run_Click(object sender, EventArgs e)
        {

            switch (listBox1.SelectedIndex) 
            {
                case 0:
                    
                    break; //AC
                case 1:
                    textBox_Raport.Text += "-------------------------------------------------------------------------------";
                    textBox_Raport.Text += "\n\r\n\r\n\r";
                    textBox_Raport.Text += Solver_Elek_DC_Node().ToString();
                    textBox_Raport.Text += "\n\r\n\r\n\r"; 
                    
                    break; //DC

                case 2:
                    
                    break; //DYN
                default: MessageBox.Show("NIE WYBRANO TRYBU DZIAŁANIA"); break;
            }
        }

        // SOLVERY
        public double Solver_Elek_DC_Node() 
        {
            return 0;
        }



        // FORMULARZE
        private void button_U_Click(object sender, EventArgs e)
        {
            Form_U form_U= new Form_U();
            form_U.Show();     
        }

        private void button_I_Click(object sender, EventArgs e)
        {
            Form_I form_I = new Form_I();
            form_I.Show();
        }

        private void button_R_Click(object sender, EventArgs e)
        {
           /* Form_R form_R = new Form_U();
            form_R.Show();*/
        }

        private void button_C_Click(object sender, EventArgs e)
        {
          /*  Form_C form_C = new Form_C();
            form_C.Show();*/
        }

        private void button_L_Click(object sender, EventArgs e)
        {
          /*  Form_L form_L = new Form_L();
            form_L.Show();*/
        }
    }
}

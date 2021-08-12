using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int questionno = 0; 
        int true1 = 0; 
        int false1 = 0;
        private void Next_Click(object sender, EventArgs e)
        {
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            questionno++;
            label4.Text = label4.ToString();

            if(questionno == 1)
            {
                richTextBox1.Text = "Which year is Sheakspare's died ?";
                A.Text = "1980";
                B.Text = "1790";
                C.Text = "1616";
                D.Text = "1618";
                label1.Text = "1616";
                
            }
            if (questionno == 2)
            {
                richTextBox1.Text = "Barcelona is the capital city of which city?";
                A.Text = "Italy";
                B.Text = "Germany";
                C.Text = "Spain";
                D.Text = "Turkey";
                label1.Text = "Spain";

            }

            if(questionno == 3)
            {
                richTextBox1.Text = "Which author wrote 1984?";
                A.Text = "Balzac";
                B.Text = "Dostoyevski";
                C.Text = "Stephen King";
                D.Text = "George Orwell";
                label1.Text = "George Orwell";
            }

            if(questionno == 4)
            {
                A.Enabled = false;
                B.Enabled = false;
                C.Enabled = false;
                D.Enabled = false;
                Next.Enabled = false;
                MessageBox.Show("True:" + true1 + "\n" + "False:" + false1);
            }
               


        }

        private void A_Click(object sender, EventArgs e)
        {
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;


            label2.Text = A.Text;
            if(label1.Text == label2.Text)
            {
                true1++;
                label5.Text = true1.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                false1++;
                label6.Text = false1.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;

            label1.Text = B.Text;
            if(label1.Text == label2.Text)
            {
                true1++;
                label5.Text = true1.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                false1++;
                label6.Text = false1.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;

            label1.Text = C.Text;
            if (label1.Text == label2.Text)
            {
                true1++;
                label5.Text = true1.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                false1++;
                label6.Text = false1.ToString();
                pictureBox2.Visible = true;
            }
    }

        private void D_Click(object sender, EventArgs e)
        {
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;

            label1.Text = D.Text;
            if (label1.Text == label2.Text)
            {
                true1++;
                label5.Text = true1.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                false1++;
                label6.Text = false1.ToString();
                pictureBox2.Visible = true;
            }

        }
    }

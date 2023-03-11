using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNO = 0, doru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNO)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakir")
                        {
                            button4.BackColor = Color.Green;
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruNO++;
            this.Text = soruNO.ToString();

            if (soruNO == 1 )
            {
                richTextBox1.Text = "Ulkemizin guney kismindaki kiyi bolgesi?";
                button1.BackColor = Color.Yellow;
            }
            if (soruNO == 2)
            {
                richTextBox1.Text = "Yesiliyle unlu Marmara ilimiz?";
                button2.BackColor = Color.Yellow;
            }
            if (soruNO == 3)
            {
                richTextBox1.Text = "Muslumanlarin kutsal gunu?";
                button3.BackColor = Color.Yellow;
            }
            if (soruNO == 4)
            {
                richTextBox1.Text = "Karpuzuyla unlu ilimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (soruNO == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zit anlamlisi?";
                button5.BackColor = Color.Yellow;
            }
            if (soruNO == 6)
            {
                richTextBox1.Text = "Padisahin buyruklarinin yazili hali?";
                button7.BackColor = Color.Yellow;
            }
        }
    }
}

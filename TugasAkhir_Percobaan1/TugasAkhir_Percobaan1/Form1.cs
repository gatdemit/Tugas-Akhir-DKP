using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir_Percobaan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox20.ReadOnly = true;
            textBox19.ReadOnly = true;
            textBox18.ReadOnly = true;
            textBox17.ReadOnly = true;
            textBox16.ReadOnly = true;
            textBox15.ReadOnly = true;
            textBox14.ReadOnly = true;
            textBox13.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox21.Text = "Selamat datang di program penghitungan indeks prestasi! Silakan Masukan nama anda dalam bentuk huruf dan NIM anda dalam bentuk angka.";
            
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

             int bobot1;
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox18.SelectedIndex == 0)
                {

                    bobot1 = 1 * 4;
                    textBox20.Text = "" + bobot1;
                }
                else if (comboBox18.SelectedIndex == 1)
                {

                    bobot1 = 2 * 4;
                    textBox20.Text = "" + bobot1;
                }
                else if (comboBox18.SelectedIndex == 2)
                {

                    bobot1 = 3 * 4;
                    textBox20.Text = "" + bobot1;
                }

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox18.SelectedIndex == 0)
                {

                    bobot1 = 1 * 3;
                    textBox20.Text = "" + bobot1;
                }
                else if (comboBox18.SelectedIndex == 1)
                {

                    bobot1 = 2 * 3;
                    textBox20.Text = "" + bobot1;
                }
                else if (comboBox18.SelectedIndex == 2)
                {

                    bobot1 = 3 * 3;
                    textBox20.Text = "" + bobot1;
                }

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox18.SelectedIndex == 0)
                {

                    bobot1 = 1 * 2;
                    textBox20.Text = "" + bobot1;
                }
                else if (comboBox18.SelectedIndex == 1)
                {

                    bobot1 = 2 * 2;
                    textBox20.Text = "" + bobot1;
                }
                else if (comboBox18.SelectedIndex == 2)
                {

                    bobot1 = 3 * 2;
                    textBox20.Text = "" + bobot1;
                }

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                if (comboBox18.SelectedIndex == 0)
                {

                    bobot1 = 1 * 1;
                    textBox20.Text = "" + bobot1;
                }
                else if (comboBox18.SelectedIndex == 1)
                {

                    bobot1 = 2 * 1;
                    textBox20.Text = "" + bobot1;
                }
                else if (comboBox18.SelectedIndex == 2)
                {

                    bobot1 = 3 * 1;
                    textBox20.Text = "" + bobot1;
                }

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                if (comboBox18.SelectedIndex == 0)
                {

                    bobot1 = 0;
                    textBox20.Text = "" + bobot1;
                }
                else if (comboBox18.SelectedIndex == 1)
                {

                    bobot1 = 0;
                    textBox20.Text = "" + bobot1;
                }
                else if (comboBox18.SelectedIndex == 2)
                {

                    bobot1 = 0;
                    textBox20.Text = "" + bobot1;
                }

            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nama = textBox1.Text;
            String nim = textBox2.Text;
            String masukan1 = textBox20.Text;
            float bobot1;
            float.TryParse(masukan1, out bobot1);
            String masukan2 = textBox19.Text;
            float bobot2;
            float.TryParse(masukan2, out bobot2);
            String masukan3 = textBox18.Text;
            float bobot3;
            float.TryParse(masukan3, out bobot3);
            String masukan4 = textBox17.Text;
            float bobot4;
            float.TryParse(masukan4, out bobot4);
            String masukan5 = textBox16.Text;
            float bobot5;
            float.TryParse(masukan5, out bobot5);
            String masukan6 = textBox15.Text;
            float bobot6;
            float.TryParse(masukan6, out bobot6);
            String masukan7 = textBox14.Text;
            float bobot7;
            float.TryParse(masukan7, out bobot7);
            String masukan8 = textBox13.Text;
            float bobot8;
            float.TryParse(masukan8, out bobot8);
            String masukan9 = textBox12.Text;
            float bobot9;
            float.TryParse(masukan9, out bobot9);
            String masukan10 = comboBox18.Text;
            int sks1;
            int.TryParse(masukan10, out sks1);
            String masukan11 = comboBox17.Text;
            int sks2;
            int.TryParse(masukan11, out sks2);
            String masukan12 = comboBox16.Text;
            int sks3;
            int.TryParse(masukan12, out sks3);
            String masukan13 = comboBox15.Text;
            int sks4;
            int.TryParse(masukan13, out sks4);
            String masukan14 = comboBox14.Text;
            int sks5;
            int.TryParse(masukan14, out sks5);
            String masukan15 = comboBox13.Text;
            int sks6;
            int.TryParse(masukan15, out sks6);
            String masukan16 = comboBox12.Text;
            int sks7;
            int.TryParse(masukan16, out sks7);
            String masukan17 = comboBox11.Text;
            int sks8;
            int.TryParse(masukan17, out sks8);
            String masukan18 = comboBox10.Text;
            int sks9;
            int.TryParse(masukan18, out sks9);
            int sks = sks1 + sks2 + sks3 + sks4 + sks5 + sks6 + sks7 + sks8 + sks9;
            float bobot = bobot1 + bobot2 + bobot3 + bobot4 + bobot5 + bobot6 + bobot7 + bobot8 + bobot9;
            float ip = bobot / sks;
            if (0 <= sks && sks <= 24)
            {

                textBox21.Text = String.Empty;
                textBox21.AppendText("Nama: " + nama + "  NIM: " + nim + Environment.NewLine + "Jumlah SKS anda adalah " + sks + " dan Bobot anda adalah " + bobot + Environment.NewLine + "IP anda adalah " + ip);
            }
            else if (24 < sks)
            {
                textBox21.Text = "Maaf. SKS yang anda ambil melebihi batas maksimal per semester. Silakan periksa kembali dan coba lagi.";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                int bobot2;
                
                if (comboBox3.SelectedIndex == 0)
                {
                    if (comboBox16.SelectedIndex == 0)
                    {

                        bobot2 = 1 * 4;
                        textBox19.Text = "" + bobot2;
                    }
                    else if (comboBox16.SelectedIndex == 1)
                    {

                        bobot2 = 2 * 4;
                        textBox19.Text = "" + bobot2;
                    }
                    else if (comboBox16.SelectedIndex == 2)
                    {

                        bobot2 = 3 * 4;
                        textBox19.Text = "" + bobot2;
                    }

                }
                else if (comboBox3.SelectedIndex == 1)
                {
                    if (comboBox16.SelectedIndex == 0)
                    {

                        bobot2 = 1 * 3;
                        textBox19.Text = "" + bobot2;
                    }
                    else if (comboBox16.SelectedIndex == 1)
                    {

                        bobot2 = 2 * 3;
                        textBox19.Text = "" + bobot2;
                    }
                    else if (comboBox16.SelectedIndex == 2)
                    {

                        bobot2 = 3 * 3;
                        textBox19.Text = "" + bobot2;
                    }

                }
                else if (comboBox3.SelectedIndex == 2)
                {
                    if (comboBox16.SelectedIndex == 0)
                    {

                        bobot2 = 1 * 2;
                        textBox19.Text = "" + bobot2;
                    }
                    else if (comboBox16.SelectedIndex == 1)
                    {

                        bobot2 = 2 * 2;
                        textBox19.Text = "" + bobot2;
                    }
                    else if (comboBox16.SelectedIndex == 2)
                    {

                        bobot2 = 3 * 2;
                        textBox19.Text = "" + bobot2;
                    }

                }
                else if (comboBox3.SelectedIndex == 3)
                {
                    if (comboBox16.SelectedIndex == 0)
                    {

                        bobot2 = 1 * 1;
                        textBox19.Text = "" + bobot2;
                    }
                    else if (comboBox16.SelectedIndex == 1)
                    {

                        bobot2 = 2 * 1;
                        textBox19.Text = "" + bobot2;
                    }
                    else if (comboBox16.SelectedIndex == 2)
                    {

                        bobot2 = 3 * 1;
                        textBox19.Text = "" + bobot2;
                    }

                }
                else if (comboBox3.SelectedIndex == 4)
                {
                    if (comboBox16.SelectedIndex == 0)
                    {

                        bobot2 = 0;
                        textBox19.Text = "" + bobot2;
                    }
                    else if (comboBox16.SelectedIndex == 1)
                    {

                        bobot2 = 0;
                        textBox19.Text = "" + bobot2;
                    }
                    else if (comboBox16.SelectedIndex == 2)
                    {

                        bobot2 = 0;
                        textBox19.Text = "" + bobot2;
                    }

                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                
                int bobot3;
                if (comboBox2.SelectedIndex == 0)
                {
                    if (comboBox17.SelectedIndex == 0)
                    {

                        bobot3 = 1 * 4;
                        textBox18.Text = "" + bobot3;
                    }
                    else if (comboBox17.SelectedIndex == 1)
                    {

                        bobot3 = 2 * 4;
                        textBox18.Text = "" + bobot3;
                    }
                    else if (comboBox17.SelectedIndex == 2)
                    {

                        bobot3 = 3 * 4;
                        textBox18.Text = "" + bobot3;
                    }

                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    if (comboBox17.SelectedIndex == 0)
                    {

                        bobot3 = 1 * 3;
                        textBox18.Text = "" + bobot3;
                    }
                    else if (comboBox17.SelectedIndex == 1)
                    {

                        bobot3 = 2 * 3;
                        textBox18.Text = "" + bobot3;
                    }
                    else if (comboBox17.SelectedIndex == 2)
                    {

                        bobot3 = 3 * 3;
                        textBox18.Text = "" + bobot3;
                    }

                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    if (comboBox17.SelectedIndex == 0)
                    {

                        bobot3 = 1 * 2;
                        textBox18.Text = "" + bobot3;
                    }
                    else if (comboBox17.SelectedIndex == 1)
                    {

                        bobot3 = 2 * 2;
                        textBox18.Text = "" + bobot3;
                    }
                    else if (comboBox18.SelectedIndex == 2)
                    {

                        bobot3 = 3 * 2;
                        textBox18.Text = "" + bobot3;
                    }

                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    if (comboBox17.SelectedIndex == 0)
                    {

                        bobot3 = 1 * 1;
                        textBox18.Text = "" + bobot3;
                    }
                    else if (comboBox17.SelectedIndex == 1)
                    {

                        bobot3 = 2 * 1;
                        textBox18.Text = "" + bobot3;
                    }
                    else if (comboBox17.SelectedIndex == 2)
                    {

                        bobot3 = 3 * 1;
                        textBox20.Text = "" + bobot3;
                    }

                }
                else if (comboBox2.SelectedIndex == 4)
                {
                    if (comboBox17.SelectedIndex == 0)
                    {

                        bobot3 = 0;
                        textBox18.Text = "" + bobot3;
                    }
                    else if (comboBox17.SelectedIndex == 1)
                    {

                        bobot3 = 0;
                        textBox18.Text = "" + bobot3;
                    }
                    else if (comboBox17.SelectedIndex == 2)
                    {

                        bobot3 = 0;
                        textBox18.Text = "" + bobot3;
                    }

                }
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                int bobot4;
                
                if (comboBox4.SelectedIndex == 0)
                {
                    if (comboBox15.SelectedIndex == 0)
                    {

                        bobot4 = 1 * 4;
                        textBox17.Text = "" + bobot4;
                    }
                    else if (comboBox15.SelectedIndex == 1)
                    {

                        bobot4 = 2 * 4;
                        textBox17.Text = "" + bobot4;
                    }
                    else if (comboBox15.SelectedIndex == 2)
                    {

                        bobot4 = 3 * 4;
                        textBox17.Text = "" + bobot4;
                    }

                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    if (comboBox15.SelectedIndex == 0)
                    {

                        bobot4 = 1 * 3;
                        textBox17.Text = "" + bobot4;
                    }
                    else if (comboBox15.SelectedIndex == 1)
                    {

                        bobot4 = 2 * 3;
                        textBox17.Text = "" + bobot4;
                    }
                    else if (comboBox15.SelectedIndex == 2)
                    {

                        bobot4 = 3 * 3;
                        textBox17.Text = "" + bobot4;
                    }

                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    if (comboBox15.SelectedIndex == 0)
                    {

                        bobot4 = 1 * 2;
                        textBox17.Text = "" + bobot4;
                    }
                    else if (comboBox15.SelectedIndex == 1)
                    {

                        bobot4 = 2 * 2;
                        textBox17.Text = "" + bobot4;
                    }
                    else if (comboBox15.SelectedIndex == 2)
                    {

                        bobot4 = 3 * 2;
                        textBox17.Text = "" + bobot4;
                    }

                }
                else if (comboBox4.SelectedIndex == 3)
                {
                    if (comboBox15.SelectedIndex == 0)
                    {

                        bobot4 = 1 * 1;
                        textBox17.Text = "" + bobot4;
                    }
                    else if (comboBox15.SelectedIndex == 1)
                    {

                        bobot4 = 2 * 1;
                        textBox17.Text = "" + bobot4;
                    }
                    else if (comboBox15.SelectedIndex == 2)
                    {

                        bobot4 = 3 * 1;
                        textBox17.Text = "" + bobot4;
                    }

                }
                else if (comboBox4.SelectedIndex == 4)
                {
                    if (comboBox15.SelectedIndex == 0)
                    {

                        bobot4 = 0;
                        textBox17.Text = "" + bobot4;
                    }
                    else if (comboBox15.SelectedIndex == 1)
                    {

                        bobot4 = 0;
                        textBox17.Text = "" + bobot4;
                    }
                    else if (comboBox15.SelectedIndex == 2)
                    {

                        bobot4 = 0;
                        textBox17.Text = "" + bobot4;
                    }

                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                
                int bobot5;
                if (comboBox5.SelectedIndex == 0)
                {
                    if (comboBox14.SelectedIndex == 0)
                    {

                        bobot5 = 1 * 4;
                        textBox16.Text = "" + bobot5;
                    }
                    else if (comboBox14.SelectedIndex == 1)
                    {

                        bobot5 = 2 * 4;
                        textBox16.Text = "" + bobot5;
                    }
                    else if (comboBox14.SelectedIndex == 2)
                    {

                        bobot5 = 3 * 4;
                        textBox16.Text = "" + bobot5;
                    }

                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    if (comboBox14.SelectedIndex == 0)
                    {

                        bobot5 = 1 * 3;
                        textBox16.Text = "" + bobot5;
                    }
                    else if (comboBox14.SelectedIndex == 1)
                    {

                        bobot5 = 2 * 3;
                        textBox16.Text = "" + bobot5;
                    }
                    else if (comboBox14.SelectedIndex == 2)
                    {

                        bobot5 = 3 * 3;
                        textBox16.Text = "" + bobot5;
                    }

                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    if (comboBox14.SelectedIndex == 0)
                    {

                        bobot5 = 1 * 2;
                        textBox16.Text = "" + bobot5;
                    }
                    else if (comboBox14.SelectedIndex == 1)
                    {

                        bobot5 = 2 * 2;
                        textBox16.Text = "" + bobot5;
                    }
                    else if (comboBox14.SelectedIndex == 2)
                    {

                        bobot5 = 3 * 2;
                        textBox16.Text = "" + bobot5;
                    }

                }
                else if (comboBox5.SelectedIndex == 3)
                {
                    if (comboBox14.SelectedIndex == 0)
                    {

                        bobot5 = 1 * 1;
                        textBox16.Text = "" + bobot5;
                    }
                    else if (comboBox14.SelectedIndex == 1)
                    {

                        bobot5 = 2 * 1;
                        textBox16.Text = "" + bobot5;
                    }
                    else if (comboBox14.SelectedIndex == 2)
                    {

                        bobot5 = 3 * 1;
                        textBox16.Text = "" + bobot5;
                    }

                }
                else if (comboBox5.SelectedIndex == 4)
                {
                    if (comboBox14.SelectedIndex == 0)
                    {

                        bobot5 = 0;
                        textBox16.Text = "" + bobot5;
                    }
                    else if (comboBox14.SelectedIndex == 1)
                    {

                        bobot5 = 0;
                        textBox16.Text = "" + bobot5;
                    }
                    else if (comboBox14.SelectedIndex == 2)
                    {

                        bobot5 = 0;
                        textBox16.Text = "" + bobot5;
                    }

                }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                int bobot6;
                
                if (comboBox6.SelectedIndex == 0)
                {
                    if (comboBox13.SelectedIndex == 0)
                    {

                        bobot6 = 1 * 4;
                        textBox15.Text = "" + bobot6;
                    }
                    else if (comboBox13.SelectedIndex == 1)
                    {

                        bobot6 = 2 * 4;
                        textBox15.Text = "" + bobot6;
                    }
                    else if (comboBox13.SelectedIndex == 2)
                    {

                        bobot6 = 3 * 4;
                        textBox15.Text = "" + bobot6;
                    }

                }
                else if (comboBox6.SelectedIndex == 1)
                {
                    if (comboBox13.SelectedIndex == 0)
                    {

                        bobot6 = 1 * 3;
                        textBox15.Text = "" + bobot6;
                    }
                    else if (comboBox13.SelectedIndex == 1)
                    {

                        bobot6 = 2 * 3;
                        textBox15.Text = "" + bobot6;
                    }
                    else if (comboBox13.SelectedIndex == 2)
                    {

                        bobot6 = 3 * 3;
                        textBox15.Text = "" + bobot6;
                    }

                }
                else if (comboBox6.SelectedIndex == 2)
                {
                    if (comboBox13.SelectedIndex == 0)
                    {

                        bobot6 = 1 * 2;
                        textBox15.Text = "" + bobot6;
                    }
                    else if (comboBox13.SelectedIndex == 1)
                    {

                        bobot6 = 2 * 2;
                        textBox15.Text = "" + bobot6;
                    }
                    else if (comboBox13.SelectedIndex == 2)
                    {

                        bobot6 = 3 * 2;
                        textBox15.Text = "" + bobot6;
                    }

                }
                else if (comboBox6.SelectedIndex == 3)
                {
                    if (comboBox13.SelectedIndex == 0)
                    {

                        bobot6 = 1 * 1;
                        textBox15.Text = "" + bobot6;
                    }
                    else if (comboBox13.SelectedIndex == 1)
                    {

                        bobot6 = 2 * 1;
                        textBox15.Text = "" + bobot6;
                    }
                    else if (comboBox13.SelectedIndex == 2)
                    {

                        bobot6 = 3 * 1;
                        textBox15.Text = "" + bobot6;
                    }

                }
                else if (comboBox6.SelectedIndex == 4)
                {
                    if (comboBox13.SelectedIndex == 0)
                    {

                        bobot6 = 0;
                        textBox15.Text = "" + bobot6;
                    }
                    else if (comboBox13.SelectedIndex == 1)
                    {

                        bobot6 = 0;
                        textBox15.Text = "" + bobot6;
                    }
                    else if (comboBox13.SelectedIndex == 2)
                    {

                        bobot6 = 0;
                        textBox15.Text = "" + bobot6;
                    }

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                int bobot7;

                if (comboBox7.SelectedIndex == 0)
                {
                    if (comboBox12.SelectedIndex == 0)
                    {

                        bobot7 = 1 * 4;
                        textBox14.Text = "" + bobot7;
                    }
                    else if (comboBox12.SelectedIndex == 1)
                    {

                        bobot7 = 2 * 4;
                        textBox14.Text = "" + bobot7;
                    }
                    else if (comboBox12.SelectedIndex == 2)
                    {

                        bobot7 = 3 * 4;
                        textBox14.Text = "" + bobot7;
                    }

                }
                else if (comboBox7.SelectedIndex == 1)
                {
                    if (comboBox12.SelectedIndex == 0)
                    {
                        
                        bobot7 = 1 * 3;
                        textBox14.Text = "" + bobot7;
                    }
                    else if (comboBox12.SelectedIndex == 1)
                    {

                        bobot7 = 2 * 3;
                        textBox14.Text = "" + bobot7;
                    }
                    else if (comboBox12.SelectedIndex == 2)
                    {

                        bobot7 = 3 * 3;
                        textBox14.Text = "" + bobot7;
                    }

                }
                else if (comboBox7.SelectedIndex == 2)
                {
                    if (comboBox12.SelectedIndex == 0)
                    {

                        bobot7 = 1 * 2;
                        textBox14.Text = "" + bobot7;
                    }
                    else if (comboBox12.SelectedIndex == 1)
                    {

                        bobot7 = 2 * 2;
                        textBox14.Text = "" + bobot7;
                    }
                    else if (comboBox12.SelectedIndex == 2)
                    {

                        bobot7 = 3 * 2;
                        textBox14.Text = "" + bobot7;
                    }

                }
                else if (comboBox7.SelectedIndex == 3)
                {
                    if (comboBox12.SelectedIndex == 0)
                    {

                        bobot7 = 1 * 1;
                        textBox14.Text = "" + bobot7;
                    }
                    else if (comboBox12.SelectedIndex == 1)
                    {

                        bobot7 = 2 * 1;
                        textBox14.Text = "" + bobot7;
                    }
                    else if (comboBox12.SelectedIndex == 2)
                    {

                        bobot7 = 3 * 1;
                        textBox14.Text = "" + bobot7;
                    }

                }
                else if (comboBox7.SelectedIndex == 4)
                {
                    if (comboBox12.SelectedIndex == 0)
                    {

                        bobot7 = 0;
                        textBox14.Text = "" + bobot7;
                    }
                    else if (comboBox12.SelectedIndex == 1)
                    {

                        bobot7 = 0;
                        textBox14.Text = "" + bobot7;
                    }
                    else if (comboBox12.SelectedIndex == 2)
                    {

                        bobot7 = 0;
                        textBox14.Text = "" + bobot7;
                    }

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                int bobot8;

                if (comboBox9.SelectedIndex == 0)
                {
                    if (comboBox10.SelectedIndex == 0)
                    {

                        bobot8 = 1 * 4;
                        textBox13.Text = "" + bobot8;
                    }
                    else if (comboBox10.SelectedIndex == 1)
                    {

                        bobot8 = 2 * 4;
                        textBox13.Text = "" + bobot8;
                    }
                    else if (comboBox10.SelectedIndex == 2)
                    {

                        bobot8 = 3 * 4;
                        textBox13.Text = "" + bobot8;
                    }

                }
                else if (comboBox9.SelectedIndex == 1)
                {
                    if (comboBox10.SelectedIndex == 0)
                    {

                        bobot8 = 1 * 3;
                        textBox13.Text = "" + bobot8;
                    }
                    else if (comboBox10.SelectedIndex == 1)
                    {

                        bobot8 = 2 * 3;
                        textBox13.Text = "" + bobot8;
                    }
                    else if (comboBox10.SelectedIndex == 2)
                    {

                        bobot8 = 3 * 3;
                        textBox13.Text = "" + bobot8;
                    }

                }
                else if (comboBox9.SelectedIndex == 2)
                {
                    if (comboBox10.SelectedIndex == 0)
                    {

                        bobot8 = 1 * 2;
                        textBox13.Text = "" + bobot8;
                    }
                    else if (comboBox10.SelectedIndex == 1)
                    {

                        bobot8 = 2 * 2;
                        textBox13.Text = "" + bobot8;
                    }
                    else if (comboBox10.SelectedIndex == 2)
                    {

                        bobot8 = 3 * 2;
                        textBox13.Text = "" + bobot8;
                    }

                }
                else if (comboBox9.SelectedIndex == 3)
                {
                    if (comboBox10.SelectedIndex == 0)
                    {

                        bobot8 = 1 * 1;
                        textBox13.Text = "" + bobot8;
                    }
                    else if (comboBox10.SelectedIndex == 1)
                    {

                        bobot8 = 2 * 1;
                        textBox13.Text = "" + bobot8;
                    }
                    else if (comboBox10.SelectedIndex == 2)
                    {

                        bobot8 = 3 * 1;
                        textBox13.Text = "" + bobot8;
                    }

                }
                else if (comboBox9.SelectedIndex == 4)
                {
                    if (comboBox10.SelectedIndex == 0)
                    {

                        bobot8 = 0;
                        textBox13.Text = "" + bobot8;
                    }
                    else if (comboBox10.SelectedIndex == 1)
                    {

                        bobot8 = 0;
                        textBox13.Text = "" + bobot8;
                    }
                    else if (comboBox10.SelectedIndex == 2)
                    {

                        bobot8 = 0;
                        textBox13.Text = "" + bobot8;
                    }

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int bobot9;

            if (comboBox8.SelectedIndex == 0)
            {
                if (comboBox11.SelectedIndex == 0)
                {

                    bobot9 = 1 * 4;
                    textBox12.Text = "" + bobot9;
                }
                else if (comboBox11.SelectedIndex == 1)
                {

                    bobot9 = 2 * 4;
                    textBox12.Text = "" + bobot9;
                }
                else if (comboBox11.SelectedIndex == 2)
                {

                    bobot9 = 3 * 4;
                    textBox12.Text = "" + bobot9;
                }

            }
            else if (comboBox8.SelectedIndex == 1)
            {
                if (comboBox11.SelectedIndex == 0)
                {

                    bobot9 = 1 * 3;
                    textBox12.Text = "" + bobot9;
                }
                else if (comboBox11.SelectedIndex == 1)
                {

                    bobot9 = 2 * 3;
                    textBox12.Text = "" + bobot9;
                }
                else if (comboBox11.SelectedIndex == 2)
                {

                    bobot9 = 3 * 3;
                    textBox12.Text = "" + bobot9;
                }

            }
            else if (comboBox8.SelectedIndex == 2)
            {
                if (comboBox11.SelectedIndex == 0)
                {

                    bobot9 = 1 * 2;
                    textBox12.Text = "" + bobot9;
                }
                else if (comboBox11.SelectedIndex == 1)
                {

                    bobot9 = 2 * 2;
                    textBox12.Text = "" + bobot9;
                }
                else if (comboBox11.SelectedIndex == 2)
                {

                    bobot9 = 3 * 2;
                    textBox12.Text = "" + bobot9;
                }

            }
            else if (comboBox8.SelectedIndex == 3)
            {
                if (comboBox11.SelectedIndex == 0)
                {

                    bobot9 = 1 * 1;
                    textBox12.Text = "" + bobot9;
                }
                else if (comboBox11.SelectedIndex == 1)
                {

                    bobot9 = 2 * 1;
                    textBox12.Text = "" + bobot9;
                }
                else if (comboBox11.SelectedIndex == 2)
                {

                    bobot9 = 3 * 1;
                    textBox12.Text = "" + bobot9;
                }

            }
            else if (comboBox8.SelectedIndex == 4)
            {
                if (comboBox11.SelectedIndex == 0)
                {

                    bobot9 = 0;
                    textBox12.Text = "" + bobot9;
                }
                else if (comboBox11.SelectedIndex == 1)
                {

                    bobot9 = 0;
                    textBox12.Text = "" + bobot9;
                }
                else if (comboBox11.SelectedIndex == 2)
                {

                    bobot9 = 0;
                    textBox12.Text = "" + bobot9;
                }

            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 32)
            {
                e.Handled = true;
            }
        }
    }
    }


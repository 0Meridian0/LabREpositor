using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string error = "Ошибка";
        private string c = "";
        private bool dot1 = false, plu = true;
        private string a, b;
        private int active1=10,active2=10;

       

        private string MethodE(string a,string b, string c)
        {
            double m = 0, l=double.Parse(a), d=double.Parse(b);
            if (c == "+")
                m = l + d;
            if (c == "-")
                m = l - d;
            if (c == "*")
                m = l * d;
            if (c == "/")
            {
                if (b == "0")
                    return error;
                else
                    m = l / d;
            }
            return m.ToString();
        }

        private string Reshenie(double aa, double bb, string c)
        {
            if (c == "+")
                aa = aa + bb;
            if (c == "-")
                aa = aa - bb;
            if (c == "*")
                aa = aa * bb;
            if (c == "/")
                if (bb == 0)
                    return error;
                else
                {
                    aa = aa / bb;
                }
            return aa.ToString();
        }
        private string Method(string a, string b)
        {
            try
            {
                double aa = 0, bb = 0;
                if (Tablo.Text != error)// ЗДЕСЬ ОШИБКА
                {
                    if (active2 != active1)
                    {
                        aa = double.Parse(Convert.ToString(Convert.ToInt64(a, active1), 10));
                        bb = double.Parse(Convert.ToString(Convert.ToInt64(b, active2), 10));
                        aa = double.Parse(Reshenie(aa, bb, c));
                        return aa.ToString();
                    }

                    if (active1 == active2)
                    {
                        if (active1 != 16)
                        {
                            if (active1 == 10)
                            {
                                aa = double.Parse(a);
                                bb = double.Parse(b);
                                aa = double.Parse(Reshenie(aa, bb, c));

                            }
                            else
                            {
                                aa = double.Parse(Convert.ToString(Convert.ToInt64(a, active1), 10));
                                bb = double.Parse(Convert.ToString(Convert.ToInt64(b, active2), 10));
                                aa = double.Parse(Convert.ToString(Convert.ToInt64(Reshenie(aa, bb, c), 10), active1));
                            }
                            if (active1 == 2)
                                bin.Checked = true;
                            if (active1 == 8)
                                oct.Checked = true;
                            if (active1 == 10)
                                dec.Checked = true;
                            return aa.ToString();
                        }
                        else
                        {
                            aa = double.Parse(Convert.ToString(Convert.ToInt64(a, active1), 10));
                            bb = double.Parse(Convert.ToString(Convert.ToInt64(b, active2), 10));
                            string h = (Convert.ToString(Convert.ToInt64(Reshenie(aa, bb, c), 10), active1)).ToUpper();
                            hex.Checked = true;
                            return h;
                        }
                    }
                    return error;
                }
                return error;
            }
            catch (Exception) { return error; }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (Tablo.Text == error)
                return;
            c = label1.Text;
            label1.Text = "";
            //if (bin.Checked == true)
            //    active2 = 2;
            //if (oct.Checked == true)
            //    active2 = 8;
            //if (dec.Checked == true)
            //    active2 = 10;
            //if (hex.Checked == true)
            //    active2 = 16;
            if (Tablo.Text.Contains("E"))
            {
                b = Tablo.Text;
                Tablo.Text = MethodE(a, b, c);
            }
            else
            {
                b = Tablo.Text;
                Tablo.Text = Method(a, b);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bin.Checked = false;
            //oct.Checked = false;
            //dec.Checked = false;
            //hex.Checked = false;
            // c = label1.Text;
            bin.Enabled = true;
            oct.Enabled = true;
            dec.Enabled = true;
            hex.Enabled = true;
            Button btn = sender as Button;
            if (Tablo.Text == error)
                return;
                if (Tablo.Text == "0")
                {
                    Tablo.Text = "";
                    Tablo.Text = btn.Text;
                }
                else
                {
                    if (c == "")
                        Tablo.Text += btn.Text;
                    else
                    {
                        if (Tablo.Text.Contains("E"))
                        {
                            c = "";
                            Tablo.Text += btn.Text;
                        }
                        else
                        {
                            c = "";
                            Tablo.Text += btn.Text;
                        }
                    }
                }
            
        }

        private void dot_Click(object sender, EventArgs e)
        {
                string a = Tablo.Text + ",";
                Tablo.Text = a;
        }

        private void smena_Click(object sender, EventArgs e)
        {
            if (plu == true)
            {
                Tablo.Text = (-1 * double.Parse(Tablo.Text)).ToString();
                plu = false;
            }
            else
            {
                Tablo.Text = (-1 * double.Parse(Tablo.Text)).ToString();
                plu = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Tablo.Text = Tablo.Text + "E-0";
        }
        private void bin_CheckedChanged(object sender, EventArgs e)
        {
            Perevodchik();
        }
        private void Perevodchik()
        {
            c = label1.Text;
            if (bin.Checked == true)
            {
                if (c == "")
                {
                    Tablo.Text = Convert.ToString(Convert.ToInt64(Tablo.Text, active1), 2);
                    active1 = 2;
                }
                else
                {
                    Tablo.Text = Convert.ToString(Convert.ToInt64(Tablo.Text, active2), 2);
                    active2 = 2;
                }
            }
            if (oct.Checked == true)
            {
                if (c == "")
                {
                    Tablo.Text = Convert.ToString(Convert.ToInt64(Tablo.Text, active1), 8);
                    active1 = 8;
                }
                else
                {
                    Tablo.Text = Convert.ToString(Convert.ToInt64(Tablo.Text, active2), 8);
                    active2 = 8;
                }
            }
            if (dec.Checked == true)
            {
                if (c == "")
                {
                    Tablo.Text = Convert.ToString(Convert.ToInt64(Tablo.Text, active1), 10);
                    active1 = 10;
                }
                else
                {
                    Tablo.Text = Convert.ToString(Convert.ToInt64(Tablo.Text, active2), 10);
                    active2 = 10;
                }
            }
            if (hex.Checked == true)
            {
                int y=0;
                if (c == "")
                {
                    foreach (char j in Tablo.Text)
                    {
                        if (char.IsLetter(j))
                            y = 1;
                    }
                    if (y!=1)
                    {
                        Tablo.Text = Convert.ToString(Convert.ToInt64(Tablo.Text, active1), 16).ToUpper();
                        active1 = 16;
                    }
                    else
                    {
                        active1 = 16;
                    }
                }
                else
                {
                    if (int.TryParse(Tablo.Text, out int n))
                    {
                        Tablo.Text = Convert.ToString(Convert.ToInt64(Tablo.Text, active2), 16);
                    active2 = 16;
                    }
                    else
                    {
                        active1 = 16;
                    }
                }
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Tablo.Text = Tablo.Text + "E+0";
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Tablo.Text = "0";
            dot1 = false;
            a = b = "";
            c = "";
            label1.Text = "";
            active1 = 10;
            active2 = 10;
        }

        private void BackSpace_Click(object sender, EventArgs e)
        {
            if (Tablo.Text.Length == 1 && Tablo.Text != "0")
                Tablo.Text = "0";
            if (Tablo.Text == "0." || Tablo.Text == "-0.")
            {
                dot1 = false;
                Tablo.Text = "0";
            }
            if (Tablo.Text == "0")
                return;
            if (Tablo.Text.Length > 1)
            {
                Tablo.Text = Tablo.Text.Remove(Tablo.Text.Length - 1);

            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            bin.Checked = false;
            oct.Checked = false;
            dec.Checked = false;
            hex.Checked = false;
            Button btn = sender as Button;
            if (Tablo.Text == error)
                return;
            if (Tablo.Text.Contains("E"))
                a = Tablo.Text;
            else
            {
                if (active1 == 10)
                    a = Tablo.Text;
                else
                    a = Tablo.Text;
            }
            Tablo.Text = "0";
            label1.Text = btn.Text;
            c = btn.Text;
            //if (bin.Checked == true)
            //{
            //    a = Tablo.Text;
            //    active1 = 2;
            //    Tablo.Text = "0";
            //    c = label1.Text = btn.Text;
            //}
            //if (oct.Checked == true)
            //{
            //    a = Tablo.Text;
            //    active1 = 8;
            //    Tablo.Text = "0";
            //    c = label1.Text = btn.Text;
            //}
            //if (hex.Checked == true)
            //{
            //    a = Tablo.Text;
            //    active1 = 16;
            //    Tablo.Text = "0";
            //    c = label1.Text = btn.Text;
            //}
            //if (dec.Checked == true)
            //{
            //    a = Tablo.Text;
            //    active1 = 10;
            //    Tablo.Text = "0";
            //    c = label1.Text = btn.Text;
            //}
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Resistence.Helpers.enumColorBand;

namespace Resistence.Forms
{
    public partial class fourBandResistence : Form
    {
        public fourBandResistence()
        {
            InitializeComponent();
        }

        private void fourBandResistence_Load(object sender, EventArgs e)
        {
            InitPositionBand();
        }

        private void firstLineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.firstLineComboBox.SelectedIndex)
            {
                case 0:
                    {
                        this.btnFirstLine.BackColor = Color.Black;
                        break;
                    }

                case 1:
                    {
                        this.TextBox1.Text = "1";
                        this.btnFirstLine.BackColor = Color.Maroon;
                        break;
                    }

                case 2:
                    {
                        this.TextBox1.Text = "2";
                        this.btnFirstLine.BackColor = Color.Red;
                        break;
                    }

                case 3:
                    {
                        this.TextBox1.Text = "3";
                        this.btnFirstLine.BackColor = Color.Orange;
                        break;
                    }

                case 4:
                    {
                        this.TextBox1.Text = "4";
                        this.btnFirstLine.BackColor = Color.Yellow;
                        break;
                    }

                case 5:
                    {
                        this.TextBox1.Text = "5";
                        this.btnFirstLine.BackColor = Color.Green;
                        break;
                    }

                case 6:
                    {
                        this.TextBox1.Text = "6";
                        this.btnFirstLine.BackColor = Color.Blue;
                        break;
                    }

                case 7:
                    {
                        this.TextBox1.Text = "7";
                        this.btnFirstLine.BackColor = Color.Violet;
                        break;
                    }

                case 8:
                    {
                        this.TextBox1.Text = "8";
                        this.btnFirstLine.BackColor = Color.Gray;
                        break;
                    }

                case 9:
                    {
                        this.TextBox1.Text = "9";
                        this.btnFirstLine.BackColor = Color.White;
                        break;
                    }
            }

            this.firstLineComboBox.Enabled = false;
            this.secontLineComboBox.Enabled = true;
            this.secontLineComboBox.Focus();
        }
        private void secontLineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            switch (this.secontLineComboBox.SelectedIndex)
            {
                case 0:
                    {
                        TextBox1.Text = "0";
                        btnSecondLine.BackColor = Color.Black;
                        break;
                    }

                case 1:
                    {
                        this.TextBox1.Text += "1";
                        btnSecondLine.BackColor = Color.Maroon;
                        break;
                    }

                case 2:
                    {
                        this.TextBox1.Text += "2";
                        btnSecondLine.BackColor = Color.Red;
                        break;
                    }

                case 3:
                    {
                        this.TextBox1.Text += "3";
                        btnSecondLine.BackColor = Color.Orange;
                        break;
                    }

                case 4:
                    {
                        this.TextBox1.Text += "4";
                        btnSecondLine.BackColor = Color.Yellow;
                        break;
                    }

                case 5:
                    {
                        this.TextBox1.Text += "5";
                        btnSecondLine.BackColor = Color.Green;
                        break;
                    }

                case 6:
                    {
                        this.TextBox1.Text += "6";
                        btnSecondLine.BackColor = Color.Blue;
                        break;
                    }

                case 7:
                    {
                        this.TextBox1.Text += "7";
                        btnSecondLine.BackColor = Color.Violet;
                        break;
                    }

                case 8:
                    {
                        this.TextBox1.Text += "8";
                        btnSecondLine.BackColor = Color.Gray;
                        break;
                    }

                case 9:
                    {
                        this.TextBox1.Text += "9";
                        btnSecondLine.BackColor = Color.White;
                        break;
                    }
            }

            this.secontLineComboBox.Enabled = false;
            this.multiplyComboBox.Enabled = true;
            this.multiplyComboBox.Focus();
        }
        private void multiplyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.multiplyComboBox.SelectedIndex)
            {
                case 0:
                    {
                        this.btnMultiply.BackColor = Color.Black;
                        break;
                    }

                case 1:
                    {
                        this.TextBox1.Text += "0";
                        this.btnMultiply.BackColor = Color.Maroon;
                        break;
                    }

                case 2:
                    {
                        this.TextBox1.Text += "00";
                        this.btnMultiply.BackColor = Color.Red;
                        break;
                    }

                case 3:
                    {
                        this.TextBox1.Text += "000";
                        this.btnMultiply.BackColor = Color.Orange;
                        break;
                    }

                case 4:
                    {
                        this.TextBox1.Text += "0000";
                        this.btnMultiply.BackColor = Color.Yellow;
                        break;
                    }

                case 5:
                    {
                        this.TextBox1.Text += "00000";
                        this.btnMultiply.BackColor = Color.Green;
                        break;
                    }

                case 6:
                    {
                        this.TextBox1.Text += "000000";
                        this.btnMultiply.BackColor = Color.Blue;
                        break;
                    }

                case 7:
                    {
                        this.TextBox1.Text += "0000000";
                        this.btnMultiply.BackColor = Color.Violet;
                        break;
                    }

                case 8:
                    {
                        this.TextBox1.Text = (Convert.ToDouble(this.TextBox1.Text) * 0.1d).ToString();
                        this.btnMultiply.BackColor = Color.Gray;
                        break;
                    }

                case 9:
                    {
                        this.TextBox1.Text = (Convert.ToDouble(this.TextBox1.Text) * 0.01d).ToString();
                        this.btnMultiply.BackColor = Color.White;
                        break;
                    }
            }

            this.multiplyComboBox.Enabled = false;
            this.toleranceLineComboBox.Enabled = true;

        }
        private void toleranceLineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.toleranceLineComboBox.SelectedIndex)
            {
                case 0:
                    {
                        this.btnTolerance.BackColor = Color.Red;
                        this.TextBox1.Text = " " + this.TextBox1.Text + " +- " + Convert.ToDouble(this.TextBox1.Text) * 2d / 100d + "Ω";
                        break;
                    }

                case 1:
                    {
                        this.btnTolerance.BackColor = Color.Gold;
                        this.TextBox1.Text = " " + this.TextBox1.Text + " +- " + Convert.ToDouble(this.TextBox1.Text) * 5d / 100d + "Ω";
                        break;
                    }

                case 2:
                    {
                        this.btnTolerance.BackColor = Color.Silver;
                        this.TextBox1.Text = " " + this.TextBox1.Text + " +- " + Convert.ToDouble(this.TextBox1.Text) * 10d / 100d + "Ω";
                        break;
                    }
            }
            FinalPositionBand(); 
            ConcateBandValue();
        }        
        public void ConcateBandValue()
        {
            int a = this.TextBox1.Text.IndexOf("");
            int b = this.TextBox1.Text.LastIndexOf("+-");
            double c = Convert.ToDouble(this.TextBox1.Text.Substring(a, b)) - 1d + 1d;
            string medida3, resultado3, muestra3, medidafinal2;
            medida3 = (this.TextBox1.Text.IndexOf("-") + 1).ToString();
            medidafinal2 = this.TextBox1.Text.LastIndexOf("Ω").ToString();
            resultado3 = (Convert.ToDouble(medidafinal2.ToString()) - Convert.ToDouble(medida3.ToString())).ToString();
            muestra3 = this.TextBox1.Text.Substring(Convert.ToInt32(medida3), Convert.ToInt32(resultado3));
            this.TextBox2.Text = muestra3.Remove(0, 1);
            this.TextBox3.Text = (Convert.ToDouble(this.TextBox1.Text.Substring(a, b)) - 1d + 1d).ToString();

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.firstLineComboBox.Enabled = true;
            this.firstLineComboBox.ResetText();
            this.secontLineComboBox.Enabled = true;
            this.secontLineComboBox.ResetText();
            this.multiplyComboBox.Enabled = true;
            this.multiplyComboBox.ResetText();
            this.toleranceLineComboBox.Enabled = true;
            this.toleranceLineComboBox.ResetText();
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox3.Text = "";
            this.btnFirstLine.BackColor = default(Color);
            this.btnSecondLine.BackColor = default(Color);
            this.btnMultiply.BackColor = default(Color);
            this.btnTolerance.BackColor = default(Color);
            this.ListBox1.Items.Clear();
            this.CheckBox1.Checked = false;
            this.CheckBox2.Checked = false;
            this.CheckBox3.Checked = false;
        }
        public void InitPositionBand()
        {
           CheckBox1.Enabled = false;
           CheckBox2.Enabled = false;
           CheckBox3.Enabled = false;
           secontLineComboBox.Enabled = false;
           multiplyComboBox.Enabled = false;
           toleranceLineComboBox.Enabled = false;
           btnFirstLine.Enabled = false;
           btnSecondLine.Enabled = false;
           btnMultiply.Enabled = false;
           btnTolerance.Enabled = false;
        }
        public void FinalPositionBand()
        {
            this.toleranceLineComboBox.Enabled = false;
            this.firstLineComboBox.Enabled = true;
            this.secontLineComboBox.Enabled = true;
            this.multiplyComboBox.Enabled = true;
            this.groupBox3.Enabled = true;
            this.CheckBox1.Enabled = true;
            this.CheckBox2.Enabled = true;
            this.CheckBox3.Enabled = true;
        }

        private void CheckBox1_Click(object sender, EventArgs e)
        {
            CheckBox2.Enabled = false;
            CheckBox3.Enabled = false;
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int f = 5;
            int g = 6;
            ListBox1.Items.Add(Math.Pow(10d, (a - 1) / 6d));
            ListBox1.Items.Add((object)(Math.Pow(10d, (b - 1) / 6d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (c - 1) / 6d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (d - 1) / 6d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (f - 1) / 6d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (g - 1) / 6d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            CheckBox1.Enabled = false; 
        }

        private void CheckBox2_Click(object sender, EventArgs e)
        {
            CheckBox1.Enabled = false;
            CheckBox3.Enabled = false;
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int f = 5;
            int g = 6;
            int h = 7;
            int i = 8;
            int j = 9;
            int k = 10;
            int l = 11;
            int m = 12;
           ListBox1.Items.Add(Math.Pow(10d, (a - 1) / 12d));
           ListBox1.Items.Add((object)(Math.Pow(10d, (b - 1) / 12d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
           ListBox1.Items.Add((object)(Math.Pow(10d, (c - 1) / 12d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
           ListBox1.Items.Add((object)(Math.Pow(10d, (d - 1) / 12d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
           ListBox1.Items.Add((object)(Math.Pow(10d, (f - 1) / 12d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
           ListBox1.Items.Add((object)(Math.Pow(10d, (g - 1) / 12d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
           ListBox1.Items.Add((object)(Math.Pow(10d, (h - 1) / 12d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
           ListBox1.Items.Add((object)(Math.Pow(10d, (i - 1) / 12d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
           ListBox1.Items.Add((object)(Math.Pow(10d, (j - 1) / 12d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
           ListBox1.Items.Add((object)(Math.Pow(10d, (k - 1) / 12d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
           ListBox1.Items.Add((object)(Math.Pow(10d, (l - 1) / 12d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
           ListBox1.Items.Add((object)(Math.Pow(10d, (m - 1) / 12d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
           CheckBox2.Enabled = false;
        }

        private void CheckBox3_Click(object sender, EventArgs e)
        {
            CheckBox1.Enabled = false;
            CheckBox2.Enabled = false;
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int f = 5;
            int g = 6;
            int h = 7;
            int i = 8;
            int j = 9;
            int k = 10;
            int l = 11;
            int m = 12;
            int a1 = 13;
            int b1 = 14;
            int c1 = 15;
            int d1 = 16;
            int f1 = 17;
            int g1 = 18;
            int h1 = 19;
            int i1 = 20;
            int j1 = 21;
            int k1 = 22;
            int l1 = 23;
            int m1 = 24;
            ListBox1.Items.Add(Math.Pow(10d, (a - 1) / 24d));
            ListBox1.Items.Add((object)(Math.Pow(10d, (b - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (c - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (d - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (f - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (g - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (h - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (i - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (j - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (k - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (l - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (m - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (a1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (b1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (c1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (d1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (f1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (g1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (h1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (i1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (j1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (k1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (l1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            ListBox1.Items.Add((object)(Math.Pow(10d, (m1 - 1) / 24d) * (Convert.ToDouble(this.TextBox3.Text) / 10d)));
            CheckBox3.Enabled = false;
        }

         

    }
} 

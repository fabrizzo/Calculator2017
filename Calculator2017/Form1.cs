using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2017
{
    public partial class Form1 : Form
    {
        Double Result = 0;
        string operation;
        bool enter_value = false;
        char ioperation;
        float iCelsius, iFahrenheit, iKevin;
        string operationname, operationname2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 289;
            this.textBox1.Width = 248;
        }
        // два нуля
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "00";
            }
            else
            {
                textBox1.Text = textBox1.Text + "00";
            }
        }
        // С
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            Result = 0;
        }
        // плюс минус умножить разделить
        private void OryphmeticOperations(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Result != 0)
            {
                button14.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblShowOps.Text = Result + "  " + operation;
                textBox1.Text = "";
            }
            else
            {
                operation = b.Text;
                Result = double.Parse(textBox1.Text);
                enter_value = true;
                lblShowOps.Text = System.Convert.ToString(Result) + "  " + operation;
            }
        }
        // Равно
        private void button14_Click(object sender, EventArgs e)
        {
            lblShowOps.Text = "";
            switch(operation)
            {
                case "x":
                    textBox1.Text = (Result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (Result / double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (Result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "+":
                    textBox1.Text = (Result + double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            Result = Double.Parse(textBox1.Text);
            operation = "";
        }

        //backspace button
        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

        }
        //НОМЕР КЛИК И точка
        private void btn_number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if((textBox1.Text == "0")||(enter_value ))
            {
                textBox1.Text = "";
                enter_value = false;
            }
            if (b.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + b.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + b.Text;
            }
        }
        // СЕ
        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (!textBox1.Text.Contains("-"))
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text.Trim(new char[] { '-' });
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != "")
            {
                Result = Double.Parse(textBox1.Text) * Double.Parse(textBox1.Text);
                textBox1.Text = Result.ToString();
            }
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != "")
            {
                Result = Math.Sqrt(Double.Parse(textBox1.Text));
                textBox1.Text = Result.ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != "")
            {
                Result = 1 / Double.Parse(textBox1.Text);
                textBox1.Text = Result.ToString();
            }
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox2.Focus();
            this.Width = 557;
            this.groupBox1.Visible = true;
            this.groupBox2.Visible = false;
        }

        private void converterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 557;
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = true;
            this.groupBox2.Location = new Point (273, 27);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bronx Inc. All Rights Reserved 2017");
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 289;
        }

        private void conCtoPha_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'C';
        }

        private void conPhatoC_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'F';
        }

        private void conCtoKel_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'K';
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            operationname = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            operationname2 = comboBox2.Text;
        }

        private void btn_cnv_Click(object sender, EventArgs e)
        {
            switch (operationname)
            {
                case "Милиметры":
                    if (operationname2 == "Сантиметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm / 10).ToString(); 
                    }
                    if (operationname2 == "Метры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm / 1000).ToString();
                    }
                    if (operationname2 == "Километры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm / 1000000).ToString();
                    }
                    if (operationname2 == "Дециметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm / 100).ToString();
                    }
                    break;
                case "Сантиметры":
                    if (operationname2 == "Милиметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm * 10).ToString();
                    }
                    if (operationname2 == "Метры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm / 100).ToString();
                    }
                    if (operationname2 == "Километры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm / 100000).ToString();
                    }
                    if (operationname2 == "Дециметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm / 10).ToString();
                    }
                    break;
                case "Метры":

                    if (operationname2 == "Сантиметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm * 10).ToString();
                    }
                    if (operationname2 == "Милиметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm * 100).ToString();
                    }
                    if (operationname2 == "Километры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm / 1000).ToString();
                    }
                    if (operationname2 == "Дециметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm / 10).ToString();
                    }
                    break;
                case "Километры":
                    if (operationname2 == "Сантиметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm * 100000).ToString();
                    }
                    if (operationname2 == "Милиметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm * 1000000).ToString();
                    }
                    if (operationname2 == "Метры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm * 1000).ToString();
                    }
                    if (operationname2 == "Дециметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm * 10000).ToString();
                    }
                    break;
                case "Дециметры":
                    if (operationname2 == "Сантиметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm * 10).ToString();
                    }
                    if (operationname2 == "Милиметры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm * 100).ToString();
                    }
                    if (operationname2 == "Метры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm / 10).ToString();
                    }
                    if (operationname2 == "Километры")
                    {
                        float sm = float.Parse(convBox3.Text);
                        lblconv3.Text = (sm / 10000).ToString();
                    }
                    break;


            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            convBox3.Clear();
            lblconv3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";


        }

        private void Convert_Click(object sender, EventArgs e)
        {
            switch(ioperation)
            {
                case 'C':
                    //celsius to fahrenheit
                    iCelsius = float.Parse(textBox2.Text);
                    lblconv.Text = (((9 * iCelsius) / 5) + 32).ToString();
                    break;
                case 'F':
                    //celsius to fahrenheit
                    iFahrenheit = float.Parse(textBox2.Text);
                    lblconv.Text = (((iFahrenheit - 32)*5) / 9).ToString();
                    break;
                case 'K':
                    //celsius to fahrenheit
                    iKevin = float.Parse(textBox2.Text);
                    lblconv.Text = ((((9 * iKevin) / 5) + 32)+273.15).ToString();
                    break;
            }
        }

        private void ResetCon_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            lblconv.Text = "";
            conCtoPha.Checked = false;
            conPhatoC.Checked = false;
            conCtoKel.Checked = false;
        }
    }

}

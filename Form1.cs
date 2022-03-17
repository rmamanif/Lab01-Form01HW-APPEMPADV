using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Form01HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("+", "Suma");
            test.Add("-", "Resta");
            test.Add("*", "Multiplicación");
            test.Add("/", "División");
            comboBox1.DataSource = new BindingSource(test, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            Dictionary<string, string> temp = new Dictionary<string, string>();
            temp.Add("1", "C° a F°");
            temp.Add("2", "F° a C°");
            comboBox2.DataSource = new BindingSource(temp, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key;
            Console.Write(value);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(num1txt.Text);
            int b = Convert.ToInt32(num2txt.Text);
            string op = (string) comboBox1.SelectedValue;
            int res = 0;
            double dba = Convert.ToDouble(a);
            double dbb = Convert.ToDouble(b);
            double dres = Convert.ToDouble(res);
            switch (op)
            {
                case "+":
                    res = a + b;
                    break;
                
                case "-":
                    res = a - b;
                    break;

                case "*":
                    res = a * b;
                    break;

                case "/":
                    
                    dres = dba / dbb;
                    break;
                default:
                    throw new Exception("operador inválido");

            }

            if (op == "/")
                resultado.Text = Convert.ToString(dres);
            else
                resultado.Text = Convert.ToString(res);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dvgraz.Rows.Clear();
            for (int i = 1; i <= 10; i++)
            {
                dvgraz.Rows.Add(i,Math.Sqrt(i));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0, num = 0, initial = 1, jump = 1;
            dgvprimo.Rows.Clear();
            while (num < 10)
            {
                jump = 1;
                count = 0;
                while (jump <= initial)
                {
                    if (initial % jump == 0)
                        count++;
                    jump++;

                }
                if (count == 2)
                {
                    Console.WriteLine(initial);
                    dgvprimo.Rows.Add(num+1,initial);
                    num++;
                }
                initial++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double temperatura = Convert.ToInt32(temptxt.Text);
            string tempop = (string)comboBox2.SelectedValue; 
            switch (tempop)
            {
                case "1":
                    temperatura = ((9 * temperatura) / 5) + 32;
                    break;
                case "2":
                    temperatura = (5 * (temperatura - 32)) / 9;
                    break;

            }
            label8.Text = Convert.ToString(temperatura);

        }
    }
}

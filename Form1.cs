using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x = double.Parse(textX1.Text);
            double y = double.Parse(textY1.Text);
            double z = double.Parse(textZ.Text);

            double cos = 2 * Math.Cos(x - Math.PI / 6);
            double denom = 0.5 + Math.Pow(Math.Sin(y), 2);
            double zPart = Math.Pow(z, 2) / (3 - (Math.Pow(z, 2) / 5));

            double result = (cos / denom) * (1 + zPart);

            lblResultLinear1.Text = $"Результат: {result:F4}";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Вычисление2_Click(object sender, EventArgs e)
        {
            try
            {

                double x = double.Parse(textX2.Text);
                double y = double.Parse(textY2.Text);

                double fx = 0;
                if (radioCos.Checked)
                {
                    fx = Math.Cos(x);
                }
                else if (radioSqr.Checked)
                {
                    fx = Math.Pow(x, 2);
                }
                else if (radioExp.Checked)
                {
                    fx = Math.Exp(x);
                }
                else
                {
                    lblResult.Text = "Выберите функцию f(x)";
                    return;
                }

                double result = 0;
                double product = x * y;

                if (product > 0)
                {
                    result = Math.Pow(fx + y, 2);
                    lblResult.Text = $"Результат = {result:F4} (x*y > 0)";
                }
                else if (product < 0)
                {
                    result = Math.Pow(fx - y, 2);
                    lblResult.Text = $"Результат = {result:F4} (x*y < 0)";
                }
                else 
                {
                    result = fx + y;
                    lblResult.Text = $"Результат = {result:F4} (x*y = 0)";
                }
            }
            catch (FormatException)
            {
                lblResult.Text = "Ошибка: введите корректные числа";
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void ClearResult(object sender, EventArgs e)
        {
            lblResult.Text = "Результат: ";
        }
    }
}

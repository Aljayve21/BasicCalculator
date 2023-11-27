using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            textBox_Results.Text = "Total" + Environment.NewLine + "000000";
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float number1, number2;
            if (!float.TryParse(textBox1.Text, out number1))
            {
                MessageBox.Show("First Number Invalid");
                return;
            }
            if(!float.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Second Number Invalid");
                return;
            }
            string oper = comboBox_Operator.Text;
            switch(oper)
            {
                case "+":
                    {
                        BasicCalculator.CalculatorPrivateAssembly add = new BasicCalculator.CalculatorPrivateAssembly();
                        textBox_Results.Text = "Total" + Environment.NewLine + Convert.ToString(add.Addition(Convert.ToInt16(textBox1.Text),Convert.ToInt16(textBox2.Text)));
                        break;
                    }
                    case "-":
                    {
                        BasicCalculator.CalculatorPrivateAssembly subtract = new BasicCalculator.CalculatorPrivateAssembly();
                        textBox_Results.Text = "Total" + Environment.NewLine + Convert.ToString(subtract.Subtraction(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)));
                        break;
                    }
                case "*":
                    {
                        BasicCalculator.CalculatorPrivateAssembly multiply = new BasicCalculator.CalculatorPrivateAssembly();
                        textBox_Results.Text = "Total" + Environment.NewLine + Convert.ToString(multiply.Multiplication(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)));
                        break;
                    }
                case "/":
                    
                        if(number2 == 0)
                        {
                            MessageBox.Show("Divided by Zero");
                        }
                        else
                        {
                            BasicCalculator.CalculatorPrivateAssembly devide = new BasicCalculator.CalculatorPrivateAssembly();
                            textBox_Results.Text = "Total" + Environment.NewLine + Convert.ToString(devide.Division(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)));
                        }
                        break;
                        default:
                            MessageBox.Show("Operator Invalid");
                        break;
                    
            }
        }
    }
}

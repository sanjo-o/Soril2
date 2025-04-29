using System;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        double cdblCurrTotal = 0;
        bool cblnReplace = false;
        string cstrLastOperation = "";
        double memory = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValue.Text = "0.";
        }

        private void CreateValue(string strCurrNum)
        {
            if ((txtValue.Text == "0.") || (txtValue.Text == "") || cblnReplace)
                txtValue.Text = strCurrNum + ".";
            else
                txtValue.Text = txtValue.Text.Substring(0, txtValue.Text.Length - 1) + strCurrNum + ".";
            cblnReplace = false;
        }

        private void DoLastOperation()
        {
            try
            {
                double current = Convert.ToDouble(txtValue.Text);
                switch (cstrLastOperation)
                {
                    case "+":
                        cdblCurrTotal += current;
                        break;
                    case "-":
                        cdblCurrTotal -= current;
                        break;
                    case "*":
                        cdblCurrTotal *= current;
                        break;
                    case "/":
                        if (current == 0)
                            throw new DivideByZeroException("Cannot divide by zero.");
                        cdblCurrTotal /= current;
                        break;
                }
                txtValue.Text = cdblCurrTotal.ToString() + ".";
                cblnReplace = true;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Math Error");
                txtValue.Text = "0";
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Error");
                txtValue.Text = "0";
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Utga alga.");
                txtValue.Text = "0";
            }
        }


        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            cdblCurrTotal = Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "+";
        }

        private void btnSubtrac_Click(object sender, EventArgs e)
        {
            cdblCurrTotal = Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "-";
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            cdblCurrTotal = Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            cdblCurrTotal = Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "/";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            DoLastOperation();
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0.";
            cdblCurrTotal = 0;
            cstrLastOperation = "";
            cblnReplace = false;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0.";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            string value = txtValue.Text;
            if (value.Length > 2)
                txtValue.Text = value.Substring(0, value.Length - 2) + ".";
            else
                txtValue.Text = "0.";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtValue.Text);
            txtValue.Text = (value / 100).ToString() + ".";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtValue.Text);
            if (value >= 0)
                txtValue.Text = Math.Sqrt(value).ToString() + ".";
            else
                MessageBox.Show("Invalid input for square root.");
        }

        private void btnOneOverX_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtValue.Text);
            if (value != 0)
                txtValue.Text = (1 / value).ToString() + ".";
            else
                MessageBox.Show("Cannot divide by zero.");
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtValue.Text);
            txtValue.Text = (-value).ToString() + ".";
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (!txtValue.Text.Contains("."))
                txtValue.Text = txtValue.Text.Substring(0, txtValue.Text.Length - 1) + txtValue.Text + ".";
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(txtValue.Text);
        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            txtValue.Text = memory.ToString() + ".";
        }

        private void btnMemoryPlus_Click(object sender, EventArgs e)
        {
            memory += Convert.ToDouble(txtValue.Text);
        }

        private void btn7_Click(object sender, EventArgs e) => CreateValue("7");
        private void btn8_Click(object sender, EventArgs e) => CreateValue("8");
        private void btn9_Click(object sender, EventArgs e) => CreateValue("9");
        private void btn4_Click(object sender, EventArgs e) => CreateValue("4");
        private void btn5_Click(object sender, EventArgs e) => CreateValue("5");
        private void btn6_Click(object sender, EventArgs e) => CreateValue("6");
        private void btn1_Click(object sender, EventArgs e) => CreateValue("1");
        private void btn2_Click(object sender, EventArgs e) => CreateValue("2");
        private void btn3_Click(object sender, EventArgs e) => CreateValue("3");
        private void btn0_Click(object sender, EventArgs e) => CreateValue("0");

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {

        }

        // You can assign `btnDivide_Click` to your division button's click event.
    }
}

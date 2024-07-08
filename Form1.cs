using System.Reflection;

namespace Calculator
{
    public enum Math
    {
        ADDITION,
        SUBTRACTION,
        MULTIPLICATION,
        DIVISION,

        NONE
    }

    public partial class Form1 : Form
    {
        private double? LastCalculation = null;
        private double? LeftNumber = null;
        private double? RightNumber = null;
        private Math LastProcess = Math.NONE;

        private char[] ArithmicCharacters =
        {
            '+', '-', '*', '/'
        };

        public Form1()
        {
            InitializeComponent();
            txtBuffer.Text = "0";

            this.KeyPress += Any_KeyPress;
            foreach (Control c in this.Controls)
            {
                c.KeyPress += Any_KeyPress;
                if(c is Button btn)
                {

                }
            }
            this.Select();
        }

        private void Any_KeyPress(object? sender, KeyPressEventArgs e)
        {
            txtBuffer.Select(txtBuffer.Text.Length, 0);
            txtBuffer.ScrollToCaret();
            txtBuffer.DeselectAll();
            if (txtBuffer.Text == "0" && char.IsDigit(e.KeyChar)) txtBuffer.Text = e.KeyChar.ToString();
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnEquals_Click(sender, EventArgs.Empty);
                    return;
                }

                if(e.KeyChar == (char)Keys.Back)
                {
                    if (txtBuffer.Text.Length <= 0) return;
                    txtBuffer.Text = txtBuffer.Text.Substring(0, txtBuffer.Text.Length - 1);
                    if (txtBuffer.Text.Length <= 0)
                    {
                        txtBuffer.Text = "0";
                    }
                    e.Handled = true;
                    return;
                }

                if(e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                {
                    if (ArithmicCharacters.Any(x => txtBuffer.Text.Contains(x)))
                    {
                        e.Handled = true;
                        return;
                    }
                }
                switch(e.KeyChar)
                {
                    case '+':
                        LastProcess = Math.ADDITION;
                        break;
                    case '-':
                        LastProcess = Math.SUBTRACTION;
                        break;
                    case '/':
                        LastProcess = Math.DIVISION;
                        break;
                    case '*':
                        LastProcess = Math.MULTIPLICATION;
                        break;
                    case '.':
                        if (txtBuffer.Text.Contains('.'))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;
                    default:
                        if (!char.IsDigit(e.KeyChar))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;
                }
                txtBuffer.Text += e.KeyChar.ToString();
                e.Handled = true;
                txtBuffer.Select(txtBuffer.Text.Length, 0);
                txtBuffer.ScrollToCaret();
                txtBuffer.DeselectAll();
            }
            this.Select();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text == "0") txtBuffer.Text = string.Empty;
            txtBuffer.Text += "0";
            this.Select();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text == "0") txtBuffer.Text = string.Empty;
            txtBuffer.Text += "1";
            this.Select();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text == "0") txtBuffer.Text = string.Empty;
            txtBuffer.Text += "2";
            this.Select();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text == "0") txtBuffer.Text = string.Empty;
            txtBuffer.Text += "3";
            this.Select();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text == "0") txtBuffer.Text = string.Empty;
            txtBuffer.Text += "4";
            this.Select();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text == "0") txtBuffer.Text = string.Empty;
            txtBuffer.Text += "5";
            this.Select();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text == "0") txtBuffer.Text = string.Empty;
            txtBuffer.Text += "6";
            this.Select();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text == "0") txtBuffer.Text = string.Empty;
            txtBuffer.Text += "7";
            this.Select();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text == "0") txtBuffer.Text = string.Empty;
            txtBuffer.Text += "8";
            this.Select();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text == "0") txtBuffer.Text = string.Empty;
            txtBuffer.Text += "9";
            this.Select();
        }

        private void btnClearLast_Click(object sender, EventArgs e)
        {
            if (LastCalculation == null)
            {
                txtBuffer.Text = "0";
                LeftNumber = null;
                LastProcess = Math.NONE;
                return;
            }
            txtBuffer.Text = LastCalculation.ToString();
            LeftNumber = LeftNumber = Convert.ToDouble(txtBuffer.Text);
            RightNumber = null;
            LastProcess = Math.NONE;
            this.Select();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            LeftNumber = null;
            RightNumber = null;
            LastCalculation = null;
            LastProcess = Math.NONE;
            txtBuffer.Text = "0";
            this.Select();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text.Contains('.')) return;
            txtBuffer.Text += ".";
            this.Select();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text.Contains('+') || LastProcess != Math.NONE) return;

            if (LeftNumber == null) LeftNumber = GetLeftNumber('+');
            txtBuffer.Text += "+";
            LastProcess = Math.ADDITION;
            this.Select();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text.Contains('-') || LastProcess != Math.NONE) return;

            if (LeftNumber == null) LeftNumber = GetLeftNumber('-');
            txtBuffer.Text += "-";
            LastProcess = Math.SUBTRACTION;
            this.Select();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text.Contains('*') || LastProcess != Math.NONE) return;

            if (LeftNumber == null) LeftNumber = GetLeftNumber('*');
            txtBuffer.Text += "*";
            LastProcess = Math.MULTIPLICATION;
            this.Select();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtBuffer.Text.Contains('/') || LastProcess != Math.NONE) return;

            if (LeftNumber == null) LeftNumber = GetLeftNumber('/');
            txtBuffer.Text += "/";
            LastProcess = Math.DIVISION;
            this.Select();
        }

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBuffer.Text, out double v))
            {
                txtBuffer.Text = (-v).ToString();
            }
            else
            {
                switch (LastProcess)
                {
                    case Math.ADDITION:
                        RightNumber = GetRightNumber('+');
                        txtBuffer.Text = $"{LeftNumber}+{-RightNumber}";
                        break;
                    case Math.SUBTRACTION:
                        RightNumber = GetRightNumber('-');
                        txtBuffer.Text = $"{LeftNumber}-{-RightNumber}";
                        break;
                    case Math.MULTIPLICATION:
                        RightNumber = GetRightNumber('*');
                        txtBuffer.Text = $"{LeftNumber}*{-RightNumber}";
                        break;
                    case Math.DIVISION:
                        RightNumber = GetRightNumber('/');
                        txtBuffer.Text = $"{LeftNumber}/{-RightNumber}";
                        break;
                }
            }
            this.Select();
        }

        private void btnEquals_Click(object? sender, EventArgs e)
        {
            switch (LastProcess)
            {
                case Math.ADDITION:
                    LeftNumber = GetLeftNumber('+');
                    RightNumber = GetRightNumber('+');
                    LastCalculation = LeftNumber + RightNumber;
                    break;
                case Math.SUBTRACTION:
                    LeftNumber = GetLeftNumber('-');
                    RightNumber = GetRightNumber('-');
                    LastCalculation = LeftNumber - RightNumber;
                    break;
                case Math.MULTIPLICATION:
                    LeftNumber = GetLeftNumber('*');
                    RightNumber = GetRightNumber('*');
                    LastCalculation = LeftNumber * RightNumber;
                    break;
                case Math.DIVISION:
                    LeftNumber = GetLeftNumber('/');
                    RightNumber = GetRightNumber('/');
                    LastCalculation = LeftNumber / RightNumber;
                    break;
            }

            if (LastCalculation == null) return;
            txtBuffer.Text = LastCalculation.ToString();
            RightNumber = null;
            LeftNumber = null;
            LastProcess = Math.NONE;
            this.Select();
        }

        private double GetRightNumber(char sep)
        {
            return Convert.ToDouble(txtBuffer.Text.Substring(
                                            txtBuffer.Text.IndexOf(sep) + 1
                                            )
                                        );
        }

        private double GetLeftNumber(char sep)
        {
            if (!txtBuffer.Text.Contains(sep)) return Convert.ToDouble(txtBuffer.Text);
            return Convert.ToDouble(txtBuffer.Text.Substring(0,
                                            txtBuffer.Text.IndexOf(sep)
                                            )
                                        );
        }
    }
}

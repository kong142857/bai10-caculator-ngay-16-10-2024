namespace bai10_caculator
{
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "+";
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "-";
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "*";
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(textBox1.Text);

            // Thực hiện phép tính dựa trên toán tử
            switch (operation)
            {
                case "+":
                    textBox1.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    textBox1.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    textBox1.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        textBox1.Text = (firstNumber / secondNumber).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Lỗi: chia cho 0";
                    }
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "/";
            textBox1.Clear();
        }
    }
}

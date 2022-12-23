namespace oop___1
{
    public partial class Form1 : Form
    {
        string operation = "";
        Double input1 = 0;
    public Form1()
        {
            InitializeComponent();
        }

    private void button1_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (this.tb_Input.Text.Length % 4 == 0)
            //{
                //this.tb_Input.Text = this.tb_Input.Text + ",";
            //}
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.tb_Input.Text);
            this.tb_Input.Text = "";
            this.operation = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.tb_Input.Text);
            this.tb_Input.Text = "";
            this.operation = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.tb_Input.Text);
            this.tb_Input.Text = "";
            this.operation = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.tb_Input.Text);
            this.tb_Input.Text = "";
            this.operation = "%";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double input2 = Double.Parse(this.tb_Input.Text);
            double result = 0;
            if (this.operation == "+")
            {
                result = input1 + input2;
                this.tb_Last.Text = input1.ToString() + "+" + input2.ToString();
            }
            else if (this.operation == "-")
            {
                this.tb_Last.Text = input1.ToString() + "-" + input2.ToString();
                result = input1 - input2;
            }
            else if (this.operation == "*")
            {
                this.tb_Last.Text = input1.ToString() + "*" + input2.ToString();
                result = input1 * input2;
            }
            else if (this.operation == "%")
            {
                this.tb_Last.Text = input1.ToString() + "%" + input2.ToString();
                result = input1 / input2;
            }
            this.tb_Input.Text = result.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tb_Input.Text = tb_Input.Text.Remove (tb_Input.Text.Length - 1);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
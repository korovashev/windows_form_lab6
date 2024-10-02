using System.Data;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                if (number % 3 == 0)
                {
                    MessageBox.Show("Число делится на 3!");
                }
                else
                {
                    MessageBox.Show("Число не делится на 3!");
                }
            }
            else
            {
                MessageBox.Show("Введите корректное число!");
            }
        }




        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (checkedListBox1.SelectedItem.ToString())
            {
                case "orange":
                    panel1.BackColor = Color.Orange;
                    break;
                case "green":
                    panel1.BackColor = Color.Green;
                    break;
                case "blue":
                    panel1.BackColor = Color.Blue;
                    break;
                case "pink":
                    panel1.BackColor = Color.Pink;
                    break;
                case "magenta":
                    panel1.BackColor = Color.Magenta;
                    break;
            }
        }



        private string input = string.Empty;

        private void button13_Click(object sender, EventArgs e)
        {
            AddInput("0");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddInput("1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddInput("2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddInput("3");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddInput("4");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddInput("5");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddInput("6");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddInput("7");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddInput("8");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddInput("9");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddInput("+");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddInput("-");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddInput("*");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AddInput("/");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                var result = Math.Pow(Convert.ToDouble(input), 2);
                input = result.ToString();
                textBox2.Text = input;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при возведении в квадрат! " + ex.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(input, null);
                input = result.ToString();
                textBox2.Text = input;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в выражении! " + ex.Message);
                input = string.Empty;
                textBox2.Text = "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (input.Length > 0)
            {
                input = input.Remove(input.Length - 1);
                textBox2.Text = input == string.Empty ? "0" : input;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            textBox2.Text = "0";
        }

        private void AddInput(string value)
        {
            input += value;
            textBox2.Text = input;
        }
    }
}
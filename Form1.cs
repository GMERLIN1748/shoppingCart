namespace shoppindcart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputnum1 = tbCoffeePrice.Text;
            string inputnum2 = tbCoffeeQuantity.Text;
            float input1, input2;

            bool isValidCoffeePrice = float.TryParse(inputnum1, out input1);
            bool isValidCoffeeQuantity = float.TryParse(inputnum2, out input2);

            string inputnum3 = tbGreenTeaPrice.Text;
            string inputnum4 = tbGreenTeaQuantity.Text;
            float input3, input4;

            bool isValidTeaPrice = float.TryParse(inputnum3, out input3);
            bool isValidTeaQuantity = float.TryParse(inputnum4, out input4);

            float total = 0;

            if (isValidCoffeePrice && isValidCoffeeQuantity && isValidTeaPrice && isValidTeaQuantity)
            {
                if (chbCoffee.Checked)
                {
                    float result1 = input1 * input2;
                    total += result1;
                }

                if (chbGreenTea.Checked)
                {
                    float result2 = input3 * input4;
                    total += result2;
                }

                tbTotal.Text = total.ToString("F2");
            }
            else
            {
                if (!isValidCoffeePrice)
                {
                    tbCoffeePrice.Focus();
                }
                else if (!isValidCoffeeQuantity)
                {
                    tbCoffeeQuantity.Focus();
                }
                else if (!isValidTeaPrice)
                {
                    tbGreenTeaPrice.Focus();
                }
                else if (!isValidTeaQuantity)
                {
                    tbGreenTeaQuantity.Focus();
                }

                tbTotal.Text = "";
                return;
            }

            if (!string.IsNullOrEmpty(tbcash.Text))
            {
                float cashReceived = 0;

                bool isValidCash = float.TryParse(tbcash.Text, out cashReceived);

                if (isValidCash)
                {
                    if (cashReceived >= total)
                    {

                        float change = cashReceived - total;
                        tbchange.Text = change.ToString("F2");

                        int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
                        float remainingChange = change;

                        tb1000.Text = tb500.Text = tb100.Text = tb50.Text =
                            tb20.Text = tb10.Text = tb5.Text = tb1.Text = "";

                        for (int i = 0; i < denominations.Length; i++)
                        {
                            int count = (int)(remainingChange / denominations[i]);
                            remainingChange %= denominations[i];

                            switch (denominations[i])
                            {
                                case 1000: tb1000.Text = count.ToString(); break;
                                case 500: tb500.Text = count.ToString(); break;
                                case 100: tb100.Text = count.ToString(); break;
                                case 50: tb50.Text = count.ToString(); break;
                                case 20: tb20.Text = count.ToString(); break;
                                case 10: tb10.Text = count.ToString(); break;
                                case 5: tb5.Text = count.ToString(); break;
                                case 1: tb1.Text = count.ToString(); break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("False", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("pls Check again", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void tbCoffeePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGreenTeaPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCoffeeQuanity_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGreenTeaQuanity_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chbGreenTea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

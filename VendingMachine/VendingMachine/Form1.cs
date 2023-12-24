namespace VendingMachine
{
    public partial class Form1 : Form
    {
        WaterMachine watermachine;
        public Form1()
        {
            InitializeComponent();
            watermachine = new WaterMachine();
        }

        private void BlackCoffee_Click(object sender, EventArgs e)
        {
            bool canMake = watermachine.MakeBlackCoffee();
            if (canMake)
            {
                pictureBox1.Image = Properties.Resources.blackcoffee1;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.SOLD_OUT1;
            }
        }

        private void Mocha_Click(object sender, EventArgs e)
        {
            bool canMake = watermachine.MakeMocha();
            if (canMake)
            {
                pictureBox1.Image = Properties.Resources.mocha;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.SOLD_OUT1;
            }
        }

        private void Latte_Click(object sender, EventArgs e)
        {
            bool canMake = watermachine.Makelatte();
            if (canMake)
            {
                pictureBox1.Image = Properties.Resources.latte;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.SOLD_OUT1;
            }
        }

        private void Hotchocolate_Click(object sender, EventArgs e)
        {
            bool canMake = watermachine.MakeHotchocolate();
            if (canMake)
            {
                pictureBox1.Image = Properties.Resources.Hotchocolate;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.SOLD_OUT1;
            }
        }

        private void ReStockButton_Click(object sender, EventArgs e)
        {
            int RS = watermachine.Restock();

        }
    }
}

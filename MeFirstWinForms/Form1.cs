namespace MeFirstWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class money
        {
            public long rub;
            public int kop;
            public money(long irub, int ikop)
            {
                rub = irub;
                kop = ikop;
            }
            public money()
            {

            }

            public money Plus(money inc)
            {
                long origr = rub;
                int origkop = kop;
                long vhrub = inc.rub;
                int vhkop = inc.kop;

                long resrub = rub + vhrub;
                int resk = kop + vhkop;
                if (resk > 100)
                {
                    resrub = resrub + 1;
                    resk = resk - 100;
                }
                money ress = new money(resrub, resk);

                ress.rub = resrub;
                ress.kop = resk;

                return ress;
            }

            public money Minus(money inc)
            {
                long origr = rub;
                int origkop = kop;
                long vhrub = inc.rub;
                int vhkop = inc.kop;
                // 9.09 - 8.99
                long resrub = rub - vhrub;
                int resk = kop - vhkop;
                if (resk < 0)
                {
                    resrub = resrub - 1;
                    resk = (-1) * resk;
                }
                money ress = new money();

                ress.rub = resrub;
                ress.kop = resk;
                return ress;
            }

            public money Umnozh(money inc)
            {
                long origr = rub;
                int origkop = kop;

                long vhrub = inc.rub;
                int vhkop = inc.kop;
                //входящее в виде Double
                double firstD = (double)vhrub + (double)vhkop / 100.0;
                //оригинальное (первое)
                double sec = (double)origr + (double)origkop / 100.0;

                double res = firstD * sec;
                long tselayaChast = (long)Math.Floor(res);
                double drobn = res - tselayaChast;
                money ress = new money();
                double kopp = Math.Round(drobn * 100);
                int kopInt = (int)kopp;

                ress.rub = tselayaChast;
                ress.kop = kopInt;
                return ress;
            }
            public money Delenie(money inc)
            {
                long origr = rub;
                int origkop = kop;

                long vhrub = inc.rub;
                int vhkop = inc.kop;

                double second = (double)vhrub + (double)vhkop / 100.0;
                double first = (double)origr + (double)origkop / 100.0;
                if (second == 0)
                {
                    throw new FormatException("делене на 0");
                }
                double third = first / second;

                long tselayaChast = (long)Math.Floor(third);
                double drobn = third - tselayaChast;
                money ress = new money();
                double kopp = Math.Round(drobn * 100);
                int kopInt = (int)kopp;

                ress.rub = tselayaChast;
                ress.kop = kopInt;
                return ress;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private money m1;
        private money m2;
        private money res;
        private void TextBoxToMoney()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxToMoney();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxToMoney();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBoxToMoney();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBoxToMoney();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LeftRubBtn_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
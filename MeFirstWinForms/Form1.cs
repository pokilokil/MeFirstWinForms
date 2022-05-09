namespace MeFirstWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private money m1;
        private money m2;
        private money res;

        private void TextBoxToMoney()
        {
            long LeftRubNumber = Convert.ToInt64(LeftRubBtn.Text);
            long RightRubNumber = Convert.ToInt64(RightRubBtn.Text);
            long ResultRubNumber = LeftRubNumber - RightRubNumber;
            int LeftKopNumber = Convert.ToInt32(LeftKopBtn.Text);
            int RightKopNumber = Convert.ToInt32(RightKopBtn.Text);
            int ResultKopNumber = LeftKopNumber - RightKopNumber;

            m1 = new money(LeftRubNumber, LeftKopNumber);
            m2 = new money(RightRubNumber, RightKopNumber);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button ClickedButt = (Button)sender;
            TextBoxToMoney();
            res = money.PlusST(m1, m2);

            ResultKopBtn.Text = Convert.ToString(res.kop);
            ResultRubBtn.Text = Convert.ToString(res.rub);

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Button ClickedButt = (Button)sender;
            TextBoxToMoney();
            res = m1.Minus(m2);
            

            
            ResultRubBtn.Text = Convert.ToString(res.rub);
            ResultKopBtn.Text = Convert.ToString(res.kop);

            
            
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
            res = money.DelenieST(m1, m2);
            ResultRubBtn.Text = Convert.ToString(res.rub);
            ResultKopBtn.Text = Convert.ToString(res.kop);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBoxToMoney();
            res = money.UmnozhST(m1, m2);
            ResultRubBtn.Text = Convert.ToString(res.rub);
            ResultKopBtn.Text = Convert.ToString(res.kop);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LeftRubBtn_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
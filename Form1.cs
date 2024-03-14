namespace hesapMakinesi1
{
    public partial class Form1 : Form
    {
        char islem;
        bool ekrantemizlenecek;
        int ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void ekranLAbel_Click(object sender, EventArgs e)
        {

        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek)
            {
                ekranLAbel.Text = "";
                ekrantemizlenecek = false;
            }
            if (ekranLAbel.Text == "0") ekranLAbel.Text = "";
            ekranLAbel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek)
            {
                ekranLAbel.Text = "";
                ekrantemizlenecek = false;
            }
            if (ekranLAbel.Text == "0") ekranLAbel.Text = "";
            ekranLAbel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek)
            {
                ekranLAbel.Text = "";
                ekrantemizlenecek = false;
            }
            if (ekranLAbel.Text == "0") ekranLAbel.Text = "";
            ekranLAbel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek)
            {
                ekranLAbel.Text = "";
                ekrantemizlenecek = false;
            }
            if (ekranLAbel.Text == "0") ekranLAbel.Text = "";
            ekranLAbel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek)
            {
                ekranLAbel.Text = "";
                ekrantemizlenecek = false;
            }
            if (ekranLAbel.Text == "0") ekranLAbel.Text = "";
            ekranLAbel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek)
            {
                ekranLAbel.Text = "";
                ekrantemizlenecek = false;
            }
            if (ekranLAbel.Text == "0") ekranLAbel.Text = "";
            ekranLAbel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek)
            {
                ekranLAbel.Text = "";
                ekrantemizlenecek = false;
            }
            if (ekranLAbel.Text == "0") ekranLAbel.Text = "";
            ekranLAbel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek)
            {
                ekranLAbel.Text = "";
                ekrantemizlenecek = false;
            }
            if (ekranLAbel.Text == "0") ekranLAbel.Text = "";
            ekranLAbel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek)
            {
                ekranLAbel.Text = "";
                ekrantemizlenecek = false;
            }
            if (ekranLAbel.Text == "0") ekranLAbel.Text = "";
            ekranLAbel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (ekrantemizlenecek)
            {
                ekranLAbel.Text = "";
                ekrantemizlenecek = false;
            }
            if (ekranLAbel.Text == "0") ekranLAbel.Text = "";
            ekranLAbel.Text += "0";
        }

        private void toplamaButton_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekrantemizlenecek = true;
            ilksayi = Convert.ToInt32(ekranLAbel.Text);

        }

        private void cikarmaButton_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekrantemizlenecek = true;
            ilksayi = Convert.ToInt32(ekranLAbel.Text);
        }

        private void carpmaButton_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekrantemizlenecek = true;
            ilksayi = Convert.ToInt32(ekranLAbel.Text);
        }

        private void bolmeButton_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekrantemizlenecek = true;
            ilksayi = Convert.ToInt32(ekranLAbel.Text);
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranLAbel.Text);
            int sonuc;
            switch (islem)
            {
                case '+':
                    sonuc = ilksayi + ikincisayi;
                    break;

                case '-':
                    sonuc = ilksayi - ikincisayi;
                    break;

                case '*':
                    sonuc = ilksayi * ikincisayi;
                    break;

                case '/':
                    sonuc = ilksayi / ikincisayi;
                    break;

                default:
                    sonuc = 0;
                    break;



            }
            ekranLAbel.Text = Convert.ToString(sonuc);
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLAbel.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

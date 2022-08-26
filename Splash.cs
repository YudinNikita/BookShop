namespace BookShop
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int startpos = 0;


        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startpos++;
            loadingProgressBar.Value = startpos;
            percentageLabel.Text = startpos + "%";
            if (loadingProgressBar.Value == 100)
            {
                loadingProgressBar.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }
    }
}
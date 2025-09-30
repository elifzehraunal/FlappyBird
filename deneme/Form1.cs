namespace deneme
{
    public partial class Form1 : Form
    {
        int boruhýzý = 8;
        int yerçekimi = 8;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1Event(object sender, EventArgs e)
        {
            fare.Top += yerçekimi;
            borualt.Left -= boruhýzý;
            boruüst.Left -= boruhýzý;
            scoretext.Text = "score:" + score;

            if (borualt.Left <- 150) {

                borualt.Left = 800;

                score++;

            }


            if (boruüst.Left < -180){

                boruüst.Left = 950;
                score++;
            }

            if (fare.Bounds.IntersectsWith(borualt.Bounds) || fare.Bounds.IntersectsWith(boruüst.Bounds) || fare.Bounds.IntersectsWith(zemin.Bounds)){
                endgame();   
            }
            if (score > 5)
            {
                boruhýzý = 15;
             }
            if(fare.Top < -25)
            {
                endgame();
            }

                    }
        

        private void fare_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerçekimi = -8;

            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerçekimi = 8;

            }
        }
        private void endgame() {
            timer1.Stop();
            scoretext.Text = "Oyun Bitti...";
        }
       
    }
}

namespace deneme
{
    public partial class Form1 : Form
    {
        int boruh�z� = 8;
        int yer�ekimi = 8;
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
            fare.Top += yer�ekimi;
            borualt.Left -= boruh�z�;
            boru�st.Left -= boruh�z�;
            scoretext.Text = "score:" + score;

            if (borualt.Left <- 150) {

                borualt.Left = 800;

                score++;

            }


            if (boru�st.Left < -180){

                boru�st.Left = 950;
                score++;
            }

            if (fare.Bounds.IntersectsWith(borualt.Bounds) || fare.Bounds.IntersectsWith(boru�st.Bounds) || fare.Bounds.IntersectsWith(zemin.Bounds)){
                endgame();   
            }
            if (score > 5)
            {
                boruh�z� = 15;
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
                yer�ekimi = -8;

            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yer�ekimi = 8;

            }
        }
        private void endgame() {
            timer1.Stop();
            scoretext.Text = "Oyun Bitti...";
        }
       
    }
}

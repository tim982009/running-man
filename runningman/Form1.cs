namespace runningman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            timer1.Enabled = true;
            timer1.Interval = 200;

        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[num];
            if (num == 3)
            {
                num = 0;
            }
            else
            {
                num++;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left - 30;
            if (pictureBox2.Left < -90)
            {
                pictureBox2.Left = this.ClientSize.Width;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
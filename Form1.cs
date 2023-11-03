namespace jpwp
{
    public partial class Form1 : Form
    {
        int x = 632;
        bool czyprawo = false, czylewo = false; bool czygora = false, czydol = false;
        int y = 405;
        public Form1()
        {
            InitializeComponent();
            postac.Location = new Point(x, y);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (x != 24 && e.KeyCode == Keys.Left) { x = x - 32; postac.Location = new Point(x, y); postac.BackgroundImage = Properties.Resources.lewo; }
            ///else if (x != 1208 && e.KeyCode == Keys.Right) { x = x + 32; postac.Location = new Point(x, y); postac.BackgroundImage = Properties.Resources.prawo; }
            //else if (y != 45 && e.KeyCode == Keys.Up) { y = y - 45; postac.Location = new Point(x, y); postac.BackgroundImage = Properties.Resources.tyl; }
            //////else if (y != 765 && e.KeyCode == Keys.Down) { y = y + 45; postac.Location = new Point(x, y); postac.BackgroundImage = Properties.Resources.przod; }
            if (e.KeyCode == Keys.Left)
            {
                czylewo = true;

            }
            else if (e.KeyCode == Keys.Right)
            {
                czyprawo = true;

            }

            else if (e.KeyCode == Keys.Up)
            {
                czygora = true;

            }
            else if (e.KeyCode == Keys.Down)
            {
                czydol = true;

            }

        }

        private void aa_Click(object sender, EventArgs e)
        {
            postac.Location = new Point(x - 32, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czylewo)
            {
                postac.Location = new Point(postac.Location.X - 5, postac.Location.Y);
                postac.BackgroundImage = Properties.Resources.lewo;

            }
            else if (czyprawo)
            {
                postac.Location = new Point(postac.Location.X + 5, postac.Location.Y);
                postac.BackgroundImage = Properties.Resources.prawo;

            }

            else if (czygora)
            {
                postac.Location = new Point(postac.Location.X , postac.Location.Y-5);
                postac.BackgroundImage = Properties.Resources.tyl;

            }
            else if (czydol)
            {
                postac.Location = new Point(postac.Location.X , postac.Location.Y+5);
                postac.BackgroundImage = Properties.Resources.przod;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                czylewo = false;

            }
            else if (e.KeyCode == Keys.Right)
            {
                czyprawo = false;

            }
           else if (e.KeyCode == Keys.Up)
            {
                czygora = false;

            }
            else if (e.KeyCode == Keys.Down)
            {
                czydol = false;

            }

        }
    }
}
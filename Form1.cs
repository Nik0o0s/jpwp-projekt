namespace jpwp
{
    public partial class Form1 : Form
    {
        int x = 632;
        bool ruchprawo = false, ruchlewo = false; bool ruchgora = false, ruchdol = false;
        int y = 405;
        int plansza = 5;
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            postac.Location = new Point(x, y);
            pictureBoxes.Add(drzewo1);
            pictureBoxes.Add(drzewo2);
            pictureBoxes.Add(drzewo3);
            pictureBoxes.Add(drzewo4);
            pictureBoxes.Add(drzewo5);
            pictureBoxes.Add(drzewo6);
            pictureBoxes.Add(drzewo7);
            pictureBoxes.Add(drzewo8);
            pictureBoxes.Add(drzewo9);
            pictureBoxes.Add(drzewo10);
            pictureBoxes.Add(drzewo11);
            pictureBoxes.Add(drzewo12);
            pictureBoxes.Add(drzewo13);
            pictureBoxes.Add(drzewo14);
            pictureBoxes.Add(drzewo15);
            pictureBoxes.Add(drzewo16);
            pictureBoxes.Add(drzewo17);
            pictureBoxes.Add(drzewo18);
            pictureBoxes.Add(drzewo19);
            pictureBoxes.Add(drzewo20);
            pictureBoxes.Add(drzewo21);
            pictureBoxes.Add(drzewo22);
            pictureBoxes.Add(drzewo23);
            pictureBoxes.Add(drzewo24);
            pictureBoxes.Add(drzewo25);
            pictureBoxes.Add(drzewo26);
            pictureBoxes.Add(drzewo27);
            pictureBoxes.Add(drzewo28);
            pictureBoxes.Add(drzewo29);
            pictureBoxes.Add(drzewo30);
            pictureBoxes.Add(drzewo31);
            pictureBoxes.Add(drzewo32);
            pictureBoxes.Add(drzewo33);
            pictureBoxes.Add(drzewo34);
            pictureBoxes.Add(drzewo35);
            pictureBoxes.Add(drzewo36);
            pictureBoxes.Add(drzewo37);
            pictureBoxes.Add(drzewo38);
            pictureBoxes.Add(drzewo39);
            pictureBoxes.Add(drzewo40);
            pictureBoxes.Add(drzewo41);
            pictureBoxes.Add(drzewo42);
            pictureBoxes.Add(drzewo43);
            pictureBoxes.Add(drzewo44);
            pictureBoxes.Add(drzewo45);
            pictureBoxes.Add(sciana1);
            pictureBoxes.Add(sciana2);
            pictureBoxes.Add(sciana3);

            pictureBoxes.Add(sciana4);
            pictureBoxes.Add(sciana5);
            pictureBoxes.Add(sciana6);
            pictureBoxes.Add(sciana7);
            pictureBoxes.Add(sciana8);
            pictureBoxes.Add(sciana9);
            pictureBoxes.Add(sciana10);
            pictureBoxes.Add(sciana11);
            pictureBoxes.Add(sciana12);
            pictureBoxes.Add(sciana13);
            pictureBoxes.Add(sciana14);
            pictureBoxes.Add(sciana15);
            pictureBoxes.Add(sciana16);
            pictureBoxes.Add(sciana17);
            pictureBoxes.Add(sciana18);
            pictureBoxes.Add(sciana19);
            pictureBoxes.Add(sciana20);
            pictureBoxes.Add(sciana21);
            pictureBoxes.Add(sciana22);
            pictureBoxes.Add(sciana23);
            pictureBoxes.Add(sciana24);
            pictureBoxes.Add(sciana25);
            pictureBoxes.Add(sciana26);
            pictureBoxes.Add(sciana27);
            pictureBoxes.Add(sciana28);

            pictureBoxes.Add(sciana29);
            pictureBoxes.Add(kamien1);
            pictureBoxes.Add(kamien2);
            pictureBoxes.Add(kamien3);
            pictureBoxes.Add(kamien4);
            pictureBoxes.Add(kamien5);
            pictureBoxes.Add(sciana30);
            Controls.SetChildIndex(postac, 0);
            ustaw_plansze(plansza);

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                ruchlewo = true;

            }
            else if (e.KeyCode == Keys.Right)
            {
                ruchprawo = true;

            }

            else if (e.KeyCode == Keys.Up)
            {
                ruchgora = true;

            }
            else if (e.KeyCode == Keys.Down)
            {
                ruchdol = true;

            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ruchlewo)
            {
                postac.Location = new Point(postac.Location.X - 5, postac.Location.Y);
                postac.BackgroundImage = Properties.Resources.lewo;

                if (IsPictureBoxOverlapAny(postac, pictureBoxes))
                {
                    postac.Location = new Point(postac.Location.X + 5, postac.Location.Y);
                }
                if (postac.Location.X < 0)
                {
                    plansza -= 1;
                    postac.Location = new Point(1240, postac.Location.Y);
                    ustaw_plansze(plansza);
                }

            }
            else if (ruchprawo)
            {
                postac.Location = new Point(postac.Location.X + 5, postac.Location.Y);
                postac.BackgroundImage = Properties.Resources.prawo;
                if (IsPictureBoxOverlapAny(postac, pictureBoxes))
                {
                    postac.Location = new Point(postac.Location.X - 5, postac.Location.Y);
                }
                if (postac.Location.X > 1230)
                {
                    plansza += 1;
                    postac.Location = new Point(0, postac.Location.Y);
                    ustaw_plansze(plansza);
                }
            }

            else if (ruchgora)
            {
                postac.Location = new Point(postac.Location.X, postac.Location.Y - 5);
                postac.BackgroundImage = Properties.Resources.tyl;
                if (IsPictureBoxOverlapAny(postac, pictureBoxes))
                {
                    postac.Location = new Point(postac.Location.X, postac.Location.Y + 5);
                }
                if (postac.Location.Y < 0)
                {
                    plansza -= 3;
                    postac.Location = new Point(postac.Location.X, 755);
                    ustaw_plansze(plansza);
                }
            }
            else if (ruchdol)
            {
                postac.Location = new Point(postac.Location.X, postac.Location.Y + 5);
                postac.BackgroundImage = Properties.Resources.przod;

                if (IsPictureBoxOverlapAny(postac, pictureBoxes))
                {
                    postac.Location = new Point(postac.Location.X, postac.Location.Y - 5);
                }
                if (postac.Location.Y > 755)
                {
                    plansza += 3;
                    postac.Location = new Point(postac.Location.X, 0);
                    ustaw_plansze(plansza);
                }
            }

        }


        private void ustaw_plansze(int plansza)
        {
            if (plansza == 1 || plansza == 6)
            {
                drzewo1.Location = new Point(23, 340);
                drzewo2.Location = new Point(12, 436);
                drzewo3.Location = new Point(12, 227);
                drzewo4.Location = new Point(23, 12);
                drzewo5.Location = new Point(438, 30);
                drzewo6.Location = new Point(23, 619);
                drzewo7.Location = new Point(34, 131);
                drzewo8.Location = new Point(106, 47);
                drzewo9.Location = new Point(176, 0);
                drzewo10.Location = new Point(368, 99);
                drzewo11.Location = new Point(23, 715);
                drzewo12.Location = new Point(106, 701);
                drzewo13.Location = new Point(765, 58);
                drzewo14.Location = new Point(325, 0);
                drzewo15.Location = new Point(255, 30);
                drzewo16.Location = new Point(34, 532);
                drzewo17.Location = new Point(508, 0);
                drzewo18.Location = new Point(937, 126);
                drzewo19.Location = new Point(508, 131);
                drzewo20.Location = new Point(905, 12);
                drzewo21.Location = new Point(298, 162);
                drzewo22.Location = new Point(835, 30);
                drzewo23.Location = new Point(695, 99);
                drzewo24.Location = new Point(1188, 523);
                drzewo25.Location = new Point(998, 30);
                drzewo26.Location = new Point(668, 0);
                drzewo27.Location = new Point(1164, 162);
                drzewo28.Location = new Point(1152, 331);
                drzewo29.Location = new Point(1035, 139);
                drzewo30.Location = new Point(1105, 68);
                drzewo31.Location = new Point(1175, 12);
                drzewo32.Location = new Point(1094, 235);
                drzewo33.Location = new Point(1118, 701);
                drzewo34.Location = new Point(1200, 619);
                drzewo35.Location = new Point(1102, 585);
                drzewo36.Location = new Point(1017, 661);
                drzewo37.Location = new Point(937, 701);
                drzewo38.Location = new Point(1175, 427);
                drzewo39.Location = new Point(106, 404);
                drzewo40.Location = new Point(847, 139);
                drzewo41.Location = new Point(106, 284);
                drzewo42.Location = new Point(119, 162);
                drzewo43.Location = new Point(176, 715);
                drzewo44.Location = new Point(218, 139);
                drzewo45.Location = new Point(598, 47);

                jezioro.Location = new Point(2000, 2000);

                kamien1.Location = new Point(200, 300);
                kamien2.Location = new Point(600, 200);
                kamien3.Location = new Point(1120, 550);
                kamien4.Location = new Point(700, 250);
                kamien5.Location = new Point(250, 650);

                sciana29.Location = new Point(2000, 2000);
                sciana1.Location = new Point(2000, 2000);
                sciana2.Location = new Point(2000, 2000);
                sciana3.Location = new Point(2000, 2000);
                sciana4.Location = new Point(2000, 2000);
                sciana5.Location = new Point(2000, 2000);
                sciana6.Location = new Point(2000, 2000);
                sciana7.Location = new Point(2000, 2000);
                sciana8.Location = new Point(2000, 2000);
                sciana9.Location = new Point(2000, 2000);
                sciana10.Location = new Point(2000, 2000);
                sciana11.Location = new Point(2000, 2000);
                sciana12.Location = new Point(2000, 2000);
                sciana13.Location = new Point(2000, 2000);
                sciana14.Location = new Point(2000, 2000);
                sciana15.Location = new Point(2000, 2000);
                sciana16.Location = new Point(2000, 2000);
                sciana17.Location = new Point(2000, 2000);
                sciana18.Location = new Point(2000, 2000);
                sciana19.Location = new Point(2000, 2000);
                sciana20.Location = new Point(2000, 2000);
                sciana21.Location = new Point(2000, 2000);
                sciana22.Location = new Point(2000, 2000);
                sciana23.Location = new Point(2000, 2000);
                sciana24.Location = new Point(2000, 2000);
                sciana25.Location = new Point(2000, 2000);
                sciana26.Location = new Point(2000, 2000);
                sciana27.Location = new Point(2000, 2000);
                sciana28.Location = new Point(2000, 2000);
                sciana30.Location = new Point(2000, 2000);
            }
            if (plansza == 5)
            {
                drzewo1.Location = new Point(82, 329);
                drzewo2.Location = new Point(12, 514);
                drzewo3.Location = new Point(12, 227);
                drzewo4.Location = new Point(122, 61);
                drzewo5.Location = new Point(262, 29);
                drzewo6.Location = new Point(34, 619);
                drzewo7.Location = new Point(82, 157);
                drzewo8.Location = new Point(192, 12);
                drzewo9.Location = new Point(332, 12);
                drzewo10.Location = new Point(595, 12);
                drzewo11.Location = new Point(12, 715);
                drzewo12.Location = new Point(82, 715);
                drzewo13.Location = new Point(402, 61);
                drzewo14.Location = new Point(472, 0);
                drzewo15.Location = new Point(751, 75);
                drzewo16.Location = new Point(681, 29);
                drzewo17.Location = new Point(516, 96);
                drzewo18.Location = new Point(821, 44);
                drzewo19.Location = new Point(837, 157);
                drzewo20.Location = new Point(922, 12);
                drzewo21.Location = new Point(607, 476);
                drzewo22.Location = new Point(907, 119);
                drzewo23.Location = new Point(1032, 44);
                drzewo24.Location = new Point(995, 157);
                drzewo25.Location = new Point(1102, 111);
                drzewo26.Location = new Point(1078, 207);
                drzewo27.Location = new Point(1188, 61);
                drzewo28.Location = new Point(1175, 207);
                drzewo29.Location = new Point(1141, 303);
                drzewo30.Location = new Point(1188, 413);
                drzewo31.Location = new Point(1102, 413);
                drzewo32.Location = new Point(1159, 514);
                drzewo33.Location = new Point(1078, 524);
                drzewo34.Location = new Point(1141, 610);
                drzewo35.Location = new Point(1141, 715);
                drzewo36.Location = new Point(1065, 659);
                drzewo37.Location = new Point(995, 601);
                drzewo38.Location = new Point(821, 691);
                drzewo39.Location = new Point(652, 636);
                drzewo40.Location = new Point(564, 691);
                drzewo41.Location = new Point(477, 636);
                drzewo42.Location = new Point(387, 673);
                drzewo43.Location = new Point(303, 636);
                drzewo44.Location = new Point(402, 436);
                drzewo45.Location = new Point(731, 303);
                jezioro.Location = new Point(2000, 2000);

                kamien1.Location = new Point(2000, 2000);
                kamien2.Location = new Point(2000, 2000);
                kamien3.Location = new Point(2000, 2000);
                kamien4.Location = new Point(2000, 2000);
                kamien5.Location = new Point(2000, 2000);

                sciana29.Location = new Point(2000, 2000);
                sciana1.Location = new Point(2000, 2000);
                sciana2.Location = new Point(2000, 2000);
                sciana3.Location = new Point(2000, 2000);
                sciana4.Location = new Point(2000, 2000);
                sciana5.Location = new Point(2000, 2000);
                sciana6.Location = new Point(2000, 2000);
                sciana7.Location = new Point(2000, 2000);
                sciana8.Location = new Point(2000, 2000);
                sciana9.Location = new Point(2000, 2000);
                sciana10.Location = new Point(2000, 2000);
                sciana11.Location = new Point(2000, 2000);
                sciana12.Location = new Point(2000, 2000);
                sciana13.Location = new Point(2000, 2000);
                sciana14.Location = new Point(2000, 2000);
                sciana15.Location = new Point(2000, 2000);
                sciana16.Location = new Point(2000, 2000);
                sciana17.Location = new Point(2000, 2000);
                sciana18.Location = new Point(2000, 2000);
                sciana19.Location = new Point(2000, 2000);
                sciana20.Location = new Point(2000, 2000);
                sciana21.Location = new Point(2000, 2000);
                sciana22.Location = new Point(2000, 2000);
                sciana23.Location = new Point(2000, 2000);
                sciana24.Location = new Point(2000, 2000);
                sciana25.Location = new Point(2000, 2000);
                sciana26.Location = new Point(2000, 2000);
                sciana27.Location = new Point(2000, 2000);
                sciana28.Location = new Point(2000, 2000);
                sciana30.Location = new Point(2000, 2000);
            }
            if (plansza == 4)
            {
                drzewo1.Location = new Point(23, 340);
                drzewo2.Location = new Point(12, 436);
                drzewo3.Location = new Point(12, 227);
                drzewo4.Location = new Point(23, 12);
                drzewo5.Location = new Point(294, 118);
                drzewo6.Location = new Point(23, 619);
                drzewo7.Location = new Point(34, 131);
                drzewo8.Location = new Point(106, 47);
                drzewo9.Location = new Point(176, 0);
                drzewo10.Location = new Point(344, 472);
                drzewo11.Location = new Point(12, 715);
                drzewo12.Location = new Point(82, 701);
                drzewo13.Location = new Point(436, 237);
                drzewo14.Location = new Point(318, 302);
                drzewo15.Location = new Point(209, 175);
                drzewo16.Location = new Point(34, 532);
                drzewo17.Location = new Point(572, 500);
                drzewo18.Location = new Point(196, 427);
                drzewo19.Location = new Point(482, 701);
                drzewo20.Location = new Point(482, 58);
                drzewo21.Location = new Point(721, 701);
                drzewo22.Location = new Point(594, 175);
                drzewo23.Location = new Point(743, 290);
                drzewo24.Location = new Point(1188, 510);
                drzewo25.Location = new Point(801, 162);
                drzewo26.Location = new Point(785, 481);
                drzewo27.Location = new Point(937, 12);
                drzewo28.Location = new Point(1188, 234);
                drzewo29.Location = new Point(992, 118);
                drzewo30.Location = new Point(1118, 0);
                drzewo31.Location = new Point(1023, 12);
                drzewo32.Location = new Point(1118, 237);
                drzewo33.Location = new Point(1072, 679);
                drzewo34.Location = new Point(1200, 619);
                drzewo35.Location = new Point(1152, 715);
                drzewo36.Location = new Point(992, 619);
                drzewo37.Location = new Point(922, 701);
                drzewo38.Location = new Point(847, 705);
                drzewo39.Location = new Point(648, 715);
                drzewo40.Location = new Point(572, 661);
                drzewo41.Location = new Point(318, 691);
                drzewo42.Location = new Point(222, 639);
                drzewo43.Location = new Point(152, 715);
                drzewo44.Location = new Point(412, 679);
                drzewo45.Location = new Point(530, 383);

                kamien1.Location = new Point(2000, 2000);
                kamien2.Location = new Point(2000, 2000);
                kamien3.Location = new Point(2000, 2000);
                kamien4.Location = new Point(2000, 2000);
                kamien5.Location = new Point(2000, 2000);

                jezioro.Location = new Point(2000, 2000);
                sciana29.Location = new Point(2000, 2000);
                sciana1.Location = new Point(2000, 2000);
                sciana2.Location = new Point(2000, 2000);
                sciana3.Location = new Point(2000, 2000);
                sciana4.Location = new Point(2000, 2000);
                sciana5.Location = new Point(2000, 2000);
                sciana6.Location = new Point(2000, 2000);
                sciana7.Location = new Point(2000, 2000);
                sciana8.Location = new Point(2000, 2000);
                sciana9.Location = new Point(2000, 2000);
                sciana10.Location = new Point(2000, 2000);
                sciana11.Location = new Point(2000, 2000);
                sciana12.Location = new Point(2000, 2000);
                sciana13.Location = new Point(2000, 2000);
                sciana14.Location = new Point(2000, 2000);
                sciana15.Location = new Point(2000, 2000);
                sciana16.Location = new Point(2000, 2000);
                sciana17.Location = new Point(2000, 2000);
                sciana18.Location = new Point(2000, 2000);
                sciana19.Location = new Point(2000, 2000);
                sciana20.Location = new Point(2000, 2000);
                sciana21.Location = new Point(2000, 2000);
                sciana22.Location = new Point(2000, 2000);
                sciana23.Location = new Point(2000, 2000);
                sciana24.Location = new Point(2000, 2000);
                sciana25.Location = new Point(2000, 2000);
                sciana26.Location = new Point(2000, 2000);
                sciana27.Location = new Point(2000, 2000);
                sciana28.Location = new Point(2000, 2000);
                sciana30.Location = new Point(2000, 2000);
            }
            if (plansza == 2)
            {
                drzewo1.Location = new Point(23, 340);
                drzewo2.Location = new Point(12, 436);
                drzewo3.Location = new Point(12, 227);
                drzewo4.Location = new Point(104, 47);
                drzewo5.Location = new Point(742, 0);
                drzewo6.Location = new Point(12, 619);
                drzewo7.Location = new Point(34, 131);
                drzewo8.Location = new Point(812, 365);
                drzewo9.Location = new Point(176, 0);
                drzewo10.Location = new Point(764, 259);
                drzewo11.Location = new Point(191, 715);
                drzewo12.Location = new Point(270, 702);
                drzewo13.Location = new Point(792, 86);
                drzewo14.Location = new Point(338, 12);
                drzewo15.Location = new Point(255, 30);
                drzewo16.Location = new Point(44, 523);
                drzewo17.Location = new Point(509, 0);
                drzewo18.Location = new Point(1179, 702);
                drzewo19.Location = new Point(937, 715);
                drzewo20.Location = new Point(937, 30);
                drzewo21.Location = new Point(421, 294);
                drzewo22.Location = new Point(862, 12);
                drzewo23.Location = new Point(1022, 12);
                drzewo24.Location = new Point(751, 678);
                drzewo25.Location = new Point(1105, 30);
                drzewo26.Location = new Point(668, 0);
                drzewo27.Location = new Point(1185, 269);
                drzewo28.Location = new Point(1185, 461);
                drzewo29.Location = new Point(1094, 645);
                drzewo30.Location = new Point(846, 471);
                drzewo31.Location = new Point(1182, 12);
                drzewo32.Location = new Point(1188, 365);
                drzewo33.Location = new Point(523, 715);
                drzewo34.Location = new Point(681, 715);
                drzewo35.Location = new Point(598, 682);
                drzewo36.Location = new Point(439, 682);
                drzewo37.Location = new Point(354, 715);
                drzewo38.Location = new Point(862, 682);
                drzewo39.Location = new Point(421, 514);
                drzewo40.Location = new Point(1007, 691);
                drzewo41.Location = new Point(421, 61);
                drzewo42.Location = new Point(453, 402);
                drzewo43.Location = new Point(812, 582);
                drzewo44.Location = new Point(395, 178);
                drzewo45.Location = new Point(598, 47);

                kamien1.Location = new Point(2000, 2000);
                kamien2.Location = new Point(2000, 2000);
                kamien3.Location = new Point(2000, 2000);
                kamien4.Location = new Point(2000, 2000);
                kamien5.Location = new Point(2000, 2000);

                jezioro.Location = new Point(2000, 2000);
                sciana29.Location = new Point(2000, 2000);
                sciana1.Location = new Point(2000, 2000);
                sciana2.Location = new Point(2000, 2000);
                sciana3.Location = new Point(2000, 2000);
                sciana4.Location = new Point(2000, 2000);
                sciana5.Location = new Point(2000, 2000);
                sciana6.Location = new Point(2000, 2000);
                sciana7.Location = new Point(2000, 2000);
                sciana8.Location = new Point(2000, 2000);
                sciana9.Location = new Point(2000, 2000);
                sciana10.Location = new Point(2000, 2000);
                sciana11.Location = new Point(2000, 2000);
                sciana12.Location = new Point(2000, 2000);
                sciana13.Location = new Point(2000, 2000);
                sciana14.Location = new Point(2000, 2000);
                sciana15.Location = new Point(2000, 2000);
                sciana16.Location = new Point(2000, 2000);
                sciana17.Location = new Point(2000, 2000);
                sciana18.Location = new Point(2000, 2000);
                sciana19.Location = new Point(2000, 2000);
                sciana20.Location = new Point(2000, 2000);
                sciana21.Location = new Point(2000, 2000);
                sciana22.Location = new Point(2000, 2000);
                sciana23.Location = new Point(2000, 2000);
                sciana24.Location = new Point(2000, 2000);
                sciana25.Location = new Point(2000, 2000);
                sciana26.Location = new Point(2000, 2000);
                sciana27.Location = new Point(2000, 2000);
                sciana28.Location = new Point(2000, 2000);
                sciana30.Location = new Point(2000, 2000);
            }
            if (plansza == 9)
            {
                drzewo1.Location = new Point(73, 360);
                drzewo2.Location = new Point(1112, 436);
                drzewo3.Location = new Point(12, 227);
                drzewo4.Location = new Point(23, 12);
                drzewo5.Location = new Point(294, 118);
                drzewo6.Location = new Point(23, 619);
                drzewo7.Location = new Point(34, 131);
                drzewo8.Location = new Point(106, 47);
                drzewo9.Location = new Point(176, 0);
                drzewo10.Location = new Point(10, 401);
                drzewo11.Location = new Point(12, 715);
                drzewo12.Location = new Point(82, 701);
                drzewo13.Location = new Point(436, 237);
                drzewo14.Location = new Point(318, 302);
                drzewo15.Location = new Point(209, 175);
                drzewo16.Location = new Point(1134, 332);
                drzewo17.Location = new Point(572, 500);
                drzewo18.Location = new Point(196, 427);
                drzewo19.Location = new Point(482, 701);
                drzewo20.Location = new Point(482, 58);
                drzewo21.Location = new Point(721, 701);
                drzewo22.Location = new Point(594, 175);
                drzewo23.Location = new Point(743, 290);
                drzewo24.Location = new Point(1188, 510);
                drzewo25.Location = new Point(801, 162);
                drzewo26.Location = new Point(785, 481);
                drzewo27.Location = new Point(937, 12);
                drzewo28.Location = new Point(1188, 234);
                drzewo29.Location = new Point(1152, 118);
                drzewo30.Location = new Point(1118, 0);
                drzewo31.Location = new Point(1023, 12);
                drzewo32.Location = new Point(1118, 237);
                drzewo33.Location = new Point(1072, 679);
                drzewo34.Location = new Point(1200, 619);
                drzewo35.Location = new Point(1152, 715);
                drzewo36.Location = new Point(992, 619);
                drzewo37.Location = new Point(922, 701);
                drzewo38.Location = new Point(847, 705);
                drzewo39.Location = new Point(648, 715);
                drzewo40.Location = new Point(572, 661);
                drzewo41.Location = new Point(318, 691);
                drzewo42.Location = new Point(222, 639);
                drzewo43.Location = new Point(152, 715);
                drzewo44.Location = new Point(412, 679);
                drzewo45.Location = new Point(530, 383);

                kamien1.Location = new Point(2000, 2000);
                kamien2.Location = new Point(2000, 2000);
                kamien3.Location = new Point(2000, 2000);
                kamien4.Location = new Point(2000, 2000);
                kamien5.Location = new Point(2000, 2000);

                jezioro.Location = new Point(2000, 2000);
                sciana29.Location = new Point(2000, 2000);
                sciana1.Location = new Point(2000, 2000);
                sciana2.Location = new Point(2000, 2000);
                sciana3.Location = new Point(2000, 2000);
                sciana4.Location = new Point(2000, 2000);
                sciana5.Location = new Point(2000, 2000);
                sciana6.Location = new Point(2000, 2000);
                sciana7.Location = new Point(2000, 2000);
                sciana8.Location = new Point(2000, 2000);
                sciana9.Location = new Point(2000, 2000);
                sciana10.Location = new Point(2000, 2000);
                sciana11.Location = new Point(2000, 2000);
                sciana12.Location = new Point(2000, 2000);
                sciana13.Location = new Point(2000, 2000);
                sciana14.Location = new Point(2000, 2000);
                sciana15.Location = new Point(2000, 2000);
                sciana16.Location = new Point(2000, 2000);
                sciana17.Location = new Point(2000, 2000);
                sciana18.Location = new Point(2000, 2000);
                sciana19.Location = new Point(2000, 2000);
                sciana20.Location = new Point(2000, 2000);
                sciana21.Location = new Point(2000, 2000);
                sciana22.Location = new Point(2000, 2000);
                sciana23.Location = new Point(2000, 2000);
                sciana24.Location = new Point(2000, 2000);
                sciana25.Location = new Point(2000, 2000);
                sciana26.Location = new Point(2000, 2000);
                sciana27.Location = new Point(2000, 2000);
                sciana28.Location = new Point(2000, 2000);
                sciana30.Location = new Point(2000, 2000);
            }
            if (plansza == 8)
            {
                drzewo1.Location = new Point(23, 340);
                drzewo2.Location = new Point(112, 244);
                drzewo3.Location = new Point(12, 227);
                drzewo4.Location = new Point(12, 35);
                drzewo5.Location = new Point(125, 142);
                drzewo6.Location = new Point(23, 619);
                drzewo7.Location = new Point(34, 131);
                drzewo8.Location = new Point(82, 0);
                drzewo9.Location = new Point(205, 194);
                drzewo10.Location = new Point(583, 125);
                drzewo11.Location = new Point(12, 715);
                drzewo12.Location = new Point(82, 701);
                drzewo13.Location = new Point(633, 227);
                drzewo14.Location = new Point(392, 12);
                drzewo15.Location = new Point(648, 121);
                drzewo16.Location = new Point(633, 456);
                drzewo17.Location = new Point(562, 12);
                drzewo18.Location = new Point(823, 12);
                drzewo19.Location = new Point(482, 701);
                drzewo20.Location = new Point(713, 286);
                drzewo21.Location = new Point(731, 679);
                drzewo22.Location = new Point(794, 244);
                drzewo23.Location = new Point(1101, 0);
                drzewo24.Location = new Point(614, 340);
                drzewo25.Location = new Point(1171, 61);
                drzewo26.Location = new Point(885, 286);
                drzewo27.Location = new Point(1200, 166);
                drzewo28.Location = new Point(1200, 286);
                drzewo29.Location = new Point(955, 357);
                drzewo30.Location = new Point(1188, 401);
                drzewo31.Location = new Point(614, 566);
                drzewo32.Location = new Point(1017, 539);
                drzewo33.Location = new Point(1071, 635);
                drzewo34.Location = new Point(1200, 619);
                drzewo35.Location = new Point(1141, 715);
                drzewo36.Location = new Point(992, 661);
                drzewo37.Location = new Point(922, 701);
                drzewo38.Location = new Point(821, 691);
                drzewo39.Location = new Point(648, 715);
                drzewo40.Location = new Point(578, 691);
                drzewo41.Location = new Point(318, 691);
                drzewo42.Location = new Point(231, 670);
                drzewo43.Location = new Point(152, 715);
                drzewo44.Location = new Point(402, 661);
                drzewo45.Location = new Point(472, 35);
                jezioro.Location = new Point(2000, 2000);

                kamien1.Location = new Point(2000, 2000);
                kamien2.Location = new Point(2000, 2000);
                kamien3.Location = new Point(2000, 2000);
                kamien4.Location = new Point(2000, 2000);
                kamien5.Location = new Point(2000, 2000);

                sciana29.Location = new Point(2000, 2000);
                sciana1.Location = new Point(2000, 2000);
                sciana2.Location = new Point(2000, 2000);
                sciana3.Location = new Point(2000, 2000);
                sciana4.Location = new Point(2000, 2000);
                sciana5.Location = new Point(2000, 2000);
                sciana6.Location = new Point(2000, 2000);
                sciana7.Location = new Point(2000, 2000);
                sciana8.Location = new Point(2000, 2000);
                sciana9.Location = new Point(2000, 2000);
                sciana10.Location = new Point(2000, 2000);
                sciana11.Location = new Point(2000, 2000);
                sciana12.Location = new Point(2000, 2000);
                sciana13.Location = new Point(2000, 2000);
                sciana14.Location = new Point(2000, 2000);
                sciana15.Location = new Point(2000, 2000);
                sciana16.Location = new Point(2000, 2000);
                sciana17.Location = new Point(2000, 2000);
                sciana18.Location = new Point(2000, 2000);
                sciana19.Location = new Point(2000, 2000);
                sciana20.Location = new Point(2000, 2000);
                sciana21.Location = new Point(2000, 2000);
                sciana22.Location = new Point(2000, 2000);
                sciana23.Location = new Point(2000, 2000);
                sciana24.Location = new Point(2000, 2000);
                sciana25.Location = new Point(2000, 2000);
                sciana26.Location = new Point(2000, 2000);
                sciana27.Location = new Point(2000, 2000);
                sciana28.Location = new Point(2000, 2000);
                sciana30.Location = new Point(2000, 2000);
            }
            if (plansza == 7)
            {
                drzewo1.Location = new Point(23, 340);
                drzewo2.Location = new Point(12, 436);
                drzewo3.Location = new Point(12, 227);
                drzewo4.Location = new Point(12, 35);
                drzewo5.Location = new Point(152, 12);
                drzewo6.Location = new Point(23, 619);
                drzewo7.Location = new Point(34, 131);
                drzewo8.Location = new Point(82, 0);
                drzewo9.Location = new Point(222, 0);
                drzewo10.Location = new Point(502, 61);
                drzewo11.Location = new Point(12, 715);
                drzewo12.Location = new Point(82, 701);
                drzewo13.Location = new Point(95, 97);
                drzewo14.Location = new Point(292, 47);
                drzewo15.Location = new Point(572, 12);
                drzewo16.Location = new Point(34, 532);
                drzewo17.Location = new Point(432, 25);
                drzewo18.Location = new Point(642, 0);
                drzewo19.Location = new Point(482, 701);
                drzewo20.Location = new Point(712, 12);
                drzewo21.Location = new Point(731, 701);
                drzewo22.Location = new Point(782, 61);
                drzewo23.Location = new Point(922, 0);
                drzewo24.Location = new Point(1188, 340);
                drzewo25.Location = new Point(992, 12);
                drzewo26.Location = new Point(852, 12);
                drzewo27.Location = new Point(1062, 0);
                drzewo28.Location = new Point(1117, 96);
                drzewo29.Location = new Point(1200, 118);
                drzewo30.Location = new Point(1178, 12);
                drzewo31.Location = new Point(1047, 97);
                drzewo32.Location = new Point(1188, 227);
                drzewo33.Location = new Point(1072, 679);
                drzewo34.Location = new Point(1200, 619);
                drzewo35.Location = new Point(1152, 715);
                drzewo36.Location = new Point(992, 661);
                drzewo37.Location = new Point(922, 701);
                drzewo38.Location = new Point(821, 691);
                drzewo39.Location = new Point(648, 715);
                drzewo40.Location = new Point(578, 691);
                drzewo41.Location = new Point(318, 691);
                drzewo42.Location = new Point(231, 670);
                drzewo43.Location = new Point(152, 715);
                drzewo44.Location = new Point(388, 715);
                drzewo45.Location = new Point(362, 0);
                jezioro.Location = new Point(138, 236);

                kamien1.Location = new Point(2000, 2000);
                kamien2.Location = new Point(2000, 2000);
                kamien3.Location = new Point(2000, 2000);
                kamien4.Location = new Point(2000, 2000);
                kamien5.Location = new Point(2000, 2000);

                sciana29.Location = new Point(200, 236);
                sciana1.Location = new Point(194, 248);
                sciana2.Location = new Point(138, 285);
                sciana3.Location = new Point(138, 301);
                sciana4.Location = new Point(152, 366);
                sciana5.Location = new Point(152, 426);
                sciana6.Location = new Point(162, 487);
                sciana7.Location = new Point(466, 612);
                sciana8.Location = new Point(265, 569);
                sciana9.Location = new Point(401, 596);
                sciana10.Location = new Point(351, 585);
                sciana11.Location = new Point(252, 511);
                sciana12.Location = new Point(194, 501);
                sciana13.Location = new Point(222, 501);
                sciana14.Location = new Point(805, 605);
                sciana15.Location = new Point(840, 578);
                sciana16.Location = new Point(871, 585);
                sciana17.Location = new Point(986, 578);
                sciana18.Location = new Point(1047, 539);
                sciana19.Location = new Point(1062, 463);
                sciana20.Location = new Point(1076, 478);
                sciana21.Location = new Point(1047, 451);
                sciana22.Location = new Point(1015, 382);
                sciana23.Location = new Point(1020, 416);
                sciana24.Location = new Point(1035, 436);
                sciana25.Location = new Point(1047, 276);
                sciana26.Location = new Point(968, 248);
                sciana27.Location = new Point(968, 257);
                sciana28.Location = new Point(986, 366);
                sciana30.Location = new Point(998, 349);
            }
            if (plansza == 3)
            {

                drzewo1.Location = new Point(0, 365);
                drzewo2.Location = new Point(12, 461);
                drzewo3.Location = new Point(12, 269);
                drzewo4.Location = new Point(104, 47);
                drzewo5.Location = new Point(742, 0);
                drzewo6.Location = new Point(104, 691);
                drzewo7.Location = new Point(22, 12);
                drzewo8.Location = new Point(668, 325);
                drzewo9.Location = new Point(176, 0);
                drzewo10.Location = new Point(784, 325);
                drzewo11.Location = new Point(22, 702);
                drzewo12.Location = new Point(270, 702);
                drzewo13.Location = new Point(792, 86);
                drzewo14.Location = new Point(338, 12);
                drzewo15.Location = new Point(255, 30);
                drzewo16.Location = new Point(186, 715);
                drzewo17.Location = new Point(509, 0);
                drzewo18.Location = new Point(1022, 339);
                drzewo19.Location = new Point(926, 678);
                drzewo20.Location = new Point(932, 86);
                drzewo21.Location = new Point(214, 339);
                drzewo22.Location = new Point(862, 12);
                drzewo23.Location = new Point(1010, 138);
                drzewo24.Location = new Point(751, 678);
                drzewo25.Location = new Point(1010, 234);
                drzewo26.Location = new Point(668, 0);
                drzewo27.Location = new Point(378, 339);
                drzewo28.Location = new Point(547, 325);
                drzewo29.Location = new Point(1071, 435);
                drzewo30.Location = new Point(854, 383);
                drzewo31.Location = new Point(1098, 61);
                drzewo32.Location = new Point(462, 365);
                drzewo33.Location = new Point(523, 715);
                drzewo34.Location = new Point(681, 715);
                drzewo35.Location = new Point(598, 682);
                drzewo36.Location = new Point(439, 682);
                drzewo37.Location = new Point(354, 715);
                drzewo38.Location = new Point(836, 691);
                drzewo39.Location = new Point(1148, 269);
                drzewo40.Location = new Point(1010, 645);
                drzewo41.Location = new Point(421, 61);
                drzewo42.Location = new Point(82, 355);
                drzewo43.Location = new Point(1084, 537);
                drzewo44.Location = new Point(298, 355);
                drzewo45.Location = new Point(598, 47);

                kamien1.Location = new Point(742, 313);
                kamien2.Location = new Point(163, 383);
                kamien3.Location = new Point(974, 413);
                kamien4.Location = new Point(932, 397);
                kamien5.Location = new Point(626, 383);

                jezioro.Location = new Point(2000, 2000);

                sciana29.Location = new Point(2000, 2000);
                sciana1.Location = new Point(2000, 2000);
                sciana2.Location = new Point(2000, 2000);
                sciana3.Location = new Point(2000, 2000);
                sciana4.Location = new Point(2000, 2000);
                sciana5.Location = new Point(2000, 2000);
                sciana6.Location = new Point(2000, 2000);
                sciana7.Location = new Point(2000, 2000);
                sciana8.Location = new Point(2000, 2000);
                sciana9.Location = new Point(2000, 2000);
                sciana10.Location = new Point(2000, 2000);
                sciana11.Location = new Point(2000, 2000);
                sciana12.Location = new Point(2000, 2000);
                sciana13.Location = new Point(2000, 2000);
                sciana14.Location = new Point(2000, 2000);
                sciana15.Location = new Point(2000, 2000);
                sciana16.Location = new Point(2000, 2000);
                sciana17.Location = new Point(2000, 2000);
                sciana18.Location = new Point(2000, 2000);
                sciana19.Location = new Point(2000, 2000);
                sciana20.Location = new Point(2000, 2000);
                sciana21.Location = new Point(2000, 2000);
                sciana22.Location = new Point(2000, 2000);
                sciana23.Location = new Point(2000, 2000);
                sciana24.Location = new Point(2000, 2000);
                sciana25.Location = new Point(2000, 2000);
                sciana26.Location = new Point(2000, 2000);
                sciana27.Location = new Point(2000, 2000);
                sciana28.Location = new Point(2000, 2000);
                sciana30.Location = new Point(2000, 2000);
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ruchlewo = false;

            }
            else if (e.KeyCode == Keys.Right)
            {
                ruchprawo = false;

            }
            else if (e.KeyCode == Keys.Up)
            {
                ruchgora = false;

            }
            else if (e.KeyCode == Keys.Down)
            {
                ruchdol = false;

            }

        }
        private bool IsPictureBoxOverlapAny(PictureBox postac, List<PictureBox> otherPictureBoxes)
        {
            Rectangle rect1 = new Rectangle(postac.Left, postac.Top, postac.Width, postac.Height);

            foreach (PictureBox otherPictureBox in otherPictureBoxes)
            {
                Rectangle rect2 = new Rectangle(otherPictureBox.Left, otherPictureBox.Top, otherPictureBox.Width, otherPictureBox.Height);

                if (rect1.IntersectsWith(rect2))
                {
                    return true; // Nachodzi na co najmniej jednym innym PictureBox
                }
            }

            return false; // Nie nachodzi na ¿adnym innym PictureBox
        }

    }
}
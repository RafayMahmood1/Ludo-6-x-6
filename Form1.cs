using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading.Tasks;

namespace Ludo
{
    public partial class Form1 : Form
    {
        int[] PathArr = new int[78];

        Green g1 = new Green(11);
        Green g2 = new Green(12);
        Green g3 = new Green(13);
        Green g4 = new Green(14);

        Orange o1 = new Orange(21);
        Orange o2 = new Orange(22);
        Orange o3 = new Orange(23);
        Orange o4 = new Orange(24);

        Blue b1 = new Blue(31);
        Blue b2 = new Blue(32);
        Blue b3 = new Blue(33);
        Blue b4 = new Blue(34);

        Yellow y1 = new Yellow(41);
        Yellow y2 = new Yellow(42);
        Yellow y3 = new Yellow(43);
        Yellow y4 = new Yellow(44);

        Purple p1 = new Purple(51);
        Purple p2 = new Purple(52);
        Purple p3 = new Purple(53);
        Purple p4 = new Purple(54);

        Red r1 = new Red(61);
        Red r2 = new Red(62);
        Red r3 = new Red(63);
        Red r4 = new Red(64);

        string temp1;
        string temp2;

        string val1;
        string val2;
        string val3;
        string val4;
        string val5;

        int RandomNumber;

        int NOP = 6;
        int Player_Turn;
        int sara = 0;
        bool Rolled = false;
        bool Moved = false;
        int CurrentisFree;
        bool sound = false;
        bool Movement = false;
        int KilledGoti;

        public Form1()
        {
            InitializeComponent();
            InitArr();
            SoundPlayer sd = new SoundPlayer("C:/Users/RAFAY/Desktop/Patakha_Guddi_(Male_Version)-A_R_Rahman[www.Mp3MaD.Com] (1).wav");
            sd.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Green Gotiyaan
        private void GGoti1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (g1.Id == Player_Turn && Rolled)
            {
                g1.Movement(RandomNumber, PathArr, ref KilledGoti ,GGoti1);
                Player_Turn = g1.Id;
                TurnChange();
                Rolled = false;

                    Moved = true;

            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void GGoti2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (g2.Id == Player_Turn && Rolled)
            {
                g2.Movement(RandomNumber,PathArr, ref KilledGoti, GGoti2);
                Player_Turn = g2.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void GGoti3_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (g3.Id == Player_Turn && Rolled)
            {
                g3.Movement(RandomNumber,  PathArr, ref KilledGoti, GGoti3);
                Player_Turn = g3.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void GGoti4_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (g4.Id == Player_Turn && Rolled)
            {
                g4.Movement(RandomNumber,  PathArr, ref KilledGoti, GGoti4);
                Player_Turn = g4.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        //Red Gotiyaan
        private void RGoti1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (r1.Id == Player_Turn && Rolled)
            {
                r1.Movement(RandomNumber, ref PathArr, ref KilledGoti, RGoti1);
                Player_Turn = r1.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void RGoti2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (r2.Id == Player_Turn && Rolled)
            {
                r2.Movement(RandomNumber, ref PathArr, ref KilledGoti, RGoti2);
                Player_Turn = r2.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void RGoti3_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (r3.Id == Player_Turn && Rolled)
            {
                r3.Movement(RandomNumber, ref PathArr, ref KilledGoti, RGoti3);
                Player_Turn = r3.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void RGoti4_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (r4.Id == Player_Turn && Rolled)
            {
                r4.Movement(RandomNumber, ref PathArr, ref KilledGoti, RGoti4);
                Player_Turn = r4.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        //Purple Gotiyaan
        private void PGoti1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (p1.Id == Player_Turn && Rolled)
            {
                p1.Movement(RandomNumber, ref PathArr, ref KilledGoti, PGoti1);
                Player_Turn = p1.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void PGoti2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (p2.Id == Player_Turn && Rolled)
            {
                p2.Movement(RandomNumber, ref PathArr, ref KilledGoti, PGoti2);
                Player_Turn = p2.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void PGoti3_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (p3.Id == Player_Turn && Rolled)
            {
                p3.Movement(RandomNumber, ref PathArr, ref KilledGoti, PGoti3);
                Player_Turn = p3.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void PGoti4_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (p4.Id == Player_Turn && Rolled)
            {
                p4.Movement(RandomNumber, ref PathArr, ref KilledGoti, PGoti4);
                Player_Turn = p4.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        //Yellow Gotiyaan
        private void YGoti1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (y1.Id == Player_Turn && Rolled)
            {
                y1.Movement(RandomNumber, ref PathArr, ref KilledGoti, YGoti1);
                Player_Turn = y1.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void YGoti2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (y2.Id == Player_Turn && Rolled)
            {
                y2.Movement(RandomNumber, ref PathArr, ref KilledGoti, YGoti2);
                Player_Turn = y2.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void YGoti3_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (y3.Id == Player_Turn && Rolled)
            {
                y3.Movement(RandomNumber, ref PathArr, ref KilledGoti, YGoti3);
                Player_Turn = y3.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void YGoti4_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (y4.Id == Player_Turn && Rolled)
            {
                y4.Movement(RandomNumber, ref PathArr, ref KilledGoti, YGoti4);
                Player_Turn = y4.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        //Blue Gotiyaan
        private void BGoti1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (b1.Id == Player_Turn && Rolled)
            {
                b1.Movement(RandomNumber, ref PathArr, ref KilledGoti, BGoti1);
                Player_Turn = b1.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void BGoti2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (b2.Id == Player_Turn && Rolled)
            {
                b2.Movement(RandomNumber, ref PathArr, ref KilledGoti, BGoti2);
                Player_Turn = b2.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void BGoti3_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (b3.Id == Player_Turn && Rolled)
            {
                b3.Movement(RandomNumber, ref PathArr, ref KilledGoti, BGoti3);
                Player_Turn = b3.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void BGoti4_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (b4.Id == Player_Turn && Rolled)
            {
                b4.Movement(RandomNumber, ref PathArr, ref KilledGoti, BGoti4);
                Player_Turn = b4.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        //Orange Gotiyaan
        private void OGoti1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (o1.Id == Player_Turn && Rolled)
            {
                o1.Movement(RandomNumber, ref PathArr, ref KilledGoti, OGoti1);
                Player_Turn = o1.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void OGoti2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (o2.Id == Player_Turn && Rolled)
            {
                o2.Movement(RandomNumber, ref PathArr, ref KilledGoti, OGoti2);
                Player_Turn = o2.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void OGoti3_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (o3.Id == Player_Turn && Rolled)
            {
                o3.Movement(RandomNumber, ref PathArr, ref KilledGoti, OGoti3);
                Player_Turn = o3.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }
        private void OGoti4_Click_1(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("C:/Users/RAFAY/Desktop/y2mate.com - mouse_click_sound_effect_hd_h6_8SlZZwvQ-[AudioTrimmer.com].wav");
            p.Play();
            if (o4.Id == Player_Turn && Rolled)
            {
                o4.Movement(RandomNumber, ref PathArr, ref KilledGoti, OGoti4);
                Player_Turn = o4.Id;
                TurnChange();
                Rolled = false;
                Moved = true;
            }
            else
            {
                if (Rolled == false)
                {
                    MessageBox.Show("Please Roll the Dice...!!!");
                }
                else
                {
                    MessageBox.Show("Player " + Player_Turn.ToString() + " Turn");
                }
            }
            IsKilled();
            IsWin();
        }


        void InitArr()
        {
            for (int i = 0; i < 78; i++)
            {
                PathArr[i] = 0;
            }
        }

        void SaveGame()
        {
            using (StreamWriter wr = new StreamWriter("D:/rafay/ucp/Semester - III/OOP/New folder/Ludo/Ludo/Ludo/Data.txt"))
            {
                wr.WriteLine(GGoti1.Location.X);
                wr.WriteLine(GGoti1.Location.Y);
                wr.WriteLine(GGoti2.Location.X);
                wr.WriteLine(GGoti2.Location.Y);
                wr.WriteLine(GGoti3.Location.X);
                wr.WriteLine(GGoti3.Location.Y);
                wr.WriteLine(GGoti4.Location.X);
                wr.WriteLine(GGoti4.Location.Y);

                wr.WriteLine(OGoti1.Location.X);
                wr.WriteLine(OGoti1.Location.Y);
                wr.WriteLine(OGoti2.Location.X);
                wr.WriteLine(OGoti2.Location.Y);
                wr.WriteLine(OGoti3.Location.X);
                wr.WriteLine(OGoti3.Location.Y);
                wr.WriteLine(OGoti4.Location.X);
                wr.WriteLine(OGoti4.Location.Y);

                wr.WriteLine(BGoti1.Location.X);
                wr.WriteLine(BGoti1.Location.Y);
                wr.WriteLine(BGoti2.Location.X);
                wr.WriteLine(BGoti2.Location.Y);
                wr.WriteLine(BGoti3.Location.X);
                wr.WriteLine(BGoti3.Location.Y);
                wr.WriteLine(BGoti4.Location.X);
                wr.WriteLine(BGoti4.Location.Y);

                wr.WriteLine(YGoti1.Location.X);
                wr.WriteLine(YGoti1.Location.Y);
                wr.WriteLine(YGoti2.Location.X);
                wr.WriteLine(YGoti2.Location.Y);
                wr.WriteLine(YGoti3.Location.X);
                wr.WriteLine(YGoti3.Location.Y);
                wr.WriteLine(YGoti4.Location.X);
                wr.WriteLine(YGoti4.Location.Y);

                wr.WriteLine(PGoti1.Location.X);
                wr.WriteLine(PGoti1.Location.Y);
                wr.WriteLine(PGoti2.Location.X);
                wr.WriteLine(PGoti2.Location.Y);
                wr.WriteLine(PGoti3.Location.X);
                wr.WriteLine(PGoti3.Location.Y);
                wr.WriteLine(PGoti4.Location.X);
                wr.WriteLine(PGoti4.Location.Y);

                wr.WriteLine(RGoti1.Location.X);
                wr.WriteLine(RGoti1.Location.Y);
                wr.WriteLine(RGoti2.Location.X);
                wr.WriteLine(RGoti2.Location.Y);
                wr.WriteLine(RGoti3.Location.X);
                wr.WriteLine(RGoti3.Location.Y);
                wr.WriteLine(RGoti4.Location.X);
                wr.WriteLine(RGoti4.Location.Y);
            }
            using (StreamWriter wr = new StreamWriter("D:/rafay/ucp/Semester - III/OOP/New folder/Ludo/Ludo/Ludo/Data2.txt"))
            {
                //green
                wr.WriteLine(g1.color);
                wr.WriteLine(g1.IsFree);
                wr.WriteLine(g1.NoOfMoves);
                wr.WriteLine(g1.GotHome);
                wr.WriteLine(g1.Id);

                wr.WriteLine(g2.color);
                wr.WriteLine(g2.IsFree);
                wr.WriteLine(g2.NoOfMoves);
                wr.WriteLine(g2.GotHome);
                wr.WriteLine(g2.Id);

                wr.WriteLine(g3.color);
                wr.WriteLine(g3.IsFree);
                wr.WriteLine(g3.NoOfMoves);
                wr.WriteLine(g3.GotHome);
                wr.WriteLine(g3.Id);

                wr.WriteLine(g4.color);
                wr.WriteLine(g4.IsFree);
                wr.WriteLine(g4.NoOfMoves);
                wr.WriteLine(g4.GotHome);
                wr.WriteLine(g4.Id);

                //orange
                wr.WriteLine(g1.color);
                wr.WriteLine(o1.IsFree);
                wr.WriteLine(o1.NoOfMoves);
                wr.WriteLine(o1.GotHome);
                wr.WriteLine(o1.Id);

                wr.WriteLine(o2.color);
                wr.WriteLine(o2.IsFree);
                wr.WriteLine(o2.NoOfMoves);
                wr.WriteLine(o2.GotHome);
                wr.WriteLine(o2.Id);

                wr.WriteLine(o3.color);
                wr.WriteLine(o3.IsFree);
                wr.WriteLine(o3.NoOfMoves);
                wr.WriteLine(o3.GotHome);
                wr.WriteLine(o3.Id);

                wr.WriteLine(o4.color);
                wr.WriteLine(o4.IsFree);
                wr.WriteLine(o4.NoOfMoves);
                wr.WriteLine(o4.GotHome);
                wr.WriteLine(o4.Id);

                //blue

                wr.WriteLine(b1.color);
                wr.WriteLine(b1.IsFree);
                wr.WriteLine(b1.NoOfMoves);
                wr.WriteLine(b1.GotHome);
                wr.WriteLine(b1.Id);

                wr.WriteLine(b2.color);
                wr.WriteLine(b2.IsFree);
                wr.WriteLine(b2.NoOfMoves);
                wr.WriteLine(b2.GotHome);
                wr.WriteLine(b2.Id);

                wr.WriteLine(b3.color);
                wr.WriteLine(b3.IsFree);
                wr.WriteLine(b3.NoOfMoves);
                wr.WriteLine(b3.GotHome);
                wr.WriteLine(b3.Id);

                wr.WriteLine(b4.color);
                wr.WriteLine(b4.IsFree);
                wr.WriteLine(b4.NoOfMoves);
                wr.WriteLine(b4.GotHome);
                wr.WriteLine(b4.Id);

                //yellow
                wr.WriteLine(y1.color);
                wr.WriteLine(y1.IsFree);
                wr.WriteLine(y1.NoOfMoves);
                wr.WriteLine(y1.GotHome);
                wr.WriteLine(y1.Id);

                wr.WriteLine(y2.color);
                wr.WriteLine(y2.IsFree);
                wr.WriteLine(y2.NoOfMoves);
                wr.WriteLine(y2.GotHome);
                wr.WriteLine(y2.Id);

                wr.WriteLine(y3.color);
                wr.WriteLine(y3.IsFree);
                wr.WriteLine(y3.NoOfMoves);
                wr.WriteLine(y3.GotHome);
                wr.WriteLine(y3.Id);

                wr.WriteLine(y4.color);
                wr.WriteLine(y4.IsFree);
                wr.WriteLine(y4.NoOfMoves);
                wr.WriteLine(y4.GotHome);
                wr.WriteLine(y4.Id);

                //purple

                wr.WriteLine(p1.color);
                wr.WriteLine(p1.IsFree);
                wr.WriteLine(p1.NoOfMoves);
                wr.WriteLine(p1.GotHome);
                wr.WriteLine(p1.Id);

                wr.WriteLine(p2.color);
                wr.WriteLine(p2.IsFree);
                wr.WriteLine(p2.NoOfMoves);
                wr.WriteLine(p2.GotHome);
                wr.WriteLine(p2.Id);

                wr.WriteLine(p3.color);
                wr.WriteLine(p3.IsFree);
                wr.WriteLine(p3.NoOfMoves);
                wr.WriteLine(p3.GotHome);
                wr.WriteLine(p3.Id);

                wr.WriteLine(p4.color);
                wr.WriteLine(p4.IsFree);
                wr.WriteLine(p4.NoOfMoves);
                wr.WriteLine(p4.GotHome);
                wr.WriteLine(p4.Id);

                //red

                wr.WriteLine(r1.color);
                wr.WriteLine(r1.IsFree);
                wr.WriteLine(r1.NoOfMoves);
                wr.WriteLine(r1.GotHome);
                wr.WriteLine(r1.Id);

                wr.WriteLine(r2.color);
                wr.WriteLine(r2.IsFree);
                wr.WriteLine(r2.NoOfMoves);
                wr.WriteLine(r2.GotHome);
                wr.WriteLine(r2.Id);

                wr.WriteLine(r3.color);
                wr.WriteLine(r3.IsFree);
                wr.WriteLine(r3.NoOfMoves);
                wr.WriteLine(r3.GotHome);
                wr.WriteLine(r3.Id);

                wr.WriteLine(r4.color);
                wr.WriteLine(r4.IsFree);
                wr.WriteLine(r4.NoOfMoves);
                wr.WriteLine(r4.GotHome);
                wr.WriteLine(r4.Id);

                wr.WriteLine(Player_Turn);
            }
        }

        void LoadGame()
        {
            using (StreamReader sr = new StreamReader("D:/rafay/ucp/Semester - III/OOP/New folder/Ludo/Ludo/Ludo/Data.txt"))
            {
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                GGoti1.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                GGoti2.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                GGoti3.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                GGoti4.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));

                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                OGoti1.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                OGoti2.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                OGoti3.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                OGoti4.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));

                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                BGoti1.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                BGoti2.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                BGoti3.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                BGoti4.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));

                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                YGoti1.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                YGoti2.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                YGoti3.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                YGoti4.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));

                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                PGoti1.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                PGoti2.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                PGoti3.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                PGoti4.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));

                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                RGoti1.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                RGoti2.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                RGoti3.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                RGoti4.Location = new Point(Convert.ToInt32(temp1), Convert.ToInt32(temp2));
            }
            using (StreamReader sr = new StreamReader("D:/rafay/ucp/Semester - III/OOP/New folder/Ludo/Ludo/Ludo/Data2.txt"))
            {
                //green
                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                g1.color = Convert.ToInt32(val1);
                g1.IsFree = Convert.ToBoolean(val2);
                g1.NoOfMoves = Convert.ToInt32(val3);
                g1.GotHome = Convert.ToBoolean(val4);
                g1.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                g2.color = Convert.ToInt32(val1);
                g2.IsFree = Convert.ToBoolean(val2);
                g2.NoOfMoves = Convert.ToInt32(val3);
                g2.GotHome = Convert.ToBoolean(val4);
                g2.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                g3.color = Convert.ToInt32(val1);
                g3.IsFree = Convert.ToBoolean(val2);
                g3.NoOfMoves = Convert.ToInt32(val3);
                g3.GotHome = Convert.ToBoolean(val4);
                g3.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                g4.color = Convert.ToInt32(val1);
                g4.IsFree = Convert.ToBoolean(val2);
                g4.NoOfMoves = Convert.ToInt32(val3);
                g4.GotHome = Convert.ToBoolean(val4);
                g4.Id = Convert.ToInt32(val5);

                //orange
                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                o1.color = Convert.ToInt32(val1);
                o1.IsFree = Convert.ToBoolean(val2);
                o1.NoOfMoves = Convert.ToInt32(val3);
                o1.GotHome = Convert.ToBoolean(val4);
                o1.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                o2.color = Convert.ToInt32(val1);
                o2.IsFree = Convert.ToBoolean(val2);
                o2.NoOfMoves = Convert.ToInt32(val3);
                o2.GotHome = Convert.ToBoolean(val4);
                o2.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                o3.color = Convert.ToInt32(val1);
                o3.IsFree = Convert.ToBoolean(val2);
                o3.NoOfMoves = Convert.ToInt32(val3);
                o3.GotHome = Convert.ToBoolean(val4);
                o3.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                o4.color = Convert.ToInt32(val1);
                o4.IsFree = Convert.ToBoolean(val2);
                o4.NoOfMoves = Convert.ToInt32(val3);
                o4.GotHome = Convert.ToBoolean(val4);
                o4.Id = Convert.ToInt32(val5);

                //Blue
                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                b1.color = Convert.ToInt32(val1);
                b1.IsFree = Convert.ToBoolean(val2);
                b1.NoOfMoves = Convert.ToInt32(val3);
                b1.GotHome = Convert.ToBoolean(val4);
                b1.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                b2.color = Convert.ToInt32(val1);
                b2.IsFree = Convert.ToBoolean(val2);
                b2.NoOfMoves = Convert.ToInt32(val3);
                b2.GotHome = Convert.ToBoolean(val4);
                b2.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                b3.color = Convert.ToInt32(val1);
                b3.IsFree = Convert.ToBoolean(val2);
                b3.NoOfMoves = Convert.ToInt32(val3);
                b3.GotHome = Convert.ToBoolean(val4);
                b3.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                b4.color = Convert.ToInt32(val1);
                b4.IsFree = Convert.ToBoolean(val2);
                b4.NoOfMoves = Convert.ToInt32(val3);
                b4.GotHome = Convert.ToBoolean(val4);
                b4.Id = Convert.ToInt32(val5);

                //Yellow
                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                y1.color = Convert.ToInt32(val1);
                y1.IsFree = Convert.ToBoolean(val2);
                y1.NoOfMoves = Convert.ToInt32(val3);
                y1.GotHome = Convert.ToBoolean(val4);
                y1.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                y2.color = Convert.ToInt32(val1);
                y2.IsFree = Convert.ToBoolean(val2);
                y2.NoOfMoves = Convert.ToInt32(val3);
                y2.GotHome = Convert.ToBoolean(val4);
                y2.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                y3.color = Convert.ToInt32(val1);
                y3.IsFree = Convert.ToBoolean(val2);
                y3.NoOfMoves = Convert.ToInt32(val3);
                y3.GotHome = Convert.ToBoolean(val4);
                y3.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                y4.color = Convert.ToInt32(val1);
                y4.IsFree = Convert.ToBoolean(val2);
                y4.NoOfMoves = Convert.ToInt32(val3);
                y4.GotHome = Convert.ToBoolean(val4);
                y4.Id = Convert.ToInt32(val5);

                //Purple
                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                p1.color = Convert.ToInt32(val1);
                p1.IsFree = Convert.ToBoolean(val2);
                p1.NoOfMoves = Convert.ToInt32(val3);
                p1.GotHome = Convert.ToBoolean(val4);
                p1.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                p2.color = Convert.ToInt32(val1);
                p2.IsFree = Convert.ToBoolean(val2);
                p2.NoOfMoves = Convert.ToInt32(val3);
                p2.GotHome = Convert.ToBoolean(val4);
                p2.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                p3.color = Convert.ToInt32(val1);
                p3.IsFree = Convert.ToBoolean(val2);
                p3.NoOfMoves = Convert.ToInt32(val3);
                p3.GotHome = Convert.ToBoolean(val4);
                p3.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                p4.color = Convert.ToInt32(val1);
                p4.IsFree = Convert.ToBoolean(val2);
                p4.NoOfMoves = Convert.ToInt32(val3);
                p4.GotHome = Convert.ToBoolean(val4);
                p4.Id = Convert.ToInt32(val5);

                //Red
                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                r1.color = Convert.ToInt32(val1);
                r1.IsFree = Convert.ToBoolean(val2);
                r1.NoOfMoves = Convert.ToInt32(val3);
                r1.GotHome = Convert.ToBoolean(val4);
                r1.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                r2.color = Convert.ToInt32(val1);
                r2.IsFree = Convert.ToBoolean(val2);
                r2.NoOfMoves = Convert.ToInt32(val3);
                r2.GotHome = Convert.ToBoolean(val4);
                r2.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                r3.color = Convert.ToInt32(val1);
                r3.IsFree = Convert.ToBoolean(val2);
                r3.NoOfMoves = Convert.ToInt32(val3);
                r3.GotHome = Convert.ToBoolean(val4);
                r3.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                val2 = sr.ReadLine();
                val3 = sr.ReadLine();
                val4 = sr.ReadLine();
                val5 = sr.ReadLine();
                r4.color = Convert.ToInt32(val1);
                r4.IsFree = Convert.ToBoolean(val2);
                r4.NoOfMoves = Convert.ToInt32(val3);
                r4.GotHome = Convert.ToBoolean(val4);
                r4.Id = Convert.ToInt32(val5);

                val1 = sr.ReadLine();
                Player_Turn = Convert.ToInt32(val1);
            }

        }

        void RestartGame()
        {
            Green g1 = new Green(11);
            Green g2 = new Green(12);
            Green g3 = new Green(13);
            Green g4 = new Green(14);

            Orange o1 = new Orange(21);
            Orange o2 = new Orange(22);
            Orange o3 = new Orange(23);
            Orange o4 = new Orange(24);

            Blue b1 = new Blue(31);
            Blue b2 = new Blue(32);
            Blue b3 = new Blue(33);
            Blue b4 = new Blue(34);

            Yellow y1 = new Yellow(41);
            Yellow y2 = new Yellow(42);
            Yellow y3 = new Yellow(43);
            Yellow y4 = new Yellow(44);

            Purple p1 = new Purple(51);
            Purple p2 = new Purple(52);
            Purple p3 = new Purple(53);
            Purple p4 = new Purple(54);

            Red r1 = new Red(61);
            Red r2 = new Red(62);
            Red r3 = new Red(63);
            Red r4 = new Red(64);

            GGoti1.Location = new Point(216, 135);
            GGoti2.Location = new Point(155, 103);
            GGoti3.Location = new Point(214, 68);
            GGoti4.Location = new Point(195, 103);

            OGoti1.Location = new Point(434, 130);
            OGoti2.Location = new Point(434, 68);
            OGoti3.Location = new Point(495, 99);
            OGoti4.Location = new Point(457, 99);

            BGoti1.Location = new Point(605, 280);
            BGoti2.Location = new Point(605, 345);
            BGoti3.Location = new Point(580, 315);
            BGoti4.Location = new Point(540, 313);

            YGoti1.Location = new Point(495, 528);
            YGoti2.Location = new Point(434, 563);
            YGoti3.Location = new Point(454, 527);
            YGoti4.Location = new Point(434, 495);

            PGoti1.Location = new Point(214, 494);
            PGoti2.Location = new Point(195, 526);
            PGoti3.Location = new Point(155, 531);
            PGoti4.Location = new Point(212, 560);

            RGoti1.Location = new Point(45, 345);
            RGoti2.Location = new Point(45, 280);
            RGoti3.Location = new Point(69, 310);
            RGoti4.Location = new Point(105, 310);
        }

        void IsKilled()
        {
            //green
            if (KilledGoti == 11)
            {
                GGoti1.Location = new Point(216, 135);
                sound = true;
            }
            else if(KilledGoti == 12)
            {
                GGoti2.Location = new Point(155, 103);
                sound = true;
            }
            else if(KilledGoti == 13)
            {
                GGoti3.Location = new Point(214, 68);
                sound = true;
            }
            else if(KilledGoti == 14)
            {
                GGoti4.Location = new Point(195, 103);
                sound = true;
            }
            //orange
            else if(KilledGoti == 21)
            {
                OGoti1.Location = new Point(434, 130);
                sound = true;
            }
            else if(KilledGoti == 22)
            {
                OGoti2.Location = new Point(434, 68);
                sound = true;
            }
            else if(KilledGoti == 23)
            {
                OGoti3.Location = new Point(495, 99);
                sound = true;
            }
            else if (KilledGoti == 24)
            {
                OGoti4.Location = new Point(457, 99);
                sound = true;
            }
            //blue
            else if (KilledGoti == 31)
            {
                BGoti1.Location = new Point(605, 280);
                sound = true;
            }
            else if (KilledGoti == 32)
            {
                BGoti2.Location = new Point(605, 345);
                sound = true;
            }
            else if (KilledGoti == 33)
            {
                BGoti3.Location = new Point(580, 315);
                sound = true;
            }
            else if (KilledGoti == 34)
            {
                BGoti4.Location = new Point(540, 313);
                sound = true;
            }
            //yellow
            else if (KilledGoti == 41)
            {
                YGoti1.Location = new Point(495, 528);
                sound = true;
            }
            else if (KilledGoti == 42)
            {
                YGoti2.Location = new Point(434, 563);
                sound = true;
            }
            else if (KilledGoti == 43)
            {
                YGoti3.Location = new Point(454, 527);
                sound = true;
            }
            else if (KilledGoti == 44)
            {
                YGoti4.Location = new Point(434, 495);
                sound = true;
            }
            //purple
            else if (KilledGoti == 51)
            {
                PGoti1.Location = new Point(214, 494);
                sound = true;
            }
            else if (KilledGoti == 52)
            {
                PGoti2.Location = new Point(195, 526);
                sound = true;
            }
            else if (KilledGoti == 53)
            {
                PGoti3.Location = new Point(155, 531);
                sound = true;
            }
            else if (KilledGoti == 54)
            {
                PGoti4.Location = new Point(212, 560);
                sound = true;
            }
            //red
            else if (KilledGoti == 61)
            {
                RGoti1.Location = new Point(45, 345);
                sound = true;
            }
            else if (KilledGoti == 62)
            {
                RGoti2.Location = new Point(45, 280);
                sound = true;
            }
            else if (KilledGoti == 63)
            {
                RGoti3.Location = new Point(69, 310);
                sound = true;
            }
            else if (KilledGoti == 64)
            {
                RGoti4.Location = new Point(105, 310);
                sound = true;
            }
            if(sound)
            {
                SoundPlayer a = new SoundPlayer("C:/Users/RAFAY/Desktop/Sad sound effects.wav");
                a.Play();
            }
        }

        void IsWin()
        {
            if (g1.GotHome && g2.GotHome && g3.GotHome && g4.GotHome)
            {
                MessageBox.Show("Green Player Wins...!!!");
            }
            if (o1.GotHome && o2.GotHome && o3.GotHome && o4.GotHome)
            {
                MessageBox.Show("Orange Player Wins...!!!");
            }
            if (b1.GotHome && b2.GotHome && b3.GotHome && b4.GotHome)
            {
                MessageBox.Show("Blue Player Wins...!!!");
            }
            if (y1.GotHome && y2.GotHome && y3.GotHome && y4.GotHome)
            {
                MessageBox.Show("Yellow Player Wins...!!!");
            }
            if (p1.GotHome && p2.GotHome && p3.GotHome && p4.GotHome)
            {
                MessageBox.Show("Purple Player Wins...!!!");
            }
            if (r1.GotHome && r2.GotHome && r3.GotHome && r4.GotHome)
            {
                MessageBox.Show("Red Player Wins...!!!");
            }
        }

        void TurnChange()
        {
            if (RandomNumber == 6)
            {
                sara++;
                if (sara == 3)
                {
                    SoundPlayer c = new SoundPlayer("C:/Users/RAFAY/Desktop/Sad sound effects.wav");
                    c.Play();
                    MessageBox.Show("Turn Wasted..!!!");
                }
                return;
            }
            sara = 0;
            Player_Turn = (Player_Turn + 1) % NOP;

            if (NOP == 2)
            {
                if (Player_Turn == 0)
                {
                    TurnPic.Location = new Point(323, 235);

                }
                else if (Player_Turn == 1)
                {
                    TurnPic.Location = new Point(323, 390);
                }
            }
            if (NOP==6)
            {
                if (Player_Turn == 0)
                {
                    TurnPic.Location = new Point(253, 273);
                }
                else if (Player_Turn == 1)
                {
                    TurnPic.Location = new Point(323, 235);
                }
                else if (Player_Turn == 2)
                {
                    TurnPic.Location = new Point(397, 273);
                }
                else if (Player_Turn == 3)
                {
                    TurnPic.Location = new Point(397, 353);
                }
                else if (Player_Turn == 4)
                {
                    TurnPic.Location = new Point(323, 390);
                }
                else if (Player_Turn == 5)
                {
                    TurnPic.Location = new Point(253, 353);
                }
            }
            

            if(NOP==2)
            {
                if(Player_Turn==0)
                {
                    TurnPic.Location = new Point(323, 235);

                }
                else if(Player_Turn==1)
                {
                    TurnPic.Location = new Point(323, 390);
                }
            }
        }

        int x = 0;
        private void DiceBtn_Click_1(object sender, EventArgs e)
        {
            //if (((g1.IsFree || g2.IsFree || g3.IsFree || g4.IsFree) && Moved && x != 0) || ((o1.IsFree || o2.IsFree || o3.IsFree || o4.IsFree) && Moved && x != 0) ||(( b1.IsFree || b2.IsFree || b3.IsFree || b4.IsFree) && Moved && x != 0) ||(( y1.IsFree || y2.IsFree || y3.IsFree || y4.IsFree) && Moved && x != 0) || ((p1.IsFree || p2.IsFree || p3.IsFree || p4.IsFree) && Moved && x != 0) || ((r1.IsFree || r2.IsFree || r3.IsFree || r4.IsFree) && Moved && x != 0))
            //{
            //    MessageBox.Show("Move Goti First...!!!");
            //    return;
            //}
            x++;
            SoundPlayer b = new SoundPlayer("C:/Users/RAFAY/Desktop/Dice - SOUND EFFECT --[AudioTrimmer.com].wav");
            b.Play();
            var t = Task.Run(async delegate
            {
                await Task.Delay(1000);
                return 42;
            });
            t.Wait();
            Random r = new Random();
            RandomNumber = r.Next(1, 7);
            Rolled = true;
            DiceDisplay.Text = RandomNumber.ToString();
            if(RandomNumber!=6)
            {
                if(Player_Turn==0)
                {
                    if (!g1.IsFree && !g2.IsFree && !g3.IsFree && !g4.IsFree)
                    {
                        TurnChange();
                    }
                }
                else if(Player_Turn==1)
                {
                    if (!o1.IsFree && !o2.IsFree && !o3.IsFree && !o4.IsFree)
                    {
                        TurnChange();
                    }
                }
                else if (Player_Turn == 2)
                {
                    if (!b1.IsFree && !b2.IsFree && !b3.IsFree && !b4.IsFree)
                    {
                        TurnChange();
                    }
                }
                else if (Player_Turn == 3)
                {
                    if (!y1.IsFree && !y2.IsFree && !y3.IsFree && !y4.IsFree)
                    {
                        TurnChange();
                    }
                }
                else if (Player_Turn == 4)
                {
                    if (!p1.IsFree && !p2.IsFree && !p3.IsFree && !p4.IsFree)
                    {
                        TurnChange();
                    }
                }
                else if (Player_Turn == 5)
                {
                    if (!r1.IsFree && !r2.IsFree && !r3.IsFree && !r4.IsFree)
                    {
                        TurnChange();
                    }
                }

            }
        }

        private void DiceDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void PlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NOP = 2;
            o1.Id = 0;
            o2.Id = 0;
            o3.Id = 0;
            o4.Id = 0;

            p1.Id = 1;
            p2.Id = 1;
            p3.Id = 1;
            p4.Id = 1;

            GGoti1.Visible = false;
            GGoti2.Visible = false;
            GGoti3.Visible = false;
            GGoti4.Visible = false;

            RGoti1.Visible = false;
            RGoti2.Visible = false;
            RGoti3.Visible = false;
            RGoti4.Visible = false;

            BGoti1.Visible = false;
            BGoti2.Visible = false;
            BGoti3.Visible = false;
            BGoti4.Visible = false;

            YGoti1.Visible = false;
            YGoti2.Visible = false;
            YGoti3.Visible = false;
            YGoti4.Visible = false;
        }

        private void PlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NOP = 3;

            o1.Id = 0;
            o2.Id = 0;
            o3.Id = 0;
            o4.Id = 0;

            y1.Id = 1;
            y2.Id = 1;
            y3.Id = 1;
            y4.Id = 1;

            r1.Id = 2;
            r2.Id = 2;
            r3.Id = 2;
            r4.Id = 2;


            BGoti1.Visible = false;
            BGoti2.Visible = false;
            BGoti3.Visible = false;
            BGoti4.Visible = false;

            GGoti1.Visible = false;
            GGoti2.Visible = false;
            GGoti3.Visible = false;
            GGoti4.Visible = false;

            PGoti1.Visible = false;
            PGoti2.Visible = false;
            PGoti3.Visible = false;
            PGoti4.Visible = false;


        }

        private void PlayerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NOP = 4;

            g1.Id = 0;
            g2.Id = 0;
            g3.Id = 0;
            g4.Id = 0;

            b1.Id = 1;
            b2.Id = 1;
            b3.Id = 1;
            b4.Id = 1;

            y1.Id = 2;
            y2.Id = 2;
            y3.Id = 2;
            y4.Id = 2;

            r1.Id = 3;
            r2.Id = 3;
            r3.Id = 3;
            r4.Id = 3;

            OGoti1.Visible = false;
            OGoti2.Visible = false;
            OGoti3.Visible = false;
            OGoti4.Visible = false;

            PGoti1.Visible = false;
            PGoti2.Visible = false;
            PGoti3.Visible = false;
            PGoti4.Visible = false;
        }

        private void PlayerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NOP = 5;

            RGoti1.Visible = false;
            RGoti2.Visible = false;
            RGoti3.Visible = false;
            RGoti4.Visible = false;
        }

        private void PlayerToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            NOP = 6;
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartGame();
            InitArr();
            KilledGoti = 0;
            Player_Turn = 0;
            Rolled = false;
            sara = 0;
            NOP = 6;
            TurnPic.Location = new Point(253, 273);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Mr.Rafay Mahmood");
        }

        private void PlatformUsedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C# .NET Framework");
        }

        private void SaveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveGame();
        }

        private void LoadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGame();
        }

        private void TurnPic_Click(object sender, EventArgs e)
        {

        }
    }
}

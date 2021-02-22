using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    class Blue : PictureBox
    {
        public int color = 2;
        public bool IsFree = false;
        public int NoOfMoves = 0;
        public bool GotHome = false;
        public int Id = 2;
        public int Continue = 0;
        public Blue(int a)
        {
            color = a;
        }

        public void Movement(int RandomNumber, ref int[] arr, ref int KilledGoti, PictureBox Goti)
        {
            if (RandomNumber == 6 && IsFree == false)
            {
                Goti.Location = new Point(590, 210);
                IsFree = true;
                return;
            }
            if (IsFree)
            {
                for (int i = 0; i < RandomNumber; i++)
                {
                    if (NoOfMoves + 26 + 1 > 77)
                    {
                        if (arr[Continue + 1] != color && arr[Continue + 1] != 0)
                        {
                            if (NoOfMoves + 1 == 0 || NoOfMoves + 1 == 13 || NoOfMoves + 1 == 26 || NoOfMoves + 1 == 39 || NoOfMoves + 52 == 0 || NoOfMoves + 1 == 65)
                            {
                                KilledGoti = 0;
                            }
                            else
                            {
                                KilledGoti = arr[Continue + 1];

                            }
                        }
                    }
                    else
                    {
                        if (arr[NoOfMoves + 26 + 1] != color && arr[NoOfMoves + 26 + 1] != 0)
                        {
                            if (NoOfMoves + 1 == 0 || NoOfMoves + 1 == 13 || NoOfMoves + 1 == 26 || NoOfMoves + 1 == 39 || NoOfMoves + 52 == 0 || NoOfMoves + 1 == 65)
                            {
                                KilledGoti = 0;
                            }
                            else
                            {
                                KilledGoti = arr[NoOfMoves + 26 + 1];
                            }
                        }
                    }
                    if(NoOfMoves < 4 || NoOfMoves > 30 && NoOfMoves <= 35)
                    {
                        Goti.Location = new Point(Goti.Location.X - 33, Goti.Location.Y + 20);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves == 4)
                    {
                        Goti.Location = new Point(Goti.Location.X + 0, Goti.Location.Y + 51);
                        NoOfMoves++;
                    }
                    else if ((NoOfMoves > 4 && NoOfMoves <= 9) || (NoOfMoves > 50 && NoOfMoves <= 55))
                    {
                        if (NoOfMoves == 51)
                        {
                            Goti.Location = new Point(552, 482);
                            Goti.Location.Offset(552, 482);
                        }
                        else
                        {
                            Goti.Location = new Point(Goti.Location.X + 33, Goti.Location.Y + 19);
                        }
                        NoOfMoves++;
                    }
                    else if (NoOfMoves > 9 && NoOfMoves <= 11)
                    {
                        Goti.Location = new Point(Goti.Location.X - 19, Goti.Location.Y + 31);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves > 11 && NoOfMoves <= 16 || NoOfMoves > 43 && NoOfMoves <= 48)
                    {
                        if (NoOfMoves == 12)
                        {
                            Goti.Location = new Point(552, 482);
                            Goti.Location.Offset(552, 482);
                        }
                        else
                        {
                            Goti.Location = new Point(Goti.Location.X - 34, Goti.Location.Y - 17);
                        }
                        NoOfMoves++;
                    }
                    else if (NoOfMoves == 17)
                    {
                        Goti.Location = new Point(Goti.Location.X - 51, Goti.Location.Y + 23);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves > 17 && NoOfMoves <= 22 || NoOfMoves > 63 && NoOfMoves <= 68)
                    {
                        if (NoOfMoves == 64)
                        {
                            Goti.Location = new Point(552, 482);
                            Goti.Location.Offset(552, 482);
                        }
                        else
                        {
                            Goti.Location = new Point(Goti.Location.X + 0, Goti.Location.Y + 37);
                        }
                        NoOfMoves++;
                    }
                    else if (NoOfMoves > 22 && NoOfMoves <= 24)
                    {
                        Goti.Location = new Point(Goti.Location.X - 40, Goti.Location.Y + 0);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves > 24 && NoOfMoves <= 29 || NoOfMoves > 56 && NoOfMoves <= 61)
                    {
                        if (NoOfMoves == 25)
                        {
                            Goti.Location = new Point(284, 584);
                            Goti.Location.Offset(284, 584);
                        }
                        else
                        {
                            Goti.Location = new Point(Goti.Location.X + 0, Goti.Location.Y - 38);
                        }
                        NoOfMoves++;
                    }
                    else if (NoOfMoves == 30)
                    {
                        Goti.Location = new Point(Goti.Location.X - 51, Goti.Location.Y - 23);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves == 36 || NoOfMoves == 37)
                    {
                        Goti.Location = new Point(Goti.Location.X - 26, Goti.Location.Y - 34);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves > 37 && NoOfMoves <= 42 || NoOfMoves > 69 && NoOfMoves <= 74)
                    {
                        if (NoOfMoves == 38)
                        {
                            Goti.Location = new Point(57, 414);
                            Goti.Location.Offset(57, 414);
                        }
                        else
                        {
                            Goti.Location = new Point(Goti.Location.X + 35, Goti.Location.Y - 19);
                        }
                        NoOfMoves++;
                    }
                    else if (NoOfMoves == 43)
                    {
                        Goti.Location = new Point(Goti.Location.X + 0, Goti.Location.Y - 50);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves == 49 || NoOfMoves == 50)
                    {
                        Goti.Location = new Point(Goti.Location.X + 21, Goti.Location.Y - 36);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves == 56)
                    {
                        Goti.Location = new Point(Goti.Location.X + 53, Goti.Location.Y - 25);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves == 62 || NoOfMoves == 63)
                    {
                        Goti.Location = new Point(Goti.Location.X + 40, Goti.Location.Y + 0);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves == 69)
                    {
                        Goti.Location = new Point(Goti.Location.X + 46, Goti.Location.Y + 27);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves == 75)
                    {
                        Goti.Location = new Point(Goti.Location.X + 20, Goti.Location.Y + 34);
                        NoOfMoves++;
                    }
                    else if (NoOfMoves > 75 && NoOfMoves <= 80)
                    {
                        Goti.Location = new Point(Goti.Location.X - 38, Goti.Location.Y + 19);

                        NoOfMoves++;
                    }
                    else if (NoOfMoves == 81)
                    {
                        GotHome = true;
                        Goti.Visible = false;
                    }

                    arr[NoOfMoves + 26] = color;
                    arr[NoOfMoves + 26 - 1] = 0;
                    if (NoOfMoves + 26 > 77)
                    {
                        arr[Continue] = color;
                        if (Continue == 0)
                        {
                            arr[77] = 0;
                        }
                        else
                        {
                            arr[Continue - 1] = 0;

                        }
                        Continue++;
                    }
                }
            }
        }
    }
}
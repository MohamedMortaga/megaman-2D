using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace project
{
    public class Actor
    {
        public int XD, YD, XS, YS;
        public Bitmap img;
    }
    public class Box
    {
        public int XD, YD, XS, YS, T;
        public Bitmap img;
    }
    public class Maga
    {
        public int XD, YD, XS, YS, oc = 0;
        public List<Bitmap> imgld = new List<Bitmap>();

    }

    public class Br
    {
        public int XD, YD, XS, YS, d, z;
        public int p = 0;
        public List<Bitmap> imgld = new List<Bitmap>();

    }
    public class Trees
    {
        public int X, Y;
        public Bitmap img;

    }
    public class line
    {
        public int X, Y, X2, Y2;
    }
    public class bar
    {
        public int X, Y, W, H;
    }
    public partial class Form1 : Form
    {
       
      
        Bitmap off;
        public Random RR = new Random();
        public Actor n = new Actor();
        public int jump = 0, ct = 0, id = 0, fl = -1, r = 0, ff = 0, cc = 0, ic = 15, dr = 0, fe = 0, fee = 0, ctt = 0, x = 0, oy = 0, icc = 0, ox = 0, ib = 0, ooo = 0, zo = 0, gun = 0, l = 1, dmg = 15, zz = 0, f = 0, j = 0, bhp = 0, nhp = 0, a = 0, icee = 3, ice = 3, ee = 0, h = 2, zzz = 0, ei = 20, z = 0, door = 0, c = 0, loser = 0, p = 0, k = 5, pos = 0, d = 0, lk = 0, o = 0;
        Timer tt = new Timer();
        List<Trees> L2 = new List<Trees>();
        List<Actor> L = new List<Actor>();
        List<Maga> MM = new List<Maga>();
        List<Actor> L3 = new List<Actor>();
        List<Actor> L33 = new List<Actor>();
        List<bar> L4 = new List<bar>();
        List<Maga> L5 = new List<Maga>();
        List<Maga> L6 = new List<Maga>();
        List<Br> Lb = new List<Br>();
        List<Actor> Lbb = new List<Actor>();
        List<Actor> Ls = new List<Actor>();
        List<Maga> Le = new List<Maga>();
        List<Br> Lm = new List<Br>();
        List<bar> Leb = new List<bar>();
        List<Maga> Lk = new List<Maga>();
        List<Maga> Lpom = new List<Maga>();
        List<Maga> lc = new List<Maga>();
        List<Actor> Lr = new List<Actor>();
        List<Actor> Hearts = new List<Actor>();
        List<Actor> Lboom = new List<Actor>();
        List<Actor> lg = new List<Actor>();
        List<line> Lsl = new List<line>();
        List<bar> bgun = new List<bar>();
        List<Actor> lud = new List<Actor>();
        List<Actor> wdoor = new List<Actor>();
        List<Box> Lbox = new List<Box>();
        List<Maga> dragon = new List<Maga>();
        List<bar> bd = new List<bar>();
        List<Actor> bull = new List<Actor>();

        public Form1()
        {

            this.Load += new EventHandler(Form1_Load);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.WindowState = FormWindowState.Maximized;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            bhp = ClientSize.Width / 10;
            nhp = ClientSize.Width / 10;
            if (loser != 3 || loser != 1)
            {
                tt.Tick += Tt_Tick;
                tt.Start();
            }

        }
 
        
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {        

            if (d != 2)
            {
                switch (e.KeyCode)
                {
                    case Keys.D:
                        if (L[0].XS + L[0].img.Width < ClientSize.Width - 400)
                        {


                            for (int i = 0; i < lc.Count; i++)
                            {
                                if (MM[0].XD < lc[i].XD + lc[i].imgld[0].Width && MM[0].XD + MM[0].imgld[ic].Width > lc[i].XD && MM[0].YD - MM[0].imgld[ic].Height / 2 <= lc[i].YD && MM[0].YD + MM[0].imgld[ic].Height > lc[i].YD)
                                {
                                    lc.RemoveAt(i);
                                    door++;
                                }
                            }

                            MM[0].XD += 3;
                            for (int i = 0; i < L4.Count; i++)
                            {
                                L4[i].X += 3;
                            }
                            for (int i = 0; i < Lboom.Count; i++)
                            {
                                Lboom[i].XD -= 3;
                            }
                            for (int i = 0; i < Lbox.Count; i++)
                            {
                                Lbox[i].XD -= 3;
                            }
                            for (int i = 0; i < bd.Count; i++)
                            {
                                bd[i].X -= 3;
                            }
                            for (int i = 0; i < Lbb.Count; i++)
                            {
                                Ls[i].XD -= 3;
                                Lbb[i].XD -= 3;
                                Le[i].XD -= 3;
                            }
                            for (int i = 0; i < Lm.Count; i++)
                            {
                                Lm[i].XD -= 3;
                                Leb[i].X -= 3;
                            }
                            for (int i = 0; i < Lsl.Count; i++)
                            {
                                Lsl[0].X -= 3;
                            }
                            for (int i = 0; i < dragon.Count; i++)
                            {
                                dragon[i].XD -= 3;
                            }
                            for (int i = 0; i < Lb.Count; i++)
                            {

                                Lb[i].XD -= 3;

                            }
                            for (int i = 0; i < Lr.Count; i++)
                            {
                                Lr[i].XD -= 3;
                            }
                            for (int i = 0; i < lud.Count; i++)
                            {
                                lud[i].XD -= 3;
                            }
                            for (int i = 0; i < wdoor.Count; i++)
                            {
                                wdoor[i].XD -= 3;
                            }
                            for (int i = 0; i < lg.Count; i++)
                            {
                                lg[i].XD -= 3;
                                bgun[i].X -= 3;
                            }
                            for (int i = 0; i < Lpom.Count; i++)
                            {
                                Lpom[i].XD -= 3;
                            }
                            for (int i = 0; i < lc.Count; i++)
                            {
                                lc[i].XD -= 3;
                            }
                            for (int i = 0; i < bull.Count; i++)
                            {
                                bull[i].XD -= 3;
                            }
                            for (int i = 0; i < L3.Count; i++)
                            {
                                L3[i].XD -= 3;
                            }
                            for (int i = 0; i < L33.Count; i++)
                            {
                                L33[i].XD -= 3;
                            }
                            for (int i = 0; i < L5.Count; i++)
                            {
                                L5[i].XD -= 3;
                            }
                            for (int i = 0; i < L6.Count; i++)
                            {
                                L6[i].XD -= 3;
                            }
                            ic++;
                            if (ic >= 7)
                            {
                                ic = 0;
                            }
                            L[0].XS++;

                        }
                        else
                        {
                            L[0].XD = 0;
                        }
                        ctt = 1;
                        break;
                    case Keys.A:
                        if (L[0].XS - 1 >= 0)
                        {
                            for (int i = 0; i < lc.Count; i++)
                            {
                                if (MM[0].XD > lc[i].XD + lc[i].imgld[0].Width && MM[0].XD + MM[0].imgld[ic].Width / 2 < lc[i].XD + lc[i].imgld[0].Width + MM[0].imgld[ic].Width * 3 / 4 && MM[0].YD - MM[0].imgld[ic].Height / 2 <= lc[i].YD && MM[0].YD + MM[0].imgld[ic].Height > lc[i].YD)
                                {
                                    lc.RemoveAt(i);
                                    door++;
                                }
                            }
                            MM[0].XD -= 3;
                            for (int i = 0; i < Lbb.Count; i++)
                            {
                                Lbb[i].XD += 3;
                                Ls[i].XD += 3;
                                Le[i].XD += 3;
                            }
                            for (int i = 0; i < bd.Count; i++)
                            {
                                bd[i].X += 3;
                            }
                            for (int i = 0; i < bull.Count; i++)
                            {
                                bull[i].XD += 3;
                            }
                            for (int i = 0; i <L3.Count; i++)
                            {
                                L3[i].XD += 3;
                            }
                            for (int i = 0; i < L33.Count; i++)
                            {
                                L33[i].XD += 3;
                            }
                            for (int i = 0; i < L5.Count; i++)
                            {
                                L5[i].XD += 3;
                            }
                            for (int i = 0; i < L6.Count; i++)
                            {
                                L6[i].XD += 3;
                            }
                            for (int i = 0; i < dragon.Count; i++)
                            {
                                dragon[i].XD += 3;
                            }
                            for (int i = 0; i < Lboom.Count; i++)
                            {
                                Lboom[i].XD += 3;
                            }
                            for (int i = 0; i < Lbox.Count; i++)
                            {
                                Lbox[i].XD += 3;
                            }
                            for (int i = 0; i < Lr.Count; i++)
                            {
                                Lr[i].XD += 3;
                            }
                            for (int i = 0; i < Lsl.Count; i++)
                            {
                                Lsl[0].X += 3;
                            }
                            for (int i = 0; i < lud.Count; i++)
                            {
                                lud[i].XD += 3;
                            }
                            for (int i = 0; i < Lb.Count; i++)
                            {

                                Lb[i].XD += 3;

                            }
                            for (int i = 0; i < wdoor.Count; i++)
                            {
                                wdoor[i].XD += 3;
                            }
                            for (int i = 0; i < lc.Count; i++)
                            {
                                lc[i].XD += 3;
                            }
                            for (int i = 0; i < Lm.Count; i++)
                            {
                                Lm[i].XD += 3;
                                Leb[i].X += 3;
                            }
                            for (int i = 0; i < lg.Count; i++)
                            {
                                lg[i].XD += 3;
                                bgun[i].X += 3;

                            }
                            for (int i = 0; i < L4.Count; i++)
                            {

                                L4[i].X -= 3;
                            }
                            ic++;
                            if (ic >= 14 || ic < 8)
                            {
                                ic = 8;
                            }
                            L[0].XS--;
                        }
                        ctt = 2;
                        break;

                    case Keys.Space:
                        if (jump == 0)
                        {
                            if (ctt == 1)
                            {
                                ic = 6;
                            } if (ctt == 2)
                            {
                                ic = 10;
                            }

                            jump = 1;
                        }
                        break;
                    case Keys.E:
                        ic = 14;
                        Createnarymen();
                        break;

                    case Keys.Q:
                        ic = 16;
                        Createnar4mal();
                        break;

                    case Keys.D2:
                        if (L4[1].W == ClientSize.Width / 10)
                        {
                            ic = 14;

                            L4[1].W = 0;
                            Createultymen();


                        }
                        break;

                    case Keys.D1:
                        if (L4[1].W == ClientSize.Width / 10)
                        {
                            ic = 16;

                            L4[1].W = 0;
                            Createult4mal();


                        }
                        break;
                    case Keys.W:
                        for (int i = 0; i < Le.Count; i++)
                        {
                            if (Le[i].XD - Le[i].imgld[0].Width / 2 <= MM[0].XD && Le[i].XD + Le[i].imgld[0].Width / 2 >= MM[0].XD + MM[0].imgld[ic].Width && Le[i].YD - Le[i].imgld[0].Height / 2 <= MM[0].YD && Le[i].YD + Le[i].imgld[0].Height / 2 >= MM[0].YD)
                            {
                                ee = 1;
                                ei = i;
                                break;
                            }
                        }

                        break;
                }

            }
        }
        void Createnarymen()
        {
            Actor pnn = new Actor();
            pnn.img = new Bitmap("nar.bmp");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.XD = MM[0].XD + MM[0].imgld[ic].Width;
            pnn.YD = MM[0].YD + pnn.img.Height / 2;
            pnn.XS = 0;
            pnn.YS = 0;
            L3.Add(pnn);
        }
        void Createnar4mal()
        {
            Actor pnn = new Actor();
            pnn.img = new Bitmap("nar.bmp");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.XD = MM[0].XD - MM[0].imgld[ic].Width;
            pnn.YD = MM[0].YD + pnn.img.Height / 2;
            pnn.XS = 0;
            pnn.YS = 0;
            L33.Add(pnn);
        }
        void Createultymen()
        {
            Maga pnn = new Maga();
            for (int i = 1; i <= 5; i++)
            {
                int k = i + i * 10;
                Bitmap m1 = new Bitmap(k + ".bmp");
                m1.MakeTransparent(m1.GetPixel(0, 0));
                pnn.imgld.Add(m1);
            }

            pnn.XD = MM[0].XD + MM[0].imgld[ic].Width;
            pnn.YD = MM[0].YD + ClientSize.Width / 50 / 2;
            pnn.XS = 0;
            pnn.YS = 0;
            L5.Add(pnn);
        }
        void Createult4mal()
        {
            Maga pnn = new Maga();
            for (int i = 1; i <= 5; i++)
            {
                int k = i + i * 10;
                Bitmap m1 = new Bitmap(k + ".bmp");
                m1.MakeTransparent(m1.GetPixel(0, 0));
                pnn.imgld.Add(m1);
            }
            pnn.XD = MM[0].XD - MM[0].imgld[ic].Width;
            pnn.YD = MM[0].YD + ClientSize.Width / 50 / 2;
            pnn.XS = 0;
            pnn.YS = 0;
            L6.Add(pnn);
        }
        void CreateLine()
        {
            line l = new line();
            if (MM[0].XD < lg[0].XD)
            {
                l.X = lg[0].XD;

            }
            else
            {
                l.X = lg[0].XD + lg[0].img.Width - 10;
            }

            l.Y = lg[0].YD + 20;

            l.Y2 = MM[0].YD;
            l.X2 = MM[0].XD;
            Lsl.Add(l);
        }

        void CreateDragon()
        {
            Maga Drag = new Maga();
            for (int i = 1; i <= 3; i++)
            {
                Bitmap m1 = new Bitmap("dragon" + i + ".bmp");
                m1.MakeTransparent(m1.GetPixel(0, 0));
                Drag.imgld.Add(m1);
            }
            for (int i = 4; i <= 6; i++)
            {
                Bitmap m1 = new Bitmap("dragon" + i + ".bmp");
                m1.MakeTransparent(m1.GetPixel(0, 0));
                Drag.imgld.Add(m1);
            }
            Drag.XD = ClientSize.Width/4;
            Drag.YD = ClientSize.Height - L2[0].img.Height - Drag.imgld[0].Height;
            Drag.XS = 0;
            Drag.YS = 0;
            dragon.Add(Drag);

            bar pnn7 = new bar();
            pnn7.W = Drag.imgld[0].Width + Drag.imgld[0].Width + Drag.imgld[0].Width;
            pnn7.X = Drag.XD - Drag.imgld[0].Width  *3/ 4;
            pnn7.H = ClientSize.Height * 1 / 100;
            pnn7.Y = Drag.YD;
            bd.Add(pnn7);
        }
        void Createbullet()
        {
            Actor pnn = new Actor();


            if (id < 3)
            {
                pnn.img = new Bitmap("bullet.bmp");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                pnn.XD = dragon[0].XD + dragon[0].imgld[0].Width + 50;
            }
            else
            {
                pnn.img = new Bitmap("bull.bmp");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                pnn.XD = dragon[0].XD - 5;
            }
            pnn.YD = dragon[0].YD + 50;
            pnn.XS = 0;
            pnn.YS = 0;
            bull.Add(pnn);
        }
        void Tt_Tick(object sender, EventArgs e)
        {
            if (door==5 && fl == -1)
            {
                CreateDragon();
                fl = 1;
            }
            if (dragon.Count != 0)
            {

                if (dragon.Count != 0)
                {
                    for (int i = 0; i < L3.Count; i++)
                    {

                        if (L3[i].XD > dragon[0].XD && L3[i].XD + L3[i].img.Width < dragon[0].XD + dragon[0].imgld[0].Width && L3[i].YD > dragon[0].YD && L3[i].YD + L3[i].img.Height < dragon[0].YD + dragon[0].imgld[0].Height + 60)
                        {
                            bd[0].W -= 20;

                            L3.RemoveAt(i);

                        }

                    }

                    for (int i = 0; i < L5.Count; i++)
                    {
                        if (L5[i].XD > dragon[0].XD && L5[i].XD + L5[i].imgld[0].Width < dragon[0].XD + dragon[0].imgld[0].Width && L5[i].YD > dragon[0].YD && L5[i].YD + L5[i].imgld[0].Height < dragon[0].YD + dragon[0].imgld[0].Height + 60)
                        {
                            bd[0].W -= 40;

                            L5.RemoveAt(i);
                        }

                    }


                    for (int i = 0; i < L6.Count; i++)
                    {
                        if (L6[i].XD > dragon[0].XD && L6[i].XD + L6[i].imgld[0].Width < dragon[0].XD + dragon[0].imgld[0].Width && L6[i].YD > dragon[0].YD && L6[i].YD + L6[i].imgld[0].Height < dragon[0].YD + dragon[0].imgld[0].Height + 30)
                        {

                            bd[0].W -= 40;

                            L6.RemoveAt(i);

                        }


                    }

                    for (int i = 0; i < L33.Count; i++)
                    {
                        if (L33[i].XD > dragon[0].XD && L33[i].XD + L33[i].img.Width < dragon[0].XD + dragon[0].imgld[0].Width && L33[i].YD > dragon[0].YD && L33[i].YD + L33[i].img.Height < dragon[0].YD + dragon[0].imgld[0].Height + 60)
                        {
                            bd[0].W -= 20;

                            L33.RemoveAt(i);
                        }

                    }
                }

                for (int i = 0; i < bull.Count; i++)
                {
                    if (bull[i].XD > MM[0].XD && bull[i].XD + bull[i].img.Width < MM[0].XD + MM[0].imgld[ic].Width * 2 && bull[i].YD > MM[0].YD - 20 && bull[i].YD + bull[i].img.Height < MM[0].YD + MM[0].imgld[ic].Height + 40)
                    {
                        L4[0].W -= L4[0].W / 4;
                        bull.RemoveAt(i);
                    }
                }

                for (int i = 0; i < bull.Count; i++)
                {
                    if (bull[i].XD > dragon[0].XD)
                    {
                        bull[i].XD += 20;
                    }
                    else
                    {
                        bull[i].XD -= 20;
                    }
                }
                if (gun == 6 && fl != -1 && ff == 0)
                {
                    r = RR.Next(15, 20);
                    ff = 1;
                }
                if (cc == r && dragon.Count != 0 && dr <= 6)
                {
                    fe = 0;
                    Createbullet();
                    cc = 0;
                    ff = 0;
                }
                if (cc != r)
                {
                    cc++;
                }
             
                if (fl == 2 && fe != 0 && dr <= 3)
                {
                    dragon[0].XD += 8;
                    bd[0].X += 8;
                    id = RR.Next(0, 3);
                    fe--;
                }
                if (fl == 2 && fe != 0 && dr <= 6 && dr > 3)
                {
                    dragon[0].XD -= 8;
                    bd[0].X -= 8;
                    id = RR.Next(3, 6);
                    fe--;
                }
                if (fl == 2 && fe > fee && dr <= 9 && dr > 6)
                {
                    dragon[0].XD -= 5;
                    dragon[0].YD -= 8;
                    bd[0].X -= 5;
                    bd[0].Y -= 8;
                    id = 5;
                    fe--;
                }
                if (fl == 2 && fe <= fee && dr <= 9 && dr > 6)
                {
                    dragon[0].XD -= 5;
                    dragon[0].YD += 8;
                    bd[0].X -= 5;
                    bd[0].Y += 8;
                    id = 5;
                    fe--;
                }
                if (fl == 2 && fe >= fee && dr <= 12 && dr > 9)
                {
                    dragon[0].XD += 5;
                    dragon[0].YD -= 8;
                    bd[0].X += 5;
                    bd[0].Y -= 8;
                    id = 2;
                    fe--;
                }
                if (fl == 2 && fe < fee && dr <= 12 && dr > 9)
                {
                    dragon[0].XD += 5;
                    dragon[0].YD += 8;
                    bd[0].X += 5;
                    bd[0].Y += 8;
                    id = 2;
                    fe--;
                }
                if (fe == 0)
                {
                    dragon[0].YD = ClientSize.Height - L2[0].img.Height - dragon[0].imgld[0].Height;
                    bd[0].Y = dragon[0].YD;
                    fl = 1;
                }
                if (fl == 1)
                {
                    fe = RR.Next(20, 40);
                    fee = fe / 2;
                    dr = RR.Next(0, 12);
                    fl = 2;
                }
                if (bd[0].W <= 0)
                {
                 
                    gun = 6;
                }
            }
            if (gun == 6)
            {
                for (int i = 0; i < dragon.Count; i++)
                {
                    dragon.RemoveAt(i);
                }
                for (int i = 0; i < bd.Count; i++)
                {
                    bd.RemoveAt(i);
                }
                for (int i = 0; i < bull.Count; i++)
                {
                    bull.RemoveAt(i);
                }
            }
            if (loser != 3 || loser != 1)
            {

                if (bgun.Count != 0)
                {
                    if (bgun[0].W <= 0)
                    {
                        lg.RemoveAt(0);
                        bgun.RemoveAt(0);
                        gun = 5;
                    }
                }

                if (lud.Count != 0 && gun == 5)
                {
                    if (MM[0].YD + MM[0].imgld[ic].Height < lud[1].YD && MM[0].XD > lud[1].XD && MM[0].imgld[ic].Width < lud[1].img.Width)
                    {
                        MM[0].YD = lud[1].YD - lud[1].img.Height - L2[0].img.Height - 30;
                        L4[0].Y = lud[1].YD - lud[1].img.Height - L2[0].img.Height - 50;
                        L4[1].Y = lud[1].YD - lud[1].img.Height - L2[0].img.Height - 50 - ClientSize.Height * 1 / 100;
                        ic = 15;
                        d = 2;
                    }
                    if (d == 2 && lud[1].YD > lud[0].YD && MM[0].XD > lud[1].XD)
                    {
                        MM[0].YD -= 6;
                        L4[0].Y -= 6;
                        L4[1].Y -= 6;
                        lud[1].YD -= 6;
                    }
                    if (lud[1].YD < lud[0].YD)
                    {
                        lud[1].YD = lud[0].YD;

                    }
                    if (lud[1].YD == lud[0].YD)
                    {
                        loser = 3;
                        DrawDubb(CreateGraphics());
                    }
                }

                if (c % 20 == 0 && door == 5 && c != 0 && gun == 1)
                {
                    if (lg.Count != 0)
                    {
                        CreateLine();
                        a = 1;
                        L4[0].W -= dmg;
                        dmg += 5;
                        DrawDubb(CreateGraphics());
                    }
                }
                if (c % 20 == 0 && door == 5 && c != 0 && a == 1)
                {
                    if (Lsl.Count != 0)
                    {
                        for (int i = 0; i < Lsl.Count; i++)
                        {

                            Lsl.RemoveAt(i);

                        }
                    }
                }
                if (loser == 0)
                {
                    if (bhp != nhp)
                    {
                        bhp = nhp;
                    }
                    for (int i = 0; i < Lr.Count; i++)
                    {
                        if (MM[0].XD - 30 <= Lr[i].XD & MM[0].XD + MM[0].imgld[ic].Width + 60 >= Lr[i].XD + Lr[i].img.Width && MM[0].YD >= Lr[0].YD - 20)
                        {
                            ic = 17;
                            L4[0].W -= 5;

                        }
                    }

                    if (L4[0].W <= 0)
                    {
                        ic = 18;
                        if (c % 10 == 0)
                        {
                            if (Hearts.Count != 0)
                            {
                                Hearts.RemoveAt(Hearts.Count - 1);
                            }

                            if (Hearts.Count == 0)
                            {
                                loser = 1;
                            }
                            else
                            {
                                L4[0].W = ClientSize.Width / 10;

                            }
                        }

                    }

                    if (door == 5 && gun==6)
                    {
                        gun = 1;
                    }

                    if (gun == 1)
                    {
                        if (gun == 1 && door == 5 && a == 1)
                        {
                            for (int i = 0; i < L3.Count; i++)
                            {
                                if (lg.Count != 0)
                                {

                                    if (gun == 1 && door == 5)
                                    {
                                        if (L3[i].XD > lg[0].XD && L3[i].XD + L3[i].img.Width >= L3[i].XD && L3[i].YD <= lg[0].YD && L3[i].YD + L3[i].img.Height >= lg[0].YD + lg[0].img.Height)
                                        {
                                            bgun[0].W -= 20;

                                            L3.RemoveAt(i);

                                        }
                                    }
                                }
                            }


                            if (gun == 1 && door == 5 && a == 1)
                            {
                                for (int i = 0; i < L5.Count; i++)
                                {


                                    if (lg.Count != 0)
                                    {

                                        if (MM[0].XD <= lg[0].XD && L5[i].XD >= lg[0].XD && L5[i].YD + 5 <= lg[0].YD && L5[i].YD + L5[i].imgld[0].Height <= lg[0].YD + lg[0].img.Height + lg[0].img.Height)
                                        {
                                            bgun[0].W -= 40;

                                            L5.RemoveAt(i);

                                        }
                                    }

                                }
                            }
                            if (gun == 1 && door == 5 && a == 1)
                            {
                                for (int i = 0; i < L6.Count; i++)
                                {

                                    if (lg.Count != 0)
                                    {

                                        if (MM[0].XD >= lg[0].XD && L6[i].XD >= lg[0].XD && L6[i].YD + 5 <= lg[0].YD && L6[i].YD + L6[i].imgld[0].Height <= lg[0].YD + lg[0].img.Height + lg[0].img.Height)
                                        {
                                            bgun[0].W -= 40;

                                            L6.RemoveAt(i);

                                        }
                                    }
                                }

                            }
                            if (gun == 1 && door == 5 && a == 1)
                            {
                                for (int i = 0; i < L33.Count; i++)
                                {

                                    if (lg.Count != 0)
                                    {
                                        if (L33[i].XD > lg[0].XD && L33[i].XD + L33[i].img.Width >= L33[i].XD && L33[i].YD <= lg[0].YD && L33[i].YD + L33[i].img.Height >= lg[0].YD + lg[0].img.Height)
                                        {

                                            bgun[0].W -= 20;

                                            L33.RemoveAt(i);

                                        }
                                    }

                                }

                            }
                        }
                    }




                    for (int i = 0; i < Lbb.Count; i++)
                    {
                        if (MM[0].XD < Lbb[i].XD && MM[0].XD <= Lbb[i].XD + Lbb[i].img.Width && MM[0].XD - MM[0].imgld[ic].Width <= Lbb[i].XD && MM[0].XD + MM[0].imgld[ic].Width >= Lbb[i].XD && MM[0].YD - MM[0].imgld[ic].Height <= Lbb[i].YD + Lbb[i].img.Height)
                        {
                            d = 1;
                            break;
                        }
                        if (MM[0].XD <= Lbb[i].XD + Lbb[i].img.Width && MM[0].imgld[ic].Width + MM[0].XD >= Lbb[i].XD + Lbb[i].img.Width && MM[0].XD >= Lbb[i].XD + Lbb[i].img.Width - MM[0].imgld[ic].Width && MM[0].YD - MM[0].imgld[ic].Height <= Lbb[i].YD + Lbb[i].img.Height)
                        {
                            d = 3;
                            break;
                        }
                    }
                    if (d == 1 || d == 2 || d == 3)
                    {
                        if (jump == 0)
                        {
                            L4[1].Y += 20;
                            L4[0].Y += 20;
                            MM[0].YD += 20;

                            if (d == 1)
                            {
                                ic = 10;
                            }
                            if (d == 3)
                            {
                                ic = 3;
                            }
                        }
                        d = 2;
                    }


                    if (d == 2 && MM[0].YD >= L2[0].Y - MM[0].imgld[ic].Height * 2 || d == 2 && MM[0].YD >= L2[0].Y - MM[0].imgld[ic].Height * 2)
                    {
                        if (jump == 0)
                        {
                            MM[0].YD = ClientSize.Height - (L2[0].img.Height * 3) + L2[0].img.Height * 1 / 5;
                            L4[0].Y = MM[0].YD - ClientSize.Height * 1 / 100;
                            L4[1].Y = MM[0].YD - ClientSize.Height * 1 / 50;
                            ic = 15;
                        }
                        d = 0;
                    }



                    if (c % 100 == 0)
                    {
                        L4[1].W = ClientSize.Width / 10;
                    }
                    if (c % 2 == 0)
                    {
                        for (int i = 0; i < Lm.Count; i++)
                        {
                            if (Lm[i].XD - Lm[i].imgld[0].Width / 2 <= MM[0].XD && Lm[i].XD + Lm[i].imgld[0].Width / 2 >= MM[0].XD && Lm[i].YD - Lm[i].imgld[0].Height <= MM[0].YD && Lm[i].YD + Lm[i].imgld[0].Height >= MM[0].YD + MM[0].imgld[ic].Height)
                            {

                                L4[0].W -= 20;
                                ic = 17;


                            }

                            if (Lm[i].d == 0)
                            {
                                Lm[i].XD -= 3;
                                Leb[i].X -= 3;

                                if (Lm[i].z == 7)
                                {
                                    Lm[i].z = 5;
                                }
                                if (Lm[i].z < 7)
                                {
                                    Lm[i].z++;

                                }
                                if (Lm[i].XD <= Lbb[Lm[i].p].XD + Lm[i].imgld[o].Width / 4)
                                {
                                    Lm[i].d = 1;
                                    Lm[i].z = 0;
                                }



                            }

                            if (Lm[i].d == 1)
                            {
                                Lm[i].XD += 3;
                                Leb[i].X += 3;

                                if (Lm[i].z == 3)
                                {
                                    Lm[i].z = 0;
                                }
                                if (Lm[i].z == 2)
                                {
                                    Lm[i].z = 3;
                                }
                                if (Lm[i].z == 1)
                                {
                                    Lm[i].z = 2;
                                }
                                if (Lm[i].z == 0)
                                {
                                    Lm[i].z = 1;
                                }
                                if (Lm[i].XD >= Lbb[Lm[i].p].XD + Lbb[Lm[i].p].img.Width * 3 / 4)
                                {
                                    Lm[i].d = 0;
                                    Lm[i].z = 4;
                                }
                            }

                        }
                    }
                    c++;
                    if (ee == 1)
                    {

                        if (l == 3)
                        {
                            icee = 0;
                        }
                        if (l == 6)
                        {
                            icee = 1;
                        }
                        if (l == 9)
                        {
                            icee = 2;
                        }
                        if (l == 12)
                        {
                            icee = 3;
                        }

                        if (l == 15)
                        {
                            MM[0].YD = Lbb[ei].YD - MM[0].imgld[0].Height * 2 + MM[0].imgld[ic].Height / 15;
                            L4[1].Y = Lbb[ei].YD - MM[0].imgld[0].Height * 2 + MM[0].imgld[ic].Height / 15 - L4[1].H;
                            L4[0].Y = Lbb[ei].YD - MM[0].imgld[0].Height * 2 + L4[0].H - L4[1].H + MM[0].imgld[ic].Height / 15;
                            ic = 13;
                            l = 0;
                            icee = 3;
                            ei = 20;
                            ee = 0;
                        }
                    }
                    if (ee == 1)
                    {
                        l++;
                    }

                    if (jump == 1)
                    {
                        MM[0].YD -= 6;
                        for (int i = 0; i < L4.Count; i++)
                        {
                            L4[i].Y -= 6;
                        }

                     
                        for (int i = 0; i < lg.Count; i++)
                        {
                            lg[i].YD += 2;
                            bgun[i].Y += 2;

                        }
                        for (int i = 0; i < lud.Count; i++)
                        {
                            lud[i].YD += 2;
                        }
                        for (int i = 0; i < Lb.Count; i++)
                        {
                            Lb[i].YD += 2;

                        }
                        for (int i = 0; i < dragon.Count; i++)
                        {
                            dragon[i].YD += 2;
                        }
                        for (int i = 0; i < wdoor.Count; i++)
                        {
                            wdoor[i].YD += 2;
                        }
                        for (int i = 0; i < Lboom.Count; i++)
                        {
                            Lboom[i].YD += 2;
                        }
                        for (int i = 0; i < Lbox.Count; i++)
                        {
                            Lbox[i].YD += 2;
                        }
                        for (int i = 0; i < Lr.Count; i++)
                        {
                            Lr[i].YD += 2;
                        }

                        for (int i = 0; i < Lpom.Count; i++)
                        {
                            Lpom[i].YD += 2;
                        }
                        for (int i = 0; i < Lsl.Count; i++)
                        {
                            Lsl[0].Y += 2;
                        }
                        for (int i = 0; i < bd.Count; i++)
                        {
                            bd[i].Y += 2;
                        }
                        for (int i = 0; i < lc.Count; i++)
                        {
                            lc[i].YD += 2;
                        }
                        for (int i = 0; i < L3.Count; i++)
                        {
                            L3[i].YD += 2;
                        }
                        for (int i = 0; i < L33.Count; i++)
                        {
                            L33[i].YD += 2;
                        }
                        for (int i = 0; i < L5.Count; i++)
                        {
                            L5[i].YD += 2;
                        }
                        for (int i = 0; i < L6.Count; i++)
                        {
                            L6[i].YD += 2;
                        }
                        for (int i = 0; i < Lbb.Count; i++)
                        {
                            Lbb[i].YD += 2;
                            Ls[i].YD += 2;

                            Le[i].YD += 2;
                        }
                        for (int i = 0; i < Lm.Count; i++)
                        {
                            Lm[i].YD += 2;
                            Leb[i].Y += 2;
                        }
                        for (int i = 0; i < bull.Count; i++)
                        {
                            bull[i].YD += 2;
                        }
                        L[0].YS -= 2;
                        for (int i = 0; i < L2.Count; i++)
                        {
                            L2[i].Y += 2;
                        }


                        if (ctt == 3)
                        {
                            ic = 13;
                        }

                        if (ctt == 1)
                        {
                            ic = 6;
                        }
                        if (ctt == 2)
                        {
                            ic = 10;
                        }
                        ct++;
                    }
                    if (ct >= 15 && ct < 30)
                    {
                        jump = 2;
                        MM[0].YD += 6;
                        for (int i = 0; i < L4.Count; i++)
                        {
                            L4[i].Y += 6;
                        }
                        for (int i = 0; i < dragon.Count; i++)
                        {
                            dragon[i].YD -= 2;
                        }
                        for (int i = 0; i < lud.Count; i++)
                        {
                            lud[i].YD -= 2;
                        }
                        for (int i = 0; i < L3.Count; i++)
                        {
                            L3[i].YD -= 2;
                        }
                        for (int i = 0; i < L33.Count; i++)
                        {
                            L33[i].YD -= 2;
                        }
                        for (int i = 0; i < L5.Count; i++)
                        {
                            L5[i].YD -= 2;
                        }
                        for (int i = 0; i < L6.Count; i++)
                        {
                            L6[i].YD -= 2;
                        }
                        for (int i = 0; i < bd.Count; i++)
                        {
                           bd[i].Y -= 2;
                        }
                        for (int i = 0; i < bull.Count; i++)
                        {
                            bull[i].YD -= 2;
                        }
                        for (int i = 0; i < wdoor.Count; i++)
                        {
                            wdoor[i].YD -= 2;
                        }
                        for (int i = 0; i < lg.Count; i++)
                        {
                            lg[i].YD -= 2;
                            bgun[i].Y -= 2;
                        }
                        for (int i = 0; i < Lb.Count; i++)
                        {
                            Lb[i].YD -= 2;

                        }
                        for (int i = 0; i < Lsl.Count; i++)
                        {
                            Lsl[0].Y -= 2;
                        }
                        for (int i = 0; i < Lboom.Count; i++)
                        {
                            Lboom[i].YD -= 2;
                        }
                        for (int i = 0; i < Lbox.Count; i++)
                        {
                            Lbox[i].YD -= 2;
                        }
                        for (int i = 0; i < Lpom.Count; i++)
                        {
                            Lpom[i].YD -= 2;
                        }
                        for (int i = 0; i < Lr.Count; i++)
                        {
                            Lr[i].YD -= 2;
                        }

                        for (int i = 0; i < lc.Count; i++)
                        {
                            lc[i].YD -= 2;
                        }
                        for (int i = 0; i < Lbb.Count; i++)
                        {
                            Lbb[i].YD -= 2;
                            Ls[i].YD -= 2;

                            Le[i].YD -= 2;

                        }

                        for (int i = 0; i < Lm.Count; i++)
                        {
                            Lm[i].YD -= 2;
                            Leb[i].Y -= 2;
                        }
                        L[0].YS += 2;
                        for (int i = 0; i < L2.Count; i++)
                        {
                            L2[i].Y -= 2;
                        }
                        if (ctt == 3)
                        {
                            ic = 13;
                        }
                        if (ctt == 1)
                        {
                            ic = 6;
                        } if (ctt == 2)
                        {
                            ic = 10;
                        }
                        ct++;
                    }
                    if (ct == 30)
                    {
                        ct = 0;
                        jump = 0;
                    }
                    int y = 0;
                    for (int i = 0; i < L3.Count; i++)
                    {
                        for (int g = 0; g < Lm.Count; g++)
                        {
                            if (MM[0].XD <= Lm[g].XD && L3[i].XD >= Lm[g].XD && L3[i].YD >= Lm[g].YD && L3[i].YD + L3[i].img.Height <= Lm[g].YD + Lm[g].imgld[0].Height + Lm[g].imgld[0].Height / 2)
                            {
                                Leb[g].W -= 20;
                                if (Leb[g].W <= 0)
                                {
                                    ox = Lm[g].XD;
                                    oy = Lm[g].YD;
                                    CreatePom();
                                    Leb.RemoveAt(g);

                                    Lm.RemoveAt(g);

                                    k++;
                                } y = 1;
                            }

                        }
                        if (y == 0)
                        {
                            L3[i].XD += 20;
                        }
                        else
                        {
                            L3.RemoveAt(i);
                            y = 0;
                            i++;
                        }
                    }
                    y = 0;
                    for (int i = 0; i < L33.Count; i++)
                    {
                        for (int g = 0; g < Lm.Count; g++)
                        {
                            if (MM[0].XD >= Lm[g].XD && L33[i].XD <= Lm[g].XD && L33[i].YD >= Lm[g].YD && L33[i].YD + L33[i].img.Height <= Lm[g].YD + Lm[g].imgld[0].Height + Lm[g].imgld[0].Height / 2)
                            {
                                Leb[g].W -= 20;
                                if (Leb[g].W <= 0)
                                {
                                    ox = Lm[g].XD;
                                    oy = Lm[g].YD;
                                    CreatePom();
                                    Leb.RemoveAt(g);
                                    Lm.RemoveAt(g);

                                    k++;
                                }
                                y = 1;
                            }
                        }
                        if (y == 0)
                        {
                            L33[i].XD -= 20;
                        }
                        else
                        {
                            L33.RemoveAt(i);
                            y = 0;
                            i++;
                        }

                    }

                    y = 0;
                    for (int i = 0; i < L5.Count; i++)
                    {
                        for (int g = 0; g < Lm.Count; g++)
                        {
                            if (MM[0].XD <= Lm[g].XD && L5[i].XD >= Lm[g].XD && L5[i].YD >= Lm[g].YD && L5[i].YD + L5[i].imgld[0].Height <= Lm[g].YD + Lm[g].imgld[0].Height + Lm[g].imgld[0].Height / 2)
                            {
                                Leb[g].W -= 70;

                                if (Leb[g].W <= 0)
                                {
                                    ox = Lm[g].XD;
                                    oy = Lm[g].YD;
                                    CreatePom();
                                    Leb.RemoveAt(g);
                                    Lm.RemoveAt(g);

                                    k++;
                                }
                                y = 1;
                            }

                        }
                        if (y == 0)
                        {
                            L5[i].XD += 30;
                        }
                        else
                        {
                            L5.RemoveAt(i);
                            y = 0;
                            i++;
                        }

                    }
                    y = 0;
                    for (int i = 0; i < L6.Count; i++)
                    {
                        for (int g = 0; g < Lm.Count; g++)
                        {
                            if (MM[0].XD >= Lm[g].XD && L6[i].XD <= Lm[g].XD && L6[i].YD >= Lm[g].YD && L6[i].YD + L6[i].imgld[0].Height <= Lm[g].YD + Lm[g].imgld[0].Height + Lm[g].imgld[0].Height / 2)
                            {
                                Leb[g].W -= 70;
                                if (Leb[g].W <= 0)
                                {
                                    ox = Lm[g].XD;
                                    oy = Lm[g].YD;
                                    CreatePom();
                                    Leb.RemoveAt(g);
                                    Lm.RemoveAt(g);

                                    k++;
                                }
                                y = 1;
                            }

                        }
                        if (y == 0)
                        {
                            L6[i].XD -= 30;
                        }
                        else
                        {
                            L6.RemoveAt(i);
                            y = 0;
                            i++;
                        }

                    }
                    poommove();
                    Boxmove();
                    for (int g = 0; g < Lboom.Count; g++)
                    {
                        if (
                            MM[0].YD >= Lboom[g].YD && MM[0].XD - 25 <= Lboom[g].XD && MM[0].XD + MM[0].imgld[ic].Width + 50 >= Lboom[g].XD + Lboom[g].img.Width && MM[0].YD + MM[0].imgld[ic].Height <= Lboom[g].img.Height + Lboom[g].YD + 6
                            ||
                             MM[0].YD >= (L2[0].Y - L2[0].img.Height - 1) - MM[0].imgld[ic].Height && L2[0].Y - L2[0].img.Height - 1 == Lboom[g].YD && MM[0].XD <= Lboom[g].XD && MM[0].XD + MM[0].imgld[ic].Width + 50 >= Lboom[g].XD + Lboom[g].img.Width
                            )
                        {
                            L4[0].W -= 100;
                            Lboom.RemoveAt(g);

                        }

                    }
                    for (int g = 0; g < Lbox.Count; g++)
                    {
                        if (MM[0].YD >= Lbox[g].YD && MM[0].XD - 25 <= Lbox[g].XD && MM[0].XD + MM[0].imgld[ic].Width + 50 >= Lbox[g].XD + Lbox[g].img.Width && MM[0].YD + MM[0].imgld[ic].Height <= Lbox[g].img.Height + Lbox[g].YD + 25
                            ||
                             MM[0].YD >= (L2[0].Y - L2[0].img.Height - 1) - MM[0].imgld[ic].Height && L2[0].Y - L2[0].img.Height - 1 == Lbox[g].YD && MM[0].XD <= Lbox[g].XD && MM[0].XD + MM[0].imgld[ic].Width + 100 >= Lbox[g].XD + Lbox[g].img.Width
                            )
                        {
                            if (Lbox[g].T == 0)
                            {
                                L4[1].W = ClientSize.Width / 10;
                            }
                            else
                            {
                                L4[0].W += (ClientSize.Width / 10) / 3;
                            }
                            Lbox.RemoveAt(g);

                        }

                    }
                    for (int i = 0; i < Lb.Count; i++)
                    {
                        if (Lb[i].d == 0)
                        {
                            Lb[i].XD -= 3;
                            ib = RR.Next(0, 4);
                        }
                        if (Lb[i].d == 1)
                        {
                            Lb[i].XD += 3;
                            ib = RR.Next(0, 4);

                        }

                    }
                    if (icc < 4)
                    {
                        icc++;
                    }
                    else
                    {
                        icc = 0;
                    }


                }

                if (c % 2 == 0)
                {
                    for (int i = 0; i < Lpom.Count; i++)
                    {
                        lk++;
                    }

                }
                if (lk == 3)
                {
                    lk = 0;
                    Createcoin();
                    for (int i = 0; i < Lpom.Count; i++)
                    {
                        Lpom.RemoveAt(i);
                    }

                }


                for (int i = 0; i < lc.Count; i++)
                {
                    if (lc[i].oc != 4)
                    {

                        lc[i].oc++;
                    }
                    else
                    {
                        lc[i].oc = 0;
                    }
                }
                if (c % 30 == 0)
                {

                    Createboom();
                }
                if (c % 43 == 0)
                {

                    CreateBox();
                }

                nhp = L4[0].W;
                if (c != 0 && bhp > nhp)
                {
                    ic = 17;
                }
                if (d == 1)
                {
                    ic = 10;
                }
                if (d == 3)
                {
                    ic = 3;
                }
                DrawDubb(CreateGraphics());
            }
        }
        void poommove()
        {
            for (int i = 0; i < Lboom.Count; i++)
            {
                if (Lboom[i].YD < L2[0].Y && Lboom[i].YD + Lboom[i].img.Height > L2[0].Y - 30)
                {
                    Lboom[i].YD = L2[0].Y - L2[0].img.Height - 1;
                }
                else
                {
                    Lboom[i].YD += 5;
                }
            }
        }
        void Boxmove()
        {
            for (int i = 0; i < Lbox.Count; i++)
            {
                if (Lbox[i].YD < L2[0].Y && Lbox[i].YD + Lbox[i].img.Height > L2[0].Y - 30)
                {
                    Lbox[i].YD = L2[0].Y - L2[0].img.Height - 1;
                }
                else
                {
                    Lbox[i].YD += 5;
                }
            }
        }
        void Createcoin()
        {
            Maga pnn = new Maga();
            for (int i = 1; i < 6; i++)
            {
                Bitmap m1 = new Bitmap(i + "c.bmp");
                m1.MakeTransparent(m1.GetPixel(0, 0));
                pnn.imgld.Add(m1);
            }

            pnn.XD = ox;
            pnn.YD = oy;
            pnn.XS = 0;
            pnn.oc = 0;
            pnn.YS = 0;
            lc.Add(pnn);
        }
        void CreatePom()
        {


            Maga pnn = new Maga();
            for (int i = 1; i <= 4; i++)
            {
                Bitmap m1 = new Bitmap(i + "p.bmp");
                m1.MakeTransparent(m1.GetPixel(0, 0));
                pnn.imgld.Add(m1);
            }

            pnn.XD = ox;
            pnn.YD = oy;
            pnn.XS = 0;
            pnn.YS = 0;
            Lpom.Add(pnn);

        }

        void CreatebarUpDown()
        {
            zo++;
            if (zo >= 1)
            {
                Actor pnn = new Actor();
                pnn.YS = 0;
                pnn.XS = 0;
                pnn.img = new Bitmap("enbar.bmp");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                if (zo == 1)
                {
                    pnn.XD = L[0].img.Width + L[0].img.Width + L[0].img.Width - 100;
                    pnn.YD = L[0].img.Height * 7 / 10;
                }
                if (zo == 2)
                {
                    pnn.XD = L[0].img.Width + L[0].img.Width + L[0].img.Width - 100;
                    pnn.YD = ClientSize.Height - L2[0].img.Height - pnn.img.Height;
                }
                lud.Add(pnn);
            }
        }
        void Createwinnrdoor()
        {
            Actor pnn = new Actor();
            pnn.YS = 0;
            pnn.XS = 0;
            pnn.img = new Bitmap("3dd.bmp");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.XD = L[0].img.Width + L[0].img.Width + L[0].img.Width - 100;
            pnn.YD = L[0].img.Height * 7 / 10 - pnn.img.Height;

            wdoor.Add(pnn);
        }
        void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb(e.Graphics);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            CreateMap();
            for (int i = 0; i < 10; i++)
            {
                CreateHearts();
            }
            while (x < Location.X + ClientSize.Width)
            {
                CreateTrees();

            }
            for (int i = 0; i < 2; i++)
            {
                CreatebarUpDown();

            }
            Createwinnrdoor();
            CreateMagaman();
            for (int i = 0; i < 15; i++)
            {
                Createbirds();
            }
            for (int i = 0; i < 5; i++)
            {
                Createbands();
            }
            for (int i = 0; i < 6; i++)
            {
                CreateR();
            }

        }
        void Createboom()
        {
            Actor pnn1 = new Actor();
            pnn1.img = new Bitmap("boom.bmp");
            pnn1.img.MakeTransparent(pnn1.img.GetPixel(0, 0));
            int num = RR.Next(0, ClientSize.Width + ClientSize.Width + ClientSize.Width);
            pnn1.XD = num;
            pnn1.YD = 0;
            pnn1.YS = 0;
            pnn1.XS = 0;
            Lboom.Add(pnn1);

        }
        void CreateBox()
        {
            Box pnn1 = new Box();
            pnn1.T = RR.Next(0, 2);
            if (pnn1.T == 0)
            {
                pnn1.img = new Bitmap("1box.bmp");
            }
            else
            {
                pnn1.img = new Bitmap("2box.bmp");
            }
            pnn1.img.MakeTransparent(pnn1.img.GetPixel(0, 0));
            int num = RR.Next(0, ClientSize.Width + ClientSize.Width + ClientSize.Width);
            pnn1.XD = num;
            pnn1.YD = 0;
            pnn1.YS = 0;
            pnn1.XS = 0;
            Lbox.Add(pnn1);

        }
        void CreateHearts()
        {
            Actor pnn1 = new Actor();
            pnn1.img = new Bitmap("h.bmp");
            pnn1.img.MakeTransparent(pnn1.img.GetPixel(0, 0));
            pnn1.XD = ClientSize.Width - f - pnn1.img.Width / 16;
            pnn1.YD = 0;
            pnn1.YS = 0;
            pnn1.XS = 0;
            Hearts.Add(pnn1);
            f += 50;
        }
        void CreateR()
        {
            zzz++;
            Actor pnn1 = new Actor();
            pnn1.img = new Bitmap("1r.bmp");
            pnn1.img.MakeTransparent(pnn1.img.GetPixel(0, 0));
            if (zzz == 1)
            {
                pnn1.XD = L[0].img.Width / 4 + L[0].img.Width * 5 / 10;

            }
            if (zzz == 2)
            {
                pnn1.XD = L[0].img.Width * 3 / 4 + L[0].img.Width * 4 / 10;

            }
            if (zzz == 3)
            {
                pnn1.XD = L[0].img.Width + L[0].img.Width / 2;

            }
            if (zzz == 4)
            {
                pnn1.XD = L[0].img.Width + L[0].img.Width + L[0].img.Width / 4;

            }
            if (zzz == 5)
            {
                pnn1.XD = L[0].img.Width + L[0].img.Width + L[0].img.Width * 3 / 4;

            }
            if (zzz == 6)
            {
                pnn1.XD = L[0].img.Width + L[0].img.Width + pnn1.img.Width / 2;

            }
            pnn1.YD = ClientSize.Height - L2[0].img.Height - pnn1.img.Height;
            pnn1.YS = 0;
            pnn1.XS = 0;
            Lr.Add(pnn1);
        }

        void Createbands()
        {
            z++;

            Actor pnn = new Actor();
            int num = RR.Next(10, 20);
            pnn.YS = 0;
            pnn.XS = 0;
            pnn.img = new Bitmap("enbar.bmp");
            if (z == 1)
            {
                pnn.XD = L[0].img.Width / 4;
                pnn.YD = L[0].img.Height + L[0].img.Height / 4;
            }
            if (z == 2)
            {
                pnn.XD = L[0].img.Width * 3 / 4;
                pnn.YD = L[0].img.Height + L[0].img.Height / 15;
            }
            if (z == 3)
            {
                pnn.XD = L[0].img.Width / 2 + L[0].img.Width;
                pnn.YD = L[0].img.Height * 6 / 10;
                Actor pnnn = new Actor();
                pnnn.img = new Bitmap("g2.bmp");
                pnnn.img.MakeTransparent(pnnn.img.GetPixel(0, 0));
                pnnn.XD = pnn.XD + pnn.img.Width / 2;
                pnnn.YD = pnn.YD - pnnn.img.Height - pnn.img.Height / 3;

                bar pnn7 = new bar();
                pnn7.W = pnnn.img.Width + pnnn.img.Width + pnnn.img.Width;
                pnn7.X = pnnn.XD - pnnn.img.Width;
                pnn7.H = ClientSize.Height * 1 / 100;
                pnn7.Y = pnnn.YD - ClientSize.Height * 1 / 100;
                bgun.Add(pnn7);
                lg.Add(pnnn);
            }
            if (z == 4)
            {
                pnn.XD = L[0].img.Width + L[0].img.Width;
                pnn.YD = L[0].img.Height * 9 / 10;
            }
            if (z == 5)
            {
                pnn.XD = L[0].img.Width + L[0].img.Width + L[0].img.Width / 2;
                pnn.YD = L[0].img.Height * 4 / 10;
            }




            Lbb.Add(pnn);
            n = pnn;



            Maga pnn2 = new Maga();
            for (int i = 1; i <= 4; i++)
            {
                Bitmap m1 = new Bitmap(i + "e.bmp");
                m1.MakeTransparent(m1.GetPixel(0, 0));
                pnn2.imgld.Add(m1);
            }
            pnn2.XD = pnn.XD + pnn.img.Width / 2 - pnn2.imgld[0].Width * 12 / 100;
            pnn2.YD = ClientSize.Height - (L2[0].img.Height * 3) + L2[0].img.Height * 1 / 5;
            pnn2.XS = 0;
            pnn2.YS = 0;
            Le.Add(pnn2);


            Br pnn3 = new Br();
            pnn3.d = RR.Next(0, 2);
            if (pnn3.d == 1)
            {
                pnn3.z = 0;
            }
            if (pnn3.d == 0)
            {
                pnn3.z = 3;
            }
            if (z == 1)
            {
                for (int i = 1; i <= 8; i++)
                {
                    if (i <= 4)
                    {
                        Bitmap m1 = new Bitmap(i + "z.bmp");
                        m1.MakeTransparent(m1.GetPixel(0, 0));
                        pnn3.imgld.Add(m1);
                    }
                    else
                    {
                        Bitmap m1 = new Bitmap(i - 4 + "zz.bmp");
                        m1.MakeTransparent(m1.GetPixel(0, 0));
                        pnn3.imgld.Add(m1);
                    }
                }
            }
            if (z == 2)
            {
                for (int i = 1; i <= 8; i++)
                {
                    if (i <= 4)
                    {
                        Bitmap m1 = new Bitmap(i + "zb.bmp");
                        m1.MakeTransparent(m1.GetPixel(0, 0));
                        pnn3.imgld.Add(m1);
                    }
                    else
                    {
                        Bitmap m1 = new Bitmap(i - 4 + "zzb.bmp");
                        m1.MakeTransparent(m1.GetPixel(0, 0));
                        pnn3.imgld.Add(m1);
                    }
                }
            }
            if (z == 3)
            {
                for (int i = 1; i <= 8; i++)
                {
                    if (i <= 4)
                    {
                        Bitmap m1 = new Bitmap(i + "z.bmp");
                        m1.MakeTransparent(m1.GetPixel(0, 0));
                        pnn3.imgld.Add(m1);
                    }
                    else
                    {
                        Bitmap m1 = new Bitmap(i - 4 + "zz.bmp");
                        m1.MakeTransparent(m1.GetPixel(0, 0));
                        pnn3.imgld.Add(m1);
                    }
                }

            }
            if (z == 4)
            {
                for (int i = 1; i <= 8; i++)
                {
                    if (i <= 4)
                    {
                        Bitmap m1 = new Bitmap(i + "zb.bmp");
                        m1.MakeTransparent(m1.GetPixel(0, 0));
                        pnn3.imgld.Add(m1);
                    }
                    else
                    {
                        Bitmap m1 = new Bitmap(i - 4 + "zzb.bmp");
                        m1.MakeTransparent(m1.GetPixel(0, 0));
                        pnn3.imgld.Add(m1);
                    }
                }
            }
            if (z == 5)
            {
                for (int i = 1; i <= 8; i++)
                {
                    if (i <= 4)
                    {
                        Bitmap m1 = new Bitmap(i + "z.bmp");
                        m1.MakeTransparent(m1.GetPixel(0, 0));
                        pnn3.imgld.Add(m1);
                    }
                    else
                    {
                        Bitmap m1 = new Bitmap(i - 4 + "zz.bmp");
                        m1.MakeTransparent(m1.GetPixel(0, 0));
                        pnn3.imgld.Add(m1);
                    }
                }
            }

            pnn3.XD = pnn.XD + pnn.img.Width / 2;
            pnn3.YD = pnn.YD - pnn3.imgld[0].Height - pnn.img.Height / 2;
            pnn3.XS = 0;
            pnn3.YS = 0;
            pnn3.p = pos;
            Lm.Add(pnn3);


            Actor pnn1 = new Actor();
            pnn1.img = new Bitmap("enbar.bmp");
            pnn1.XD = pnn.XD + pnn.img.Width / 2 + pnn2.imgld[0].Width / 5;
            pnn1.YD = pnn.YD + pnn.img.Height / 3;
            pnn1.YS = 0;
            pnn1.XS = 0;
            Ls.Add(pnn1);


            bar pnn4 = new bar();
            pnn4.W = pnn3.imgld[0].Width;
            pnn4.X = pnn3.XD;
            pnn4.H = ClientSize.Height * 1 / 100;
            pnn4.Y = pnn3.YD - ClientSize.Height * 1 / 100;
            Leb.Add(pnn4);
            pos++;
        }

        void Createbirds()
        {
            Br Bird = new Br();
            Bird.d = RR.Next(0, 2);
            if (Bird.d == 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Bitmap m1 = new Bitmap(i + "b.bmp");
                    m1.MakeTransparent(m1.GetPixel(0, 0));
                    Bird.imgld.Add(m1);
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    Bitmap m1 = new Bitmap(i + "bb.bmp");
                    m1.MakeTransparent(m1.GetPixel(0, 0));
                    Bird.imgld.Add(m1);
                }
            }
            Bird.XD = RR.Next(L[0].img.Width / 4, L[0].img.Width + L[0].img.Width + L[0].img.Width);
            Bird.YD = RR.Next(0, ClientSize.Height / 2);
            Bird.XS = 0;
            Bird.YS = 0;

            Lb.Add(Bird);
        }

        void CreateTrees()
        {
            Trees pnn = new Trees();
            pnn.img = new Bitmap("2.bmp");
            pnn.X = Location.X + x;
            pnn.Y = ClientSize.Height - pnn.img.Height;
            x += pnn.img.Width;
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            L2.Add(pnn);
        }
        void CreateMagaman()
        {
            Maga Man = new Maga();
            for (int i = 1; i <= 7; i++)
            {
                Bitmap m1 = new Bitmap(i + "d.bmp");
                m1.MakeTransparent(m1.GetPixel(0, 0));
                Man.imgld.Add(m1);
            }
            for (int i = 8; i <= 19; i++)
            {
                Bitmap m1 = new Bitmap(i - 7 + "a.bmp");
                m1.MakeTransparent(m1.GetPixel(0, 0));
                Man.imgld.Add(m1);
            }

            Man.YD = ClientSize.Height - (L2[0].img.Height * 3) + L2[0].img.Height * 1 / 5;
            Man.XS = 0;
            Man.YS = 0;
            MM.Add(Man);
            Createbar();

        }


        void Createbar()
        {
            bar pnn = new bar();
            pnn.W = ClientSize.Width / 10;
            pnn.X = MM[0].XD - ClientSize.Width / 40;
            pnn.H = ClientSize.Height * 1 / 100;
            pnn.Y = MM[0].YD - ClientSize.Height * 1 / 100;
            L4.Add(pnn);

            bar pnn1 = new bar();
            pnn1.W = ClientSize.Width / 10;
            pnn1.X = MM[0].XD - ClientSize.Width / 40;
            pnn1.H = ClientSize.Height * 1 / 100;
            pnn1.Y = MM[0].YD - ClientSize.Height * 1 / 50;
            L4.Add(pnn1);
        }
        void CreateMap()
        {
            Actor pnn = new Actor();
            pnn.XD = 0;
            pnn.YD = 0;
            pnn.XS = 0;
            pnn.YS = 0;
            pnn.img = new Bitmap("2.png");
            L.Add(pnn);
        }
        void DrawScene(Graphics g)
        {
            if (loser == 0 || loser == 1)
            {
                g.Clear(Color.White);

                for (int i = 0; i < L.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(L[i].XD, L[i].YD, ClientSize.Width, ClientSize.Height);
                    Rectangle rcSrs = new Rectangle(L[i].XS, L[i].YS + L[i].img.Height * 1 / 10, L[i].img.Width / 2, L[i].img.Height * 3 / 4);
                    g.DrawImage(L[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);
                } for (int i = 0; i < wdoor.Count; i++)
                {

                    Rectangle rcDest = new Rectangle(wdoor[i].XD, wdoor[i].YD, ClientSize.Width / 16, ClientSize.Height / 9 + 2);
                    Rectangle rcSrs = new Rectangle(wdoor[i].XS, wdoor[i].YS, wdoor[i].img.Width, wdoor[i].img.Height);
                    g.DrawImage(wdoor[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < Hearts.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(Hearts[i].XD, Hearts[i].YD, ClientSize.Width / 17, ClientSize.Height / 15);
                    Rectangle rcSrs = new Rectangle(Hearts[i].XS, Hearts[i].YS, Hearts[i].img.Width, Hearts[i].img.Height);
                    g.DrawImage(Hearts[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);
                }
                for (int i = 0; i < L5.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(L5[i].XD, L5[i].YD, ClientSize.Width / 50, ClientSize.Height / 25);
                    Rectangle rcSrs = new Rectangle(L5[i].XS, L5[i].YS, L5[i].imgld[icc].Width, L5[i].imgld[icc].Height);
                    g.DrawImage(L5[i].imgld[icc], rcDest, rcSrs, GraphicsUnit.Pixel);
                }
                for (int i = 0; i < L6.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(L6[i].XD, L6[i].YD, ClientSize.Width / 50, ClientSize.Height / 25);
                    Rectangle rcSrs = new Rectangle(L6[i].XS, L6[i].YS, L6[i].imgld[icc].Width, L6[i].imgld[icc].Height);
                    g.DrawImage(L6[i].imgld[icc], rcDest, rcSrs, GraphicsUnit.Pixel);
                }
                for (int i = 0; i < Lb.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(Lb[i].XD, Lb[i].YD, ClientSize.Width / 43, ClientSize.Height / 15);
                    Rectangle rcSrs = new Rectangle(Lb[i].XS, Lb[i].YS, Lb[i].imgld[ib].Width, Lb[i].imgld[ib].Height);
                    g.DrawImage(Lb[i].imgld[ib], rcDest, rcSrs, GraphicsUnit.Pixel);
                }
                if (door == 5)
                {
                    for (int i = 0; i < bgun.Count; i++)
                    {
                        g.FillRectangle(Brushes.Red, bgun[i].X, bgun[i].Y, bgun[i].W, bgun[i].H);
                        g.DrawRectangle(new Pen(Color.Black, 2), bgun[i].X, bgun[i].Y, bgun[i].W, bgun[i].H);
                    }
                }
                for (int i = 0; i < Lbb.Count; i++)
                {

                    Rectangle rcDest = new Rectangle(Lbb[i].XD, Lbb[i].YD, ClientSize.Width / 5, ClientSize.Height / 100);
                    Rectangle rcSrs = new Rectangle(Lbb[i].XS, Lbb[i].YS, Lbb[i].img.Width, Lbb[i].img.Height);
                    g.DrawImage(Lbb[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);

                    Rectangle rcDestw = new Rectangle(Ls[i].XD, Ls[i].YD, ClientSize.Width / 100, ClientSize.Height - Le[0].imgld[0].Height);
                    Rectangle rcSrsw = new Rectangle(Ls[i].XS, Ls[i].YS, Ls[i].img.Width, Ls[i].img.Height);
                    g.DrawImage(Ls[i].img, rcDestw, rcSrsw, GraphicsUnit.Pixel);

                    Rectangle crcDest = new Rectangle(Le[i].XD, Le[i].YD, ClientSize.Width / 20, ClientSize.Height / 10);
                    if (ei == i)
                    {
                        Rectangle crcSrs = new Rectangle(Le[i].XS, Le[i].YS, Le[i].imgld[icee].Width, Le[i].imgld[icee].Height);
                        g.DrawImage(Le[i].imgld[icee], crcDest, crcSrs, GraphicsUnit.Pixel);
                    }
                    else
                    {
                        Rectangle crcSrs = new Rectangle(Le[i].XS, Le[i].YS, Le[i].imgld[3].Width, Le[i].imgld[3].Height);
                        g.DrawImage(Le[i].imgld[ice], crcDest, crcSrs, GraphicsUnit.Pixel);
                    }
                }

                for (int i = 0; i < L4.Count; i++)
                {
                    if (i == 0)
                    {
                        g.FillRectangle(Brushes.Red, L4[i].X, L4[i].Y, L4[i].W, L4[i].H);
                        g.DrawRectangle(new Pen(Color.Black, 2), L4[i].X, L4[i].Y, L4[i].W, L4[i].H);
                    }
                    if (i == 1)
                    {
                        g.FillRectangle(Brushes.Blue, L4[i].X, L4[i].Y, L4[i].W, L4[i].H);
                        g.DrawRectangle(new Pen(Color.Black, 2), L4[i].X, L4[i].Y, L4[i].W, L4[i].H);
                    }
                }
                if (dragon.Count != 0)
                {
                    for (int i = 0; i < bull.Count; i++)
                    {
                        Rectangle rcDest = new Rectangle(bull[i].XD, bull[i].YD, ClientSize.Width / 25, ClientSize.Height / 25);
                        Rectangle rcSrs = new Rectangle(bull[i].XS, bull[i].YS, bull[i].img.Width, bull[i].img.Height);
                        g.DrawImage(bull[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);
                    }
                }
                for (int i = 0; i < L3.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(L3[i].XD, L3[i].YD, ClientSize.Width / 50, ClientSize.Height / 25);
                    Rectangle rcSrs = new Rectangle(L3[i].XS, L3[i].YS, L3[i].img.Width, L3[i].img.Height);
                    g.DrawImage(L3[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);
                }
                for (int i = 0; i < L33.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(L33[i].XD, L33[i].YD, ClientSize.Width / 50, ClientSize.Height / 25);
                    Rectangle rcSrs = new Rectangle(L33[i].XS, L33[i].YS, L33[i].img.Width, L33[i].img.Height);
                    g.DrawImage(L33[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);
                }

                for (int i = 0; i < L2.Count; i++)
                {
                    g.DrawImage(L2[i].img, L2[i].X, L2[i].Y);
                }
                if (door == 5)
                {
                    for (int i = 0; i < lg.Count; i++)
                    {
                        Rectangle rcDest = new Rectangle(lg[i].XD, lg[i].YD, ClientSize.Width / 30, ClientSize.Height / 15);
                        Rectangle rcSrs = new Rectangle(lg[i].XS, lg[i].YS, lg[i].img.Width, lg[i].img.Height);
                        g.DrawImage(lg[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);
                    }
                }
                for (int i = 0; i < Lm.Count; i++)
                {
                    Rectangle rcDestw = new Rectangle(Lm[i].XD, Lm[i].YD, ClientSize.Width / 20, ClientSize.Height / 10);
                    Rectangle rcSrsw = new Rectangle(Lm[i].XS, Lm[i].YS, Lm[i].imgld[Lm[i].z].Width, Lm[i].imgld[Lm[i].z].Height);
                    g.DrawImage(Lm[i].imgld[Lm[i].z], rcDestw, rcSrsw, GraphicsUnit.Pixel);

                }

                Rectangle arcDest = new Rectangle(MM[0].XD, MM[0].YD, ClientSize.Width / 20, ClientSize.Height / 10);
                Rectangle arcSrs = new Rectangle(MM[0].XS, MM[0].YS, MM[0].imgld[ic].Width, MM[0].imgld[ic].Height);
                g.DrawImage(MM[0].imgld[ic], arcDest, arcSrs, GraphicsUnit.Pixel);
                for (int i = 0; i < dragon.Count; i++)
                {

                    Rectangle rcDest = new Rectangle(dragon[i].XD, dragon[i].YD, ClientSize.Width / 9, ClientSize.Height / 7);
                    Rectangle rcSrs = new Rectangle(dragon[i].XS, dragon[i].YS, dragon[i].imgld[id].Width, dragon[i].imgld[id].Height);
                    g.DrawImage(dragon[i].imgld[id], rcDest, rcSrs, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < Leb.Count; i++)
                {
                    g.FillRectangle(Brushes.Red, Leb[i].X, Leb[i].Y, Leb[i].W, Leb[i].H);
                    g.DrawRectangle(new Pen(Color.Black, 2), Leb[i].X, Leb[i].Y, Leb[i].W, Leb[i].H);

                }
                for (int i = 0; i < Lpom.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(Lpom[i].XD, Lpom[i].YD, ClientSize.Width / 20, ClientSize.Height / 10);
                    Rectangle rcSrs = new Rectangle(Lpom[i].XS, Lpom[i].YS, Lpom[i].imgld[lk].Width, Lpom[i].imgld[lk].Height);
                    g.DrawImage(Lpom[i].imgld[lk], rcDest, rcSrs, GraphicsUnit.Pixel);
                }
                for (int i = 0; i < bd.Count; i++)
                {
                    g.FillRectangle(Brushes.Red, bd[i].X, bd[i].Y, bd[i].W, bd[i].H);
                    g.DrawRectangle(new Pen(Color.Black, 2), bd[i].X, bd[i].Y, bd[i].W, bd[i].H);
                }
                for (int i = 0; i < lc.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(lc[i].XD, lc[i].YD, ClientSize.Width / 40, ClientSize.Height / 15);
                    Rectangle rcSrs = new Rectangle(lc[i].XS, lc[i].YS, lc[i].imgld[lc[i].oc].Width, lc[i].imgld[lc[i].oc].Height);
                    g.DrawImage(lc[i].imgld[lc[i].oc], rcDest, rcSrs, GraphicsUnit.Pixel);
                }

                for (int i = 0; i < Lr.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(Lr[i].XD, Lr[i].YD, ClientSize.Width / 30, ClientSize.Height / 13);
                    Rectangle rcSrs = new Rectangle(Lr[i].XS, Lr[i].YS, Lr[i].img.Width, Lr[i].img.Height);
                    g.DrawImage(Lr[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);

                }
                if (Lsl.Count != 0)
                {
                    g.DrawLine(new Pen(Color.OrangeRed, 3), Lsl[Lsl.Count - 1].X, Lsl[Lsl.Count - 1].Y, MM[0].XD + MM[0].imgld[ic].Width + MM[0].imgld[ic].Width / 2, MM[0].YD + MM[0].imgld[ic].Height);
                }
                for (int i = 0; i < Lboom.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(Lboom[i].XD, Lboom[i].YD, ClientSize.Width / 30, ClientSize.Height / 15);
                    Rectangle rcSrs = new Rectangle(Lboom[i].XS, Lboom[i].YS, Lboom[i].img.Width, Lboom[i].img.Height);
                    g.DrawImage(Lboom[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);
                }
                for (int i = 0; i < Lbox.Count; i++)
                {
                    Rectangle rcDest = new Rectangle(Lbox[i].XD, Lbox[i].YD, ClientSize.Width / 30, ClientSize.Height / 15);
                    Rectangle rcSrs = new Rectangle(Lbox[i].XS, Lbox[i].YS, Lbox[i].img.Width, Lbox[i].img.Height);
                    g.DrawImage(Lbox[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);
                }
                for (int i = 0; i < lud.Count; i++)
                {

                    Rectangle rcDest = new Rectangle(lud[i].XD, lud[i].YD, ClientSize.Width / 15, ClientSize.Height / 100);
                    Rectangle rcSrs = new Rectangle(lud[i].XS, lud[i].YS, lud[i].img.Width, lud[i].img.Height);
                    g.DrawImage(lud[i].img, rcDest, rcSrs, GraphicsUnit.Pixel);

                }


            }
            if (loser == 1)
            {
                Bitmap win = new Bitmap("4.bmp");
                g.DrawImage(win, 0, 0, ClientSize.Width, ClientSize.Height);
                loser = 2;
            }
            if (loser == 3)
            {
                Bitmap win = new Bitmap("q1.bmp");
                g.DrawImage(win, 0, 0, ClientSize.Width, ClientSize.Height);
                loser = 2;
            }
        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
    }
}
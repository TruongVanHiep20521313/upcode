using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vẽ_điểm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(1201, 801);
            //diem
            for (int i = 599; i < 602; i++)
            {
                for (int j = 229; j < 232; j++)
                {
                    bm.SetPixel(i,j, Color.Red);
                }
            }
                
            //nha
            for(int i= 0; i<1201;i++)
            {
                for (int j = 0; j < 801; j++)
                {
                    if (i == 0 || i == 1200)
                    {
                        bm.SetPixel(i, j, Color.Black);
                    }
                }
                bm.SetPixel(i, 0, Color.Black);
                bm.SetPixel(i, 800, Color.Black);
            }


            for (int i = 480; i <= 480+240; i++)
            {
                for (int j = 160; j <= 160+140; j++)
                {
                    if (i == 480 || i == 720)
                    {
                        bm.SetPixel(i, j, Color.Black);
                    }
                }
                bm.SetPixel(i, 160, Color.Black);
                bm.SetPixel(i, 300, Color.Black);
            }
            //new Rectangle(475, 155, 250, 150)
            for (int i = 475; i <= 725 ; i++)
            {
                for (int j = 155; j <= 305; j++)
                {
                    if (i == 475 || i == 725)
                    {
                        bm.SetPixel(i, j, Color.Black);
                    }
                }
                bm.SetPixel(i, 155, Color.Black);
                bm.SetPixel(i, 305, Color.Black);
            }
            //new Rectangle(530,190,140,80),
            for (int i = 530; i <= 670; i++)
            {
                for (int j = 190; j <= 270; j++)
                {
                    if (i == 530 || i == 670)
                    {
                        bm.SetPixel(i, j, Color.Black);
                    }
                }
                bm.SetPixel(i, 190, Color.Black);
                bm.SetPixel(i, 270, Color.Black);
            }
            //new Rectangle(475,460,250,20)
            for (int i = 475; i <= 725; i++)
            {
                for (int j = 460; j <= 480; j++)
                {
                    if (i == 475 || i == 725)
                    {
                        bm.SetPixel(i, j, Color.Black);
                    }
                }
                bm.SetPixel(i, 460, Color.Black);
                bm.SetPixel(i, 480, Color.Black);
            }
            //new Rectangle(475,480,15,140)
            for (int i = 475; i <= 490; i++)
            {
                for (int j = 480; j <= 620; j++)
                {
                    if (i == 475 || i == 490)
                    {
                        bm.SetPixel(i, j, Color.Black);
                    }
                }
                bm.SetPixel(i, 620, Color.Black);
                bm.SetPixel(i, 480, Color.Black);
            }
            //new Rectangle(710,480,15,140)
            for (int i = 710; i <= 725; i++)
            {
                for (int j = 480; j <= 620; j++)
                {
                    if (i == 710 || i == 725)
                    {
                        bm.SetPixel(i, j, Color.Black);
                    }
                }
                bm.SetPixel(i, 620, Color.Black);
                bm.SetPixel(i, 480, Color.Black);
            }
            //new Rectangle(545,480,15,50)  chan sau
            for (int i = 545; i <= 560; i++)
            {
                for (int j = 480; j <= 530; j++)
                {
                    if (i == 545 || i == 560)
                    {
                        bm.SetPixel(i, j, Color.Black);
                    }
                }
                bm.SetPixel(i, 530, Color.Black);
                bm.SetPixel(i, 480, Color.Black);
            }
            //new Rectangle(640,480,15,50)
            for (int i = 640; i <= 655; i++)
            {
                for (int j = 480; j <= 530; j++)
                {
                    if (i == 640 || i == 655)
                    {
                        bm.SetPixel(i, j, Color.Black);
                    }
                }
                bm.SetPixel(i, 530, Color.Black);
                bm.SetPixel(i, 480, Color.Black);
            }
            // sàn  x=x0+u1t    y=y0+u2t

            // new PointF(320,520), new PointF(45,800)
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i-520)*-275)/(280) +320;
                bm.SetPixel(j,i, Color.Black);
            }
            // new PointF(130, 800), new PointF(360, 520)
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i - 520) * -230) / (280) + 360;
                bm.SetPixel(j, i, Color.Black);
            }
            // new PointF(205, 800), new PointF(400, 520)
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * 195) / (-280) + 205;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(285, 800), new PointF(440, 520)
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * 155) / (-280) + 285;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(360, 800), new PointF(475, 525)
            for (int i = 525; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * 115) / (-275) + 360;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(440, 800), new PointF(520, 520
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * 80) / (-280) + 440;
                bm.SetPixel( j,i, Color.Black);
            }
            //new PointF(520, 800), new PointF(558, 530)
            for (int i = 530; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * 38) / (-270) + 520;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(600, 800), new PointF(600, 520)
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * 0) / (-280) + 600;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(680, 800), new PointF(640, 530)
            for (int i = 530; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * -38) / (-270) + 680;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(760, 800), new PointF(680, 520)
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * -80) / (-280) + 760;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(840, 800), new PointF(725, 525)
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * -115) / (-280) + 840;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(915, 800), new PointF(760, 520)
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * -155) / (-280) + 915;
                bm.SetPixel(j, i, Color.Black);
            }
            // new PointF(995, 800), new PointF(800, 520) 
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * -195) / (-280) + 995;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(1070, 800), new PointF(840, 520)
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * -230) / (-280) + 1070;
                bm.SetPixel(j, i, Color.Black);
            }
            // new PointF(1155, 800), new PointF(880, 520)
            for (int i = 520; i <= 800; i++)
            {
                int j;
                j = ((i - 800) * -275) / (-280) + 1155;
                bm.SetPixel(j, i, Color.Black);
            }

            // tường 

            //new PointF(320, 520), new PointF(320, 120)
            for (int i = 120; i <= 520; i++)
            {    
                bm.SetPixel(320, i, Color.Black);
            }
            //new PointF(880,520), new PointF(880,120)
            for (int i = 120; i <= 520; i++)
            {  
                bm.SetPixel(880, i, Color.Black);
            }
            //bi că tnew PointF(545, 520), new PointF(495, 520)
            for (int i = 495; i <= 545; i++)
            {          
                bm.SetPixel(i, 520, Color.Black);
            }
            //new PointF(705, 520), new PointF(655, 520)
            for (int i = 655; i <= 705; i++)
            {
                bm.SetPixel(i, 520, Color.Black);
            }
            //new PointF(635, 520), new PointF(565, 520)
            for (int i = 565; i <= 635; i++)
            {
                bm.SetPixel(i, 520, Color.Black);
            }
            //new PointF(475, 520), new PointF(320, 520)
            for (int i = 320; i <= 475; i++)
            {
                bm.SetPixel(i, 520, Color.Black);
            }
            //new PointF(725, 520), new PointF(880, 520)
            for (int i = 725; i <= 880; i++)
            {
                bm.SetPixel(i, 520, Color.Black);
            }

            //trần 
            // new PointF(20, 0), new PointF(320, 120), new PointF(320 + 14 * 40, 120), new PointF(1180, 0)
            for (int i = 320; i <= 320+14*40; i++)
            {
                bm.SetPixel(i, 120, Color.Black);
            }
            for (int i = 20; i <= 320; i++)
            {
                int j;
                j = ((i - 20) * 120) / (300) + 0;
                bm.SetPixel( i, j, Color.Black);
            }
            for (int i = 880; i <= 1180; i++)
            {
                int j;
                j = ((i - 880) * -120) / (1180-880) + 120;
                bm.SetPixel(i, j, Color.Black);
            }

            //ảnh 
            //new PointF(480, 160), new PointF(530, 190), new PointF(670,190), new PointF(720,160)
            for (int i = 480; i <= 530; i++)
            {
                int j;
                j = ((i - 480) * 30) / (50) + 160;
                bm.SetPixel(i, j, Color.Black);
            }
            for (int i = 670; i <= 720; i++)
            {
                int j;
                j = ((i - 670) * -30) / (50) + 190;
                bm.SetPixel(i, j, Color.Black);
            }
            //new PointF(480, 300), new PointF(530, 270), new PointF(670, 270), new PointF(720, 300)
            for (int i = 480; i <= 530; i++)
            {
                int j;
                j = ((i - 480) * -30) / (50) + 300;
                bm.SetPixel(i, j, Color.Black);
            }
            for (int i = 670; i <= 720; i++)
            {
                int j;
                j = ((i - 670) * 30) / (50) + 270;
                bm.SetPixel(i, j, Color.Black);
            }
            //bàn
            //
            //new PointF(545,330), new PointF(655,330), new PointF(725,460), new PointF(475, 460) 
            for (int i = 545; i <= 655; i++)
            {
                bm.SetPixel(i, 330, Color.Black);
            }
            for (int i = 330; i <= 460; i++)
            {
                int j;
                j = ((i - 330) * -70) / (130) +545;
                bm.SetPixel(j, i,  Color.Black);
            }
            for (int i = 330; i <= 460; i++)
            {
                int j;
                j = ((i - 330) * 70) / (130) + 655;
                bm.SetPixel(j,i, Color.Black);
            }
            // chân
            //
            // new PointF(490, 480), new PointF(495, 480), new PointF(495,600), new PointF(490,620)
            for (int i = 480; i <= 600; i++)
            {
                bm.SetPixel(495, i, Color.Black);
            }
            for (int i = 600; i <= 620; i++)
            {
                int j;
                j = ((i - 600) * -5) / (20) + 495;
                bm.SetPixel(j, i, Color.Black);
            }
            // new PointF(705, 480), new PointF(710, 480), new PointF(710, 620), new PointF(705, 600)
            for (int i = 480; i <= 600; i++)
            {
                bm.SetPixel(705, i, Color.Black);
            }
            for (int i = 600; i <= 620; i++)
            {
                int j;
                j = ((i - 620) * -5) / (-20) + 710;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(560, 480), new PointF(565, 480), new PointF(565, 520), new PointF(560, 530)
            for (int i = 480; i <= 520; i++)
            {
                bm.SetPixel(565, i, Color.Black);
            }
            for (int i = 520; i <= 530; i++)
            {
                int j;
                j = ((i - 520) * -5) / (10) + 565;
                bm.SetPixel(j, i, Color.Black);
            }
            // new PointF(635, 480), new PointF(640, 480), new PointF(640,530), new PointF(635, 520)
            for (int i = 480; i <= 520; i++)
            {
                bm.SetPixel(635, i, Color.Black);
            }
            for (int i = 520; i <= 530; i++)
            {
                int j;
                j = ((i - 530) * -5) / (-10) + 640;
                bm.SetPixel(j, i, Color.Black);
            }

            // ốp 

            //new PointF(0, 740), new PointF(120, 638)
            for (int i = 638; i <= 740; i++)
            {
                int j;
                j = ((i - 740) * 120) / (-102) + 0;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(280, 505), new PointF(320, 470)
            for (int i = 280; i <= 320; i++)
            {
                int j;
                j = ((i - 280) *-35) / (40) + 505;
                bm.SetPixel(i, j,  Color.Black);
            }
            // new PointF(475, 470), new PointF(320, 470
            for (int i = 320; i <= 475; i++)
            {
                bm.SetPixel(i, 470, Color.Black);
            }
            //new PointF(880, 470), new PointF(725, 470)
            for (int i = 725; i <= 880; i++)
            {
                bm.SetPixel(i, 470, Color.Black);
            }
            //new PointF(1200, 740), new PointF(880, 470)
            for (int i = 880; i <= 1200; i++)
            {
                int j;
                j = ((i - 1200) * -270) / (-320) + 740;
                bm.SetPixel(i, j, Color.Black);
            }

            //cửa


            //new PointF(280, 158), new PointF(120, 120), new PointF(120, 724), new PointF(280, 561)
            for (int i = 158; i <= 561; i++)
            {
                bm.SetPixel(280, i, Color.Black);
            }
            for (int i = 120; i <= 724; i++)
            {
                bm.SetPixel(120,i, Color.Black);
            }
            for (int i =120; i <= 280; i++)
            {
                int j;
                j = ((i - 280) * -38) / (-160) + 158;
                bm.SetPixel(i, j, Color.Black);
            }
            // new PointF(270, 167), new PointF(140, 140), new PointF(140, 704), new PointF(270, 570)
            for (int i = 167; i <= 570; i++)
            {
                bm.SetPixel(270, i, Color.Black);
            }
            for (int i = 140; i <= 704; i++)
            {
                bm.SetPixel(140, i, Color.Black);
            }
            for (int i = 140; i <= 270; i++)
            {
                int j;
                j = ((i - 270) * -27) / (-130) + 167;
                bm.SetPixel(i, j, Color.Black);
            }
            //new PointF(120,120), new PointF(110,120), new PointF(110,647), new PointF(120, 638)
            for (int i = 110; i <= 120; i++)
            {
                bm.SetPixel(i, 120, Color.Black);
            }
            for (int i = 120; i <= 647; i++)
            {
                bm.SetPixel(110, i, Color.Black);
            }
            for (int i = 140; i <= 270; i++)
            {
                int j;
                j = ((i - 270) * -27) / (-130) + 167;
                bm.SetPixel(i, j, Color.Black);
            }

            // cửa sổ
            //
            // (920 + 15, 162 + 20), (1064 + 15, 120 + 40), new PointF(1064 + 15, 380 + 30), (920 + 15, 338 + 20)
            for (int i = 182; i <= 358; i++)
            {
                bm.SetPixel(935, i, Color.Black);
            }
            for (int i = 160; i <= 410; i++)
            {
                bm.SetPixel(1079, i, Color.Black);
            }
            for (int i = 935; i <= 1079; i++)
            {
                int j;
                j = ((i - 935) * -22) / (144) + 182;
                bm.SetPixel(i, j, Color.Black);
            }
            for (int i = 935; i <= 1079; i++)
            {
                int j;
                j = ((i - 1079) * -52) / (-144) + 410;
                bm.SetPixel(i, j, Color.Black);
            }
            //(925 + 15, 165 + 20), new PointF(1059 + 15, 127 + 40), new PointF(1059 + 15, 373 + 30),(925 + 15, 335 + 20)
            for (int i = 185; i <= 355; i++)
            {
                bm.SetPixel(940, i, Color.Black);
            }
            for (int i = 167; i <= 403; i++)
            {
                bm.SetPixel(1074, i, Color.Black);
            }
            for (int i = 940; i <= 1074; i++)
            {
                int j;
                j = ((i - 940) * -18) / (134) + 185;
                bm.SetPixel(i, j, Color.Black);
            }
            for (int i = 940; i <= 1074; i++)
            {
                int j;
                j = ((i - 1074) * -48) / (-134) + 403;
                bm.SetPixel(i, j, Color.Black);
            }
            //(980, 205), (1074, 197), (1074, 361), (980, 335)
            for (int i =205; i <= 335; i++)
            {
                bm.SetPixel(980, i, Color.Black);
            }
            for (int i = 980; i <= 1074; i++)
            {
                int j;
                j = ((i - 980) * -8) / (94) + 205;
                bm.SetPixel(i, j, Color.Black);
            }
            for (int i = 980; i <= 1074; i++)
            {
                int j;
                j = ((i - 1074) * -26) / (-94) + 361;
                bm.SetPixel(i, j, Color.Black);
            }
            //  new PointF(980, 205), new PointF(940, 185)
            for (int i = 940; i <= 980; i++)
            {
                int j;
                j = ((i - 980) * -20) / (-40) + 205;
                bm.SetPixel(i, j, Color.Black);
            }
            // new PointF(980, 335 ), new PointF(940, 355)
            for (int i = 940; i <= 980; i++)
            {
                int j;
                j = ((i - 980) * 20) / (-40) + 335;
                bm.SetPixel(i, j, Color.Black);
            }


            //sách 
            // new PointF(610, 360), new PointF(655, 360), new PointF(675,410 ), new PointF(620,410)
            for (int i = 610; i <= 655; i++)
            {
                bm.SetPixel(i, 360, Color.Black);
            }
            for (int i = 620; i <= 675; i++)
            {
                bm.SetPixel(i, 410, Color.Black);
            }
            for (int i = 360; i <= 410; i++)
            {
                int j;
                j = ((i - 360) * 10) / (50) + 610;
                bm.SetPixel(j,i, Color.Black);
            }
            for (int i = 360; i <= 410; i++)
            {
                int j;
                j = ((i - 360) * 20) / (50) + 655;
                bm.SetPixel(j, i, Color.Black);
            }
            //new PointF(610, 360), new PointF(609, 370), new PointF(617, 415), new PointF(677, 415 )(675,410), new PointF(620,410)
            for (int i = 360; i <= 370; i++)
            {
                int j;
                j = ((i - 360) *-1) / (10) + 610;
                bm.SetPixel(j, i, Color.Black);
            }
            for (int i = 370; i <= 415; i++)
            {
                int j;
                j = ((i - 370) * 8) / (45) + 609;
                bm.SetPixel(j, i, Color.Black);
            }
            for (int i = 617; i <= 677; i++)
            {
                
                bm.SetPixel(i,415, Color.Black);
            }
            for (int i = 410; i <= 415; i++)
            {
                int j;
                j = ((i - 415) * -2) / (-5) + 677;
                bm.SetPixel(j, i, Color.Black);
            }

            // công tắc 
            // new PointF(60,363), new PointF(90,355), new PointF(90,398), new PointF(60,408)
            for (int i = 363; i <= 408; i++)
            {
                bm.SetPixel(60, i, Color.Black);
            }
            for (int i = 355; i <= 398; i++)
            {
                bm.SetPixel(90,i, Color.Black);
            }
            for (int i = 60; i <= 90; i++)
            {
                int j;
                j = ((i - 60) * -8) / (30) + 363;
                bm.SetPixel(i, j, Color.Black);
            }
            for (int i = 60; i <= 90; i++)
            {
                int j;
                j = ((i - 90) * 10) / (-30) + 398;
                bm.SetPixel(i,j, Color.Black);
            }
            //
            for (int i = 375; i <= 390; i++)
            {
                bm.SetPixel(73, i, Color.Black);
            }
            for (int i = 373; i <= 388; i++)
            {
                bm.SetPixel(77, i, Color.Black);
            }
            for (int i = 73; i <= 77; i++)
            {
                int j;
                j = ((i - 73) * -2) / (4) + 375;
                bm.SetPixel(i, j, Color.Black);
            }
            for (int i = 73; i <= 77; i++)
            {
                int j;
                j = ((i - 73) * -2) / (4) + 390;
                bm.SetPixel(i, j, Color.Black);
            }
            //
            for (int i = 73; i <= 77; i++)
            {
                int j;
                j = ((i - 73) * -2) / (4) + 383;
                bm.SetPixel(i, j, Color.Black);
            }

            // mở cửa 
            //new PointF(170, 406), new PointF(160,406)
            // new PointF(170, 420), new PointF(160, 414)
            for (int i = 160; i <= 170; i++)
            {
                bm.SetPixel(i,406, Color.Black);
            }
            for (int i = 160; i <= 170; i++)
            {
                bm.SetPixel(i, 418, Color.Black);
            }
            for (int i = 170; i <= 200; i++)
            {
                int j;
                j = ((i - 170) * -10) / (25) + 406;
                bm.SetPixel(i, j, Color.Black);
            }
            for (int i = 170; i <= 200; i++)
            {
                int j;
                j = ((i - 170) * -16) / (25) + 418;
                bm.SetPixel(i, j, Color.Black);
            }
            for (int i = 395; i <= 400; i++)
            {
                bm.SetPixel(200, i, Color.Black);
            }
            for (int i = 396; i <= 428; i++)
            {
                bm.SetPixel(160, i, Color.Black);
            }
            pictureBox1.Image = bm;
        }
    }
}

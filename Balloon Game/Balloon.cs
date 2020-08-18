using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balloon_Game
{
    public class Balloon
    {
        public static bool challengeCheckbox { get; set; }
        private Image UrlConvertToImage(string filename)
        {
            return Image.FromFile(filename);
        }
        public Image [] balloons()
        {
            Image[] balloons =
               {
                UrlConvertToImage(Application.StartupPath+"\\images\\balloons\\blue balloon.png"),
                UrlConvertToImage(Application.StartupPath+"\\images\\balloons\\red balloon.png"),
                UrlConvertToImage(Application.StartupPath+"\\images\\balloons\\green balloon.png"),
                UrlConvertToImage(Application.StartupPath+"\\images\\balloons\\gold balloon.png"),
                UrlConvertToImage(Application.StartupPath+"\\images\\balloons\\purple balloon.png"),
                UrlConvertToImage(Application.StartupPath+"\\images\\balloons\\red balloon.png"),
                UrlConvertToImage(Application.StartupPath+"\\images\\balloons\\legendary balloon.png"),
            };

            return balloons;
        }
        public Image CheckRandomballoons()
        {
            Random random = new Random();
            int index = random.Next(0, balloons().Length);

            return balloons()[index];
        }
        private int CheckRandomLocation(int windowWidth)
        {
            Random random = new Random();
            int location = random.Next(10, windowWidth-81);

            return location;
        }
        int id = 0;
        public PictureBox balloonPictureBox(int windowWidth,int windowTop)
        {
            var myPictureBox = new PictureBox();
            id++;
            myPictureBox.Name = "myballoon_"+id.ToString();
            myPictureBox.Cursor = CreateCursor((Bitmap)Image.FromFile(Application.StartupPath + "\\images\\cursor\\target.ico"), new Size(48, 48));
            myPictureBox.Width = 81;
            myPictureBox.Height = 204;
            myPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            myPictureBox.Left = CheckRandomLocation(windowWidth);
            myPictureBox.Top = windowTop;
            myPictureBox.Image = CheckRandomballoons();
            myPictureBox.BackColor = Color.Transparent;
            return myPictureBox;
        }
        public void BoomAnimation(object sender)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = UrlConvertToImage(Application.StartupPath + "\\images\\balloons\\boom balloon.gif");
            pictureBox.Name += "+boombed";
            Thread.Sleep(250);
            pictureBox.Visible = false;
        }
        public void Boom()
        {
            SoundPlayer boomSound = new SoundPlayer(Application.StartupPath + "\\sound\\boom sound.wav");
            boomSound.Play();
        }
        public Cursor CreateCursor(Bitmap bm,Size size)
        {
            bm = new Bitmap(bm, size);
            return new Cursor(bm.GetHicon());
        }
    }
}

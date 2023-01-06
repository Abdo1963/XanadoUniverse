using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOPXanadu
{
    internal class YY : Humanoid,ICanEat,ISpeakFrench
    {

        public YY() {
            Ancestor = "None";
            Subspeise = "None";
            FirstHoppy = "SpeakFrench";
            SecondHoppy = "Eat";
            PicturePath = "C:\\Users\\this\\Downloads\\NewYY.png";
            Name = "YY";
            FirstHoppyPath = "C:\\Users\\this\\Downloads\\Getting Out-Frenched at a French Restaurant - Key & Peele (online-video-cutter.com).mp4";
            SecondHoppyPath = "C:\\Users\\this\\Downloads\\Luffy eating for 3 minutes straights (online-video-cutter.com).mp4";
        }
        public void Eat()
        {
            Form3 form3 = new Form3(SecondHoppyPath);
            form3.Show();
        }

        public override void Ancestordisplay()
        {
            MessageBox.Show("NONE");
        }
        public override void SubspeiseDisplay()
        {
            MessageBox.Show("NONE");
        }
        public override void FirstHoppyDisplay()
        {

            SpeakFrench();

        }
        public override void SecondHoppyDisplay()
        {
            Eat();
        }
        public void sing()
        {
            throw new NotImplementedException();
        }

        public void SpeakFrench()
        {
            Form3 form3 = new Form3(FirstHoppyPath);
            form3.Show();
        }
    }
}

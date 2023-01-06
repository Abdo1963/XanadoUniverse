using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOPXanadu
{
    internal class ZZ : Humanoid, ICanDance, ISpeakFrench
    {
        public ZZ() {
            Ancestor = "None";
            Subspeise = "NN";
            FirstHoppy = "Dance";
            SecondHoppy = "Sing";
            PicturePath = "C:\\Users\\this\\Downloads\\NewZZ.png";
            Name = "ZZ";
            FirstHoppyPath = "C:\\Users\\this\\Downloads\\Rick Astley - Never Gonna Give You Up (Official Music Video).mp4";
            SecondHoppyPath = "C:\\Users\\this\\Downloads\\Untitled design.mp4";
        }
        public override void Ancestordisplay()
        {
            MessageBox.Show("NONE");
        }
        public override void SubspeiseDisplay()
        {
            NN nN = new NN();
            Form2 form2_NN = new Form2(nN);
            form2_NN.Show();
        }
        public void Dance()
        {
            Form3 form3 = new Form3(FirstHoppyPath);
            form3.Show();
        }

        public override void FirstHoppyDisplay()
        {

            Dance();

        }
        public override void SecondHoppyDisplay()
        {
            sing();
        }

        public void sing()
        {
            Form3 form3 = new Form3(SecondHoppyPath);
            form3.Show();
        }

        public void SpeakFrench()
        {
            throw new NotImplementedException();
        }
    }
}

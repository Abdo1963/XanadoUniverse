using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOOPXanadu
{
    internal class NN:ZZ,ICodeCSharp
    {
        public NN() 
        { 
            Ancestor= "ZZ";
            Subspeise = "DD";
            FirstHoppy = "Write code";
            SecondHoppy = "Sing";
            PicturePath = "C:\\Users\\this\\Downloads\\NewNN.png";
            Name = "NN";
            FirstHoppyPath = "C:\\Users\\this\\Downloads\\What people think programming is vs. how it actually is.mp4";
            SecondHoppyPath = "C:\\Users\\this\\Downloads\\Untitled design.mp4";
    }
        public override void Ancestordisplay()
        {
            ZZ zZ = new ZZ();
            Form2 form2_ZZ = new Form2(zZ);
            form2_ZZ.Show();
        }
        public override void SubspeiseDisplay()
        {
            DD dD = new DD();
            Form2 form2_DD = new Form2(dD);
            form2_DD.Show();
        }
        public override void FirstHoppyDisplay()
        {
            
            WriteCode();

        }
        public override void SecondHoppyDisplay()
        {
            sing();
        }
        public void Sing()
        {
            Form3 form3 = new Form3(SecondHoppyPath);
            form3.Show();
        }
        public void WriteCode()
        {

            Form3 form3 = new Form3(FirstHoppyPath);
            form3.Show();
        }
    }
}

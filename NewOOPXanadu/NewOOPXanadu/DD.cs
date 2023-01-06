using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOPXanadu
{
    internal class DD : NN, ISnore
    {
        
        public DD(){
            Ancestor = "NN";
            Subspeise = "None";
            FirstHoppy = "Snore";
            SecondHoppy = "None";
            PicturePath = "C:\\Users\\this\\Downloads\\NewDD.png";
            Name = "DD";
            FirstHoppyPath = "C:\\Users\\this\\Downloads\\videoplayback.mp4";
            
        }
        public override void Ancestordisplay()
        {
            NN nN = new NN();
            Form2 form2_NN = new Form2(nN);
            form2_NN.Show();
        }
        public override void SubspeiseDisplay()
        {
            MessageBox.Show("NONE");
        }
        public override void FirstHoppyDisplay()
        {

            snore();

        }
        public override void SecondHoppyDisplay()
        {
            MessageBox.Show("NONE");
        }
        public void snore()
        {
            Form3 form3 = new Form3(FirstHoppyPath);
            form3.Show();
        }
    }
}

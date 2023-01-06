using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOPXanadu
{
    internal abstract class Humanoid
    {
        internal string Ancestor { get; set; }
        internal string Subspeise { get; set; }
        internal string FirstHoppy { get; set; }
        internal string SecondHoppy { get; set; }
        internal string FirstHoppyPath { get; set; }
        internal string SecondHoppyPath { get; set; }
        internal string PicturePath { get; set; }
        internal string Name { get; set; }

        public abstract void Ancestordisplay();


        public abstract void SubspeiseDisplay();


        public abstract void FirstHoppyDisplay();

        public abstract void SecondHoppyDisplay();

    }
}

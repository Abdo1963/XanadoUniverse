using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOPXanadu
{
    public partial class Form2 : Form
    {
        private Humanoid humanoid;
        public Form2(Object _humanoid)
        {
            this.humanoid = (Humanoid)_humanoid;   
            InitializeComponent();
            button1.Text = humanoid.Ancestor;
            button2.Text = humanoid.Subspeise;
            button3.Text = humanoid.FirstHoppy;
            button4.Text = humanoid.SecondHoppy;
            pictureBox2.Load(humanoid.PicturePath);
            label1.Text = humanoid.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            humanoid.Ancestordisplay();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            humanoid.SubspeiseDisplay();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            humanoid.FirstHoppyDisplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            humanoid.SecondHoppyDisplay();
        }

       
    }
}

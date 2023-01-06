using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOPXanadu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNN_Click(object sender, EventArgs e)
        {
          
            NN nN=new NN();
            Form2 form2 = new Form2(nN);
            form2.Show();
        }

        private void buttonZZ_Click(object sender, EventArgs e)
        {
            ZZ zZ=new ZZ();
            Form2 form2 = new Form2(zZ);
            form2.Show();
        }

        private void buttonYY_Click(object sender, EventArgs e)
        {
            YY yY=new YY();
            Form2 form2 = new Form2(yY);
            form2.Show();
        }

        private void buttonDD_Click(object sender, EventArgs e)
        {
            DD  dD=new DD();
            Form2 form2 = new Form2(dD);
            form2.Show();
        }

       
    }
}

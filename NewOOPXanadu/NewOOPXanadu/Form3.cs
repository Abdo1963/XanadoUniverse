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
    public partial class Form3 : Form
    {
        
        public Form3(string path)
        {
            
            InitializeComponent();
            axWindowsMediaPlayer1.URL = path;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}

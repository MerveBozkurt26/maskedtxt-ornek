using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mtTC.Mask = "00000000000";
            mtTelefon.Mask = "(999) 000 00 00";
            mtTarih.Mask = "00/00/0000";
            mtNumara.Mask = "0000-0000-0000-0000";
            mtAdres.Mask = "###.###.###.###";
        }
    }
}

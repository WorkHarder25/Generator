using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsultGenGUI
{
    
    public partial class PopUp : Form
    {
        private int _word;

        public PopUp()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _word = 1;
            Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _word = 2;
            Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            _word = 3;
            Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            _word = 4;
            Close();
        }

        public int Word
        {
            get => _word;
        }
    }
}

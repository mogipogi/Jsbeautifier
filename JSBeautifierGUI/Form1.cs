using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jsbeautifier;

namespace JSBeautifierGUI
{
    public partial class Form1 : Form
    {

        Jsbeautifier.Beautifier BT;
        
        public Form1()
        {
            InitializeComponent();
            BT = new Beautifier();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            rtbInput.Text = BT.Beautify(rtbInput.Text);
        }
    }
}

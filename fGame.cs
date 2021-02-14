using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessSound
{
    public partial class fGame : Form
    {
        public fGame()
        {
            InitializeComponent();
        }

        private void fGame_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            WMP.URL = Victorina.list[1];
        }
    }
}

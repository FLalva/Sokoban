using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLalvaAssignment1
{
    public partial class SokobanMenu : Form
    {
        public SokobanMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            DesignForm form = new DesignForm();
            form.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm form = new PlayForm();
            form.ShowDialog();
        }
    }
}

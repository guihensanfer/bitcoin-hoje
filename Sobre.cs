using System;
using System.Windows.Forms;

namespace Bitcoin_Hoje
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

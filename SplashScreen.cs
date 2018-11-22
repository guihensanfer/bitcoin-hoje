using System;
using System.Windows.Forms;

namespace Bitcoin_Hoje
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        Form1 f = new Form1();              

        private void timer1_Tick(object sender, EventArgs e)
        {           
            // Deixa o splash screen invisivel
            this.Opacity = 0;
            this.TopMost = false;            
            
            // Deixa a tela principal visivel e focada
            f.ShowInTaskbar = true;
            timer1.Interval = 10;
            if (f.Opacity.Equals(1))
            {
                timer1.Stop();
                f.Focus();
            }
            f.Opacity = f.Opacity + 0.1;            
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {                                    
            // Aciona a interface principal deixando-a "segundo plano" temporariamente
            f.Opacity = 0;
            f.ShowInTaskbar = false;
            f.Show();                        
        }      
    }
}

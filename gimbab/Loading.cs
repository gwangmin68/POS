using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gimbab
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            BackgroundImage = new Bitmap(Image.FromFile(Application.StartupPath + @"/LoadImage/Loading.jpeg"), new Size(Width, Height));
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;
            ProgressTimer.Start();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if(progressBar.Value >= progressBar.Maximum)
            {
                ProgressTimer.Stop();
                MainForm main = new MainForm();
                main.Show();
                Hide();
                return;
            }
            progressBar.Step = new Random().Next(5, 25);
            progressBar.PerformStep();
        }
    }
}

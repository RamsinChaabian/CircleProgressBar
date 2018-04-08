using System.Threading;
using System.Windows.Forms;

namespace circle_progressbar
{
    public partial class Form2 : Form
    {
        private circle_progressBar circleProgressBar = new circle_progressBar();

        public Form2()
        {
            CheckForIllegalCrossThreadCalls = false;

            var thread = new Thread(splash);
            thread.Start();
            Thread.Sleep(7000);

            InitializeComponent();

            circleProgressBar.Close();
        }

        private void splash()
        {
            Application.Run(circleProgressBar);
        }
    }
}
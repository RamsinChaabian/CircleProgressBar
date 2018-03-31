using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circle_progressbar
{
    public partial class circle_progressBar : Form
    {
        public circle_progressBar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            Task.Run(() =>
            {
                for (var num = 0; num <= 100; num++)
                {
                    new Thread(progressUpdate).Start(num);
                    Thread.Sleep(60);
                    if (num == 100) Application.Exit();
                }
            });
        }

        private void progressUpdate(object progress)
        {
            pb_progressbar.Invoke(
                (MethodInvoker) delegate { pb_progressbar.updateProgress(Convert.ToInt32(progress)); });
        }
    }
}
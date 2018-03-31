using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace circle_progressbar
{
    public partial class circleprogressBar : UserControl
    {
        private int progress;

        public circleprogressBar()
        {
            progress = 0;
            InitializeComponent();
        }

        private void circleprogressbar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.RotateTransform(-90);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var obj_pen = new Pen(Color.GreenYellow);
            var rect = new Rectangle(0 - Width / 2 + 20, 0 - Height / 2 + 20, Width - 40, Height - 40);
            e.Graphics.DrawPie(obj_pen, rect, 0, (int) (progress * 3.6));
            e.Graphics.FillPie(new SolidBrush(Color.GreenYellow), rect, 0, (int) (progress * 3.6));

            obj_pen = new Pen(Color.Gray);
            rect = new Rectangle(0 - Width / 2 + 30, 0 - Height / 2 + 30, Width - 60, Height - 60);
            e.Graphics.DrawPie(obj_pen, rect, 0, 360);
            e.Graphics.FillPie(new SolidBrush(Color.Gray), rect, 0, 360);

            e.Graphics.RotateTransform(90);

            var ft = new StringFormat();
            ft.LineAlignment = StringAlignment.Center;
            ft.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(progress + "%", new Font("Arial", 40), new SolidBrush(Color.GreenYellow), rect, ft);
        }

        public void updateProgress(int progress)
        {
            this.progress = progress;
            Invalidate();
        }
    }
}
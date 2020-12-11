using System;
using System.Drawing;
using System.Windows.Forms;

namespace TuningKOZ.View
{
    public partial class MessageForm : Form
    {
        private readonly string message;
        private readonly bool error;
        private readonly int waitTime;

        private MessageForm(string message, bool error, int waitTime)
        {
            InitializeComponent();
            this.message = message;
            this.error = error;
            this.waitTime = waitTime;
        }

        public static void Show(Point location, string message, bool error = false, int waitTime = 2000)
        {
            var frm = new MessageForm(message, error, waitTime);
            location.Offset(0, 20);
            frm.Location = location;
            frm.Show();
            frm.UpdateSize();
            frm.Focus();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = waitTime;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Close();
        }

        private void MessageForm_Paint(object sender, PaintEventArgs e)
        {
            var size = GetMessageSize(e.Graphics, message);
            var rect = new RectangleF(new PointF(), size);
            using (var brush = new SolidBrush(ForeColor))
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                if (error)
                {
                    e.Graphics.FillRectangle(Brushes.Red, rect);
                    brush.Color = Color.White;
                }
                e.Graphics.DrawString(message, Font, brush, rect, sf);
            }
        }

        private SizeF GetMessageSize(Graphics gr, string message)
        {
            return SizeF.Add(gr.MeasureString(message, Font, 250), new SizeF(10, 10));
        }

        public void UpdateSize()
        {
            using (var gr = Graphics.FromHwnd(this.Handle))
            {
                var size = GetMessageSize(gr, message);
                Size = Size.Ceiling(size);
            }
        }

        private void MessageForm_Leave(object sender, EventArgs e)
        {
            Close();
        }
    }

}

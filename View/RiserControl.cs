using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuningKOZ.View
{
    public partial class RiserControl : Control
    {
        private bool linked;
        private bool workMode;
        private bool smallValve;
        private bool bigValve;
        private object hasNoGround;
        private bool hasHandMode;
        private bool showReadyAndAlarm;
        private bool alarmLevel;
        private bool? ready;
        private bool calcBoxes;
        private int currentLevel;
        private int setpoint;
        private string ntype = "69";
        private int riser;
        private bool fillingInProgress;
        private bool channelActive;

        public RiserControl()
        {
            InitializeComponent();
        }

        public RiserControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var graphics = e.Graphics;
            var riserRect = ClientRectangle;
            var rect = new Rectangle(riserRect.Location, riserRect.Size);
            using (var brush = new SolidBrush(Color.FromArgb(216, 228, 248)))
                graphics.FillRectangle(brush, rect);
            rect.Size -= new Size(1, 1);
            DrawBorder(graphics, rect, Color.White, Color.FromArgb(160, 160, 160), 1);
            rect.Inflate(-1, -1);
            DrawBorder(graphics, rect, Color.FromArgb(160, 160, 160), Color.White, 1);
            rect.Inflate(-2, -2);
            DrawBorder(graphics, rect, Color.White, Color.FromArgb(160, 160, 160), 1);

            linked = true;

            if (linked)
            {
                rect = new Rectangle(new Point(riserRect.Left + 29, riserRect.Top + 22),
                                     Properties.Resources.waggon.Size);
                graphics.DrawImage(Properties.Resources.waggon, rect);

                workMode = true;

                if (workMode) // стояк в положении налива (горловина показывается)
                {
                    rect = new Rectangle(new Point(riserRect.Left + 67, riserRect.Top + 4),
                                         Properties.Resources.throat.Size);
                    graphics.DrawImage(Properties.Resources.throat, rect);

                    smallValve = false;

                    if (smallValve) // малый клапан включен
                    {
                        rect = new Rectangle(new Point(riserRect.Left + 67, riserRect.Top + 4),
                                             Properties.Resources.flow_small.Size);
                        graphics.DrawImage(Properties.Resources.flow_small, rect);
                    }

                    bigValve = false;

                    if (bigValve) // большой клапан включен
                    {
                        rect = new Rectangle(new Point(riserRect.Left + 67, riserRect.Top + 4),
                                             Properties.Resources.flow_big.Size);
                        graphics.DrawImage(Properties.Resources.flow_big, rect);
                    }
                }

                showReadyAndAlarm = true;

                if (showReadyAndAlarm)
                {
                    DrawLamp(graphics, new Rectangle(riserRect.Left + 47, riserRect.Top + 7, 14, 14), ready,
                             Color.Lime, Color.Red, Color.Silver);
                    if (alarmLevel)
                        DrawLamp(graphics, new Rectangle(riserRect.Left + 77, riserRect.Top + 22, 14, 14), true,
                                 Color.Red, Color.Lime, Color.Silver);
                }
                else
                    DrawLamp(graphics, new Rectangle(riserRect.Left + 47, riserRect.Top + 7, 14, 14), alarmLevel,
                                Color.Red, Color.Lime, Color.Silver);


                hasNoGround = false;

                if (hasNoGround != null) // нет запрета контроля заземления
                {
                    rect = new Rectangle(new Point(riserRect.Left + 76, riserRect.Top + 65),
                                         (bool)hasNoGround
                                             ? Properties.Resources.ground_red.Size
                                             : Properties.Resources.ground_green.Size);
                    graphics.DrawImage((bool)hasNoGround
                                           ? Properties.Resources.ground_red
                                           : Properties.Resources.ground_green, rect);
                }

                hasHandMode = true;

                if (hasHandMode) //режим АВТОНОМНО
                {
                    rect = new Rectangle(new Point(riserRect.Left + 122, riserRect.Top + 4),
                                         Properties.Resources.hand_red.Size);
                    graphics.DrawImage(Properties.Resources.hand_red, rect);
                }
            }
            using (var format = new StringFormat())
            {
                if (!calcBoxes)
                {
                    format.LineAlignment = StringAlignment.Center;
                    format.Alignment = StringAlignment.Center;
                    // номер стояка
                    using (var font = new Font("Courier New", 10, FontStyle.Bold))
                        graphics.DrawString(riser.ToString("0"), font, linked ? Brushes.Blue : Brushes.Red,
                                            new Rectangle(riserRect.Left + 58, riserRect.Top + 80, 34, 16),
                                            format);
                    // задание взлива
                    using (var font = new Font("Courier New", 9, FontStyle.Bold))
                        graphics.DrawString(setpoint.ToString("0"), font, Brushes.Black,
                                            new Rectangle(riserRect.Left + 2, riserRect.Top + 6, 40, 16), format);
                    // номер типа вагона
                    using (var font = new Font("Courier New", 9, FontStyle.Bold))
                        graphics.DrawString(ntype, font, Brushes.Green,
                                            new Rectangle(riserRect.Left + 2, riserRect.Top + 39, 33, 16),
                                            format);
                }

                // текущий измеренный уровень взлива
                if (linked)
                {
                    if (!calcBoxes)
                    {
                        var valueForLevel = currentLevel.ToString("0");
                        if (currentLevel < 0) valueForLevel = "0";
                        using (var font = new Font("Segoe UI", 20, FontStyle.Bold))
                        {
                            graphics.DrawString(valueForLevel, font, Brushes.Black,
                                                new Rectangle(riserRect.Left + 30, riserRect.Top + 18, 112, 56),
                                                format);
                            graphics.DrawString(valueForLevel, font, fillingInProgress
                                                                         ? Brushes.Yellow
                                                                         : Brushes.Khaki,
                                                new Rectangle(riserRect.Left + 29, riserRect.Top + 17, 112, 56),
                                                format);
                        }
                    }
                    if (channelActive)
                    {
                    }
                }
                else if (!calcBoxes)
                {
                    using (var font = new Font("Courier New", 10, FontStyle.Bold))
                        graphics.DrawString("НЕТ СВЯЗИ", font, Brushes.Red,
                                            new RectangleF(riserRect.Left + 29, riserRect.Top + 22, 112, 56),
                                            format);
                }
            }

        }

        private static void DrawBorder(Graphics g, RectangleF rect, Color lefttop, Color rightdown, float width)
        {
            using (var pen = new Pen(lefttop, width))
                g.DrawLines(pen, new[]
                    {
                        new PointF(rect.X, rect.Y + rect.Height),
                        new PointF(rect.X, rect.Y),
                        new PointF(rect.X + rect.Width, rect.Y)
                    });
            using (var pen = new Pen(rightdown, width))
                g.DrawLines(pen, new[]
                    {
                        new PointF(rect.X + rect.Width, rect.Y),
                        new PointF(rect.X + rect.Width, rect.Y + rect.Height),
                        new PointF(rect.X, rect.Y + rect.Height)
                    });
        }

        private static void DrawLamp(Graphics graphics, Rectangle rect, bool? state,
                              Color colorOn, Color colorOff, Color colorNone)
        {
            using (var brush = new SolidBrush(state != null ?
                ((bool)state ? colorOn : colorOff) : colorNone))
            {
                graphics.FillEllipse(brush, rect);
                graphics.DrawEllipse(Pens.Black, rect);
                rect.Inflate(-1, -1);
                graphics.DrawEllipse(Pens.Gray, rect);
            }
            var blick = new Rectangle(rect.X + 2, rect.Y + 2, 4, 4);
            graphics.FillEllipse(Brushes.White, blick);
        }
    }
}

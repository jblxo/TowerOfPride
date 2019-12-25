using System;
using System.Drawing;

namespace TowerOfHanoi
{
    public class Disk
    {
        public int Weight { get; set; }
        public int Length { get; set; }
        public Point Position { get { return position; } }
        private Point position;
        private Pen customPen;
        private static Random rnd = new Random();

        public Disk(int weight)
        {
            customPen = createCustomPen();

            Weight = weight;
            Length = weight * 5;
        }

        public void SetPosition(Point p)
        {
            position = p;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(customPen, Position, new Point(Position.X - Length , Position.Y));
            g.DrawLine(customPen, Position, new Point(Position.X + Length, Position.Y));
        }

        private Pen createCustomPen()
        {
            int r, g, b;
            Color color;
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            color = Color.FromArgb(r, g, b);
            return new Pen(color, 6);
        }
    }
}

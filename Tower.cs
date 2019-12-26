using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class Tower : UserControl
    {
        private Pen customPen;
        public event Action<Tower> TowerSelected;
        public List<Disk> Disks { get; set; } = new List<Disk>();

        public Tower()
        {
            InitializeComponent();

            customPen = new Pen(Color.Black, 4);
        }

        public Disk PopDisk()
        {
            if(Disks.Count > 0)
            {
                Disk disk = Disks.Last();
                Disks.Remove(disk);
                return disk;
            }

            return null;
        }

        public Disk GetLastDisk()
        {
            if(Disks.Count > 0)
            {
                return Disks.Last();
            }
            return null;
        }

        public void DrawDisks(Graphics g)
        {
            foreach(var disk in Disks)
            {
                disk.Draw(g);
            }
        }

        public void AddDisk(Disk d)
        {
            d.SetPosition(new Point(Width / 2 - 1, Height - 1 - ((Disks.Count + 1) * 5 * 2)));
            Disks.Add(d);
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(customPen, 1, Height - 1, Width - 1, Height - 1);
            e.Graphics.DrawLine(customPen, Width / 2 - 1, 1, Width / 2 - 1, Height - 1);
            DrawDisks(e.Graphics);
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (TowerSelected != null)
                TowerSelected(this);
        }
    }
}

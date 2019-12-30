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
        private List<Disk> disks;

        public Tower()
        {
            InitializeComponent();

            customPen = new Pen(Color.Black, 4);
            disks = new List<Disk>();
        }

        public List<Disk> GetDisks()
        {
            return disks;
        }

        public void SetDisks(List<Disk> disks)
        {
            this.disks = disks;
        }

        public Disk PopDisk()
        {
            if(disks.Count > 0)
            {
                Disk disk = disks.Last();
                disks.Remove(disk);
                return disk;
            }

            return null;
        }

        public Disk GetLastDisk()
        {
            if(disks.Count > 0)
            {
                return disks.Last();
            }
            return null;
        }

        public void Drawdisks(Graphics g)
        {
            foreach(var disk in disks)
            {
                disk.Draw(g);
            }
        }

        public void AddDisk(Disk d)
        {
            if (d == null)
                return;

            d.SetPosition(new Point(Width / 2 - 1, Height - 1 - ((disks.Count + 1) * 5 * 2)));
            disks.Add(d);
        }

        public void ClearBorder()
        {
            BorderStyle = BorderStyle.None;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(customPen, 1, Height - 1, Width - 1, Height - 1);
            e.Graphics.DrawLine(customPen, Width / 2 - 1, 1, Width / 2 - 1, Height - 1);
            Drawdisks(e.Graphics);
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (TowerSelected != null)
            {
                TowerSelected(this);
            }             
        }
    }
}

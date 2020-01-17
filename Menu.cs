using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void TBNumOfDisks_ValueChanged(object sender, EventArgs e)
        {
            int numberOfDisks = tBNumOfDisks.Value;
            GameData.Instance.NumOfDisks = numberOfDisks;
            lblNumOfDisks.Text = numberOfDisks.ToString();
        }

        private void BtnStartManGame_Click(object sender, EventArgs e)
        {
            SwitchForms(new ManualGame());
        }

        private void SwitchForms(Form form)
        {
            form.Show();
            form.FormClosed += (sender, args) => Show();
            Hide();
        }

        private void btnStartAutoGame_Click(object sender, EventArgs e)
        {
            SwitchForms(new AutoGame());
        }
    }
}

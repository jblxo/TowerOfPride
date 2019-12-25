using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class ManualGame : Form
    {
        public ManualGame()
        {
            InitializeComponent();

            PrepareGame();
        }

        private void PrepareGame()
        {
            GenerateDisks();
        }

        private void GenerateDisks()
        {
            int disksCount = GameData.Instance.NumOfDisks;
            for(int i = 0; i < disksCount; i++)
            {
                Disk disk = new Disk(i + 1);
                towerLeft.AddDisk(disk);
            }
        }
    }
}

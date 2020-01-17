using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using ExtensionMethods;

namespace TowerOfHanoi
{
    public partial class AutoGame : Form
    {
        private Tower towerFrom;
        private Tower towerTo;
        private int turnCount;
        private Thread autoPlay;
        private int numOfDiscs = 0;
        private List<TowersMove> moves = new List<TowersMove>();
        private int autoPlaySpeed = 500;

        public AutoGame()
        {
            InitializeComponent();

            PrepareGame();

            autoPlay = new Thread(AutoSolve);
            autoPlay.IsBackground = true;
            autoPlay.Start();
        }

        private void SetTurnCount(int count)
        {
            turnCount = count;
            lblTurnCount.Text = count.ToString();
        }

        private void PrepareGame()
        {
            numOfDiscs = GameData.Instance.NumOfDisks;
            SolveGame(numOfDiscs, towerLeft, towerRight, towerMiddle);
            SetTurnCount(0);
            GenerateDisks();
            InitTowers();
        }

        private void InitTowers()
        {
            towerLeft.TowerSelected += TowerSelected;
            towerMiddle.TowerSelected += TowerSelected;
            towerRight.TowerSelected += TowerSelected;
        }

        private void TowerSelected(Tower tower)
        {
            tower.BorderStyle = BorderStyle.FixedSingle;

            if (towerFrom == null)
            {
                towerFrom = tower;

                if (towerFrom.GetDisks().Count < 1)
                    towerFrom = null;
            }
            else
            {
                towerTo = tower;
                TransferDisk(towerFrom, towerTo);
                towerFrom = null;
                towerTo = null;
            }

            RefreshTowers();
            CheckEnd();
        }

        private void RefreshTowers()
        {
            towerLeft.Refresh();
            towerMiddle.Refresh();
            towerRight.Refresh();
        }

        private void TransferDisk(Tower towerFrom, Tower towerTo)
        {
            ClearBorders();
            Disk disk = towerFrom.GetLastDisk();
            Disk lastDisk = towerTo.GetLastDisk();

            if (!IsValid(disk, lastDisk))
                return;

            disk = towerFrom.PopDisk();

            towerTo.AddDisk(disk);
            SetTurnCount(turnCount + 1);
        }

        private void ClearBorders()
        {
            towerLeft.ClearBorder();
            towerMiddle.ClearBorder();
            towerRight.ClearBorder();
        }

        private bool IsValid(Disk disk, Disk lastDisk)
        {
            if (towerFrom == towerTo)
                return false;

            if (disk == null)
                return false;

            if (lastDisk == null)
                return true;

            if (lastDisk.Weight < disk.Weight)
                return false;

            return true;
        }

        private void CheckEnd()
        {
            if (towerRight.GetDisks().Count == GameData.Instance.NumOfDisks)
            {
                MessageBox.Show("You won!");
                Close();
            }
        }

        private void GenerateDisks()
        {
            int disksCount = GameData.Instance.NumOfDisks;
            for (int i = disksCount; i >= 1; i--)
            {
                Disk disk = new Disk(i);
                towerLeft.AddDisk(disk);
            }
        }

        private void SolveGame(int diskCount, Tower fromPole, Tower toPole, Tower viaPole)
        {
            if (diskCount == 1)
            {
                moves.Add(new TowersMove { TowerFrom = fromPole, TowerTo = toPole });
            }
            else
            {
                SolveGame(diskCount - 1, fromPole, viaPole, toPole);
                SolveGame(1, fromPole, toPole, viaPole);
                SolveGame(diskCount - 1, viaPole, toPole, fromPole);
            }
        }

        private void AutoSolve()
        {
            for(int i = 0; i < moves.Count; i++)
            {
                this.PerformSafely(() => TowerSelected(moves[i].TowerFrom));
                this.PerformSafely(() => TowerSelected(moves[i].TowerTo));
                Thread.Sleep(autoPlaySpeed);
            }
        }

        private void tBAutoPlaySpeed_ValueChanged(object sender, System.EventArgs e)
        {
            autoPlaySpeed = tBAutoPlaySpeed.Value * 100;
            lblAutoPlaySpeedValue.Text = (tBAutoPlaySpeed.Value * 100) + "ms";
        }
    }

    
}

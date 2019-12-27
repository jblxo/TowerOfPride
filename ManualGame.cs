﻿using System;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class ManualGame : Form
    {
        private Tower towerFrom;
        private Tower towerTo;
        private int turnCount;

        public ManualGame()
        {
            InitializeComponent();

            PrepareGame();
        }

        private void SetTurnCount(int count)
        {
            turnCount = count;
            lblTurnCount.Text = count.ToString();
        }

        private void PrepareGame()
        {
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
            if(towerFrom == null)
            {
                towerFrom = tower;
            } else
            {
                towerTo = tower;
                TransferDisk(towerFrom, towerTo);
                towerFrom = null;
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
            if (towerFrom == towerTo)
                return;

            Disk disk = towerFrom.GetLastDisk();
            Disk lastDisk = towerTo.GetLastDisk();

            if (lastDisk != null && disk != null && disk.Weight > lastDisk.Weight)
                return;

            disk = towerFrom.PopDisk();

            towerTo.AddDisk(disk);
            SetTurnCount(turnCount + 1);
        }

        private void CheckEnd()
        {
            if(towerRight.GetDisks().Count == GameData.Instance.NumOfDisks)
            {
                MessageBox.Show("You won!");
                Close();
            }
        }

        private void GenerateDisks()
        {
            int disksCount = GameData.Instance.NumOfDisks;
            for(int i = disksCount; i >= 1; i--)
            {
                Disk disk = new Disk(i);
                towerLeft.AddDisk(disk);
            }
        }
    }
}

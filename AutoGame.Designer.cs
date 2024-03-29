﻿namespace TowerOfHanoi
{
    partial class AutoGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.towerLeft = new TowerOfHanoi.Tower();
            this.towerMiddle = new TowerOfHanoi.Tower();
            this.towerRight = new TowerOfHanoi.Tower();
            this.lblTurnCount = new System.Windows.Forms.Label();
            this.lblTurnCountTxt = new System.Windows.Forms.Label();
            this.tBAutoPlaySpeed = new System.Windows.Forms.TrackBar();
            this.lblAutoPlaySpeedTxt = new System.Windows.Forms.Label();
            this.lblAutoPlaySpeedValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBAutoPlaySpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.towerLeft);
            this.flowLayoutPanel1.Controls.Add(this.towerMiddle);
            this.flowLayoutPanel1.Controls.Add(this.towerRight);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(475, 259);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // towerLeft
            // 
            this.towerLeft.Location = new System.Drawing.Point(3, 3);
            this.towerLeft.Name = "towerLeft";
            this.towerLeft.Size = new System.Drawing.Size(150, 250);
            this.towerLeft.TabIndex = 0;
            // 
            // towerMiddle
            // 
            this.towerMiddle.Location = new System.Drawing.Point(159, 3);
            this.towerMiddle.Name = "towerMiddle";
            this.towerMiddle.Size = new System.Drawing.Size(150, 250);
            this.towerMiddle.TabIndex = 1;
            // 
            // towerRight
            // 
            this.towerRight.Location = new System.Drawing.Point(315, 3);
            this.towerRight.Name = "towerRight";
            this.towerRight.Size = new System.Drawing.Size(150, 250);
            this.towerRight.TabIndex = 2;
            // 
            // lblTurnCount
            // 
            this.lblTurnCount.AutoSize = true;
            this.lblTurnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTurnCount.Location = new System.Drawing.Point(591, 12);
            this.lblTurnCount.Name = "lblTurnCount";
            this.lblTurnCount.Size = new System.Drawing.Size(19, 20);
            this.lblTurnCount.TabIndex = 4;
            this.lblTurnCount.Text = "0";
            // 
            // lblTurnCountTxt
            // 
            this.lblTurnCountTxt.AutoSize = true;
            this.lblTurnCountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTurnCountTxt.Location = new System.Drawing.Point(493, 12);
            this.lblTurnCountTxt.Name = "lblTurnCountTxt";
            this.lblTurnCountTxt.Size = new System.Drawing.Size(92, 20);
            this.lblTurnCountTxt.TabIndex = 3;
            this.lblTurnCountTxt.Text = "Turn Count:";
            // 
            // tBAutoPlaySpeed
            // 
            this.tBAutoPlaySpeed.Location = new System.Drawing.Point(12, 393);
            this.tBAutoPlaySpeed.Maximum = 20;
            this.tBAutoPlaySpeed.Minimum = 3;
            this.tBAutoPlaySpeed.Name = "tBAutoPlaySpeed";
            this.tBAutoPlaySpeed.Size = new System.Drawing.Size(475, 45);
            this.tBAutoPlaySpeed.TabIndex = 5;
            this.tBAutoPlaySpeed.Value = 5;
            this.tBAutoPlaySpeed.ValueChanged += new System.EventHandler(this.tBAutoPlaySpeed_ValueChanged);
            // 
            // lblAutoPlaySpeedTxt
            // 
            this.lblAutoPlaySpeedTxt.AutoSize = true;
            this.lblAutoPlaySpeedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAutoPlaySpeedTxt.Location = new System.Drawing.Point(12, 370);
            this.lblAutoPlaySpeedTxt.Name = "lblAutoPlaySpeedTxt";
            this.lblAutoPlaySpeedTxt.Size = new System.Drawing.Size(131, 20);
            this.lblAutoPlaySpeedTxt.TabIndex = 6;
            this.lblAutoPlaySpeedTxt.Text = "Auto Play Speed:";
            // 
            // lblAutoPlaySpeedValue
            // 
            this.lblAutoPlaySpeedValue.AutoSize = true;
            this.lblAutoPlaySpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAutoPlaySpeedValue.Location = new System.Drawing.Point(146, 370);
            this.lblAutoPlaySpeedValue.Name = "lblAutoPlaySpeedValue";
            this.lblAutoPlaySpeedValue.Size = new System.Drawing.Size(62, 20);
            this.lblAutoPlaySpeedValue.TabIndex = 7;
            this.lblAutoPlaySpeedValue.Text = "500ms";
            // 
            // AutoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.lblAutoPlaySpeedValue);
            this.Controls.Add(this.lblAutoPlaySpeedTxt);
            this.Controls.Add(this.tBAutoPlaySpeed);
            this.Controls.Add(this.lblTurnCount);
            this.Controls.Add(this.lblTurnCountTxt);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AutoGame";
            this.Text = "AutoGame";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tBAutoPlaySpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Tower towerLeft;
        private Tower towerMiddle;
        private Tower towerRight;
        private System.Windows.Forms.Label lblTurnCount;
        private System.Windows.Forms.Label lblTurnCountTxt;
        private System.Windows.Forms.TrackBar tBAutoPlaySpeed;
        private System.Windows.Forms.Label lblAutoPlaySpeedTxt;
        private System.Windows.Forms.Label lblAutoPlaySpeedValue;
    }
}
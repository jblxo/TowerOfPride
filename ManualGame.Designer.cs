namespace TowerOfHanoi
{
    partial class ManualGame
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
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.towerLeft);
            this.flowLayoutPanel1.Controls.Add(this.towerMiddle);
            this.flowLayoutPanel1.Controls.Add(this.towerRight);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 259);
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
            // ManualGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ManualGame";
            this.Text = "ManualGame";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Tower towerLeft;
        private Tower towerMiddle;
        private Tower towerRight;
    }
}
namespace TowerOfHanoi
{
    partial class Menu
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBNumOfDisks = new System.Windows.Forms.TrackBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumOfDisks = new System.Windows.Forms.Label();
            this.btnStartManGame = new System.Windows.Forms.Button();
            this.btnStartAutoGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBNumOfDisks)).BeginInit();
            this.SuspendLayout();
            // 
            // tBNumOfDisks
            // 
            this.tBNumOfDisks.Location = new System.Drawing.Point(12, 90);
            this.tBNumOfDisks.Minimum = 3;
            this.tBNumOfDisks.Name = "tBNumOfDisks";
            this.tBNumOfDisks.Size = new System.Drawing.Size(310, 45);
            this.tBNumOfDisks.TabIndex = 0;
            this.tBNumOfDisks.Value = 3;
            this.tBNumOfDisks.ValueChanged += new System.EventHandler(this.TBNumOfDisks_ValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tower Of Hanoi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumOfDisks
            // 
            this.lblNumOfDisks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumOfDisks.Location = new System.Drawing.Point(17, 46);
            this.lblNumOfDisks.Name = "lblNumOfDisks";
            this.lblNumOfDisks.Size = new System.Drawing.Size(305, 41);
            this.lblNumOfDisks.TabIndex = 2;
            this.lblNumOfDisks.Text = "3";
            this.lblNumOfDisks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartManGame
            // 
            this.btnStartManGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartManGame.Location = new System.Drawing.Point(17, 141);
            this.btnStartManGame.Name = "btnStartManGame";
            this.btnStartManGame.Size = new System.Drawing.Size(100, 35);
            this.btnStartManGame.TabIndex = 3;
            this.btnStartManGame.Text = "Manual Game";
            this.btnStartManGame.UseVisualStyleBackColor = true;
            this.btnStartManGame.Click += new System.EventHandler(this.BtnStartManGame_Click);
            // 
            // btnStartAutoGame
            // 
            this.btnStartAutoGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartAutoGame.Location = new System.Drawing.Point(222, 141);
            this.btnStartAutoGame.Name = "btnStartAutoGame";
            this.btnStartAutoGame.Size = new System.Drawing.Size(100, 35);
            this.btnStartAutoGame.TabIndex = 4;
            this.btnStartAutoGame.Text = "Auto Game";
            this.btnStartAutoGame.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 186);
            this.Controls.Add(this.btnStartAutoGame);
            this.Controls.Add(this.btnStartManGame);
            this.Controls.Add(this.lblNumOfDisks);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tBNumOfDisks);
            this.Name = "Menu";
            this.Text = "Tower of Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.tBNumOfDisks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tBNumOfDisks;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumOfDisks;
        private System.Windows.Forms.Button btnStartManGame;
        private System.Windows.Forms.Button btnStartAutoGame;
    }
}


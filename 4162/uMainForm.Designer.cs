namespace _4162
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pboxFWorkSpace = new System.Windows.Forms.PictureBox();
            this.pnlFControlSpace = new System.Windows.Forms.Panel();
            this.lblFTrajectorySizeX = new System.Windows.Forms.Label();
            this.tbarFTrajectorySizeX = new System.Windows.Forms.TrackBar();
            this.tbarFTrajectorySizeY = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFTrajectorySizeY = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFTrajectorySizeMerged = new System.Windows.Forms.Label();
            this.tbarFTrajectorySizeXY = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFWorkSpace)).BeginInit();
            this.pnlFControlSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeY)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeXY)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxFWorkSpace
            // 
            this.pboxFWorkSpace.BackColor = System.Drawing.Color.Gainsboro;
            this.pboxFWorkSpace.Location = new System.Drawing.Point(12, 12);
            this.pboxFWorkSpace.Name = "pboxFWorkSpace";
            this.pboxFWorkSpace.Size = new System.Drawing.Size(1000, 640);
            this.pboxFWorkSpace.TabIndex = 0;
            this.pboxFWorkSpace.TabStop = false;
            this.pboxFWorkSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxFWorkSpace_Paint);
            // 
            // pnlFControlSpace
            // 
            this.pnlFControlSpace.Controls.Add(this.lblFTrajectorySizeX);
            this.pnlFControlSpace.Controls.Add(this.tbarFTrajectorySizeX);
            this.pnlFControlSpace.Location = new System.Drawing.Point(1026, 12);
            this.pnlFControlSpace.Name = "pnlFControlSpace";
            this.pnlFControlSpace.Size = new System.Drawing.Size(270, 100);
            this.pnlFControlSpace.TabIndex = 1;
            // 
            // lblFTrajectorySizeX
            // 
            this.lblFTrajectorySizeX.AutoSize = true;
            this.lblFTrajectorySizeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTrajectorySizeX.Location = new System.Drawing.Point(3, 9);
            this.lblFTrajectorySizeX.Name = "lblFTrajectorySizeX";
            this.lblFTrajectorySizeX.Size = new System.Drawing.Size(191, 20);
            this.lblFTrajectorySizeX.TabIndex = 1;
            this.lblFTrajectorySizeX.Text = "Размер траектории X";
            // 
            // tbarFTrajectorySizeX
            // 
            this.tbarFTrajectorySizeX.Location = new System.Drawing.Point(3, 41);
            this.tbarFTrajectorySizeX.Maximum = 50;
            this.tbarFTrajectorySizeX.Name = "tbarFTrajectorySizeX";
            this.tbarFTrajectorySizeX.Size = new System.Drawing.Size(264, 56);
            this.tbarFTrajectorySizeX.TabIndex = 1;
            this.tbarFTrajectorySizeX.Value = 25;
            this.tbarFTrajectorySizeX.ValueChanged += new System.EventHandler(this.tbarFTrajectorySize_ValueChanged);
            // 
            // tbarFTrajectorySizeY
            // 
            this.tbarFTrajectorySizeY.Location = new System.Drawing.Point(3, 41);
            this.tbarFTrajectorySizeY.Maximum = 50;
            this.tbarFTrajectorySizeY.Name = "tbarFTrajectorySizeY";
            this.tbarFTrajectorySizeY.Size = new System.Drawing.Size(264, 56);
            this.tbarFTrajectorySizeY.TabIndex = 1;
            this.tbarFTrajectorySizeY.Value = 25;
            this.tbarFTrajectorySizeY.ValueChanged += new System.EventHandler(this.tbarFTrajectorySizeY_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFTrajectorySizeY);
            this.panel1.Controls.Add(this.tbarFTrajectorySizeY);
            this.panel1.Location = new System.Drawing.Point(1026, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 100);
            this.panel1.TabIndex = 3;
            // 
            // lblFTrajectorySizeY
            // 
            this.lblFTrajectorySizeY.AutoSize = true;
            this.lblFTrajectorySizeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.lblFTrajectorySizeY.Location = new System.Drawing.Point(3, 9);
            this.lblFTrajectorySizeY.Name = "lblFTrajectorySizeY";
            this.lblFTrajectorySizeY.Size = new System.Drawing.Size(199, 20);
            this.lblFTrajectorySizeY.TabIndex = 3;
            this.lblFTrajectorySizeY.Text = "Размер тракектории Y";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbarFTrajectorySizeXY);
            this.panel2.Controls.Add(this.lblFTrajectorySizeMerged);
            this.panel2.Location = new System.Drawing.Point(1026, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 100);
            this.panel2.TabIndex = 4;
            // 
            // lblFTrajectorySizeMerged
            // 
            this.lblFTrajectorySizeMerged.AutoSize = true;
            this.lblFTrajectorySizeMerged.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.lblFTrajectorySizeMerged.Location = new System.Drawing.Point(3, 9);
            this.lblFTrajectorySizeMerged.Name = "lblFTrajectorySizeMerged";
            this.lblFTrajectorySizeMerged.Size = new System.Drawing.Size(201, 20);
            this.lblFTrajectorySizeMerged.TabIndex = 0;
            this.lblFTrajectorySizeMerged.Text = "Размер траектории XY";
            // 
            // tbarFTrajectorySizeXY
            // 
            this.tbarFTrajectorySizeXY.Location = new System.Drawing.Point(3, 41);
            this.tbarFTrajectorySizeXY.Maximum = 50;
            this.tbarFTrajectorySizeXY.Name = "tbarFTrajectorySizeXY";
            this.tbarFTrajectorySizeXY.Size = new System.Drawing.Size(260, 56);
            this.tbarFTrajectorySizeXY.TabIndex = 1;
            this.tbarFTrajectorySizeXY.Value = 25;
            this.tbarFTrajectorySizeXY.ValueChanged += new System.EventHandler(this.tbarFTrajectorySizeXY_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1308, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFControlSpace);
            this.Controls.Add(this.pboxFWorkSpace);
            this.Name = "frmMain";
            this.Text = "Мое первое приложение";
            ((System.ComponentModel.ISupportInitialize)(this.pboxFWorkSpace)).EndInit();
            this.pnlFControlSpace.ResumeLayout(false);
            this.pnlFControlSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeY)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeXY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxFWorkSpace;
        private System.Windows.Forms.Panel pnlFControlSpace;
        private System.Windows.Forms.TrackBar tbarFTrajectorySizeX;
        private System.Windows.Forms.Label lblFTrajectorySizeX;
        private System.Windows.Forms.TrackBar tbarFTrajectorySizeY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFTrajectorySizeY;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFTrajectorySizeMerged;
        private System.Windows.Forms.TrackBar tbarFTrajectorySizeXY;
    }
}


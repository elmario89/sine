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
            this.lblFTrjectorySize = new System.Windows.Forms.Label();
            this.tbarFTrajectorySizeX = new System.Windows.Forms.TrackBar();
            this.tbarFTrajectorySizeY = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFWorkSpace)).BeginInit();
            this.pnlFControlSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeY)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pnlFControlSpace.Controls.Add(this.lblFTrjectorySize);
            this.pnlFControlSpace.Controls.Add(this.tbarFTrajectorySizeX);
            this.pnlFControlSpace.Location = new System.Drawing.Point(1026, 12);
            this.pnlFControlSpace.Name = "pnlFControlSpace";
            this.pnlFControlSpace.Size = new System.Drawing.Size(270, 100);
            this.pnlFControlSpace.TabIndex = 1;
            // 
            // lblFTrjectorySize
            // 
            this.lblFTrjectorySize.AutoSize = true;
            this.lblFTrjectorySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTrjectorySize.Location = new System.Drawing.Point(3, 9);
            this.lblFTrjectorySize.Name = "lblFTrjectorySize";
            this.lblFTrjectorySize.Size = new System.Drawing.Size(191, 20);
            this.lblFTrjectorySize.TabIndex = 1;
            this.lblFTrjectorySize.Text = "Размер траектории X";
            // 
            // tbarFTrajectorySizeX
            // 
            this.tbarFTrajectorySizeX.Location = new System.Drawing.Point(3, 41);
            this.tbarFTrajectorySizeX.Name = "tbarFTrajectorySizeX";
            this.tbarFTrajectorySizeX.Size = new System.Drawing.Size(264, 56);
            this.tbarFTrajectorySizeX.TabIndex = 1;
            this.tbarFTrajectorySizeX.Value = 5;
            this.tbarFTrajectorySizeX.ValueChanged += new System.EventHandler(this.tbarFTrajectorySize_ValueChanged);
            // 
            // tbarFTrajectorySizeY
            // 
            this.tbarFTrajectorySizeY.Location = new System.Drawing.Point(3, 41);
            this.tbarFTrajectorySizeY.Name = "tbarFTrajectorySizeY";
            this.tbarFTrajectorySizeY.Size = new System.Drawing.Size(264, 56);
            this.tbarFTrajectorySizeY.TabIndex = 1;
            this.tbarFTrajectorySizeY.Value = 5;
            this.tbarFTrajectorySizeY.ValueChanged += new System.EventHandler(this.tbarFTrajectorySizeY_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbarFTrajectorySizeY);
            this.panel1.Location = new System.Drawing.Point(1026, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер тракектории Y";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1308, 661);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxFWorkSpace;
        private System.Windows.Forms.Panel pnlFControlSpace;
        private System.Windows.Forms.TrackBar tbarFTrajectorySizeX;
        private System.Windows.Forms.Label lblFTrjectorySize;
        private System.Windows.Forms.TrackBar tbarFTrajectorySizeY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}


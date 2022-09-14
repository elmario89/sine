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
            this.pnlFControlSpace2 = new System.Windows.Forms.Panel();
            this.lblFTrajectorySizeY = new System.Windows.Forms.Label();
            this.pnlFControlSpace3 = new System.Windows.Forms.Panel();
            this.tbarFTrajectorySizeXY = new System.Windows.Forms.TrackBar();
            this.lblFTrajectorySizeMerged = new System.Windows.Forms.Label();
            this.pnlFControlSpace4 = new System.Windows.Forms.Panel();
            this.tbarFFrequency = new System.Windows.Forms.TrackBar();
            this.lblFFrequency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFWorkSpace)).BeginInit();
            this.pnlFControlSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeY)).BeginInit();
            this.pnlFControlSpace2.SuspendLayout();
            this.pnlFControlSpace3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeXY)).BeginInit();
            this.pnlFControlSpace4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxFWorkSpace
            // 
            this.pboxFWorkSpace.BackColor = System.Drawing.Color.Gainsboro;
            this.pboxFWorkSpace.Location = new System.Drawing.Point(0, -2);
            this.pboxFWorkSpace.Name = "pboxFWorkSpace";
            this.pboxFWorkSpace.Size = new System.Drawing.Size(1003, 662);
            this.pboxFWorkSpace.TabIndex = 0;
            this.pboxFWorkSpace.TabStop = false;
            this.pboxFWorkSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxFWorkSpace_Paint);
            // 
            // pnlFControlSpace
            // 
            this.pnlFControlSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFControlSpace.Controls.Add(this.lblFTrajectorySizeX);
            this.pnlFControlSpace.Controls.Add(this.tbarFTrajectorySizeX);
            this.pnlFControlSpace.Location = new System.Drawing.Point(1042, -2);
            this.pnlFControlSpace.Name = "pnlFControlSpace";
            this.pnlFControlSpace.Size = new System.Drawing.Size(270, 100);
            this.pnlFControlSpace.TabIndex = 1;
            // 
            // lblFTrajectorySizeX
            // 
            this.lblFTrajectorySizeX.AutoSize = true;
            this.lblFTrajectorySizeX.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // pnlFControlSpace2
            // 
            this.pnlFControlSpace2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFControlSpace2.Controls.Add(this.lblFTrajectorySizeY);
            this.pnlFControlSpace2.Controls.Add(this.tbarFTrajectorySizeY);
            this.pnlFControlSpace2.Location = new System.Drawing.Point(1042, 101);
            this.pnlFControlSpace2.Name = "pnlFControlSpace2";
            this.pnlFControlSpace2.Size = new System.Drawing.Size(270, 100);
            this.pnlFControlSpace2.TabIndex = 3;
            // 
            // lblFTrajectorySizeY
            // 
            this.lblFTrajectorySizeY.AutoSize = true;
            this.lblFTrajectorySizeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.lblFTrajectorySizeY.Location = new System.Drawing.Point(3, 9);
            this.lblFTrajectorySizeY.Name = "lblFTrajectorySizeY";
            this.lblFTrajectorySizeY.Size = new System.Drawing.Size(103, 20);
            this.lblFTrajectorySizeY.TabIndex = 3;
            this.lblFTrajectorySizeY.Text = "Амплитуда";
            // 
            // pnlFControlSpace3
            // 
            this.pnlFControlSpace3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFControlSpace3.Controls.Add(this.tbarFTrajectorySizeXY);
            this.pnlFControlSpace3.Controls.Add(this.lblFTrajectorySizeMerged);
            this.pnlFControlSpace3.Location = new System.Drawing.Point(1042, 204);
            this.pnlFControlSpace3.Name = "pnlFControlSpace3";
            this.pnlFControlSpace3.Size = new System.Drawing.Size(270, 100);
            this.pnlFControlSpace3.TabIndex = 4;
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
            // lblFTrajectorySizeMerged
            // 
            this.lblFTrajectorySizeMerged.AutoSize = true;
            this.lblFTrajectorySizeMerged.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.lblFTrajectorySizeMerged.Location = new System.Drawing.Point(3, 9);
            this.lblFTrajectorySizeMerged.Name = "lblFTrajectorySizeMerged";
            this.lblFTrajectorySizeMerged.Size = new System.Drawing.Size(199, 20);
            this.lblFTrajectorySizeMerged.TabIndex = 0;
            this.lblFTrajectorySizeMerged.Text = "Размер X и амплитуда";
            // 
            // pnlFControlSpace4
            // 
            this.pnlFControlSpace4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFControlSpace4.Controls.Add(this.tbarFFrequency);
            this.pnlFControlSpace4.Controls.Add(this.lblFFrequency);
            this.pnlFControlSpace4.Location = new System.Drawing.Point(1042, 310);
            this.pnlFControlSpace4.Name = "pnlFControlSpace4";
            this.pnlFControlSpace4.Size = new System.Drawing.Size(268, 100);
            this.pnlFControlSpace4.TabIndex = 5;
            // 
            // tbarFFrequency
            // 
            this.tbarFFrequency.Location = new System.Drawing.Point(5, 41);
            this.tbarFFrequency.Maximum = 50;
            this.tbarFFrequency.Minimum = 1;
            this.tbarFFrequency.Name = "tbarFFrequency";
            this.tbarFFrequency.Size = new System.Drawing.Size(260, 56);
            this.tbarFFrequency.TabIndex = 1;
            this.tbarFFrequency.Value = 2;
            this.tbarFFrequency.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lblFFrequency
            // 
            this.lblFFrequency.AutoSize = true;
            this.lblFFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.lblFFrequency.Location = new System.Drawing.Point(1, 9);
            this.lblFFrequency.Name = "lblFFrequency";
            this.lblFFrequency.Size = new System.Drawing.Size(81, 20);
            this.lblFFrequency.TabIndex = 0;
            this.lblFFrequency.Text = "Частота";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1308, 661);
            this.Controls.Add(this.pnlFControlSpace4);
            this.Controls.Add(this.pnlFControlSpace3);
            this.Controls.Add(this.pnlFControlSpace2);
            this.Controls.Add(this.pnlFControlSpace);
            this.Controls.Add(this.pboxFWorkSpace);
            this.Name = "frmMain";
            this.Text = "Мое первое приложение";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFWorkSpace)).EndInit();
            this.pnlFControlSpace.ResumeLayout(false);
            this.pnlFControlSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeY)).EndInit();
            this.pnlFControlSpace2.ResumeLayout(false);
            this.pnlFControlSpace2.PerformLayout();
            this.pnlFControlSpace3.ResumeLayout(false);
            this.pnlFControlSpace3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeXY)).EndInit();
            this.pnlFControlSpace4.ResumeLayout(false);
            this.pnlFControlSpace4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFFrequency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxFWorkSpace;
        private System.Windows.Forms.Panel pnlFControlSpace;
        private System.Windows.Forms.TrackBar tbarFTrajectorySizeX;
        private System.Windows.Forms.Label lblFTrajectorySizeX;
        private System.Windows.Forms.TrackBar tbarFTrajectorySizeY;
        private System.Windows.Forms.Panel pnlFControlSpace2;
        private System.Windows.Forms.Label lblFTrajectorySizeY;
        private System.Windows.Forms.Panel pnlFControlSpace3;
        private System.Windows.Forms.Label lblFTrajectorySizeMerged;
        private System.Windows.Forms.TrackBar tbarFTrajectorySizeXY;
        private System.Windows.Forms.Panel pnlFControlSpace4;
        private System.Windows.Forms.Label lblFFrequency;
        private System.Windows.Forms.TrackBar tbarFFrequency;
    }
}


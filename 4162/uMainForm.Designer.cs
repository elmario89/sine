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
            this.tbarFTrajectorySize = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFWorkSpace)).BeginInit();
            this.pnlFControlSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySize)).BeginInit();
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
            this.pnlFControlSpace.Controls.Add(this.tbarFTrajectorySize);
            this.pnlFControlSpace.Location = new System.Drawing.Point(1026, 12);
            this.pnlFControlSpace.Name = "pnlFControlSpace";
            this.pnlFControlSpace.Size = new System.Drawing.Size(270, 100);
            this.pnlFControlSpace.TabIndex = 1;
            this.pnlFControlSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFControlSpace_Paint);
            // 
            // lblFTrjectorySize
            // 
            this.lblFTrjectorySize.AutoSize = true;
            this.lblFTrjectorySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTrjectorySize.Location = new System.Drawing.Point(3, 0);
            this.lblFTrjectorySize.Name = "lblFTrjectorySize";
            this.lblFTrjectorySize.Size = new System.Drawing.Size(191, 20);
            this.lblFTrjectorySize.TabIndex = 1;
            this.lblFTrjectorySize.Text = "Размер траектории X";
            // 
            // tbarFTrajectorySize
            // 
            this.tbarFTrajectorySize.Location = new System.Drawing.Point(3, 44);
            this.tbarFTrajectorySize.Maximum = 20;
            this.tbarFTrajectorySize.Name = "tbarFTrajectorySize";
            this.tbarFTrajectorySize.Size = new System.Drawing.Size(264, 56);
            this.tbarFTrajectorySize.TabIndex = 0;
            this.tbarFTrajectorySize.Value = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1308, 661);
            this.Controls.Add(this.pnlFControlSpace);
            this.Controls.Add(this.pboxFWorkSpace);
            this.Name = "frmMain";
            this.Text = "Мое первое приложение";
            ((System.ComponentModel.ISupportInitialize)(this.pboxFWorkSpace)).EndInit();
            this.pnlFControlSpace.ResumeLayout(false);
            this.pnlFControlSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxFWorkSpace;
        private System.Windows.Forms.Panel pnlFControlSpace;
        private System.Windows.Forms.TrackBar tbarFTrajectorySize;
        private System.Windows.Forms.Label lblFTrjectorySize;
    }
}


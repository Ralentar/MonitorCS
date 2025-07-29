namespace MonitorCS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblInterval = new System.Windows.Forms.Label();
            this.txtBoxInterval = new System.Windows.Forms.TextBox();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.txtBoxTrigger = new System.Windows.Forms.TextBox();
            this.btnSound = new System.Windows.Forms.Button();
            this.txtSoundPath = new System.Windows.Forms.TextBox();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            this.btnBase = new System.Windows.Forms.Button();
            this.txtConfigPath = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.txtQueryPath1 = new System.Windows.Forms.TextBox();
            this.txtQueryResult1 = new System.Windows.Forms.TextBox();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.txtQueryPath2 = new System.Windows.Forms.TextBox();
            this.txtQueryResult2 = new System.Windows.Forms.TextBox();
            this.lblException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Image = global::MonitorCS.Properties.Resources.Start;
            this.btnStart.Location = new System.Drawing.Point(10, 10);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(40, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::MonitorCS.Properties.Resources.Stop;
            this.btnStop.Location = new System.Drawing.Point(60, 10);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 40);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(120, 25);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(2);
            this.lblInterval.MinimumSize = new System.Drawing.Size(140, 20);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(165, 20);
            this.lblInterval.TabIndex = 3;
            this.lblInterval.Text = "Интервал проверки в секундах";
            this.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxInterval
            // 
            this.txtBoxInterval.Location = new System.Drawing.Point(320, 25);
            this.txtBoxInterval.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxInterval.MinimumSize = new System.Drawing.Size(40, 20);
            this.txtBoxInterval.Name = "txtBoxInterval";
            this.txtBoxInterval.Size = new System.Drawing.Size(40, 20);
            this.txtBoxInterval.TabIndex = 4;
            this.txtBoxInterval.Text = "60";
            this.txtBoxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.Location = new System.Drawing.Point(420, 25);
            this.lblTrigger.Margin = new System.Windows.Forms.Padding(2);
            this.lblTrigger.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(50, 20);
            this.lblTrigger.TabIndex = 5;
            this.lblTrigger.Text = "Порог %";
            this.lblTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxTrigger
            // 
            this.txtBoxTrigger.Location = new System.Drawing.Point(375, 25);
            this.txtBoxTrigger.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTrigger.MinimumSize = new System.Drawing.Size(40, 20);
            this.txtBoxTrigger.Name = "txtBoxTrigger";
            this.txtBoxTrigger.Size = new System.Drawing.Size(40, 20);
            this.txtBoxTrigger.TabIndex = 6;
            this.txtBoxTrigger.Text = "10";
            this.txtBoxTrigger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(10, 60);
            this.btnSound.MinimumSize = new System.Drawing.Size(40, 20);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(40, 20);
            this.btnSound.TabIndex = 7;
            this.btnSound.Text = "Звук";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // txtSoundPath
            // 
            this.txtSoundPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoundPath.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtSoundPath.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSoundPath.Location = new System.Drawing.Point(60, 60);
            this.txtSoundPath.MaximumSize = new System.Drawing.Size(300, 20);
            this.txtSoundPath.MinimumSize = new System.Drawing.Size(300, 20);
            this.txtSoundPath.Name = "txtSoundPath";
            this.txtSoundPath.ReadOnly = true;
            this.txtSoundPath.Size = new System.Drawing.Size(300, 20);
            this.txtSoundPath.TabIndex = 8;
            this.txtSoundPath.Text = "sound.wav";
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.Location = new System.Drawing.Point(375, 60);
            this.checkBoxSound.MinimumSize = new System.Drawing.Size(100, 20);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(100, 20);
            this.checkBoxSound.TabIndex = 9;
            this.checkBoxSound.Text = "Оповещение";
            this.checkBoxSound.UseVisualStyleBackColor = true;
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(10, 90);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(40, 20);
            this.btnBase.TabIndex = 10;
            this.btnBase.Text = "Base";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // txtConfigPath
            // 
            this.txtConfigPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfigPath.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtConfigPath.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtConfigPath.Location = new System.Drawing.Point(60, 90);
            this.txtConfigPath.MaximumSize = new System.Drawing.Size(300, 20);
            this.txtConfigPath.MinimumSize = new System.Drawing.Size(300, 20);
            this.txtConfigPath.Name = "txtConfigPath";
            this.txtConfigPath.ReadOnly = true;
            this.txtConfigPath.Size = new System.Drawing.Size(300, 20);
            this.txtConfigPath.TabIndex = 11;
            this.txtConfigPath.Text = "ConfigConnection.txt";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTime.Location = new System.Drawing.Point(375, 90);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 12;
            this.txtTime.Text = "Time";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQuery1
            // 
            this.btnQuery1.Location = new System.Drawing.Point(10, 120);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(40, 20);
            this.btnQuery1.TabIndex = 13;
            this.btnQuery1.Text = "SQL";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // txtQueryPath1
            // 
            this.txtQueryPath1.BackColor = System.Drawing.SystemColors.Control;
            this.txtQueryPath1.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtQueryPath1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtQueryPath1.Location = new System.Drawing.Point(60, 120);
            this.txtQueryPath1.MaximumSize = new System.Drawing.Size(300, 20);
            this.txtQueryPath1.MinimumSize = new System.Drawing.Size(300, 20);
            this.txtQueryPath1.Name = "txtQueryPath1";
            this.txtQueryPath1.ReadOnly = true;
            this.txtQueryPath1.Size = new System.Drawing.Size(300, 20);
            this.txtQueryPath1.TabIndex = 14;
            this.txtQueryPath1.Text = "SQL-SELECT.sql";
            // 
            // txtQueryResult1
            // 
            this.txtQueryResult1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQueryResult1.Location = new System.Drawing.Point(375, 120);
            this.txtQueryResult1.Name = "txtQueryResult1";
            this.txtQueryResult1.ReadOnly = true;
            this.txtQueryResult1.Size = new System.Drawing.Size(100, 20);
            this.txtQueryResult1.TabIndex = 15;
            this.txtQueryResult1.Text = "1";
            this.txtQueryResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQuery2
            // 
            this.btnQuery2.Location = new System.Drawing.Point(10, 150);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(40, 20);
            this.btnQuery2.TabIndex = 16;
            this.btnQuery2.Text = "SQL";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // txtQueryPath2
            // 
            this.txtQueryPath2.BackColor = System.Drawing.SystemColors.Control;
            this.txtQueryPath2.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtQueryPath2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtQueryPath2.Location = new System.Drawing.Point(60, 150);
            this.txtQueryPath2.MaximumSize = new System.Drawing.Size(300, 20);
            this.txtQueryPath2.MinimumSize = new System.Drawing.Size(300, 20);
            this.txtQueryPath2.Name = "txtQueryPath2";
            this.txtQueryPath2.ReadOnly = true;
            this.txtQueryPath2.Size = new System.Drawing.Size(300, 20);
            this.txtQueryPath2.TabIndex = 17;
            this.txtQueryPath2.Text = "SQL-SELECT.sql";
            // 
            // txtQueryResult2
            // 
            this.txtQueryResult2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQueryResult2.Location = new System.Drawing.Point(375, 150);
            this.txtQueryResult2.Name = "txtQueryResult2";
            this.txtQueryResult2.ReadOnly = true;
            this.txtQueryResult2.Size = new System.Drawing.Size(100, 20);
            this.txtQueryResult2.TabIndex = 18;
            this.txtQueryResult2.Text = "1";
            this.txtQueryResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(10, 180);
            this.lblException.Margin = new System.Windows.Forms.Padding(2);
            this.lblException.MinimumSize = new System.Drawing.Size(460, 20);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(460, 20);
            this.lblException.TabIndex = 19;
            this.lblException.Text = "Сообщение:";
            this.lblException.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.txtQueryResult2);
            this.Controls.Add(this.txtQueryResult1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.txtBoxInterval);
            this.Controls.Add(this.lblTrigger);
            this.Controls.Add(this.txtBoxTrigger);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.txtSoundPath);
            this.Controls.Add(this.checkBoxSound);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtConfigPath);
            this.Controls.Add(this.btnBase);
            this.Controls.Add(this.btnQuery1);
            this.Controls.Add(this.txtQueryPath1);
            this.Controls.Add(this.btnQuery2);
            this.Controls.Add(this.txtQueryPath2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 250);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Монитор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;

        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TextBox txtBoxInterval;

        private System.Windows.Forms.Label lblTrigger;
        private System.Windows.Forms.TextBox txtBoxTrigger;

        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.TextBox txtSoundPath;
        private System.Windows.Forms.CheckBox checkBoxSound;

        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.TextBox txtConfigPath;
        private System.Windows.Forms.TextBox txtTime;

        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.TextBox txtQueryPath1;
        private System.Windows.Forms.TextBox txtQueryResult1;

        private System.Windows.Forms.Button btnQuery2;
        private System.Windows.Forms.TextBox txtQueryPath2;
        private System.Windows.Forms.TextBox txtQueryResult2;
        private System.Windows.Forms.Label lblException;
    }
}
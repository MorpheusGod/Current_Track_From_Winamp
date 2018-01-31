namespace TrackFromWinamp
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
            this.StartWork = new System.Windows.Forms.Button();
            this.StopWork = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrackName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartWork
            // 
            this.StartWork.Location = new System.Drawing.Point(13, 69);
            this.StartWork.Name = "StartWork";
            this.StartWork.Size = new System.Drawing.Size(108, 23);
            this.StartWork.TabIndex = 0;
            this.StartWork.Text = "Запустить";
            this.StartWork.UseVisualStyleBackColor = true;
            this.StartWork.Click += new System.EventHandler(this.StartWork_Click);
            // 
            // StopWork
            // 
            this.StopWork.Location = new System.Drawing.Point(171, 69);
            this.StopWork.Name = "StopWork";
            this.StopWork.Size = new System.Drawing.Size(106, 23);
            this.StopWork.TabIndex = 1;
            this.StopWork.Text = "Остановить";
            this.StopWork.UseVisualStyleBackColor = true;
            this.StopWork.Click += new System.EventHandler(this.StopWork_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TrackName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущий трек";
            // 
            // TrackName
            // 
            this.TrackName.AutoSize = true;
            this.TrackName.Location = new System.Drawing.Point(6, 25);
            this.TrackName.Name = "TrackName";
            this.TrackName.Size = new System.Drawing.Size(35, 13);
            this.TrackName.TabIndex = 0;
            this.TrackName.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 101);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StopWork);
            this.Controls.Add(this.StartWork);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track From Winamp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartWork;
        private System.Windows.Forms.Button StopWork;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TrackName;
    }
}


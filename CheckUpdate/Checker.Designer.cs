namespace CheckUpdate
{
    partial class Checker
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Label_checkVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButt = new System.Windows.Forms.PictureBox();
            this.label_version = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EmailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButt)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(49, 57);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 23);
            this.progressBar1.Step = 20;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // Label_checkVersion
            // 
            this.Label_checkVersion.AutoSize = true;
            this.Label_checkVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_checkVersion.Location = new System.Drawing.Point(57, 27);
            this.Label_checkVersion.Name = "Label_checkVersion";
            this.Label_checkVersion.Size = new System.Drawing.Size(166, 16);
            this.Label_checkVersion.TabIndex = 1;
            this.Label_checkVersion.Text = "Checking new version..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available Version:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CloseButt
            // 
            this.CloseButt.Image = global::CheckUpdate.Properties.Resources.close_icon_15;
            this.CloseButt.Location = new System.Drawing.Point(247, 7);
            this.CloseButt.Name = "CloseButt";
            this.CloseButt.Size = new System.Drawing.Size(25, 25);
            this.CloseButt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButt.TabIndex = 3;
            this.CloseButt.TabStop = false;
            this.CloseButt.Click += new System.EventHandler(this.CloseButt_Click);
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_version.Location = new System.Drawing.Point(181, 95);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(55, 15);
            this.label_version.TabIndex = 4;
            this.label_version.Text = "Version";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_version.UseMnemonic = false;
            this.label_version.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(26, 33);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(0, 15);
            this.EmailLabel.TabIndex = 5;
            // 
            // Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.CloseButt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_checkVersion);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Label_checkVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox CloseButt;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label EmailLabel;
    }
}


namespace Attendance_IT3A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboxAll = new System.Windows.Forms.ListBox();
            this.lboxPerson = new System.Windows.Forms.ListBox();
            this.lboxRecord = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShiftStart = new System.Windows.Forms.Button();
            this.btnShiftStop = new System.Windows.Forms.Button();
            this.btnPauseStart = new System.Windows.Forms.Button();
            this.btnPauseEnd = new System.Windows.Forms.Button();
            this.btnDoctorStart = new System.Windows.Forms.Button();
            this.btnDoctorEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxAll
            // 
            this.lboxAll.FormattingEnabled = true;
            this.lboxAll.ItemHeight = 25;
            this.lboxAll.Location = new System.Drawing.Point(12, 56);
            this.lboxAll.Name = "lboxAll";
            this.lboxAll.Size = new System.Drawing.Size(217, 454);
            this.lboxAll.TabIndex = 0;
            // 
            // lboxPerson
            // 
            this.lboxPerson.FormattingEnabled = true;
            this.lboxPerson.ItemHeight = 25;
            this.lboxPerson.Location = new System.Drawing.Point(235, 56);
            this.lboxPerson.Name = "lboxPerson";
            this.lboxPerson.Size = new System.Drawing.Size(217, 454);
            this.lboxPerson.TabIndex = 0;
            this.lboxPerson.SelectedIndexChanged += new System.EventHandler(this.lboxPerson_SelectedIndexChanged);
            // 
            // lboxRecord
            // 
            this.lboxRecord.FormattingEnabled = true;
            this.lboxRecord.ItemHeight = 25;
            this.lboxRecord.Location = new System.Drawing.Point(458, 56);
            this.lboxRecord.Name = "lboxRecord";
            this.lboxRecord.Size = new System.Drawing.Size(217, 454);
            this.lboxRecord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Všechno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Osoby";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Záznamy";
            // 
            // btnShiftStart
            // 
            this.btnShiftStart.BackColor = System.Drawing.Color.Lime;
            this.btnShiftStart.Location = new System.Drawing.Point(681, 56);
            this.btnShiftStart.Name = "btnShiftStart";
            this.btnShiftStart.Size = new System.Drawing.Size(193, 69);
            this.btnShiftStart.TabIndex = 2;
            this.btnShiftStart.Text = "Zahájení směny";
            this.btnShiftStart.UseVisualStyleBackColor = false;
            this.btnShiftStart.Click += new System.EventHandler(this.btnShiftStart_Click);
            // 
            // btnShiftStop
            // 
            this.btnShiftStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnShiftStop.Location = new System.Drawing.Point(681, 131);
            this.btnShiftStop.Name = "btnShiftStop";
            this.btnShiftStop.Size = new System.Drawing.Size(193, 69);
            this.btnShiftStop.TabIndex = 2;
            this.btnShiftStop.Text = "Ukončení směny";
            this.btnShiftStop.UseVisualStyleBackColor = false;
            this.btnShiftStop.Click += new System.EventHandler(this.btnShiftStop_Click);
            // 
            // btnPauseStart
            // 
            this.btnPauseStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPauseStart.Location = new System.Drawing.Point(681, 206);
            this.btnPauseStart.Name = "btnPauseStart";
            this.btnPauseStart.Size = new System.Drawing.Size(193, 69);
            this.btnPauseStart.TabIndex = 2;
            this.btnPauseStart.Text = "Zahájení pauzy";
            this.btnPauseStart.UseVisualStyleBackColor = false;
            this.btnPauseStart.Click += new System.EventHandler(this.btnPauseStart_Click);
            // 
            // btnPauseEnd
            // 
            this.btnPauseEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPauseEnd.Location = new System.Drawing.Point(681, 281);
            this.btnPauseEnd.Name = "btnPauseEnd";
            this.btnPauseEnd.Size = new System.Drawing.Size(193, 69);
            this.btnPauseEnd.TabIndex = 2;
            this.btnPauseEnd.Text = "Ukončení pauzy";
            this.btnPauseEnd.UseVisualStyleBackColor = false;
            this.btnPauseEnd.Click += new System.EventHandler(this.btnPauseEnd_Click);
            // 
            // btnDoctorStart
            // 
            this.btnDoctorStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDoctorStart.Location = new System.Drawing.Point(681, 356);
            this.btnDoctorStart.Name = "btnDoctorStart";
            this.btnDoctorStart.Size = new System.Drawing.Size(193, 69);
            this.btnDoctorStart.TabIndex = 2;
            this.btnDoctorStart.Text = "Odchod k lékaři";
            this.btnDoctorStart.UseVisualStyleBackColor = false;
            this.btnDoctorStart.Click += new System.EventHandler(this.btnDoctorStart_Click);
            // 
            // btnDoctorEnd
            // 
            this.btnDoctorEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDoctorEnd.Location = new System.Drawing.Point(681, 431);
            this.btnDoctorEnd.Name = "btnDoctorEnd";
            this.btnDoctorEnd.Size = new System.Drawing.Size(193, 69);
            this.btnDoctorEnd.TabIndex = 2;
            this.btnDoctorEnd.Text = "Návrat od lékaře";
            this.btnDoctorEnd.UseVisualStyleBackColor = false;
            this.btnDoctorEnd.Click += new System.EventHandler(this.btnDoctorEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 539);
            this.Controls.Add(this.btnDoctorEnd);
            this.Controls.Add(this.btnDoctorStart);
            this.Controls.Add(this.btnPauseEnd);
            this.Controls.Add(this.btnPauseStart);
            this.Controls.Add(this.btnShiftStop);
            this.Controls.Add(this.btnShiftStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxRecord);
            this.Controls.Add(this.lboxPerson);
            this.Controls.Add(this.lboxAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxAll;
        private System.Windows.Forms.ListBox lboxPerson;
        private System.Windows.Forms.ListBox lboxRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShiftStart;
        private System.Windows.Forms.Button btnShiftStop;
        private System.Windows.Forms.Button btnPauseStart;
        private System.Windows.Forms.Button btnPauseEnd;
        private System.Windows.Forms.Button btnDoctorStart;
        private System.Windows.Forms.Button btnDoctorEnd;
    }
}


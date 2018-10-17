namespace ExerciseTwo
{
    partial class Form1
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
            this.lbl_data = new System.Windows.Forms.Label();
            this.tb_sort = new System.Windows.Forms.TextBox();
            this.tb_trim = new System.Windows.Forms.TextBox();
            this.lbl_sortedCount = new System.Windows.Forms.Label();
            this.lbl_trimCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_scan = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_unique = new System.Windows.Forms.Button();
            this.lbl_scanTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_sortTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_raw = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_data
            // 
            this.lbl_data.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_data.Location = new System.Drawing.Point(12, 9);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(582, 516);
            this.lbl_data.TabIndex = 0;
            // 
            // tb_sort
            // 
            this.tb_sort.Location = new System.Drawing.Point(788, 30);
            this.tb_sort.Multiline = true;
            this.tb_sort.Name = "tb_sort";
            this.tb_sort.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_sort.Size = new System.Drawing.Size(157, 542);
            this.tb_sort.TabIndex = 2;
            // 
            // tb_trim
            // 
            this.tb_trim.Location = new System.Drawing.Point(951, 30);
            this.tb_trim.Multiline = true;
            this.tb_trim.Name = "tb_trim";
            this.tb_trim.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_trim.Size = new System.Drawing.Size(165, 542);
            this.tb_trim.TabIndex = 3;
            // 
            // lbl_sortedCount
            // 
            this.lbl_sortedCount.AutoSize = true;
            this.lbl_sortedCount.Location = new System.Drawing.Point(882, 586);
            this.lbl_sortedCount.Name = "lbl_sortedCount";
            this.lbl_sortedCount.Size = new System.Drawing.Size(13, 17);
            this.lbl_sortedCount.TabIndex = 4;
            this.lbl_sortedCount.Text = "-";
            // 
            // lbl_trimCount
            // 
            this.lbl_trimCount.AutoSize = true;
            this.lbl_trimCount.Location = new System.Drawing.Point(1042, 586);
            this.lbl_trimCount.Name = "lbl_trimCount";
            this.lbl_trimCount.Size = new System.Drawing.Size(13, 17);
            this.lbl_trimCount.TabIndex = 5;
            this.lbl_trimCount.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "words count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(948, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "words count:";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(12, 565);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(122, 38);
            this.btn_scan.TabIndex = 8;
            this.btn_scan.Text = "Scanner";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(140, 565);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(122, 38);
            this.btn_sort.TabIndex = 9;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_unique
            // 
            this.btn_unique.Location = new System.Drawing.Point(472, 565);
            this.btn_unique.Name = "btn_unique";
            this.btn_unique.Size = new System.Drawing.Size(122, 38);
            this.btn_unique.TabIndex = 10;
            this.btn_unique.Text = "Unique";
            this.btn_unique.UseVisualStyleBackColor = true;
            this.btn_unique.Click += new System.EventHandler(this.btn_unique_Click);
            // 
            // lbl_scanTime
            // 
            this.lbl_scanTime.AutoSize = true;
            this.lbl_scanTime.Location = new System.Drawing.Point(113, 545);
            this.lbl_scanTime.Name = "lbl_scanTime";
            this.lbl_scanTime.Size = new System.Drawing.Size(13, 17);
            this.lbl_scanTime.TabIndex = 11;
            this.lbl_scanTime.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "scan time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "sort time:";
            // 
            // lbl_sortTime
            // 
            this.lbl_sortTime.AutoSize = true;
            this.lbl_sortTime.Location = new System.Drawing.Point(234, 545);
            this.lbl_sortTime.Name = "lbl_sortTime";
            this.lbl_sortTime.Size = new System.Drawing.Size(13, 17);
            this.lbl_sortTime.TabIndex = 14;
            this.lbl_sortTime.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Scanned";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(785, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sorted";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(948, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Unique";
            // 
            // lb_raw
            // 
            this.lb_raw.FormattingEnabled = true;
            this.lb_raw.ItemHeight = 16;
            this.lb_raw.Location = new System.Drawing.Point(603, 30);
            this.lb_raw.Name = "lb_raw";
            this.lb_raw.Size = new System.Drawing.Size(179, 548);
            this.lb_raw.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 615);
            this.Controls.Add(this.lb_raw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_sortTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_scanTime);
            this.Controls.Add(this.btn_unique);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_trimCount);
            this.Controls.Add(this.lbl_sortedCount);
            this.Controls.Add(this.tb_trim);
            this.Controls.Add(this.tb_sort);
            this.Controls.Add(this.lbl_data);
            this.Name = "Form1";
            this.Text = "Exsercise Two";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.TextBox tb_sort;
        private System.Windows.Forms.TextBox tb_trim;
        private System.Windows.Forms.Label lbl_sortedCount;
        private System.Windows.Forms.Label lbl_trimCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_unique;
        private System.Windows.Forms.Label lbl_scanTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_sortTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lb_raw;
    }
}


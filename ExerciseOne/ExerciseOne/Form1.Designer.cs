namespace ExerciseOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_scan = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.lv_raw = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_sort = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.timeRec = new System.Windows.Forms.Label();
            this.dataWarningLabel = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(571, 581);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(139, 23);
            this.btn_scan.TabIndex = 3;
            this.btn_scan.Text = "Scanner";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(716, 581);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(139, 23);
            this.btn_sort.TabIndex = 4;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // lv_raw
            // 
            this.lv_raw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv_raw.Location = new System.Drawing.Point(571, 69);
            this.lv_raw.Name = "lv_raw";
            this.lv_raw.Size = new System.Drawing.Size(139, 471);
            this.lv_raw.TabIndex = 5;
            this.lv_raw.UseCompatibleStateImageBehavior = false;
            this.lv_raw.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Raw Format";
            this.columnHeader1.Width = 100;
            // 
            // lv_sort
            // 
            this.lv_sort.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lv_sort.Location = new System.Drawing.Point(716, 69);
            this.lv_sort.Name = "lv_sort";
            this.lv_sort.Size = new System.Drawing.Size(139, 471);
            this.lv_sort.TabIndex = 6;
            this.lv_sort.UseCompatibleStateImageBehavior = false;
            this.lv_sort.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sorted Format";
            this.columnHeader2.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time it took to sort: ";
            // 
            // timeRec
            // 
            this.timeRec.AutoSize = true;
            this.timeRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeRec.Location = new System.Drawing.Point(208, 516);
            this.timeRec.Name = "timeRec";
            this.timeRec.Size = new System.Drawing.Size(20, 24);
            this.timeRec.TabIndex = 8;
            this.timeRec.Text = "0";
            // 
            // dataWarningLabel
            // 
            this.dataWarningLabel.AutoSize = true;
            this.dataWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dataWarningLabel.Location = new System.Drawing.Point(97, 9);
            this.dataWarningLabel.Name = "dataWarningLabel";
            this.dataWarningLabel.Size = new System.Drawing.Size(0, 17);
            this.dataWarningLabel.TabIndex = 10;
            this.dataWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(44, 69);
            this.txtBoxInput.Multiline = true;
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(494, 416);
            this.txtBoxInput.TabIndex = 11;
            this.txtBoxInput.Text = resources.GetString("txtBoxInput.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 625);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.dataWarningLabel);
            this.Controls.Add(this.timeRec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_sort);
            this.Controls.Add(this.lv_raw);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_scan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.ListView lv_raw;
        private System.Windows.Forms.ListView lv_sort;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeRec;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Label dataWarningLabel;
    }
}


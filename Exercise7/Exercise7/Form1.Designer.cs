namespace Exercise7
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnTest3 = new System.Windows.Forms.Button();
            this.btnTest4 = new System.Windows.Forms.Button();
            this.btnTest5 = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.rbtnGet = new System.Windows.Forms.RadioButton();
            this.rbtnHead = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHeaders = new System.Windows.Forms.TextBox();
            this.tbHtml = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(93, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(1221, 22);
            this.tbUrl.TabIndex = 0;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblURL.Location = new System.Drawing.Point(32, 9);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(55, 24);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTime.Location = new System.Drawing.Point(169, 240);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(28, 17);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "----";
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(12, 51);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(75, 56);
            this.btnTest1.TabIndex = 3;
            this.btnTest1.Text = "Test1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(12, 113);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(75, 56);
            this.btnTest2.TabIndex = 4;
            this.btnTest2.Text = "Test2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // btnTest3
            // 
            this.btnTest3.Location = new System.Drawing.Point(12, 175);
            this.btnTest3.Name = "btnTest3";
            this.btnTest3.Size = new System.Drawing.Size(75, 56);
            this.btnTest3.TabIndex = 5;
            this.btnTest3.Text = "Test3";
            this.btnTest3.UseVisualStyleBackColor = true;
            this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // btnTest4
            // 
            this.btnTest4.Location = new System.Drawing.Point(12, 240);
            this.btnTest4.Name = "btnTest4";
            this.btnTest4.Size = new System.Drawing.Size(75, 56);
            this.btnTest4.TabIndex = 6;
            this.btnTest4.Text = "Test4";
            this.btnTest4.UseVisualStyleBackColor = true;
            this.btnTest4.Click += new System.EventHandler(this.btnTest4_Click);
            // 
            // btnTest5
            // 
            this.btnTest5.Location = new System.Drawing.Point(12, 302);
            this.btnTest5.Name = "btnTest5";
            this.btnTest5.Size = new System.Drawing.Size(75, 56);
            this.btnTest5.TabIndex = 7;
            this.btnTest5.Text = "Test5";
            this.btnTest5.UseVisualStyleBackColor = true;
            this.btnTest5.Click += new System.EventHandler(this.btnTest5_Click);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(102, 113);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(169, 56);
            this.btnSendRequest.TabIndex = 8;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // rbtnGet
            // 
            this.rbtnGet.AutoSize = true;
            this.rbtnGet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnGet.Checked = true;
            this.rbtnGet.Location = new System.Drawing.Point(112, 184);
            this.rbtnGet.Name = "rbtnGet";
            this.rbtnGet.Size = new System.Drawing.Size(115, 21);
            this.rbtnGet.TabIndex = 9;
            this.rbtnGet.TabStop = true;
            this.rbtnGet.Text = "GET Request";
            this.rbtnGet.UseVisualStyleBackColor = false;
            // 
            // rbtnHead
            // 
            this.rbtnHead.AutoSize = true;
            this.rbtnHead.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnHead.Location = new System.Drawing.Point(112, 211);
            this.rbtnHead.Name = "rbtnHead";
            this.rbtnHead.Size = new System.Drawing.Size(124, 21);
            this.rbtnHead.TabIndex = 10;
            this.rbtnHead.TabStop = true;
            this.rbtnHead.Text = "HEAD Request";
            this.rbtnHead.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(277, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "HEADERS";
            // 
            // tbHeaders
            // 
            this.tbHeaders.Location = new System.Drawing.Point(283, 83);
            this.tbHeaders.Multiline = true;
            this.tbHeaders.Name = "tbHeaders";
            this.tbHeaders.Size = new System.Drawing.Size(1031, 275);
            this.tbHeaders.TabIndex = 12;
            // 
            // tbHtml
            // 
            this.tbHtml.Location = new System.Drawing.Point(21, 393);
            this.tbHtml.Multiline = true;
            this.tbHtml.Name = "tbHtml";
            this.tbHtml.Size = new System.Drawing.Size(1293, 297);
            this.tbHtml.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(15, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "HTML";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(109, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Време:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(93, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 305);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 702);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHtml);
            this.Controls.Add(this.tbHeaders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnHead);
            this.Controls.Add(this.rbtnGet);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.btnTest5);
            this.Controls.Add(this.btnTest4);
            this.Controls.Add(this.btnTest3);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnTest1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Exercise7";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnTest3;
        private System.Windows.Forms.Button btnTest4;
        private System.Windows.Forms.Button btnTest5;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.RadioButton rbtnGet;
        private System.Windows.Forms.RadioButton rbtnHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHeaders;
        private System.Windows.Forms.TextBox tbHtml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


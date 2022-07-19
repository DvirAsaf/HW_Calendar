namespace CalendarY
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
            this.DayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.BtNext = new System.Windows.Forms.Button();
            this.BtPrevious = new System.Windows.Forms.Button();
            this.Sunday = new System.Windows.Forms.Label();
            this.Monday = new System.Windows.Forms.Label();
            this.Tuseday = new System.Windows.Forms.Label();
            this.Wednesday = new System.Windows.Forms.Label();
            this.Thursday = new System.Windows.Forms.Label();
            this.Friday = new System.Windows.Forms.Label();
            this.Saturday = new System.Windows.Forms.Label();
            this.LBDATE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DayContainer
            // 
            this.DayContainer.Location = new System.Drawing.Point(12, 103);
            this.DayContainer.Name = "DayContainer";
            this.DayContainer.Size = new System.Drawing.Size(1117, 552);
            this.DayContainer.TabIndex = 0;
            // 
            // BtNext
            // 
            this.BtNext.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNext.Location = new System.Drawing.Point(973, 12);
            this.BtNext.Name = "BtNext";
            this.BtNext.Size = new System.Drawing.Size(128, 45);
            this.BtNext.TabIndex = 1;
            this.BtNext.Text = "Next";
            this.BtNext.UseVisualStyleBackColor = true;
            this.BtNext.Click += new System.EventHandler(this.BtNext_Click);
            // 
            // BtPrevious
            // 
            this.BtPrevious.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPrevious.Location = new System.Drawing.Point(40, 9);
            this.BtPrevious.Name = "BtPrevious";
            this.BtPrevious.Size = new System.Drawing.Size(129, 48);
            this.BtPrevious.TabIndex = 2;
            this.BtPrevious.Text = "Previous";
            this.BtPrevious.UseVisualStyleBackColor = true;
            this.BtPrevious.Click += new System.EventHandler(this.BtPrevious_Click);
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Sunday.ForeColor = System.Drawing.Color.MediumBlue;
            this.Sunday.Location = new System.Drawing.Point(47, 60);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(111, 37);
            this.Sunday.TabIndex = 3;
            this.Sunday.Text = "Sunday";
            //this.Sunday.Click += new System.EventHandler(this.label1_Click);
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Monday.ForeColor = System.Drawing.Color.MediumBlue;
            this.Monday.Location = new System.Drawing.Point(201, 60);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(123, 37);
            this.Monday.TabIndex = 4;
            this.Monday.Text = "Monday";
            // 
            // Tuseday
            // 
            this.Tuseday.AutoSize = true;
            this.Tuseday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Tuseday.ForeColor = System.Drawing.Color.MediumBlue;
            this.Tuseday.Location = new System.Drawing.Point(362, 60);
            this.Tuseday.Name = "Tuseday";
            this.Tuseday.Size = new System.Drawing.Size(121, 37);
            this.Tuseday.TabIndex = 5;
            this.Tuseday.Text = "Tuseday";
            //this.Tuseday.Click += new System.EventHandler(this.label3_Click);
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Wednesday.ForeColor = System.Drawing.Color.MediumBlue;
            this.Wednesday.Location = new System.Drawing.Point(507, 60);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(165, 37);
            this.Wednesday.TabIndex = 6;
            this.Wednesday.Text = "Wednesday";
            //this.Wednesday.Click += new System.EventHandler(this.label4_Click);
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Thursday.ForeColor = System.Drawing.Color.MediumBlue;
            this.Thursday.Location = new System.Drawing.Point(674, 60);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(135, 37);
            this.Thursday.TabIndex = 7;
            this.Thursday.Text = "Thursday";
            //this.Thursday.Click += new System.EventHandler(this.label5_Click);
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Friday.ForeColor = System.Drawing.Color.Red;
            this.Friday.Location = new System.Drawing.Point(844, 60);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(97, 37);
            this.Friday.TabIndex = 8;
            this.Friday.Text = "Friday";
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Saturday.ForeColor = System.Drawing.Color.Red;
            this.Saturday.Location = new System.Drawing.Point(993, 60);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(132, 37);
            this.Saturday.TabIndex = 9;
            this.Saturday.Text = "Saturday";
            //this.Saturday.Click += new System.EventHandler(this.Saturday_Click);
            // 
            // LBDATE
            // 
            this.LBDATE.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LBDATE.ForeColor = System.Drawing.Color.DarkViolet;
            this.LBDATE.Location = new System.Drawing.Point(338, 9);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(439, 51);
            this.LBDATE.TabIndex = 10;
            this.LBDATE.Text = "MONTH YEAR";
            this.LBDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 670);
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuseday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.BtPrevious);
            this.Controls.Add(this.BtNext);
            this.Controls.Add(this.DayContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel DayContainer;
        private System.Windows.Forms.Button BtNext;
        private System.Windows.Forms.Button BtPrevious;
        private System.Windows.Forms.Label Sunday;
        private System.Windows.Forms.Label Monday;
        private System.Windows.Forms.Label Tuseday;
        private System.Windows.Forms.Label Wednesday;
        private System.Windows.Forms.Label Thursday;
        private System.Windows.Forms.Label Friday;
        private System.Windows.Forms.Label Saturday;
        private System.Windows.Forms.Label LBDATE;
    }
}


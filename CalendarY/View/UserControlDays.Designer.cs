namespace CalendarY
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbDays = new System.Windows.Forms.Label();
            this.lbEvent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.weekDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.ForeColor = System.Drawing.Color.Black;
            this.lbDays.Location = new System.Drawing.Point(23, 16);
            this.lbDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(39, 36);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "00";
            // 
            // lbEvent
            // 
            this.lbEvent.AutoSize = true;
            this.lbEvent.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvent.Location = new System.Drawing.Point(61, 66);
            this.lbEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(0, 23);
            this.lbEvent.TabIndex = 1;
            this.lbEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // weekDay
            // 
            this.weekDay.AutoSize = true;
            this.weekDay.ForeColor = System.Drawing.Color.White;
            this.weekDay.Location = new System.Drawing.Point(124, 16);
            this.weekDay.Name = "weekDay";
            this.weekDay.Size = new System.Drawing.Size(18, 20);
            this.weekDay.TabIndex = 2;
            this.weekDay.Text = "0";
            //this.weekDay.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.weekDay);
            this.Controls.Add(this.lbEvent);
            this.Controls.Add(this.lbDays);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(203, 103);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label lbEvent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label weekDay;
    }
}

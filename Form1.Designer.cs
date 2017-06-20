namespace clock
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.captureButton1 = new System.Windows.Forms.Button();
            this.captureButton2 = new System.Windows.Forms.Button();
            this.captureButton3 = new System.Windows.Forms.Button();
            this.timer1value = new System.Windows.Forms.Label();
            this.timer2value = new System.Windows.Forms.Label();
            this.timer3value = new System.Windows.Forms.Label();
            this.starttime = new System.Windows.Forms.Label();
            this.timert1 = new System.Windows.Forms.Label();
            this.timert2 = new System.Windows.Forms.Label();
            this.timert3 = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 148.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 220);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00.00";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program running: 0 Sec";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Program";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(726, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(46, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // captureButton1
            // 
            this.captureButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.captureButton1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.captureButton1.FlatAppearance.BorderSize = 0;
            this.captureButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.captureButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.captureButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captureButton1.ForeColor = System.Drawing.Color.Black;
            this.captureButton1.Location = new System.Drawing.Point(141, 324);
            this.captureButton1.Name = "captureButton1";
            this.captureButton1.Size = new System.Drawing.Size(90, 23);
            this.captureButton1.TabIndex = 4;
            this.captureButton1.Text = "Capture timer 1";
            this.captureButton1.UseVisualStyleBackColor = false;
            this.captureButton1.Click += new System.EventHandler(this.CaptureButton1_Click);
            // 
            // captureButton2
            // 
            this.captureButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.captureButton2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.captureButton2.FlatAppearance.BorderSize = 0;
            this.captureButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.captureButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.captureButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captureButton2.ForeColor = System.Drawing.Color.Black;
            this.captureButton2.Location = new System.Drawing.Point(141, 353);
            this.captureButton2.Name = "captureButton2";
            this.captureButton2.Size = new System.Drawing.Size(90, 23);
            this.captureButton2.TabIndex = 5;
            this.captureButton2.Text = "Capture timer 2";
            this.captureButton2.UseVisualStyleBackColor = false;
            this.captureButton2.Click += new System.EventHandler(this.CaptureButton2_Click);
            // 
            // captureButton3
            // 
            this.captureButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.captureButton3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.captureButton3.FlatAppearance.BorderSize = 0;
            this.captureButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.captureButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.captureButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captureButton3.ForeColor = System.Drawing.Color.Black;
            this.captureButton3.Location = new System.Drawing.Point(141, 382);
            this.captureButton3.Name = "captureButton3";
            this.captureButton3.Size = new System.Drawing.Size(90, 23);
            this.captureButton3.TabIndex = 6;
            this.captureButton3.Text = "Capture timer 3";
            this.captureButton3.UseVisualStyleBackColor = false;
            this.captureButton3.Click += new System.EventHandler(this.CaptureButton3_Click);
            // 
            // timer1value
            // 
            this.timer1value.AutoSize = true;
            this.timer1value.Location = new System.Drawing.Point(54, 329);
            this.timer1value.Name = "timer1value";
            this.timer1value.Size = new System.Drawing.Size(38, 13);
            this.timer1value.TabIndex = 7;
            this.timer1value.Text = "timer 1";
            // 
            // timer2value
            // 
            this.timer2value.AutoSize = true;
            this.timer2value.Location = new System.Drawing.Point(54, 358);
            this.timer2value.Name = "timer2value";
            this.timer2value.Size = new System.Drawing.Size(38, 13);
            this.timer2value.TabIndex = 8;
            this.timer2value.Text = "timer 2";
            // 
            // timer3value
            // 
            this.timer3value.AutoSize = true;
            this.timer3value.Location = new System.Drawing.Point(54, 387);
            this.timer3value.Name = "timer3value";
            this.timer3value.Size = new System.Drawing.Size(38, 13);
            this.timer3value.TabIndex = 9;
            this.timer3value.Text = "timer 3";
            // 
            // starttime
            // 
            this.starttime.AutoSize = true;
            this.starttime.Location = new System.Drawing.Point(461, 290);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(87, 13);
            this.starttime.TabIndex = 10;
            this.starttime.Text = "Time started: null";
            // 
            // timert1
            // 
            this.timert1.AutoSize = true;
            this.timert1.Location = new System.Drawing.Point(273, 329);
            this.timert1.Name = "timert1";
            this.timert1.Size = new System.Drawing.Size(49, 13);
            this.timert1.TabIndex = 11;
            this.timert1.Text = "00:00.00";
            // 
            // timert2
            // 
            this.timert2.AutoSize = true;
            this.timert2.Location = new System.Drawing.Point(273, 358);
            this.timert2.Name = "timert2";
            this.timert2.Size = new System.Drawing.Size(49, 13);
            this.timert2.TabIndex = 12;
            this.timert2.Text = "00:00.00";
            // 
            // timert3
            // 
            this.timert3.AutoSize = true;
            this.timert3.Location = new System.Drawing.Point(273, 387);
            this.timert3.Name = "timert3";
            this.timert3.Size = new System.Drawing.Size(49, 13);
            this.timert3.TabIndex = 13;
            this.timert3.Text = "00:00.00";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(618, 537);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(154, 15);
            this.copyright.TabIndex = 14;
            this.copyright.Text = "© Niels Arensman 2017";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.timert3);
            this.Controls.Add(this.timert2);
            this.Controls.Add(this.timert1);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.timer3value);
            this.Controls.Add(this.timer2value);
            this.Controls.Add(this.timer1value);
            this.Controls.Add(this.captureButton3);
            this.Controls.Add(this.captureButton2);
            this.Controls.Add(this.captureButton1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Clock_timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button captureButton1;
        private System.Windows.Forms.Button captureButton2;
        private System.Windows.Forms.Button captureButton3;
        private System.Windows.Forms.Label timer1value;
        private System.Windows.Forms.Label timer2value;
        private System.Windows.Forms.Label timer3value;
        private System.Windows.Forms.Label starttime;
        private System.Windows.Forms.Label timert1;
        private System.Windows.Forms.Label timert2;
        private System.Windows.Forms.Label timert3;
        private System.Windows.Forms.Label copyright;
    }
}


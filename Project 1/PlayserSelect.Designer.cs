namespace Project_1
{
    partial class PlayserSelect
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MPSelPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SPSelPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.MPSelPanel.SuspendLayout();
            this.SPSelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Quizzer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to Music Quizzer.\r\nPlease select your player option.";
            // 
            // MPSelPanel
            // 
            this.MPSelPanel.BackColor = System.Drawing.Color.Silver;
            this.MPSelPanel.Controls.Add(this.label3);
            this.MPSelPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MPSelPanel.Location = new System.Drawing.Point(366, 171);
            this.MPSelPanel.Name = "MPSelPanel";
            this.MPSelPanel.Size = new System.Drawing.Size(150, 150);
            this.MPSelPanel.TabIndex = 2;
            this.MPSelPanel.Click += new System.EventHandler(this.MPSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(47, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Multi Player";
            // 
            // SPSelPanel
            // 
            this.SPSelPanel.BackColor = System.Drawing.Color.Silver;
            this.SPSelPanel.Controls.Add(this.label4);
            this.SPSelPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SPSelPanel.Location = new System.Drawing.Point(76, 171);
            this.SPSelPanel.Name = "SPSelPanel";
            this.SPSelPanel.Size = new System.Drawing.Size(150, 150);
            this.SPSelPanel.TabIndex = 3;
            this.SPSelPanel.Click += new System.EventHandler(this.SPSelect);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(22, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Single Player";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::Project_1.Properties.Resources.close;
            this.btnExit.InitialImage = global::Project_1.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(567, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PlayserSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 391);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.SPSelPanel);
            this.Controls.Add(this.MPSelPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlayserSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Quizzer";
            this.MPSelPanel.ResumeLayout(false);
            this.MPSelPanel.PerformLayout();
            this.SPSelPanel.ResumeLayout(false);
            this.SPSelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel MPSelPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel SPSelPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnExit;
    }
}


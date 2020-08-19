namespace Project_1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlGameMoves = new System.Windows.Forms.Panel();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSide = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameMoves
            // 
            this.pnlGameMoves.Location = new System.Drawing.Point(39, 169);
            this.pnlGameMoves.Name = "pnlGameMoves";
            this.pnlGameMoves.Size = new System.Drawing.Size(196, 495);
            this.pnlGameMoves.TabIndex = 1;
            // 
            // pnlUsers
            // 
            this.pnlUsers.Location = new System.Drawing.Point(39, 43);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(196, 90);
            this.pnlUsers.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(223, 12);
            this.btnExit.MaximumSize = new System.Drawing.Size(25, 25);
            this.btnExit.MinimumSize = new System.Drawing.Size(15, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Project_1.Properties.Resources.Map;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1836, 686);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(2500, 2500);
            this.panel1.MinimumSize = new System.Drawing.Size(150, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1830, 692);
            this.panel1.TabIndex = 7;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.Transparent;
            this.pnlSide.Controls.Add(this.pnlGameMoves);
            this.pnlSide.Controls.Add(this.pnlUsers);
            this.pnlSide.Controls.Add(this.btnExit);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSide.Location = new System.Drawing.Point(1570, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(260, 692);
            this.pnlSide.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 692);
            this.ControlBox = false;
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlSide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlGameMoves;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSide;
    }
}
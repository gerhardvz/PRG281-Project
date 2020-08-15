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
            this.pnlGameMoves = new System.Windows.Forms.Panel();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlGameMoves
            // 
            this.pnlGameMoves.Location = new System.Drawing.Point(1376, 334);
            this.pnlGameMoves.Name = "pnlGameMoves";
            this.pnlGameMoves.Size = new System.Drawing.Size(268, 566);
            this.pnlGameMoves.TabIndex = 1;
            // 
            // pnlUsers
            // 
            this.pnlUsers.Location = new System.Drawing.Point(1376, 59);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(364, 151);
            this.pnlUsers.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 967);
            this.ControlBox = false;
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.pnlGameMoves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlGameMoves;
        private System.Windows.Forms.Panel pnlUsers;
    }
}
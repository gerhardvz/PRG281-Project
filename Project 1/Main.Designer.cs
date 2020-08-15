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
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.pnlGameMoves = new System.Windows.Forms.Panel();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.pnlGameBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.Controls.Add(this.picMap);
            this.pnlGameBoard.Location = new System.Drawing.Point(102, 115);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(650, 562);
            this.pnlGameBoard.TabIndex = 0;
            // 
            // pnlGameMoves
            // 
            this.pnlGameMoves.Location = new System.Drawing.Point(807, 110);
            this.pnlGameMoves.Name = "pnlGameMoves";
            this.pnlGameMoves.Size = new System.Drawing.Size(268, 566);
            this.pnlGameMoves.TabIndex = 1;
            // 
            // pnlUsers
            // 
            this.pnlUsers.Location = new System.Drawing.Point(1133, 111);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(364, 151);
            this.pnlUsers.TabIndex = 2;
            // 
            // picMap
            // 
            this.picMap.Image = global::Project_1.Properties.Resources.Map;
            this.picMap.Location = new System.Drawing.Point(21, 30);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(602, 514);
            this.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 814);
            this.ControlBox = false;
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.pnlGameMoves);
            this.Controls.Add(this.pnlGameBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.pnlGameBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Panel pnlGameMoves;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.PictureBox picMap;
    }
}
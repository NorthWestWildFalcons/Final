namespace Final
{
    partial class Game1
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
            this.block1 = new System.Windows.Forms.TextBox();
            this.block2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // block1
            // 
            this.block1.Location = new System.Drawing.Point(1, 141);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(799, 20);
            this.block1.TabIndex = 0;
            // 
            // block2
            // 
            this.block2.Location = new System.Drawing.Point(1, 26);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(799, 20);
            this.block2.TabIndex = 1;
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.block1);
            this.Name = "Game1";
            this.Text = "Game1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox block1;
        private System.Windows.Forms.TextBox block2;
    }
}
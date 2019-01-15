namespace Final
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
            this.btnGame2 = new System.Windows.Forms.Button();
            this.btnGame3 = new System.Windows.Forms.Button();
            this.btnGame4 = new System.Windows.Forms.Button();
            this.btnGame1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame2
            // 
            this.btnGame2.BackColor = System.Drawing.Color.White;
            this.btnGame2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame2.Location = new System.Drawing.Point(198, 210);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Size = new System.Drawing.Size(150, 65);
            this.btnGame2.TabIndex = 2;
            this.btnGame2.Text = ">Score";
            this.btnGame2.UseVisualStyleBackColor = false;
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            // 
            // btnGame3
            // 
            this.btnGame3.BackColor = System.Drawing.Color.White;
            this.btnGame3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame3.Location = new System.Drawing.Point(26, 311);
            this.btnGame3.Name = "btnGame3";
            this.btnGame3.Size = new System.Drawing.Size(150, 65);
            this.btnGame3.TabIndex = 3;
            this.btnGame3.Text = "Testing Game 3";
            this.btnGame3.UseVisualStyleBackColor = false;
            this.btnGame3.Click += new System.EventHandler(this.btnGame3_Click);
            // 
            // btnGame4
            // 
            this.btnGame4.BackColor = System.Drawing.Color.White;
            this.btnGame4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame4.Location = new System.Drawing.Point(198, 311);
            this.btnGame4.Name = "btnGame4";
            this.btnGame4.Size = new System.Drawing.Size(150, 65);
            this.btnGame4.TabIndex = 4;
            this.btnGame4.Text = "Testing Game 4";
            this.btnGame4.UseVisualStyleBackColor = false;
            this.btnGame4.Click += new System.EventHandler(this.btnGame4_Click);
            // 
            // btnGame1
            // 
            this.btnGame1.BackColor = System.Drawing.Color.White;
            this.btnGame1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame1.Location = new System.Drawing.Point(26, 210);
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.Size = new System.Drawing.Size(150, 65);
            this.btnGame1.TabIndex = 1;
            this.btnGame1.Text = "> Start Game";
            this.btnGame1.UseVisualStyleBackColor = false;
            this.btnGame1.Click += new System.EventHandler(this.btnGame1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGame1);
            this.Controls.Add(this.btnGame4);
            this.Controls.Add(this.btnGame3);
            this.Controls.Add(this.btnGame2);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGame2;
        private System.Windows.Forms.Button btnGame3;
        private System.Windows.Forms.Button btnGame4;
        private System.Windows.Forms.Button btnGame1;
    }
}


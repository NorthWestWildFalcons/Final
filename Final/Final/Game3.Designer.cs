namespace Final
{
    partial class Game3
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
            this.components = new System.ComponentModel.Container();
            this.PictureHolder = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.PictureHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureHolder
            // 
            this.PictureHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PictureHolder.Controls.Add(this.lblTimer);
            this.PictureHolder.Controls.Add(this.pic4);
            this.PictureHolder.Controls.Add(this.pic3);
            this.PictureHolder.Controls.Add(this.pic2);
            this.PictureHolder.Controls.Add(this.pic1);
            this.PictureHolder.Location = new System.Drawing.Point(60, 48);
            this.PictureHolder.Name = "PictureHolder";
            this.PictureHolder.Size = new System.Drawing.Size(355, 361);
            this.PictureHolder.TabIndex = 0;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(162, 307);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(28, 26);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "5";
            // 
            // pic4
            // 
            this.pic4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic4.Image = global::Final.Properties.Resources.picback3;
            this.pic4.Location = new System.Drawing.Point(207, 196);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(123, 137);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabIndex = 3;
            this.pic4.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic3.Image = global::Final.Properties.Resources.picback2;
            this.pic3.Location = new System.Drawing.Point(24, 196);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(123, 137);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic2.Image = global::Final.Properties.Resources.picback1;
            this.pic2.Location = new System.Drawing.Point(207, 26);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(123, 137);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic1.Image = global::Final.Properties.Resources.picback;
            this.pic1.Location = new System.Drawing.Point(25, 26);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(123, 137);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 555);
            this.Controls.Add(this.PictureHolder);
            this.Name = "Game3";
            this.Text = "Game3";
            this.Load += new System.EventHandler(this.Game3_Load);
            this.PictureHolder.ResumeLayout(false);
            this.PictureHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PictureHolder;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}
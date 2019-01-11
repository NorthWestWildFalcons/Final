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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.rectangle1 = new System.Windows.Forms.PictureBox();
            this.rectangle2 = new System.Windows.Forms.PictureBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCountdown = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.rectangle1);
            this.panel1.Controls.Add(this.rectangle2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 550);
            this.panel1.TabIndex = 0;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Yellow;
            this.player.Location = new System.Drawing.Point(191, 502);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(90, 40);
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // rectangle1
            // 
            this.rectangle1.BackColor = System.Drawing.Color.Red;
            this.rectangle1.Location = new System.Drawing.Point(-12, 240);
            this.rectangle1.Name = "rectangle1";
            this.rectangle1.Size = new System.Drawing.Size(589, 25);
            this.rectangle1.TabIndex = 1;
            this.rectangle1.TabStop = false;
            // 
            // rectangle2
            // 
            this.rectangle2.BackColor = System.Drawing.Color.Red;
            this.rectangle2.Location = new System.Drawing.Point(-12, 36);
            this.rectangle2.Name = "rectangle2";
            this.rectangle2.Size = new System.Drawing.Size(518, 30);
            this.rectangle2.TabIndex = 0;
            this.rectangle2.TabStop = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(489, 488);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(258, 48);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Press Space to Change Color\r\n Press R to Reset";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(604, 13);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(20, 24);
            this.lblCountdown.TabIndex = 2;
            this.lblCountdown.Text = "5";
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 556);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.panel1);
            this.Name = "Game1";
            this.Text = "Game1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyisDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox rectangle1;
        private System.Windows.Forms.PictureBox rectangle2;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label lblCountdown;
    }
}
namespace Final
{
    partial class Game4
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSymbol1 = new System.Windows.Forms.Label();
            this.lblSymbol4 = new System.Windows.Forms.Label();
            this.lblSymbol3 = new System.Windows.Forms.Label();
            this.lblSymbol2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblSymbol1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSymbol4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSymbol3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSymbol2, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(123, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 224);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSymbol1
            // 
            this.lblSymbol1.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblSymbol1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSymbol1.Location = new System.Drawing.Point(3, 0);
            this.lblSymbol1.Name = "lblSymbol1";
            this.lblSymbol1.Size = new System.Drawing.Size(122, 112);
            this.lblSymbol1.TabIndex = 0;
            this.lblSymbol1.Text = "c";
            this.lblSymbol1.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // lblSymbol4
            // 
            this.lblSymbol4.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblSymbol4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSymbol4.Location = new System.Drawing.Point(131, 112);
            this.lblSymbol4.Name = "lblSymbol4";
            this.lblSymbol4.Size = new System.Drawing.Size(122, 112);
            this.lblSymbol4.TabIndex = 2;
            this.lblSymbol4.Text = "c";
            this.lblSymbol4.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // lblSymbol3
            // 
            this.lblSymbol3.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblSymbol3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSymbol3.Location = new System.Drawing.Point(131, 0);
            this.lblSymbol3.Name = "lblSymbol3";
            this.lblSymbol3.Size = new System.Drawing.Size(122, 112);
            this.lblSymbol3.TabIndex = 1;
            this.lblSymbol3.Text = "c";
            this.lblSymbol3.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // lblSymbol2
            // 
            this.lblSymbol2.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblSymbol2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSymbol2.Location = new System.Drawing.Point(3, 112);
            this.lblSymbol2.Name = "lblSymbol2";
            this.lblSymbol2.Size = new System.Drawing.Size(122, 112);
            this.lblSymbol2.TabIndex = 3;
            this.lblSymbol2.Text = "c";
            this.lblSymbol2.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // Game4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Game4";
            this.Text = "Game4";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSymbol1;
        private System.Windows.Forms.Label lblSymbol4;
        private System.Windows.Forms.Label lblSymbol3;
        private System.Windows.Forms.Label lblSymbol2;
    }
}
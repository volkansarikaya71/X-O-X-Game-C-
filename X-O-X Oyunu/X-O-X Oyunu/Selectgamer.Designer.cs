namespace X_O_X_Oyunu
{
    partial class Selectgamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selectgamer));
            this.random = new System.Windows.Forms.PictureBox();
            this.oyuncu1 = new System.Windows.Forms.Label();
            this.oyuncu2 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.random)).BeginInit();
            this.SuspendLayout();
            // 
            // random
            // 
            this.random.BackColor = System.Drawing.Color.Transparent;
            this.random.Cursor = System.Windows.Forms.Cursors.Hand;
            this.random.Image = ((System.Drawing.Image)(resources.GetObject("random.Image")));
            this.random.Location = new System.Drawing.Point(161, 134);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(174, 30);
            this.random.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.random.TabIndex = 2;
            this.random.TabStop = false;
            this.random.Click += new System.EventHandler(this.player1_Click);
            this.random.MouseMove += new System.Windows.Forms.MouseEventHandler(this.player1_MouseMove);
            // 
            // oyuncu1
            // 
            this.oyuncu1.AutoSize = true;
            this.oyuncu1.BackColor = System.Drawing.Color.Transparent;
            this.oyuncu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oyuncu1.Font = new System.Drawing.Font("Counter-Strike", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oyuncu1.ForeColor = System.Drawing.Color.Maroon;
            this.oyuncu1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.oyuncu1.Location = new System.Drawing.Point(46, 81);
            this.oyuncu1.Name = "oyuncu1";
            this.oyuncu1.Size = new System.Drawing.Size(150, 26);
            this.oyuncu1.TabIndex = 3;
            this.oyuncu1.Text = "oyuncu1";
            this.oyuncu1.Click += new System.EventHandler(this.label1_Click);
            this.oyuncu1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // oyuncu2
            // 
            this.oyuncu2.AutoSize = true;
            this.oyuncu2.BackColor = System.Drawing.Color.Transparent;
            this.oyuncu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oyuncu2.Font = new System.Drawing.Font("Counter-Strike", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oyuncu2.ForeColor = System.Drawing.Color.Maroon;
            this.oyuncu2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.oyuncu2.Location = new System.Drawing.Point(314, 81);
            this.oyuncu2.Name = "oyuncu2";
            this.oyuncu2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oyuncu2.Size = new System.Drawing.Size(134, 26);
            this.oyuncu2.TabIndex = 4;
            this.oyuncu2.Text = "label2";
            this.oyuncu2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.oyuncu2.Click += new System.EventHandler(this.label2_Click);
            this.oyuncu2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Counter-Strike", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.Maroon;
            this.txt.Location = new System.Drawing.Point(46, 25);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(402, 26);
            this.txt.TabIndex = 5;
            this.txt.Text = "OYUNA KİM BAŞLASIN";
            // 
            // Selectgamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(496, 198);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.oyuncu2);
            this.Controls.Add(this.oyuncu1);
            this.Controls.Add(this.random);
            this.Name = "Selectgamer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selectgamer";
            this.Load += new System.EventHandler(this.Selectgamer_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Selectgamer_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.random)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox random;
        private System.Windows.Forms.Label oyuncu1;
        private System.Windows.Forms.Label oyuncu2;
        private System.Windows.Forms.Label txt;
    }
}
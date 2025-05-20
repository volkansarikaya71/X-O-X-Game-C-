namespace X_O_X_Oyunu
{
    partial class Home
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.playernick = new System.Windows.Forms.PictureBox();
            this.playernick2 = new System.Windows.Forms.PictureBox();
            this.nickname2 = new System.Windows.Forms.TextBox();
            this.nickname = new System.Windows.Forms.TextBox();
            this.easy = new System.Windows.Forms.PictureBox();
            this.hard = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.backmod = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playernick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playernick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backmod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player1.Image = ((System.Drawing.Image)(resources.GetObject("player1.Image")));
            this.player1.Location = new System.Drawing.Point(230, 155);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(238, 61);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 1;
            this.player1.TabStop = false;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            this.player1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.player1_MouseMove);
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player2.Image = ((System.Drawing.Image)(resources.GetObject("player2.Image")));
            this.player2.Location = new System.Drawing.Point(232, 254);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(232, 49);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 2;
            this.player2.TabStop = false;
            this.player2.Click += new System.EventHandler(this.player2_Click);
            this.player2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.player2_MouseMove);
            // 
            // playernick
            // 
            this.playernick.BackColor = System.Drawing.Color.Transparent;
            this.playernick.Image = ((System.Drawing.Image)(resources.GetObject("playernick.Image")));
            this.playernick.Location = new System.Drawing.Point(3, 311);
            this.playernick.Name = "playernick";
            this.playernick.Size = new System.Drawing.Size(223, 41);
            this.playernick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playernick.TabIndex = 3;
            this.playernick.TabStop = false;
            this.playernick.Visible = false;
            // 
            // playernick2
            // 
            this.playernick2.BackColor = System.Drawing.Color.Transparent;
            this.playernick2.Image = ((System.Drawing.Image)(resources.GetObject("playernick2.Image")));
            this.playernick2.Location = new System.Drawing.Point(475, 318);
            this.playernick2.Name = "playernick2";
            this.playernick2.Size = new System.Drawing.Size(197, 34);
            this.playernick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playernick2.TabIndex = 5;
            this.playernick2.TabStop = false;
            this.playernick2.Visible = false;
            // 
            // nickname2
            // 
            this.nickname2.BackColor = System.Drawing.Color.Black;
            this.nickname2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nickname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nickname2.ForeColor = System.Drawing.Color.White;
            this.nickname2.Location = new System.Drawing.Point(475, 381);
            this.nickname2.MaxLength = 10;
            this.nickname2.Name = "nickname2";
            this.nickname2.Size = new System.Drawing.Size(197, 45);
            this.nickname2.TabIndex = 6;
            this.nickname2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nickname2.Visible = false;
            // 
            // nickname
            // 
            this.nickname.BackColor = System.Drawing.Color.Black;
            this.nickname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nickname.ForeColor = System.Drawing.Color.White;
            this.nickname.Location = new System.Drawing.Point(12, 381);
            this.nickname.MaxLength = 10;
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(197, 45);
            this.nickname.TabIndex = 7;
            this.nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nickname.Visible = false;
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Transparent;
            this.easy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easy.Image = ((System.Drawing.Image)(resources.GetObject("easy.Image")));
            this.easy.Location = new System.Drawing.Point(232, 318);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(232, 42);
            this.easy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.easy.TabIndex = 8;
            this.easy.TabStop = false;
            this.easy.Visible = false;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            this.easy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.easy_MouseMove);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Transparent;
            this.hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hard.Image = ((System.Drawing.Image)(resources.GetObject("hard.Image")));
            this.hard.Location = new System.Drawing.Point(230, 395);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(232, 42);
            this.hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hard.TabIndex = 9;
            this.hard.TabStop = false;
            this.hard.Visible = false;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            this.hard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hard_MouseMove);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(499, 165);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(128, 128);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.back.TabIndex = 10;
            this.back.TabStop = false;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            this.back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.back_MouseMove);
            // 
            // backmod
            // 
            this.backmod.BackColor = System.Drawing.Color.Transparent;
            this.backmod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backmod.Image = ((System.Drawing.Image)(resources.GetObject("backmod.Image")));
            this.backmod.Location = new System.Drawing.Point(429, 366);
            this.backmod.Name = "backmod";
            this.backmod.Size = new System.Drawing.Size(33, 23);
            this.backmod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backmod.TabIndex = 11;
            this.backmod.TabStop = false;
            this.backmod.Visible = false;
            this.backmod.Click += new System.EventHandler(this.backmod_Click);
            this.backmod.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backmod_MouseMove);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.Location = new System.Drawing.Point(27, 42);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(167, 50);
            this.start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start.TabIndex = 12;
            this.start.TabStop = false;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            this.start.MouseMove += new System.Windows.Forms.MouseEventHandler(this.start_MouseMove);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.start);
            this.Controls.Add(this.backmod);
            this.Controls.Add(this.back);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.nickname2);
            this.Controls.Add(this.playernick2);
            this.Controls.Add(this.playernick);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playernick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playernick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backmod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox playernick;
        private System.Windows.Forms.PictureBox playernick2;
        private System.Windows.Forms.TextBox nickname2;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.PictureBox easy;
        private System.Windows.Forms.PictureBox hard;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox backmod;
        private System.Windows.Forms.PictureBox start;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_X_Oyunu
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public string playername, playername2, mod;
        public int x, y, width, height;
        public void addstartbutton()
        {
            start.Visible = true;
            start.SetBounds(x, y, width, height);
            this.Controls.Add(start);
            start.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "start.png"));
            start.BackColor = Color.Transparent;
        }

        public void nickadd()
        {
            playernick.Visible = true;
            nickname.Visible = true;
            player1.Visible = false;
            player2.Visible = false;
            back.Visible = true;
        }
        public void reversenickadd()
        {
            playernick.Visible = false;
            nickname.Visible = false;
            player1.Visible = true;
            player2.Visible = true;
            back.Visible = false;
            easy.Visible = false;
            hard.Visible = false;
            playernick2.Visible = false;
            nickname2.Visible = false;
            nickname.Clear();
            nickname2.Clear();
            backmod.Visible = false;
            start.Visible = false;
        }
        public void buttuncolor()
        {
            player1.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "1.player.png"));
            player2.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "2.player.png"));
            hard.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "hard.png"));
            easy.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "easy.png"));
            back.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "left-arrow.png"));
            backmod.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "left-arrow.png"));
            start.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "start.png"));
        }


        private void Home_Load(object sender, EventArgs e)
        {


        }

        private void player1_Click(object sender, EventArgs e)
        {
            nickadd();
            easy.Visible = true;
            hard.Visible = true;
            start.Visible = true;
            start.SetBounds(499, 358, 167, 50);
            mod = "0";
        }

        private void player2_Click(object sender, EventArgs e)
        {
            nickadd();
            playernick2.Visible = true;
            nickname2.Visible = true;
            mod = "3";
            start.Visible = true;
            start.SetBounds(268, 355, 167, 50);
        }

        private void back_Click(object sender, EventArgs e)
        {
            reversenickadd ();

        }

        private void player1_MouseMove(object sender, MouseEventArgs e)
        {
            player1.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "1.player.ters.png"));
            player2.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "2.player.png"));
        }

        private void player2_MouseMove(object sender, MouseEventArgs e)
        {
            player2.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "2.player.ters.png"));
            player1.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "1.player.png"));
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            buttuncolor();
        }

        private void easy_MouseMove(object sender, MouseEventArgs e)
        {
            easy.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "easy.ters.png"));
            hard.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "hard.png"));
        }

        private void easy_Click(object sender, EventArgs e)
        {
            hard.Visible = false;
            backmod.Visible = true;
            mod = "1";
        }

        private void start_Click(object sender, EventArgs e)
        {

            if(nickname2.Visible==false)
            {
                if(mod == "1" || mod == "2")
                {
                    Selectgamer selectgamer = new Selectgamer();
                    selectgamer.nickname1 = nickname.Text;
                    selectgamer.nickname2 = "Computer";
                    selectgamer.zorluk = mod;
                    selectgamer.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("lütfen oyun zorlugu seçin!");
                }  
            }
            else if (mod == "3")
            {
                Selectgamer selectgamer = new Selectgamer();
                selectgamer.nickname1 = nickname.Text;
                selectgamer.nickname2 = nickname2.Text;
                selectgamer.zorluk = mod;
                selectgamer.Show();
                this.Hide();
            }
        }

        private void start_MouseMove(object sender, MouseEventArgs e)
        {
            start.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "start.ters.png"));
        }

        private void hard_Click(object sender, EventArgs e)
        {
            easy.Visible = false;
            backmod.Visible = true;
            mod = "2";
        }

        private void backmod_Click(object sender, EventArgs e)
        {
            backmod.Visible = false;
            hard.Visible = true;
            easy.Visible = true;
        }

        private void backmod_MouseMove(object sender, MouseEventArgs e)
        {
            backmod.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "left-arrow.ters.png"));
        }

        private void hard_MouseMove(object sender, MouseEventArgs e)
        {
            hard.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "hard.ters.png"));
            easy.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "easy.png"));          
        }

        private void back_MouseMove(object sender, MouseEventArgs e)
        {
            back.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "resim", "left-arrow.ters.png"));
        }
    }
}

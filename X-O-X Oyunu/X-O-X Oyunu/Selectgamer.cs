using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_X_Oyunu
{
    public partial class Selectgamer : Form
    {
        public Selectgamer()
        {
            InitializeComponent();
        }
        public string nickname1, nickname2, zorluk, basliyacakolan;

        public void sıra()
        {
            Game game = new Game();
            game.nickname1 = nickname1;
            game.nickname2 = nickname2;
            game.zorluk = zorluk;
            game.oyunabaslayan = basliyacakolan;
            game.Show();
            this.Hide();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            oyuncu1.ForeColor = Color.Black;
            oyuncu2.ForeColor = Color.Maroon;
            random.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\random.png");

        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            oyuncu1.ForeColor = Color.Maroon;
            oyuncu2.ForeColor = Color.Black;
            random.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\random.png");

        }

        private void player1_MouseMove(object sender, MouseEventArgs e)
        {
            oyuncu1.ForeColor = Color.Maroon;
            oyuncu2.ForeColor = Color.Maroon;
            random.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\random.ters.png");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            basliyacakolan = "0";
            sıra();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            basliyacakolan = "1";
            sıra();
        }

        private void player1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            basliyacakolan =Convert.ToString(rastgele.Next(2));
            sıra();
        }

        private void Selectgamer_MouseMove(object sender, MouseEventArgs e)
        {
            oyuncu1.ForeColor=Color.Maroon;
            oyuncu2.ForeColor = Color.Maroon;
            random.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\random.png");
        }

        private void Selectgamer_Load(object sender, EventArgs e)
        {
            oyuncu1.Text = nickname1;
            oyuncu2.Text = nickname2;

        }
    }
}

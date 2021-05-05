using System;
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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public string nickname1, nickname2,zorluk,oyunabaslayan, buttunno;
        public int puan1 = 0, puan2 = 0, buttonsayac = 0,kontrol=0,dongukontrol=1;

   

        private void kutu3_Click(object sender, EventArgs e)
        {
            if (zorluk == "1")
            {
                buttunno = "3";
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();
                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            easy();
                        }
                    }
                }

            }
            else if (zorluk == "2")
            {
                buttunno = "3"; ;
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            hard();

                        }
                    }
                }

            }
            else if (zorluk == "3")
            {
                buttunno = "3";
                buttonsecme();
                kazanma();
                berabere();
            }
        }

        private void kutu4_Click(object sender, EventArgs e)
        {
            if (zorluk == "1")
            {
                buttunno = "4";
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();
                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            easy();

                        }
                    }
                }

            }
            else if (zorluk == "3")
            {
                buttunno = "4";
                buttonsecme();
                kazanma();
                berabere();
            }
            else if (zorluk == "2")
            {
                buttunno = "4"; ;
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            hard();

                        }
                    }
                }

            }
        }

        private void kutu5_Click(object sender, EventArgs e)
        {
            if (zorluk == "1")
            {
                buttunno = "5";
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();
                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            easy();

                        }
                    }
                }

            }
            else if (zorluk == "2")
            {
                buttunno = "5"; ;
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            hard();

                        }
                    }
                }

            }
            else if (zorluk == "3")
            {
                buttunno = "5";
                buttonsecme();
                kazanma();
                berabere();
            }
        }

        private void kutu6_Click(object sender, EventArgs e)
        {
            if (zorluk == "1")
            {
                buttunno = "6";
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();
                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            easy();

                        }
                    }
                }

            }
            else if (zorluk == "2")
            {
                buttunno = "6"; ;
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            hard();

                        }
                    }
                }

            }
            else if (zorluk == "3")
            {
                buttunno = "6";
                buttonsecme();
                kazanma();
                berabere();
            }
        }

        private void kutu7_Click(object sender, EventArgs e)
        {
            if (zorluk == "1")
            {
                buttunno = "7";
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            berabere();
                            kazanma();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            easy();
                            kazanma();
                            berabere();

                        }
                    }
                }

            }
            else if (zorluk == "2")
            {
                buttunno = "7"; ;
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            hard();
                        }
                    }
                }

            }
            else if (zorluk == "3")
            {
                buttunno = "7";
                buttonsecme();
                kazanma();
                berabere();
            }
        }

        private void kutu8_Click(object sender, EventArgs e)
        {
            if (zorluk == "1")
            {
                buttunno = "8";
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();
                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            easy();
                        }
                    }
                }

            }
            else if (zorluk == "2")
            {
                buttunno = "8"; ;
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            hard();

                        }
                    }
                }

            }
            else if (zorluk == "3")
            {
                buttunno = "8";
                buttonsecme();
                kazanma();
                berabere();
            }
        }

        private void kutu9_Click(object sender, EventArgs e)
        {
            if (zorluk == "1")
            {
                buttunno = "9";;
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            easy();

                        }
                    }
                }

            }
            else if (zorluk == "2")
            {
                buttunno = "9"; ;
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            hard();

                        }
                    }
                }

            }
            else if (zorluk == "3")
            {
                buttunno = "9";
                buttonsecme();
                kazanma();
                berabere();
            }
        }

        private void kutu2_Click(object sender, EventArgs e)
        {
            if (zorluk == "1")
            {
                buttunno = "2";
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            easy ();
                        }
                    }
                }
            }
            else if (zorluk == "2")
            {
                buttunno = "2"; ;
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            hard();
                        }
                    }
                }

            }
            else if (zorluk == "3")
            {
                buttunno = "2";
                buttonsecme();
                kazanma();
                berabere();
            }
        }
        public void button1gif()
        {
            if (kutu1.BackColor == Color.White)
            {
                kutu1.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                buttonsayac++;
            }
            else if (kutu1.BackColor == Color.Black)
            {
                kutu1.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                buttonsayac++;
            }
            else if (kutu1.BackColor == Color.Transparent)
            {
                kutu1.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                buttonsayac++;
            }
        }
        public void button2gif()
        {
            if (kutu2.BackColor == Color.White)
            {
                kutu2.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                buttonsayac++;
            }
            else if (kutu2.BackColor == Color.Black)
            {
                kutu2.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                buttonsayac++;
            }
            else if (kutu2.BackColor == Color.Transparent)
            {
                kutu2.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                buttonsayac++;
            }
        }
        public void button3gif()
        {
            if (kutu3.BackColor == Color.White)
            {
                kutu3.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                buttonsayac++;
            }
            else if (kutu3.BackColor == Color.Black)
            {
                kutu3.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                buttonsayac++;
            }
            else if (kutu3.BackColor == Color.Transparent)
            {
                kutu3.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                buttonsayac++;
            }
        }
        public void button4gif()
        {
            if (kutu4.BackColor == Color.White)
            {
                kutu4.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                buttonsayac++;
            }
            else if (kutu4.BackColor == Color.Black)
            {
                kutu4.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                buttonsayac++;
            }
            else if (kutu4.BackColor == Color.Transparent)
            {
                kutu4.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                buttonsayac++;
            }
        }
        public void button5gif()
        {
            if (kutu5.BackColor == Color.White)
            {
                kutu5.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                buttonsayac++;
            }
            else if (kutu5.BackColor == Color.Black)
            {
                kutu5.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                buttonsayac++;
            }
            else if (kutu5.BackColor == Color.Transparent)
            {
                kutu5.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                buttonsayac++;
            }
        }
        public void button6gif()
        {
            if (kutu6.BackColor == Color.White)
            {
                kutu6.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                buttonsayac++;
            }
            else if (kutu6.BackColor == Color.Black)
            {
                kutu6.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                buttonsayac++;
            }
            else if (kutu6.BackColor == Color.Transparent)
            {
                kutu6.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                buttonsayac++;
            }
        }
        public void button7gif()
        {
            if (kutu7.BackColor == Color.White)
            {
                kutu7.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                buttonsayac++;
            }
            else if (kutu7.BackColor == Color.Black)
            {
                kutu7.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                buttonsayac++;
            }
            else if (kutu7.BackColor == Color.Transparent)
            {
                kutu7.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                buttonsayac++;
            }
        }
        public void button8gif()
        {
            if (kutu8.BackColor == Color.White)
            {
                kutu8.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                buttonsayac++;
            }
            else if (kutu8.BackColor == Color.Black)
            {
                kutu8.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                buttonsayac++;
            }
            else if (kutu8.BackColor == Color.Transparent)
            {
                kutu8.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                buttonsayac++;
            }
        }
        public void button9gif()
        {
            if (kutu9.BackColor == Color.White)
            {
                kutu9.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                buttonsayac++;
            }
            else if (kutu9.BackColor == Color.Black)
            {
                kutu9.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                buttonsayac++;
            }
            else if (kutu9.BackColor == Color.Transparent)
            {
                kutu9.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                buttonsayac++;
            }
        }

        private void kutu1_MouseMove(object sender, MouseEventArgs e)
        {
            button2gif();
            button3gif();
            button4gif();
            button5gif();
            button6gif();
            button7gif();
            button8gif();
            button9gif();
            if (oyunabaslayan == "0")
            {
                kutu1.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.gif");
                
            }
            else
            {
                kutu1.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.gif");
            }
        }

        private void kutu2_MouseMove(object sender, MouseEventArgs e)
        {
            button1gif();
            button3gif();
            button4gif();
            button5gif();
            button6gif();
            button7gif();
            button8gif();
            button9gif();
            if (oyunabaslayan == "0")
            {
                kutu2.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.gif");
            }
            else
            {
                kutu2.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.gif");
            }
        }
        public void easykazanmaengelleme()
        {
            kontrol = 1;
            if (kutu1.BackColor == Color.White && kutu2.BackColor == Color.White && kutu3.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu3, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu4.BackColor == Color.White && kutu5.BackColor == Color.White && kutu6.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu6, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu7.BackColor == Color.White && kutu8.BackColor == Color.White && kutu9.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu9, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu2.BackColor == Color.White && kutu3.BackColor == Color.White && kutu1.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu1, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu5.BackColor == Color.White && kutu6.BackColor == Color.White && kutu4.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu4, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu8.BackColor == Color.White && kutu9.BackColor == Color.White && kutu7.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu7, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu1.BackColor == Color.White && kutu3.BackColor == Color.White && kutu2.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu2, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu4.BackColor == Color.White && kutu6.BackColor == Color.White && kutu5.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu5, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu7.BackColor == Color.White && kutu9.BackColor == Color.White && kutu8.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu8, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            //////sağdan sora  engelleme
            else if (kutu1.BackColor == Color.White && kutu4.BackColor == Color.White && kutu7.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu7, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu1.BackColor == Color.White && kutu7.BackColor == Color.White && kutu4.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu4, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu4.BackColor == Color.White && kutu7.BackColor == Color.White && kutu1.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu1, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu2.BackColor == Color.White && kutu5.BackColor == Color.White && kutu8.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu8, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu5.BackColor == Color.White && kutu8.BackColor == Color.White && kutu2.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu2, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu8.BackColor == Color.White && kutu2.BackColor == Color.White && kutu5.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu5, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu3.BackColor == Color.White && kutu6.BackColor == Color.White && kutu9.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu9, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu9.BackColor == Color.White && kutu6.BackColor == Color.White && kutu3.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu3, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu3.BackColor == Color.White && kutu9.BackColor == Color.White && kutu6.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu6, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            /////yukarıdan aşağı engelleme
            else if (kutu3.BackColor == Color.White && kutu5.BackColor == Color.White && kutu7.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu7, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu5.BackColor == Color.White && kutu7.BackColor == Color.White && kutu3.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu3, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu3.BackColor == Color.White && kutu7.BackColor == Color.White && kutu5.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu5, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu1.BackColor == Color.White && kutu5.BackColor == Color.White && kutu9.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu9, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu9.BackColor == Color.White && kutu1.BackColor == Color.White && kutu5.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu5, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu5.BackColor == Color.White && kutu9.BackColor == Color.White && kutu1.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu1, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            //////////////çarplazlama engelleme
        }
        public void botwin()
        {
            kontrol = 2;
            if (kutu1.BackColor == Color.Black && kutu2.BackColor == Color.Black && kutu3.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu3, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu4.BackColor == Color.Black && kutu5.BackColor == Color.Black && kutu6.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu6, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu7.BackColor == Color.Black && kutu8.BackColor == Color.Black && kutu9.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu9, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu2.BackColor == Color.Black && kutu3.BackColor == Color.Black && kutu1.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu1, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu5.BackColor == Color.Black && kutu6.BackColor == Color.Black && kutu4.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu4, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu8.BackColor == Color.Black && kutu9.BackColor == Color.Black && kutu7.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu7, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu1.BackColor == Color.Black && kutu3.BackColor == Color.Black && kutu2.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu2, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu4.BackColor == Color.Black && kutu6.BackColor == Color.Black && kutu5.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu5, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu7.BackColor == Color.Black && kutu9.BackColor == Color.Black && kutu8.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu8, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            //////sağdan sora  win
            else if (kutu1.BackColor == Color.Black && kutu4.BackColor == Color.Black && kutu7.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu7, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu1.BackColor == Color.Black && kutu7.BackColor == Color.Black && kutu4.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu4, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu4.BackColor == Color.Black && kutu7.BackColor == Color.Black && kutu1.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu1, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu2.BackColor == Color.Black && kutu5.BackColor == Color.Black && kutu8.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu8, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu5.BackColor == Color.Black && kutu8.BackColor == Color.Black && kutu2.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu2, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu8.BackColor == Color.Black && kutu2.BackColor == Color.Black && kutu5.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu5, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu3.BackColor == Color.Black && kutu6.BackColor == Color.Black && kutu9.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu9, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu9.BackColor == Color.Black && kutu6.BackColor == Color.Black && kutu3.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu3, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu3.BackColor == Color.Black && kutu9.BackColor == Color.Black && kutu6.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu6, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            /////yukarıdan aşağı win
            else if (kutu3.BackColor == Color.Black && kutu5.BackColor == Color.Black && kutu7.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu7, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu5.BackColor == Color.Black && kutu7.BackColor == Color.Black && kutu3.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu3, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu3.BackColor == Color.Black && kutu7.BackColor == Color.Black && kutu5.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu5, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu1.BackColor == Color.Black && kutu5.BackColor == Color.Black && kutu9.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu9, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu9.BackColor == Color.Black && kutu1.BackColor == Color.Black && kutu5.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu5, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            else if (kutu5.BackColor == Color.Black && kutu9.BackColor == Color.Black && kutu1.BackColor == Color.Transparent)
            {
                this.InvokeOnClick(kutu1, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
                kazanma();
            }
            //////////////çarplazlama win
        }
        public void easy()
        {

            //////sıraya göre o koyma
            if (kutu5.Enabled == true )
            {
                this.InvokeOnClick(kutu5, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu1.Enabled == true )
            {
                this.InvokeOnClick(kutu1, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu2.Enabled == true )
            {
                this.InvokeOnClick(kutu2, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu3.Enabled == true )
            {
                this.InvokeOnClick(kutu3, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu4.Enabled == true )
            {
                this.InvokeOnClick(kutu4, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu6.Enabled == true )
            {
                this.InvokeOnClick(kutu6, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu7.Enabled == true )
            {
                this.InvokeOnClick(kutu7, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu8.Enabled == true )
            {
                this.InvokeOnClick(kutu8, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu9.Enabled == true )
            {
                this.InvokeOnClick(kutu9, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
        }
        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            button1gif();
            button2gif();
            button3gif();
            button4gif();
            button5gif();
            button6gif();
            button7gif();
            button8gif();
            button9gif();
        }

        private void kutu3_MouseMove(object sender, MouseEventArgs e)
        {
            button1gif();
            button2gif();
            button4gif();
            button5gif();
            button6gif();
            button7gif();
            button8gif();
            button9gif();
            if (oyunabaslayan == "0")
            {
                kutu3.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.gif");
            }
            else
            {
                kutu3.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.gif");
            }
        }

        private void kutu4_MouseMove(object sender, MouseEventArgs e)
        {
            button1gif();
            button2gif();
            button3gif();
            button5gif();
            button6gif();
            button7gif();
            button8gif();
            button9gif();
            if (oyunabaslayan == "0")
            {
                kutu4.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.gif");
            }
            else
            {
                kutu4.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.gif");
            }
        }

        private void kutu5_MouseMove(object sender, MouseEventArgs e)
        {
            button1gif();
            button2gif();
            button3gif();
            button4gif();
            button6gif();
            button7gif();
            button8gif();
            button9gif();
            if (oyunabaslayan == "0")
            {
                kutu5.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.gif");
            }
            else
            {
                kutu5.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.gif");
            }
        }

        private void kutu6_MouseMove(object sender, MouseEventArgs e)
        {
            button1gif();
            button2gif();
            button3gif();
            button4gif();
            button5gif();
            button7gif();
            button8gif();
            button9gif();
            if (oyunabaslayan == "0")
            {
                kutu6.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.gif");
            }
            else
            {
                kutu6.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.gif");
            }
        }

        private void kutu7_MouseMove(object sender, MouseEventArgs e)
        {
            button1gif();
            button2gif();
            button3gif();
            button4gif();
            button5gif();
            button6gif();
            button8gif();
            button9gif();
            if (oyunabaslayan == "0")
            {
                kutu7.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.gif");
            }
            else
            {
                kutu7.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.gif");
            }
        }

        private void kutu8_MouseMove(object sender, MouseEventArgs e)
        {
            button1gif();
            button2gif();
            button3gif();
            button4gif();
            button5gif();
            button6gif();
            button7gif();
            button9gif();
            if (oyunabaslayan == "0")
            {
                kutu8.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.gif");
            }
            else
            {
                kutu8.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.gif");
            }
        }

        private void kutu9_MouseMove(object sender, MouseEventArgs e)
        {
            button1gif();
            button2gif();
            button3gif();
            button4gif();
            button5gif();
            button6gif();
            button7gif();
            button8gif();
            if (oyunabaslayan == "0")
            {
                kutu9.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.gif");
            }
            else
            {
                kutu9.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.gif");
            }
        }

        private void kutu1_Click(object sender, EventArgs e)
        {
            if(zorluk=="1")
            {
                buttunno = "1";
                buttonsecme();
                if(oyunabaslayan=="1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();
                        }
                        else if(kontrol==2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            easy();
                        }
                    }
                }

            }
            else if (zorluk == "2")
            {
                buttunno = "1"; ;
                buttonsecme();
                if (oyunabaslayan == "1")
                {
                    dongukontrol = 1;
                    while (dongukontrol != 2)
                    {
                        if (kontrol == 0)
                        {
                            botwin();

                        }
                        else if (kontrol == 2)
                        {
                            kazanma();
                            berabere();
                            easykazanmaengelleme();
                        }
                        else if (kontrol == 1)
                        {
                            kazanma();
                            berabere();
                            hard();
                        }
                    }
                }

            }
            else if(zorluk=="3")
            {
                buttunno = "1";
                buttonsecme();
                kazanma();
                berabere();
            }

        }
        public void yenioyun()
        {
            DialogResult secenek = MessageBox.Show("Oyunu yeniden başlatmak ister misiniz?", "UYGULAMA BİLGİSİ", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                skor1.Text = puan1.ToString();
                skor2.Text = puan2.ToString();
                kutu1.BackColor = Color.Transparent;
                kutu2.BackColor = Color.Transparent;
                kutu3.BackColor = Color.Transparent;
                kutu4.BackColor = Color.Transparent;
                kutu5.BackColor = Color.Transparent;
                kutu6.BackColor = Color.Transparent;
                kutu7.BackColor = Color.Transparent;
                kutu8.BackColor = Color.Transparent;
                kutu9.BackColor = Color.Transparent;
                kutu1.Enabled = true;
                kutu2.Enabled = true;
                kutu3.Enabled = true;
                kutu4.Enabled = true;
                kutu5.Enabled = true;
                kutu6.Enabled = true;
                kutu7.Enabled = true;
                kutu8.Enabled = true;
                kutu9.Enabled = true;
                kutu1.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                kutu2.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                kutu3.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                kutu4.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                kutu5.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                kutu6.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                kutu7.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                kutu8.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                kutu9.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu.png");
                oyuncu1.Visible = true;
                oyuncu2.Visible = true;
                sırasizde();
            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show(nickname1 + "skorunuz:"+puan1.ToString());
                MessageBox.Show(nickname2 + "skorunuz:" + puan2.ToString());
                this.Close();
            }

        }
        public void berabere()
        { 
            //oyunundaki bütün buttonlara basılıp basılmadığını kontrol eder.
            if(kutu1.BackColor != Color.Transparent && kutu2.BackColor != Color.Transparent && kutu3.BackColor != Color.Transparent && kutu4.BackColor != Color.Transparent && kutu5.BackColor != Color.Transparent && kutu6.BackColor != Color.Transparent && kutu7.BackColor != Color.Transparent && kutu8.BackColor != Color.Transparent && kutu9.BackColor != Color.Transparent)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show("berabere");
                yenioyun();
            }

        }
        public void kazanma()
        {
            //oyunun bitip bitmedigi kontrol eder.
            if(kutu1.BackColor==Color.White && kutu2.BackColor == Color.White && kutu3.BackColor == Color.White)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname1+"kazandınız");
                puan1++;
                yenioyun();
            }
            else if(kutu4.BackColor == Color.White && kutu5.BackColor == Color.White && kutu6.BackColor == Color.White)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname1 + "kazandınız");
                puan1++;
                yenioyun();
            }
            else if (kutu7.BackColor == Color.White && kutu8.BackColor == Color.White && kutu9.BackColor == Color.White)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname1 + "kazandınız");
                puan1++;
                yenioyun(); 
            }
            else if (kutu1.BackColor == Color.White && kutu4.BackColor == Color.White && kutu7.BackColor == Color.White)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname1 + "kazandınız");
                puan1++;
                yenioyun();
            }
            else if (kutu2.BackColor == Color.White && kutu5.BackColor == Color.White && kutu8.BackColor == Color.White)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname1 + "kazandınız");
                puan1++;
                yenioyun();
            }
            else if (kutu3.BackColor == Color.White && kutu6.BackColor == Color.White && kutu9.BackColor == Color.White)
            {
                MessageBox.Show(nickname1 + "kazandınız");
                puan1++;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                yenioyun();
            }
            else if (kutu1.BackColor == Color.White && kutu5.BackColor == Color.White && kutu9.BackColor == Color.White)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname1 + "kazandınız");
                puan1++;
                yenioyun();
            }
            else if (kutu3.BackColor == Color.White && kutu5.BackColor == Color.White && kutu7.BackColor == Color.White)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname1 + "kazandınız");
                puan1++;
                yenioyun();
            }
            //////XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            else if (kutu1.BackColor == Color.Black && kutu2.BackColor == Color.Black && kutu3.BackColor == Color.Black)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname2 + "kazandınız");
                puan2++;
                yenioyun();
            }
            else if (kutu4.BackColor == Color.Black && kutu5.BackColor == Color.Black && kutu6.BackColor == Color.Black)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname2 + "kazandınız");
                puan2++;
                yenioyun();
            }
            else if (kutu7.BackColor == Color.Black && kutu8.BackColor == Color.Black && kutu9.BackColor == Color.Black)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname2 + "kazandınız");
                puan2++;
                yenioyun();
            }
            else if (kutu1.BackColor == Color.Black && kutu4.BackColor == Color.Black && kutu7.BackColor == Color.Black)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname2 + "kazandınız");
                puan2++;
                yenioyun();
            }
            else if (kutu2.BackColor == Color.Black && kutu5.BackColor == Color.Black && kutu8.BackColor == Color.Black)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname2 + "kazandınız");
                puan2++;
                yenioyun();
            }
            else if (kutu3.BackColor == Color.Black && kutu6.BackColor == Color.Black && kutu9.BackColor == Color.Black)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                MessageBox.Show(nickname2 + "kazandınız");
                puan2++;
                yenioyun();
            }
            else if (kutu1.BackColor == Color.Black && kutu5.BackColor == Color.Black && kutu9.BackColor == Color.Black)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                puan2++;
                MessageBox.Show(nickname2 + "kazandınız");
                yenioyun();

            }
            else if (kutu3.BackColor == Color.Black && kutu5.BackColor == Color.Black && kutu7.BackColor == Color.Black)
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = false;
                oyuncu1.Visible = false;
                oyuncu2.Visible = false;
                puan2++;
                MessageBox.Show(nickname2 + "kazandınız");
                yenioyun();

            }
        }

        public void buttonsecme()
        {
            //oyuncunun secitigi buton x veya o olur
            if(oyunabaslayan=="0")
            {
              if(buttunno=="1")
                {
                    kutu1.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                    oyunabaslayan = "1";
                    kutu1.Enabled = false;
                    kutu1.BackColor = Color.White;
                    oyuncu2.ForeColor = Color.Green;
                    oyuncu1.ForeColor=Color.Black;
                    sirasizde1.Visible = false;
                    sirasizde2.Visible = true;
                }
              else if(buttunno=="2")
                {
                    kutu2.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                    oyunabaslayan = "1";
                    kutu2.Enabled = false;
                    kutu2.BackColor = Color.White;
                    oyuncu2.ForeColor = Color.Green;
                    oyuncu1.ForeColor = Color.Black;
                    sirasizde1.Visible = false;
                    sirasizde2.Visible = true;
                }
                else if (buttunno == "3")
                {
                    kutu3.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                    oyunabaslayan = "1";
                    kutu3.Enabled = false;
                    kutu3.BackColor = Color.White;
                    oyuncu2.ForeColor = Color.Green;
                    oyuncu1.ForeColor = Color.Black;
                    sirasizde1.Visible = false;
                    sirasizde2.Visible = true;
                }
                else if (buttunno == "4")
                {
                    kutu4.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                    oyunabaslayan = "1";
                    kutu4.Enabled = false;
                    kutu4.BackColor = Color.White;
                    oyuncu2.ForeColor = Color.Green;
                    oyuncu1.ForeColor = Color.Black;
                    sirasizde1.Visible = false;
                    sirasizde2.Visible = true;
                }
                else if (buttunno == "5")
                {
                    kutu5.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                    oyunabaslayan = "1";
                    kutu5.Enabled = false;
                    kutu5.BackColor = Color.White;
                    oyuncu2.ForeColor = Color.Green;
                    oyuncu1.ForeColor = Color.Black;
                    sirasizde1.Visible = false;
                    sirasizde2.Visible = true;
                }
                else if (buttunno == "6")
                {
                    kutu6.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                    oyunabaslayan = "1";
                    kutu6.Enabled = false;
                    kutu6.BackColor = Color.White;
                    oyuncu2.ForeColor = Color.Green;
                    oyuncu1.ForeColor = Color.Black;
                    sirasizde1.Visible = false;
                    sirasizde2.Visible = true;
                }
                else if (buttunno == "7")
                {
                    kutu7.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                    oyunabaslayan = "1";
                    kutu7.Enabled = false;
                    kutu7.BackColor = Color.White;
                    oyuncu2.ForeColor = Color.Green;
                    oyuncu1.ForeColor = Color.Black;
                    sirasizde1.Visible = false;
                    sirasizde2.Visible = true;
                }
                else if (buttunno == "8")
                {
                    kutu8.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                    oyunabaslayan = "1";
                    kutu8.Enabled = false;
                    kutu8.BackColor = Color.White;
                    oyuncu2.ForeColor = Color.Green;
                    oyuncu1.ForeColor = Color.Black;
                    sirasizde1.Visible = false;
                    sirasizde2.Visible = true;
                }
                else if (buttunno == "9")
                {
                    kutu9.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-x.png");
                    oyunabaslayan = "1";
                    kutu9.Enabled = false;
                    kutu9.BackColor = Color.White;
                    oyuncu2.ForeColor = Color.Green;
                    oyuncu1.ForeColor = Color.Black;
                    sirasizde1.Visible = false;
                    sirasizde2.Visible = true;
                }
            }
            else if(oyunabaslayan=="1")
            {
                if (buttunno == "1")
                {
                    kutu1.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                    oyunabaslayan = "0";
                    kutu1.Enabled = false;
                    kutu1.BackColor = Color.Black;
                    oyuncu2.ForeColor = Color.Black;
                    oyuncu1.ForeColor = Color.Green;
                    sirasizde1.Visible = true;
                    sirasizde2.Visible = false;
                }
                else if (buttunno == "2")
                {
                    kutu2.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                    oyunabaslayan = "0";
                    kutu2.Enabled = false;
                    kutu2.BackColor = Color.Black;
                    oyuncu2.ForeColor = Color.Black;
                    oyuncu1.ForeColor = Color.Green;
                    sirasizde1.Visible = true;
                    sirasizde2.Visible = false;
                }
                else if (buttunno == "3")
                {
                    kutu3.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                    oyunabaslayan = "0";
                    kutu3.Enabled = false;
                    kutu3.BackColor = Color.Black;
                    oyuncu2.ForeColor = Color.Black;
                    oyuncu1.ForeColor = Color.Green;
                    sirasizde1.Visible = true;
                    sirasizde2.Visible = false;
                }
                else if (buttunno == "4")
                {
                    kutu4.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                    oyunabaslayan = "0";
                    kutu4.Enabled = false;
                    kutu4.BackColor = Color.Black;
                    oyuncu2.ForeColor = Color.Black;
                    oyuncu1.ForeColor = Color.Green;
                    sirasizde1.Visible = true;
                    sirasizde2.Visible = false;
                }
                else if (buttunno == "5")
                {
                    kutu5.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                    oyunabaslayan = "0";
                    kutu5.Enabled = false;
                    kutu5.BackColor = Color.Black;
                    oyuncu2.ForeColor = Color.Black;
                    oyuncu1.ForeColor = Color.Green;
                    sirasizde1.Visible = true;
                    sirasizde2.Visible = false;
                }
                else if (buttunno == "6")
                {
                    kutu6.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                    oyunabaslayan = "0";
                    kutu6.Enabled = false;
                    kutu6.BackColor = Color.Black;
                    oyuncu2.ForeColor = Color.Black;
                    oyuncu1.ForeColor = Color.Green;
                    sirasizde1.Visible = true;
                    sirasizde2.Visible = false;
                }
                else if (buttunno == "7")
                {
                    kutu7.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                    oyunabaslayan = "0";
                    kutu7.Enabled = false;
                    kutu7.BackColor = Color.Black;
                    oyuncu2.ForeColor = Color.Black;
                    oyuncu1.ForeColor = Color.Green;
                    sirasizde1.Visible = true;
                    sirasizde2.Visible = false;
                }
                else if (buttunno == "8")
                {
                    kutu8.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                    oyunabaslayan = "0";
                    kutu8.Enabled = false;
                    kutu8.BackColor = Color.Black;
                    oyuncu2.ForeColor = Color.Black;
                    oyuncu1.ForeColor = Color.Green;
                    sirasizde1.Visible = true;
                    sirasizde2.Visible = false;
                }
                else if (buttunno == "9")
                {
                    kutu9.Image = Image.FromFile("C:\\Users\\volka\\source\\repos\\X-O-X Oyunu\\X-O-X Oyunu\\bin\\Debug\\resim\\kutu-o.png");
                    oyunabaslayan = "0";
                    kutu9.Enabled = false;
                    kutu9.BackColor = Color.Black;
                    oyuncu2.ForeColor = Color.Black;
                    oyuncu1.ForeColor = Color.Green;
                    sirasizde1.Visible = true;
                    sirasizde2.Visible = false;
                }
            }
        }
         public void sırasizde()
        {
            //sirasizde butonu yakma kısmıF
            if (oyunabaslayan == "0")
            {
                sirasizde1.Visible = true;
                sirasizde2.Visible = false;
                oyuncu2.ForeColor = Color.Black;
                oyuncu1.ForeColor = Color.Green;
            }
            else
            {
                sirasizde1.Visible = false;
                sirasizde2.Visible = true;
                oyuncu2.ForeColor = Color.Green;
                oyuncu1.ForeColor = Color.Black;
            }
        }
        private void Game_Load(object sender, EventArgs e)
        {
            oyuncu1.Text = nickname1;
            oyuncu2.Text = nickname2;
            skor1.Text = puan1.ToString();
            skor2.Text = puan2.ToString();
            sırasizde();
            if(oyunabaslayan=="1" && zorluk=="1")
            {
                easy ();
            }
            else if (oyunabaslayan == "1" && zorluk == "2")
            {
                hard();
            }
        }
        public void hard()
        {
            // zor bot butona basması
            if (kutu5.Enabled == true)
            {
                this.InvokeOnClick(kutu5, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu9.Enabled == true)
            {
                this.InvokeOnClick(kutu9, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu3.Enabled == true)
            {
                this.InvokeOnClick(kutu3, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu1.Enabled == true)
            {
                this.InvokeOnClick(kutu1, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu7.Enabled == true)
            {
                this.InvokeOnClick(kutu7, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }

            else if (kutu2.Enabled == true)
            {
                this.InvokeOnClick(kutu2, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }

            else if (kutu4.Enabled == true)
            {
                this.InvokeOnClick(kutu4, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }
            else if (kutu6.Enabled == true)
            {
                this.InvokeOnClick(kutu6, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }

            else if (kutu8.Enabled == true)
            {
                this.InvokeOnClick(kutu8, EventArgs.Empty);
                kontrol = 0;
                dongukontrol = 2;
            }

        }

    }
}

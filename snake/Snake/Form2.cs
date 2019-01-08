using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Snake.Properties;
using WMPLib;

namespace Snake
{
    public partial class Form2 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form2()
        {
            InitializeComponent();
            player.URL = "marios.mp3";
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resources.buton42;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resources.buton41;
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Resources.buton11;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Resources.buton1;
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Resources.buton22;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Resources.buton21;
        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Resources.buton52;
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Resources.buton51;
        }
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Resources.buton32;
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Resources.buton31;
        }
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = Resources.exitbuton1;
        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = Resources.exitbuton;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1(); form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autori:Cocos Florian-Cristian,Man Victor si Sandru Raluca-Diana\nProiect:Snake-Jocul");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Foloseste butonul 'PLAY' pentru a incepe jocul. \n Aduna puncte colectand fructele ce vor aparea pe ecran.\n Pentru a misca jucatorul trebuie sa apesi pe sageti. \n Daca ai pierdut si vrei sa incerci iar,apasa Enter.");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mult cunoscutul joc Snake vine si in varianta C#.Colecteaza cat mai multe puncte.");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }
    }
}

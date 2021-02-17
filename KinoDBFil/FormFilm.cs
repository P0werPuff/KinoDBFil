using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoDBFil
{
    public partial class FormFilm : Form
    {
        Button btn1, btn2, btn3, btn4, btn5, btn6;
        Label lbl1, lbl2, lbl3, lbl4, lbl5, lbl6;
        public FormFilm()
        {
            Height = 750;
            Width = 1500;
            Text = "Film select";

            btn1 = new Button();
            btn1.Size = new Size(200, 200);
            btn1.Location = new Point(30, 40);
            btn1.Image = Image.FromFile(@"C:\Users\opilane\source\repos\KinoDBFil\KinoDBFil\Images\1.jpg");
            btn1.Click += Btn1_Click;
            Controls.Add(btn1);

            btn2 = new Button();
            btn2.Size = new Size(200, 200);
            btn2.Location = new Point(500, 40);
            btn2.Image = Image.FromFile(@"C:\Users\opilane\source\repos\KinoDBFil\KinoDBFil\Images\2.jpg");
            btn2.Click += Btn2_Click;
            Controls.Add(btn2);

            btn3 = new Button();
            btn3.Size = new Size(200, 200);
            btn3.Location = new Point(960, 40);
            btn3.Image = Image.FromFile(@"C:\Users\opilane\source\repos\KinoDBFil\KinoDBFil\Images\3.jpg");
            btn3.Click += Btn3_Click;
            Controls.Add(btn3);

            btn4 = new Button();
            btn4.Size = new Size(200, 200);
            btn4.Location = new Point(960, 40);
            btn4.Image = Image.FromFile(@"C:\Users\opilane\source\repos\KinoDBFil\KinoDBFil\Images\4.jpg");
            btn4.Click += Btn4_Click;
            Controls.Add(btn4);

            btn5 = new Button();
            btn5.Size = new Size(200, 200);
            btn5.Location = new Point(960, 40);
            btn5.Image = Image.FromFile(@"C:\Users\opilane\source\repos\KinoDBFil\KinoDBFil\Images\5.jpg");
            btn5.Click += Btn5_Click;
            Controls.Add(btn5);

            btn6 = new Button();
            btn6.Size = new Size(200, 200);
            btn6.Location = new Point(960, 40);
            btn6.Image = Image.FromFile(@"C:\Users\opilane\source\repos\KinoDBFil\KinoDBFil\Images\6.jpg");
            btn6.Click += Btn6_Click;
            Controls.Add(btn6);

            lbl1 = new Label();
            lbl1.Text = "Film name 1";
            lbl1.Size = new Size(70, 20);
            lbl1.Location = new Point(100, 260);
            Controls.Add(lbl1);

            lbl2 = new Label();
            lbl2.Text = "Film name 2";
            lbl2.Size = new Size(70, 20);
            lbl2.Location = new Point(360, 260);
            Controls.Add(lbl2);

            lbl3 = new Label();
            lbl3.Text = "Film name 3";
            lbl3.Size = new Size(70, 20);
            lbl3.Location = new Point(620, 260);
            Controls.Add(lbl3);

            lbl4 = new Label();
            lbl4.Text = "Film name 4";
            lbl4.Size = new Size(70, 20);
            lbl4.Location = new Point(620, 260);
            Controls.Add(lbl4);

            lbl5 = new Label();
            lbl5.Text = "Film name 5";
            lbl5.Size = new Size(70, 20);
            lbl5.Location = new Point(620, 260);
            Controls.Add(lbl5);

            lbl6 = new Label();
            lbl6.Text = "Film name 6";
            lbl6.Size = new Size(70, 20);
            lbl6.Location = new Point(620, 260);
            Controls.Add(lbl6);
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            Form1 kino = new Form1();
            kino.Show();
            Hide();
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            Form1 kino = new Form1();
            kino.Show();
            Hide();
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            Form1 kino = new Form1();
            kino.Show();
            Hide();
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            Form1 kino = new Form1();
            kino.Show();
            Hide();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Form1 kino = new Form1();
            kino.Show();
            Hide();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Form1 kino = new Form1();
            kino.Show();
            Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_Animal_Picture_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            array[0] = pictureBox1.Tag.ToString();
            array[1] = pictureBox2.Tag.ToString();
            array[2] = pictureBox3.Tag.ToString();

            array[3] = pictureBox4.Tag.ToString();
            array[4] = pictureBox5.Tag.ToString();
            array[5] = pictureBox6.Tag.ToString();

            array[6] = pictureBox7.Tag.ToString();
            array[7] = pictureBox8.Tag.ToString();
            array[8] = pictureBox9.Tag.ToString();

        }
        private void ShuffleArray(string[] array)
        {
            Random rnd = new Random();
            array = array.OrderBy(x => rnd.Next()).ToArray();
        }

        private Random randomGenrator = new Random();
        private string[] array = new string[9];
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pbanimal_Paint(object sender, PaintEventArgs e)
        {
           //y,x 
            //w,h
            Color color = Color.FromArgb(250, 240, 215);
            Pen colroPen = new Pen(color);
            
            colroPen.Width = 10;
            Color color2 = Color.FromArgb(222, 184, 135);
            Pen colorPen2 = new Pen(color);
            colorPen2.Width = 5;
            colroPen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            colroPen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;

            colorPen2.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            colorPen2.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
            //
            e.Graphics.DrawLine(colroPen, -5, 28, 700, 28);
            e.Graphics.DrawLine(colroPen, -5, 78, 700, 78);
            e.Graphics.DrawLine(colroPen, -5, 60, 689, 60);
            e.Graphics.DrawLine(colroPen, -5, 118, 689, 118);
            e.Graphics.DrawLine(colroPen, -3, 543, 687, 543);
            e.Graphics.DrawLine(colroPen, -3, 621, 681, 621);
            e.Graphics.DrawRectangle(colorPen2, 286, 560, 130, 49);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[1];
            pictureBox3.Image = imageList1.Images[2];

            pictureBox4.Image = imageList1.Images[3];
            pictureBox5.Image = imageList1.Images[4];
            pictureBox6.Image = imageList1.Images[5];

            pictureBox7.Image = imageList1.Images[6];
            pictureBox8.Image = imageList1.Images[7];
            pictureBox9.Image = imageList1.Images[8];

            pictureBox1.Image = imageList1.Images[randomGenrator.Next(0, 8)];
            do
            {
                pictureBox2.Image = imageList1.Images[randomGenrator.Next(0, 8)];
            } while (pictureBox1.Image == pictureBox2.Image);
            do
            {
                pictureBox3.Image = imageList1.Images[randomGenrator.Next(0, 8)];
            } while (pictureBox2.Image == pictureBox3.Image);

           

            do
            {
                pictureBox4.Image = imageList1.Images[randomGenrator.Next(0, 8)];
            } while (pictureBox3.Image == pictureBox4.Image);

            do
            {
                pictureBox5.Image = imageList1.Images[randomGenrator.Next(0, 8)];
            } while (pictureBox4.Image == pictureBox5.Image);

            do
            {
                pictureBox6.Image = imageList1.Images[randomGenrator.Next(0, 8)];
            } while (pictureBox5.Image == pictureBox6.Image);

            do
            {
                pictureBox7.Image = imageList1.Images[randomGenrator.Next(0, 8)];
            } while (pictureBox6.Image == pictureBox7.Image);

            do
            {
                pictureBox8.Image = imageList1.Images[randomGenrator.Next(0, 8)];
            } while (pictureBox7.Image == pictureBox8.Image);

            do
            {
                pictureBox9.Image = imageList1.Images[randomGenrator.Next(0, 8)];
            } while (pictureBox8.Image == pictureBox9.Image);


           
        }
    }
}

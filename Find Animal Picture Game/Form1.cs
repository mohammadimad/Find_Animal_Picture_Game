using System;
using Find_Animal_Picture_Game.Properties;
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
        }
    private static uint timer = 7;
    string[] animal = new string[9];
    public static string QuationAnimaName = string.Empty;
    static string[] Shuffle(string[] Animals)
    {
        Random random = new Random();
        for (byte i = 0; i < Animals.Length; i++)
        {
            int j = random.Next(Animals.Length);
            string temp = Animals[i];
            Animals[i] = Animals[j];
            Animals[j] = temp;
        }
        return Animals;
    }


    private void ShowQuestion(string AnimalQuestion, bool ShowMessage = true)
    {
        for (short i = 0; i < animal.Length; i++)
        {
            if (animal[i] == AnimalQuestion)
            {
                QuationAnimaName = AnimalQuestion;
                break;
            }
        }


        if (ShowMessage == true)
        {
            lab_Question.Text = "Where's " + AnimalQuestion + " Picture ? ";
        }
        

    }
    private System.Drawing.Image GetImages(string ImageName)
    {
        System.Drawing.Image image = null;
        switch (ImageName)
        {
            case "tiger":
                {
                    image = Resources.tiger;
                    break;
                }
            case "cat":
                {
                    image = Resources.cat;
                    break;
                }
            case "whale":
                {
                    image = Resources.whale;
                    break;
                }
            case "fish":
                {
                    image = Resources.fish;
                    break;
                }
            case "dog":
                {
                    image = Resources.dog;
                    break;
                }
            case "giraffe":
                {
                    image = Resources.giraffe;
                    break;
                }
            case "panda":
                {
                    image = Resources.panda;
                    break;
                }
            case "monkey":
                {
                    image = Resources.monkey;
                    break;
                }
            case "snake":
                {
                    image = Resources.snake;
                    break;
                }

            default:
                {
                    image = null;
                    break;
                }
        }
        return image;
    }
    private PictureBox GetImages2(string ImageName)
    {
        PictureBox image = new PictureBox();
        switch (ImageName)
        {
            case "tiger":
                {
                    image.Image = Resources.tiger;
                    image.Tag = "tiger";
                    break;
                }
            case "cat":
                {
                    image.Image = Resources.cat;
                    image.Tag = "cat";
                    break;
                }
            case "whale":
                {
                    image.Image = Resources.whale;
                    image.Tag = "whale";
                    break;
                }
            case "fish":
                {
                    image.Image = Resources.fish;
                    image.Tag = "fish";
                    break;
                }
            case "dog":
                {
                    image.Image = Resources.dog;
                    image.Tag = "dog";
                    break;
                }
            case "giraffe":
                {
                    image.Image = Resources.giraffe;
                    image.Tag = "giraffe";
                    break;
                }
            case "panda":
                {
                    image.Image = Resources.panda;
                    image.Tag = "panda";
                    break;
                }
            case "monkey":
                {
                    image.Image = Resources.monkey;
                    image.Tag = "Monkey";
                    break;
                }
            case "snake":
                {
                    image.Image = Resources.snake;
                    image.Tag = "Snake";
                    break;
                }

            default:
                {
                    image = null;
                    break;
                }
        }
        return image;
    }

    private string GetImageTag(string ImegeName)
    {
        string Tag = string.Empty;
        switch (ImegeName)
        {
            case "tiger":
                {
                    Tag = "tiger";
                    break;
                }
            case "cat":
                {
                    Tag = "cat";
                    break;
                }
            case "whale":
                {
                    Tag = "whale";
                    break;
                }
            case "fish":
                {
                    Tag = "fish";
                    break;
                }
            case "dog":
                {
                    Tag = "dog";
                    break;
                }
            case "giraffe":
                {
                    Tag = "giraffe";
                    break;
                }
            case "panda":
                {
                    Tag = "panda";
                    break;
                }
            case "monkey":
                {
                    Tag = "monkey";
                    break;
                }
            case "snake":
                {
                    Tag = "snake";
                    break;
                }

            default:
                {
                    Tag = null;
                    break;
                }
        }
        return Tag;

    }
    private void LoadAnimalsPictures()
    {
        animal[0] = "tiger";
        animal[1] = "cat";
        animal[2] = "snake";
        animal[3] = "whale";
        animal[4] = "fish";
        animal[5] = "dog";
        animal[6] = "giraffe";
        animal[7] = "panda";
        animal[8] = "monkey";
        animal = Shuffle(animal);

        PB_1.Image = GetImages(animal[0]);
        PB_1.Tag = GetImageTag(animal[0]);

        PB_2.Image = GetImages(animal[1]);
        PB_2.Tag = GetImageTag(animal[1]);

        PB_3.Image = GetImages(animal[2]);
        PB_3.Tag = GetImageTag(animal[2]);

        PB_4.Image = GetImages(animal[3]);
        PB_4.Tag = GetImageTag(animal[3]);

        PB_5.Image = GetImages(animal[4]);
        PB_5.Tag = GetImageTag(animal[4]);

        PB_6.Image = GetImages(animal[5]);
        PB_6.Tag = GetImageTag(animal[5]);

        PB_7.Image = GetImages(animal[6]);
        PB_7.Tag = GetImageTag(animal[6]);

        PB_8.Image = GetImages(animal[7]);
        PB_8.Tag = GetImageTag(animal[7]);

        PB_9.Image = GetImages(animal[8]);
        PB_9.Tag = GetImageTag(animal[8]);


    }
    private void Form1_Load(object sender, EventArgs e)
    {
        DisEnableAllPicture();
        PB_1.Enabled = false;
        PB_2.Enabled = false;
        PB_3.Enabled = false;
        PB_4.Enabled = false;
        PB_5.Enabled = false;
        PB_6.Enabled = false;
        PB_7.Enabled = false;
        PB_8.Enabled = false;
        PB_9.Enabled = false;
        PB_11.Image = Resources.question_mark_96;
        PB_22.Image = Resources.question_mark_96;
        PB_33.Image = Resources.question_mark_96;
        PB_44.Image = Resources.question_mark_96;
        PB_55.Image = Resources.question_mark_96;
        PB_66.Image = Resources.question_mark_96;
        PB_77.Image = Resources.question_mark_96;
        PB_88.Image = Resources.question_mark_96;
        PB_99.Image = Resources.question_mark_96;
        lab_Timer.Text = timer.ToString();
        this.LoadAnimalsPictures();
    }

    private void PaintFrom1(object sender, PaintEventArgs e)
    {
        Color Brown = Color.FromArgb(250, 240, 215);
        Pen pen = new Pen(Brown);
        pen.Width = 8;

        pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
        pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
            //
        e.Graphics.DrawLine(pen, 0, 37, 1100, 37);
        e.Graphics.DrawLine(pen, 0, 78, 1100, 78);
        e.Graphics.DrawLine(pen, 0, 92, 1100, 92);
        e.Graphics.DrawLine(pen, 0, 133, 1100, 133);
        e.Graphics.DrawLine(pen, 0, 574, 1100, 574);
        e.Graphics.DrawLine(pen, 0, 639, 1100, 639);
        }

    private void timer1_Tick(object sender, EventArgs e)
    {
        timer--;
        if (timer == 0)
        {
            timer1_btn.Stop();
            lab_Question.Visible = true;
            PB_11.Visible = true;
            PB_22.Visible = true;
            PB_33.Visible = true;
            PB_44.Visible = true;
            PB_55.Visible = true;
            PB_66.Visible = true;
            PB_77.Visible = true;
            PB_88.Visible = true;
            PB_99.Visible = true;
            PB_11.Enabled = true;
            PB_22.Enabled = true;
            PB_33.Enabled = true;
            PB_44.Enabled = true;
            PB_55.Enabled = true;
            PB_66.Enabled = true;
            PB_77.Enabled = true;
            PB_88.Enabled = true;
            PB_99.Enabled = true;
        }
        lab_Timer.Text = timer.ToString();

    }

    private void button1_Click(object sender, EventArgs e)
    {
        timer = 7;
        PB_11.Visible = false;
        PB_22.Visible = false;
        PB_33.Visible = false;
        PB_44.Visible = false;
        PB_55.Visible = false;
        PB_66.Visible = false;
        PB_77.Visible = false;
        PB_88.Visible = false;
        PB_99.Visible = false;
                     
        lab_Question.Visible = false;
        timer1_btn.Enabled = true;
        timer1_btn.Start();
        btn_Start.Enabled = false;
        Random random = new Random();
        ShowQuestion(animal[random.Next(0, 9)]);
    }

    private void DisEnableAllPicture()
    {
        PB_11.Enabled = false;
        PB_22.Enabled = false;
        PB_33.Enabled = false;
        PB_44.Enabled = false;
        PB_55.Enabled = false;
        PB_66.Enabled = false;
        PB_77.Enabled = false;
        PB_88.Enabled = false;
        PB_99.Enabled = false;
    }
        
        private void PB_11_Click(object sender, EventArgs e)
        {
            PictureBox CurrentImage = new PictureBox();
            CurrentImage = GetImages2(QuationAnimaName);
            if (PB_1.Image == CurrentImage.Image || PB_1.Tag == CurrentImage.Tag)
            {
                PB_11.Visible = false;
                PB_1.BackColor = Color.Green;
                MessageBox.Show("Correct Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                PB_11.Visible = false;
                PB_1.BackColor = Color.OrangeRed;
                MessageBox.Show("Wrong Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PB_1.BackColor = Color.White;
            btn_Start.Enabled = true;
            this.DisEnableAllPicture();
            Random rand = new Random();
            ShowQuestion(animal[rand.Next(0, 9)], false);

        }

        private void PB_22_Click(object sender, EventArgs e)
        {
            PictureBox CurrentImage = new PictureBox(); ;
            CurrentImage = GetImages2(QuationAnimaName);
            if (PB_2.Image == CurrentImage.Image || PB_2.Tag == CurrentImage.Tag)
            {
                PB_22.Visible = false;
                PB_2.BackColor = Color.Green;
                MessageBox.Show("Correct Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PB_22.Visible = false;
                PB_2.BackColor = Color.OrangeRed;
                MessageBox.Show("Wrong Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PB_2.BackColor = Color.White;
            btn_Start.Enabled = true;
            this.DisEnableAllPicture();
            Random rand = new Random();
            ShowQuestion(animal[rand.Next(0, 9)], false);
        }

        private void PB_33_Click(object sender, EventArgs e)
        {
            PictureBox CurrentImage = new PictureBox(); ;
            CurrentImage = GetImages2(QuationAnimaName);
            if ((PB_3.Image == CurrentImage.Image) || (PB_3.Tag == CurrentImage.Tag))
            {
                PB_33.Visible = false;
                PB_3.BackColor = Color.Green;
                MessageBox.Show("Correct Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PB_33.Visible = false;
                PB_3.BackColor = Color.OrangeRed;
                MessageBox.Show("Wrong Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PB_3.BackColor = Color.White;
            btn_Start.Enabled = true;
            this.DisEnableAllPicture();
            Random rand = new Random();
            ShowQuestion(animal[rand.Next(0, 9)], false);
        }

        private void PB_44_Click(object sender, EventArgs e)
        {
            PictureBox CurrentImage = new PictureBox(); ;
            CurrentImage = GetImages2(QuationAnimaName);
            if (PB_4.Image == CurrentImage.Image || PB_4.Tag == CurrentImage.Tag)
            {
                PB_44.Visible = false;
                PB_4.BackColor = Color.Green;
                MessageBox.Show("Correct Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PB_44.Visible = false;
                PB_4.BackColor = Color.OrangeRed;
                MessageBox.Show("Wrong Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            PB_4.BackColor = Color.White;
            btn_Start.Enabled = true;
            this.DisEnableAllPicture();
            Random rand = new Random();
            ShowQuestion(animal[rand.Next(0, 9)], false);
        }

        private void PB_55_Click(object sender, EventArgs e)
        {
            PictureBox CurrentImage = new PictureBox(); ;
            CurrentImage = GetImages2(QuationAnimaName);
            if (PB_5.Image == CurrentImage.Image || PB_5.Tag == CurrentImage.Tag)
            {
                PB_55.Visible = false;
                PB_5.BackColor = Color.Green;
                MessageBox.Show("Correct Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PB_55.Visible = false;
                PB_5.BackColor = Color.OrangeRed;
                MessageBox.Show("Wrong Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            PB_5.BackColor = Color.White;
            btn_Start.Enabled = true;
            this.DisEnableAllPicture();
            Random rand = new Random();
            ShowQuestion(animal[rand.Next(0, 9)], false);
        }

        private void PB_66_Click(object sender, EventArgs e)
        {
            PictureBox CurrentImage = new PictureBox(); ;
            CurrentImage = GetImages2(QuationAnimaName);
            if (PB_6.Image == CurrentImage.Image || PB_6.Tag == CurrentImage.Tag)
            {
                PB_66.Visible = false;
                PB_6.BackColor = Color.Green;
                MessageBox.Show("Correct Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PB_66.Visible = false;
                PB_6.BackColor = Color.OrangeRed;
                MessageBox.Show("Wrong Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            PB_6.BackColor = Color.White;
            btn_Start.Enabled = true;
            this.DisEnableAllPicture();
            Random rand = new Random();
            ShowQuestion(animal[rand.Next(0, 9)], false);
        }

        private void PB_77_Click(object sender, EventArgs e)
        {
            PictureBox CurrentImage = new PictureBox(); ;
            CurrentImage = GetImages2(QuationAnimaName);
            if (PB_7.Image == CurrentImage.Image || PB_7.Tag == CurrentImage.Tag)
            {
                PB_77.Visible = false;
                PB_7.BackColor = Color.Green;
                MessageBox.Show("Correct Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PB_77.Visible = false;
                PB_7.BackColor = Color.OrangeRed;
                MessageBox.Show("Wrong Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            PB_7.BackColor = Color.White;
            btn_Start.Enabled = true;
            this.DisEnableAllPicture();
            Random rand = new Random();
            ShowQuestion(animal[rand.Next(0, 9)], false);
        }

        private void PB_88_Click(object sender, EventArgs e)
        {
            PictureBox CurrentImage = new PictureBox(); ;
            CurrentImage = GetImages2(QuationAnimaName);
            if (PB_8.Image == CurrentImage.Image || PB_8.Tag == CurrentImage.Tag)
            {
                PB_88.Visible = false;
                PB_8.BackColor = Color.Green;
                MessageBox.Show("Correct Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PB_88.Visible = false;
                PB_8.BackColor = Color.OrangeRed;
                MessageBox.Show("Wrong Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            PB_8.BackColor = Color.White;
            btn_Start.Enabled = true;
            this.DisEnableAllPicture();
            Random rand = new Random();
            ShowQuestion(animal[rand.Next(0, 9)], false);
        }

        private void PB_99_Click(object sender, EventArgs e)
        {
            PictureBox CurrentImage = new PictureBox();
            CurrentImage = GetImages2(QuationAnimaName);
            if (PB_9.Image == CurrentImage.Image || PB_9.Tag == CurrentImage.Tag)
            {
                PB_99.Visible = false;
                PB_9.BackColor = Color.Green;
                MessageBox.Show("Correct Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PB_99.Visible = false;
                PB_9.BackColor = Color.OrangeRed;
                MessageBox.Show("Wrong Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            PB_9.BackColor = Color.White;
            btn_Start.Enabled = true;
            this.DisEnableAllPicture();
            Random rand = new Random();
            ShowQuestion(animal[rand.Next(0, 9)], false);
        }
    }
}

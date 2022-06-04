using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class PlayGame : Form
    {
        public string[,] quizes = new Quizes().quizes;
        public Button[] controllers;
        public Label question = CreateLabel(new Size(530, 90), new Point(258, 264));
        public ProgressBar scientistHealthBar = CreateHealth(new Point(430, 200));
        public ProgressBar catHealthBar = CreateHealth(new Point(430, 600));
        public int numberQuiz;

        public PlayGame()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void PlayButton_MouseClick(object sender, MouseEventArgs e)
        {
            CreateCatGame("Cat sprite.png");
            controllers = CreateControllers();
            Controls.Add(catHealthBar);
            Controls.Add(scientistHealthBar);
            Controls.Add(question);

            DoQuests();
            controllers[0].Click += (sender, args) => DoAnswer(0, numberQuiz);
            controllers[1].Click += (sender, args) => DoAnswer(1, numberQuiz);
            controllers[2].Click += (sender, args) => DoAnswer(2, numberQuiz);
            controllers[3].Click += (sender, args) => DoAnswer(3, numberQuiz);
        }

        public void DoQuests()
        {
            Random rnd = new Random();
            numberQuiz = rnd.Next(0, 14);
            question.Text = quizes[numberQuiz, 0];
            for (var i = 0; i < 4; i++)
                controllers[i].Text = quizes[numberQuiz, i + 1];
        }

        public void DoAnswer(int numberContol, int numberQuiz)
        {   
            if (controllers[numberContol].Text.Equals(quizes[numberQuiz, 5]))
            {
                scientistHealthBar.Value -= 10;
                if (scientistHealthBar.Value <= 0)
                    EndGame();
                DoQuests();
            }
            else
            {
                catHealthBar.Value -= 10;
                if (catHealthBar.Value <= 0)
                    EndGame();
            }
        }

        public void CreateCatGame(String catSprite)
        {
            Controls.Clear();
            Controls.Add(CreateHero(new Point(415, 635), catSprite));
            Controls.Add(CreateHero(new Point(415, 0), "Angry scientist1.png"));
        }

        public void EndGame()
        {
            Controls.Clear();
            const string message = "Game is over";
            const string caption = "Quiz";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        public PictureBox CreateHero(Point location, String sprite)
        {
            PictureBox hero = new PictureBox()
            {
                Location = location,
                Size = new Size(200, 200)
            };
            System.IO.FileStream fs = new System.IO.FileStream(@"..\..\..\Sprites\" + sprite, System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            hero.Image = img;
            hero.BackColor = Color.Transparent;
            return hero;
        }

        public Button[] CreateControllers()
        {
            var controlOne = CreateButton(new Size(260, 65), new Point(258, 376));
            Controls.Add(controlOne);
            var controlTwo = CreateButton(new Size(260, 65), new Point(528, 376));
            Controls.Add(controlTwo);
            var controlThree = CreateButton(new Size(260, 65), new Point(528, 460));
            Controls.Add(controlThree);
            var controlFour = CreateButton(new Size(260, 65), new Point(258, 460));
            Controls.Add(controlFour);
            return new[] { controlOne, controlTwo, controlThree, controlFour };
        }

        public Button CreateButton(Size size, Point point)
        {
            return new Button()
            {
                Size = size,
                Location = point
            };
        }
        public static Label CreateLabel(Size size, Point point)
        {
            return new Label()
            {
                Size = size,
                Location = point
            };
        }
        public static ProgressBar CreateHealth(Point point)
        {
            return new ProgressBar()
            {
                Location = point,
                Size = new Size(190, 30),
                Value = 100,
                Text = "Health",
                ForeColor = Color.Red
            };
        }

        private void PlayGame_Load(object sender, EventArgs e)
        {

        }
    }
}

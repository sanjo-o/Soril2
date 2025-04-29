using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Soril2
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ballTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer countdownTimer = new System.Windows.Forms.Timer();

        List<PictureBox> balls = new List<PictureBox>();
        Random rand = new Random();
        PictureBox unicorn;
        int score = 0;
        int ballCount = 5;
        int gameDuration = 30; // 30 seconds game duration
        int timeLeft;
        Label scoreLabel = new Label();
        Label timeLabel = new Label();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Ball Hunter Unicorn";
            this.Width = 500;
            this.Height = 600;
            this.BackColor = Color.White;
            this.KeyPreview = true;
            this.DoubleBuffered = true;

            InitUnicorn();
            InitScoreLabel();
            InitTimeLabel();
            InitTimers();
            this.KeyDown += Form1_KeyDown;
        }

        private void InitUnicorn()
        {
            unicorn = new PictureBox();
            unicorn.Image = Image.FromFile("C:/Users/Sanjaa/source/repos/Soril2/unicorn.png");
            unicorn.SizeMode = PictureBoxSizeMode.StretchImage;
            unicorn.Size = new Size(70, 70);
            unicorn.Top = this.ClientSize.Height - unicorn.Height - 10;
            unicorn.Left = this.ClientSize.Width / 2 - unicorn.Width / 2;
            this.Controls.Add(unicorn);
        }

        private void InitScoreLabel()
        {
            scoreLabel.Text = "Оноо: 0";
            scoreLabel.Font = new Font("Arial", 14);
            scoreLabel.AutoSize = true;
            scoreLabel.Top = 10;
            scoreLabel.Left = 10;
            this.Controls.Add(scoreLabel);
        }

        private void InitTimeLabel()
        {
            timeLabel.Text = $"Хугацаа: {gameDuration}с";
            timeLabel.Font = new Font("Arial", 14);
            timeLabel.AutoSize = true;
            timeLabel.Top = 40;
            timeLabel.Left = 10;
            this.Controls.Add(timeLabel);
        }

        private void InitTimers()
        {
            // Game timer for game logic
            gameTimer.Interval = 30;
            gameTimer.Tick += GameLoop;

            // Ball spawn timer
            ballTimer.Interval = 1000;
            ballTimer.Tick += SpawnBall;

            // Countdown timer
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;

            // Initialize game state
            timeLeft = gameDuration;
            gameTimer.Start();
            ballTimer.Start();
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            timeLabel.Text = $"Хугацаа: {timeLeft}с";

            if (timeLeft <= 0)
            {
                EndGame();
            }
        }

        private void SpawnBall(object sender, EventArgs e)
        {
            if (balls.Count >= ballCount)
            {
                return;
            }

            PictureBox ball = new PictureBox();
            ball.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            ball.Width = 30;
            ball.Height = 30;
            ball.Left = rand.Next(0, this.ClientSize.Width - ball.Width);
            ball.Top = 0;
            ball.Tag = "ball";
            this.Controls.Add(ball);
            balls.Add(ball);
            ball.BringToFront();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            // Move all balls down
            foreach (var ball in balls.ToArray())
            {
                ball.Top += 5;

                // Check for collision with unicorn
                if (ball.Bounds.IntersectsWith(unicorn.Bounds))
                {
                    score++;
                    scoreLabel.Text = "Оноо: " + score;
                    this.Controls.Remove(ball);
                    balls.Remove(ball);
                }
                // Remove balls that go off screen
                else if (ball.Top > this.ClientSize.Height)
                {
                    this.Controls.Remove(ball);
                    balls.Remove(ball);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int moveSpeed = 20;

            if (e.KeyCode == Keys.Left)
            {
                if (unicorn.Left - moveSpeed >= 0)
                    unicorn.Left -= moveSpeed;
                else
                    unicorn.Left = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (unicorn.Right + moveSpeed <= this.ClientSize.Width)
                    unicorn.Left += moveSpeed;
                else
                    unicorn.Left = this.ClientSize.Width - unicorn.Width;
            }
        }

        private void EndGame()
        {
            // Stop all timers
            gameTimer.Stop();
            ballTimer.Stop();
            countdownTimer.Stop();

            // Remove all balls
            foreach (var ball in balls.ToArray())
            {
                this.Controls.Remove(ball);
                balls.Remove(ball);
            }

            // Save score and show message
            SaveScoreToDatabase();
            MessageBox.Show($"Тоглоом дууслаа! Оноо: {score}");
        }

        private void SaveScoreToDatabase()
        {
            string connectionString = @"Server=DESKTOP-SQOBGOL;Database=UnicornGameDB;Trusted_Connection=True;";

            // First check if table exists
            string checkTableQuery = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'gameScore'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if table exists
                    SqlCommand checkCmd = new SqlCommand(checkTableQuery, connection);
                    int tableExists = (int)checkCmd.ExecuteScalar();

                    if (tableExists == 0)
                    {
                        // Create the table if it doesn't exist
                        string createTableQuery = @"
                    CREATE TABLE gameScore (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        playedDate DATETIME NOT NULL,
                        collectedScore INT NOT NULL
                    )";

                        SqlCommand createCmd = new SqlCommand(createTableQuery, connection);
                        createCmd.ExecuteNonQuery();
                    }

                    // Now insert the score
                    string insertQuery = "INSERT INTO gameScore (playedDate, collectedScore) VALUES (@date, @score)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@date", DateTime.Now);
                        command.Parameters.AddWithValue("@score", score);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Оноо амжилттай хадгалагдлаа!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Алдаа гарлаа: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-SQOBGOL;Database=UnicornGameDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("✅ Database-тэй холбогдлоо!", "Амжилттай", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Холболт амжилтгүй:\n" + ex.Message, "Холболтын алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
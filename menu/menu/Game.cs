using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace menu
{
    public partial class Game : Form
    {
        string text1;
        public const int mapSize = 10;
        public int cellSize = 30;
        public string alphabet = "АБВГДЕЖЗИК";

        public int[,] myMap = new int[mapSize, mapSize];
        public int[,] enemyMap = new int[mapSize, mapSize];

        public Button[,] myButtons = new Button[mapSize, mapSize];
        public Button[,] enemyButtons = new Button[mapSize, mapSize];

        public bool isPlaying = false;

        public Bot bot;

        private Form active;
        public Game()
        {
            InitializeComponent();
            this.Text = "Морський бій";
            Init();
        }
        



        public Game(Fon fon)
        {
        }

        public void Init()
        {
            isPlaying = false;
            CreateMaps();
            bot = new Bot(enemyMap, myMap, enemyButtons, myButtons);
            enemyMap = bot.ConfigureShips();
        }
        public void CreateMaps()
        {
            this.Width = mapSize * 2 * cellSize + 230;
            this.Height = (mapSize + 3) * cellSize + 70;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    myMap[i, j] = 0;

                    Button button = new Button();
                    button.Location = new Point(j * cellSize, i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.BackColor = Color.White;
                    if (j == 0 || i == 0)
                    {
                        button.BackColor = Color.Gray;
                        if (i == 0 && j > 0)
                            button.Text = alphabet[j - 1].ToString();
                        if (j == 0 && i > 0)
                            button.Text = i.ToString();
                    }
                    else
                    {
                        button.Click += new EventHandler(ConfigureShips);
                    }
                    myButtons[i, j] = button;
                    this.Controls.Add(button);
                }
            }
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    myMap[i, j] = 0;
                    enemyMap[i, j] = 0;

                    Button button = new Button();
                    button.Location = new Point(320 + j * cellSize, i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.BackColor = Color.White;
                    if (j == 0 || i == 0)
                    {
                        button.BackColor = Color.Gray;
                        if (i == 0 && j > 0)
                            button.Text = alphabet[j - 1].ToString();
                        if (j == 0 && i > 0)
                            button.Text = i.ToString();
                    }
                    else
                    {
                        button.Click += new EventHandler(PlayerShoot);
                    }
                    enemyButtons[i, j] = button;
                    this.Controls.Add(button);
                }
            }
            Label map1 = new Label();
            map1.Text = "Карта игрока";
            map1.Location = new Point(mapSize * cellSize / 10, mapSize * cellSize + 5);
            this.Controls.Add(map1);

            Label map2 = new Label();
            map2.Text = "Карта противника";
            map2.Location = new Point(350 + mapSize * cellSize / 14, mapSize * cellSize + 5);
            this.Controls.Add(map2);

            
            Button startButton = new Button();
            startButton.Text = "Начать";
            startButton.Click += new EventHandler(Start);
            startButton.Location = new Point(0, mapSize * cellSize + 85);
            this.Controls.Add(startButton);

            Button SettingButton = new Button();
            SettingButton.Text = "Налаштування";
            SettingButton.Click += SettingButton_Click;
            SettingButton.Location = new Point(660, mapSize * cellSize + 85);
            SettingButton.Width = 120;
            this.Controls.Add(SettingButton);

            Button ExitButton = new Button();
            ExitButton.Text = "Завершити";
            ExitButton.Click += ExitButton_Click;
            ExitButton.Location = new Point(260, mapSize * cellSize + 40);
            ExitButton.Width = 120;
            ExitButton.Height = 50;
            this.Controls.Add(ExitButton);

            Button TextButton = new Button();
            TextButton.Text = "Text";
            TextButton.Click += TextButton_Click;
            TextButton.Location = new Point(520, mapSize * cellSize + 85);
            TextButton.Width = 120;
            this.Controls.Add(TextButton);


            


        }
        private void Game_Load(object sender, EventArgs e)
        {
            
        }
        //setting
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelMyText.Text = "Мінус один";
            labelTextNoMy.Text = "Тобі просто повезло";
        }
        private void radioButtonMyWin_CheckedChanged(object sender, EventArgs e)
        {
            labelMyText.Text = "Я тебе виграю";
            labelTextNoMy.Text = "Даже не мрій";
        }
        private void radioButtonHello_CheckedChanged(object sender, EventArgs e)
        {
            labelMyText.Text = "Привіт";
            labelTextNoMy.Text = "Хай";

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            labelMyText.Text = "Привіт";
        }
        internal void TextButton_Click(object sender, EventArgs e)
        {
            radioButtonHello.Visible = true;
            radioButtonMyWin.Visible = true;
            radioButton3.Visible = true;
        }
        internal void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        internal void ChangeFormColor(Color color)
        {
            this.BackColor = color;
        }
        private void SettingButton_Click(object sender, EventArgs e)
        {
            Settin settingsForm = new Settin();
            settingsForm.Show();
        }
        public void Start(object sender, EventArgs e)
        {
            isPlaying = true;
        }
        public bool CheckIfMapIsNotEmpty()
        {
            bool isEmpty1 = true;
            bool isEmpty2 = true;
            for (int i = 1; i < mapSize; i++)
            {
                for (int j = 1; j < mapSize; j++)
                {
                    if (myMap[i, j] != 0)
                        isEmpty1 = false;
                    if (enemyMap[i, j] != 0)
                        isEmpty2 = false;
                }
            }
            if (isEmpty1 || isEmpty2)
                return false;
            else return true;
        }
        public void ConfigureShips(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            if (!isPlaying)
            {
                if (myMap[pressedButton.Location.Y / cellSize, pressedButton.Location.X / cellSize] == 0)
                {
                    pressedButton.BackColor = Color.Red;
                    myMap[pressedButton.Location.Y / cellSize, pressedButton.Location.X / cellSize] = 1;
                }
                else
                {
                    pressedButton.BackColor = Color.White;
                    myMap[pressedButton.Location.Y / cellSize, pressedButton.Location.X / cellSize] = 0;
                }
            }
        }
        public void PlayerShoot(object sender, EventArgs e)
        {

            Button pressedButton = sender as Button;
            bool playerTurn = Shoot(enemyMap, pressedButton);
            if (!playerTurn)
                bot.Shoot();

            if (!CheckIfMapIsNotEmpty())
            {
                this.Controls.Clear();
                Init();
            }
        }
        public bool Shoot(int[,] map, Button pressedButton)
        {
            bool hit = false;
            if (isPlaying)
            {
                int delta = 0;
                if (pressedButton.Location.X > 320)
                    delta = 320;
                if (map[pressedButton.Location.Y / cellSize, (pressedButton.Location.X - delta) / cellSize] != 0)
                {
                    hit = true;
                    map[pressedButton.Location.Y / cellSize, (pressedButton.Location.X - delta) / cellSize] = 0;
                    pressedButton.BackColor = Color.Blue;
                    pressedButton.Text = "X";
                }
                else
                {
                    hit = false;

                    pressedButton.BackColor = Color.Black;
                }
            }
            return hit;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Fon temp = new Fon();
            temp.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        
    }
}

namespace LabForm3
{
    public partial class Form1 : Form
    {
        private int targetNumber;
        private int guessCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayGame();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckGuess();
        }

        private void PlayAgain()
        {
            DialogResult result = MessageBox.Show("Бажаєте зіграти ще раз?", "Гра \"Вгадай число\"", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                Application.Exit();
                return;
            }
            PlayAgain();
        }
        private void PlayGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 201);
            guessCount = 0;
            MessageBox.Show("Нова гра розпочата!", "Гра \"Вгадай число\"");
        }
        private void CheckGuess()
        {
            string input = textBox1.Text;
            int userGuess;

            if (int.TryParse(input, out userGuess))
            {
                MessageBox.Show("Некоректний ввід. Будь ласка, введіть число.", "Гра \"Вгадай число\"");
                return;

            }
            guessCount++;

            if (userGuess < targetNumber)
            {
                MessageBox.Show("Ваше число замале.", "Гра \"Вгадай число\"");
            }
            else if (userGuess > targetNumber)
            {
                MessageBox.Show("Ваше число завелике.", "Гра \"Вгадай число\"");
            }
            else
            {
                MessageBox.Show("Ви вгадали число " + targetNumber + "!", "Гра \"Вгадай число\"");
                MessageBox.Show("Кількість спроб: " + guessCount, "Гра \"Вгадай число\"");
                PlayAgain();
            }
        }
        private void EndGame()
        {
            MessageBox.Show("Гра завершена. Загадане число: " + targetNumber, "Гра \"Вгадай число\"");
            Application.Exit();
        }
    }
}
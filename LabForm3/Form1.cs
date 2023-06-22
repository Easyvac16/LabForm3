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
        private void PlayGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 201);
            guessCount = 0;
            MessageBox.Show("���� ��� ���������!", "��� \"������ �����\"");
        }

        private void CheckGuess()
        {
            string input = textBox1.Text;
            int userGuess;

            if (int.TryParse(input, out userGuess))
            {
                guessCount++;

                if (userGuess < targetNumber)
                {
                    MessageBox.Show("���� ����� ������.", "��� \"������ �����\"");
                }
                else if (userGuess > targetNumber)
                {
                    MessageBox.Show("���� ����� ��������.", "��� \"������ �����\"");
                }
                else
                {
                    MessageBox.Show("�� ������� ����� " + targetNumber + "!", "��� \"������ �����\"");
                    MessageBox.Show("ʳ������ �����: " + guessCount, "��� \"������ �����\"");
                    PlayAgain();
                }
            }
            else
            {
                MessageBox.Show("����������� ���. ���� �����, ������ �����.", "��� \"������ �����\"");
            }
        }




        private void EndGame()
        {
            MessageBox.Show("��� ���������. �������� �����: " + targetNumber, "��� \"������ �����\"");
        }




        private void button2_Click(object sender, EventArgs e)
        {
            EndGame();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckGuess();
        }

        private void PlayAgain()
        {
            DialogResult result = MessageBox.Show("������ ������ �� ���?", "��� \"������ �����\"", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                PlayGame();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
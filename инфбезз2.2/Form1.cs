namespace инфбезз2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                // Алфавиты
                char[] firstAlphabet = "vwxyz .,!:;?-klmnopqrstuabcdefghij".ToCharArray();
                char[] secondAlphabet = "z .xy,!st:;qr?-uvwlmnopabcdefghijk".ToCharArray();
                char[] thirdAlphabet = "z .xy,!st;:qr?-uvwlmnopabcdefghijk".ToCharArray();

                // Введенное слово
                string inputWord = textBox1.Text.ToLower(); // Приводим к нижнему регистру

                // Преобразуем слово в массив символов
                char[] inputChars = inputWord.ToCharArray();

                // Зашифрованное слово
                string encryptedWord = "";

                // Проходим по каждому символу в массиве и определяем его порядковый номер в слове
                for (int i = 0; i < inputChars.Length; i++)
                {
                    int charPositionInWord = i + 1;

                    // Исходя из порядкового номера, выбираем нужный алфавит и заменяем символ на соответствующий ему символ в выбранном алфавите
                    if (charPositionInWord % 3 == 1)
                    {
                        encryptedWord += firstAlphabet[Array.IndexOf(firstAlphabet, inputChars[i])];
                    }
                    else if (charPositionInWord % 3 == 2)
                    {
                        encryptedWord += secondAlphabet[Array.IndexOf(firstAlphabet, inputChars[i])];
                    }
                    else if (charPositionInWord % 3 == 0)
                    {
                        encryptedWord += thirdAlphabet[Array.IndexOf(firstAlphabet, inputChars[i])];
                    }
                }

                // Выводим зашифрованное слово
                textBox2.Text = encryptedWord;
            }


            if (checkBox1.Checked == true)
            {
                string input = textBox1.Text.ToLower();
                string output = " ";

                Dictionary<char, char> dict = new Dictionary<char, char>
                {
                    {'a','v'},
                    {'b','w'},
                    {'c','x'},
                    {'d','y'},
                    {'e','z'},
                    {'f',' '},
                    {'g','.'},
                    {'h',','},
                    {'i','!'},
                    {'j',':'},
                    {'k',';'},
                    {'l','?'},
                    {'m','-'},
                    {'n','k'},
                    {'o','l'},
                    {'p','m'},
                    {'q','n'},
                    {'r','o'},
                    {'s','p'},
                    {'t','q'},
                    {'u','r'},
                    {'v','s'},
                    {'w','t'},
                    {'x','u'},
                    {'y','a'},
                    {'z','b'},
                    {' ','c'},
                    {'.','d'},
                    {',','e'},
                    {'!','f'},
                    {':','g'},
                    {';','h'},
                    {'?','i'},
                    {'-','j'}
                };
                // проходим по каждой букве исходного текста и заменяем ее на соответствующую букву из словаря
                foreach (char c in input)
                {
                    if (dict.ContainsKey(c))
                    {
                        output += dict[c];
                    }
                    else
                    {
                        output += c; // если символ не является буквой, оставляем его без изменений
                    }
                }
                // выводим зашифрованный текст в TextBox
                textBox2.Text = output;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                // Алфавиты
                char[] firstAlphabet = "vwxyz .,!:;?-klmnopqrstuabcdefghij".ToCharArray();
                char[] secondAlphabet = "z .xy,!st:;qr?-uvwlmnopabcdefghijk".ToCharArray();
                char[] thirdAlphabet = "z .xy,!st;:qr?-uvwlmnopabcdefghijk".ToCharArray();
                // Введенное слово
                string inputWord = textBox2.Text.ToLower(); // Приводим к нижнему регистру

                // Преобразуем слово в массив символов
                char[] inputChars = inputWord.ToCharArray();

                // Зашифрованное слово
                string encryptedWord = "";

                // Проходим по каждому символу в массиве и определяем его порядковый номер в слове
                for (int i = 0; i < inputChars.Length; i++)
                {
                    int charPositionInWord = i + 1;

                    // Исходя из порядкового номера, выбираем нужный алфавит и заменяем символ на соответствующий ему символ в выбранном алфавите
                    if (charPositionInWord % 3 == 1)
                    {
                        encryptedWord += firstAlphabet[Array.IndexOf(firstAlphabet, inputChars[i])];
                    }
                    else if (charPositionInWord % 3 == 2)
                    {
                        encryptedWord += firstAlphabet[Array.IndexOf(secondAlphabet, inputChars[i])];
                    }
                    else if (charPositionInWord % 3 == 0)
                    {
                        encryptedWord += firstAlphabet[Array.IndexOf(thirdAlphabet, inputChars[i])];
                    }
                }
                textBox1.Text = encryptedWord;// Выводим зашифрованное слово
            }

        
            if (checkBox1.Checked == true)
            {
                string input = textBox2.Text.ToLower();
                string output = " ";

                Dictionary<char, char> dict = new Dictionary<char, char>
                {
                    {'v','a'},
                    {'w','b'},
                    {'x','c'},
                    {'y','d'},
                    {'z','e'},
                    {' ','f'},
                    {'.','g'},
                    {',','h'},
                    {'!','i'},
                    {':','j'},
                    {';','k'},
                    {'?','l'},
                    {'-','m'},
                    {'k','n'},
                    {'l','o'},
                    {'m','p'},
                    {'n','q'},
                    {'o','r'},
                    {'p','s'},
                    {'q','t'},
                    {'r','u'},
                    {'s','v'},
                    {'t','w'},
                    {'u','x'},
                    {'a','y'},
                    {'b','z'},
                    {'c',' '},
                    {'d','.'},
                    {'e',','},
                    {'f','!'},
                    {'g',':'},
                    {'h',';'},
                    {'i','?'},
                    {'j','-'}
                };
                foreach (char c in input)
                {
                    if (dict.ContainsKey(c))
                    {
                        output += dict[c];
                    }
                    else
                    {
                        output += c; // если символ не является буквой, оставляем его без изменений
                    }
                }
                // выводим зашифрованный текст в TextBox
                textBox1.Text = output;
            }

        }
    }
}
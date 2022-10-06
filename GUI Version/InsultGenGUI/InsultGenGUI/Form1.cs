using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InsultGenGUI
{
    public partial class Form1 : Form
    {
        int compCount, insultCount;
        private int _wordResult = 3;
        public Form1()
        {
            InitializeComponent();
        }

        static string getString(char[] arr)
        {
            // string() is a used to 
            // convert the char array
            // to string
            string s = new string(arr);

            return s;
        }

        private string FindAppPath(string name)
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            return strWorkPath;
        }
        private void RemoveFirstChar(string[] token)
        {
            List<char> charsToRemove = new List<char>() { '\n' };
            for(int i = 0; i < token.Length; i++)
            { 
                foreach(char c in charsToRemove)
                {
                    token[i] = token[i].Replace(c.ToString(), String.Empty);
                }
            }
        }

        private bool checkFirstLetter(string word)
        {
            if (word == "")
                return false;
            List<char> capitalLetters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

            for (int i = 0; i < capitalLetters.Count; i++)
            {
                if (word[0] == capitalLetters[i])
                    return true;
            }
            return false;
        }

        private string Generator()
        {
            // 355 lines in nice, 427 lines in insult
            int max = 200;
            int toRead = 45;
            int getOut = 0;
            int z = 100;
            int[] num = new int[_wordResult];
            int i, k;
            int j = 0;
            char[] line = new char[toRead];
            string s, word;
            string[] token = new string[50];
            string final = "";
            bool ready = false;

            if(insultToolStripMenuItem.Checked)
                insultCount++;
            if(compToolStripMenuItem.Checked)
                compCount++;

            string path = FindAppPath("InsultGenGUI");
            StreamReader fp;
            // open file for reading
            if (insultToolStripMenuItem.Checked)
                fp = new StreamReader(path + "\\insult.txt");
            else if (compToolStripMenuItem.Checked)
                fp = new StreamReader(path + "\\nice.txt");
            else
                fp = null;

            // Create a random vars
            Random randNum = new Random();
            Random rand = new Random(randNum.Next());
            while(fp != null && j < _wordResult)
            {
                // Reset pointer to top of file
                fp.DiscardBufferedData();
                fp.BaseStream.Seek(0, SeekOrigin.Begin);

                num[j] =  rand.Next() % max;
                
                for(k = 0; k < _wordResult; k++)
                {
                    if((j != k) && (num[j] == num[k]))
                    {
                        num[j] = rand.Next() % max;
                    }
                }

                for(i = 0; i < num[j]; i++)
                {
                    fp.Read(line, 0, toRead);
                }

                s = string.Concat(line);
                token = s.Split('\r');
                RemoveFirstChar(token);
                if (token.Length > 1)
                    word = token[rand.Next() % (token.Length - 1)];
                else
                    word = token[rand.Next() % token.Length];

                if (insultCount % 3 == 0)
                {
                    while (num[j] > z)
                    {
                        fp.DiscardBufferedData();
                        fp.BaseStream.Seek(0, SeekOrigin.Begin);
                        num[j] = rand.Next() % max;

                        for (i = 0; i < num[j]; i++)
                        {
                            fp.Read(line, 0, toRead);
                        }

                        s = string.Concat(line);
                        token = s.Split('\r');
                        RemoveFirstChar(token);
                        if (token.Length > 1)
                            word = token[rand.Next() % (token.Length - 1)];
                        else
                            word = token[rand.Next() % token.Length];
                    }
                }

                while (!ready)
                {
                    getOut++;

                    if(getOut == 5)
                    {
                        fp.DiscardBufferedData();
                        fp.BaseStream.Seek(0, SeekOrigin.Begin);
                        num[j] = rand.Next() % max;


                        while(num[j] > z)
                        {
                            num[j] = rand.Next() % max;
                        }

                        for (i = 0; i < num[j]; i++)
                        {
                            fp.Read(line, 0, toRead);
                        }

                        s = string.Concat(line);
                        token = s.Split('\r');
                        RemoveFirstChar(token);
                        if (token.Length > 1)
                            word = token[rand.Next() % (token.Length - 1)];
                        else
                            word = token[rand.Next() % token.Length];

                        getOut = 0;
                    }

                    ready = true;
                    while (word == "" || word[0] == '\0')
                    {
                        if (token.Length > 1)
                            word = token[rand.Next() % (token.Length - 1)];
                        else
                            word = token[rand.Next() % token.Length];
                        ready = false;
                    }

                    while (word[word.Length - 1] != ' ')
                    {
                        if (token.Length > 1)
                            word = token[rand.Next() % (token.Length - 1)];
                        else
                            word = token[rand.Next() % token.Length];
                        ready = false;
                    }

                    while (word == "o")
                    {
                        if (token.Length > 1)
                            word = token[rand.Next() % (token.Length - 1)];
                        else
                            word = token[rand.Next() % token.Length];
                        ready = false;
                    }

                    while (!checkFirstLetter(word))
                    {
                        word = token[rand.Next() % token.Length];
                        ready = false;
                    }

                    if (final.Contains(word))
                        ready = false;
                }
                ready = false;

                if (word == "Yaho")
                    word = "Yahoo";

                final += word;

                j++;
            }

            return final;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (insultToolStripMenuItem.Checked)
                this.Text = "Insult Generator 3000";
            else if (compToolStripMenuItem.Checked)
                this.Text = "Compliment Generator 3000";
            else
                this.Text = "Generator 3000";
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e) // yes
        {
            bool found = false;
            string text = Generator();

            if (_wordResult == 1 && compToolStripMenuItem.Checked)
            {
                this.textBox2.Text = "Call them";
            }
            else
            {
                List<char> vowel = new List<char>() { 'A', 'E', 'I', 'O', 'U' };
                for (int i = 0; i < vowel.Count; i++)
                {
                    if (text[0] == vowel[i])
                        found = true;
                }

                if (found)
                    this.textBox2.Text = "Call them an";
                else
                    this.textBox2.Text = "Call them a";
            }

            this.displayText.Text = text;


            this.statBox.Text = insultCount.ToString();
            this.statBox2.Text = compCount.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e) // no
        {
            if (insultToolStripMenuItem.Checked) // if insult gen on
            {
                this.textBox2.Text = "";
                this.displayText.Text = "Sick Burn Bro!";
            }
            else // if comp gen on
            {
                this.textBox2.Text = "";
                this.displayText.Text = "How Lovely of You";
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void displayStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(displayStatsToolStripMenuItem.Checked)
            {
                //make stats visable
                this.statBox.Enabled = true;
                this.statBox.Visible = true;
                this.GeneratedTextBox.Visible = true;

                this.statBox.Text = insultCount.ToString();

                this.statBox2.Enabled = true;
                this.statBox2.Visible = true;
                this.GeneratedTextBox2.Visible = true;

                this.statBox2.Text = compCount.ToString();

                this.statBox3.Enabled = true;
                this.statBox3.Visible = true;
                this.GeneratedTextBox3.Visible = true;

                this.statBox3.Text = _wordResult.ToString();
            }
            else
            {
                //hide stats
                this.statBox.Enabled = false;
                this.statBox.Visible = false;
                this.GeneratedTextBox.Visible = false;

                this.statBox2.Enabled = false;
                this.statBox2.Visible = false;
                this.GeneratedTextBox2.Visible = false;

                this.statBox3.Enabled = false;
                this.statBox3.Visible = false;
                this.GeneratedTextBox3.Visible = false;
            }
        }

        private void restartCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insultCount = 0;
            compCount = 0;
            this.statBox.Text = insultCount.ToString();
            this.statBox2.Text = compCount.ToString();
        }

        private void compToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(insultToolStripMenuItem.Checked) // if insult gen was turned on
            {
                this.Text = "Compliment Generator 3000";
                insultToolStripMenuItem.Checked = false; // turn check for insult off
                this.textBox1.Text = "Do you need a compliment?";
                this.displayText.Text = "";

                this.textBox2.Text = "";

                this.yesButton.Enabled = true;
                this.noButton.Enabled = true;
            }
            else if(!compToolStripMenuItem.Checked) // if nothing is selected
            {
                this.Text = "Generator 3000";
                this.textBox1.Text = "";
                this.textBox2.Text = "No Generator Selected";
                this.displayText.Text = "";

                this.yesButton.Enabled = false;
                this.noButton.Enabled = false;
            }
            else
            {
                this.Text = "Compliment Generator 3000";
                this.textBox1.Text = "Do you need a compliment?";
                this.displayText.Text = "";

                this.textBox2.Text = "";

                this.yesButton.Enabled = true;
                this.noButton.Enabled = true;
            }

        }

        private void changeNumberOfWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopUp popup = new PopUp();
            DialogResult dialogResult = popup.ShowDialog();

            _wordResult = popup.Word;
            this.statBox3.Text = _wordResult.ToString();

        }

        private void insultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(compToolStripMenuItem.Checked) // if compliment gen was turned on
            {
                this.Text = "Insult Generator 3000";
                compToolStripMenuItem.Checked = false; // turn check for comp off
                this.textBox1.Text = "Do you need an insult?";
                this.displayText.Text = "";
                this.textBox2.Text = "";

                this.yesButton.Enabled = true;
                this.noButton.Enabled = true;
            }
            else if(!insultToolStripMenuItem.Checked) // if nothing is selected
            {
                this.Text = "Generator 3000";
                this.textBox1.Text = "";
                this.textBox2.Text = "No Generator Selected";
                this.displayText.Text = "";

                this.yesButton.Enabled = false;
                this.noButton.Enabled = false;
            }
            else
            {
                this.Text = "Insult Generator 3000";
                this.textBox1.Text = "Do you need a insult?";
                this.displayText.Text = "";

                this.textBox2.Text = "";

                this.yesButton.Enabled = true;
                this.noButton.Enabled = true;
            }
        }

        public int WordResult
        {
            get => _wordResult;
        }
    }
}

using HangMan.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace HangMan
{
    public partial class frmHangman : Form
    {
        private Bitmap[] hangImages = { HangMan.Properties.Resources.hangman1,
                                        HangMan.Properties.Resources.hangman2,
                                        HangMan.Properties.Resources.hangman3,
                                        HangMan.Properties.Resources.hangman4,
                                        HangMan.Properties.Resources.hangman5,
                                        HangMan.Properties.Resources.hangman6,
                                        HangMan.Properties.Resources.hangman7};
     
        private int wrongGuesses = 0;
        private string current = "";
        
        private string copyCurrent = "";
        private string[] words;
        private string[] hints;

        private string engOrNonEng = "";
        private string easyMedDiff = "";

        SoundPlayer bgSound = new SoundPlayer();
        SoundPlayer bgSound2 = new SoundPlayer();

        public frmHangman()
        {
            InitializeComponent();
            bgSound.SoundLocation = "bgmusic.wav";
            if (!btMusic.Font.Strikeout)
            {
                bgSound.PlayLooping();
            }
            
            foreach (Control c in this.Controls)
            {
                if (c.GetType() != typeof(Button))
                {
                    c.Hide();
                }
                else
                {
                    if (!c.Name.Equals("bt_E") && !c.Name.Equals("bt_NE") && !c.Name.Equals("btMusic"))
                    {
                        c.Hide();
                    } else
                    {
                        c.Show();
                    }
                }
            }
        }

        private void bt_G_Home_Click(object sender, EventArgs e)
        {
            reset();
            bgSound.SoundLocation = "bgmusic.wav";
            if (!btMusic.Font.Strikeout)
            {
                bgSound.PlayLooping();
            }
            foreach (Control c in this.Controls)
            {
                c.Hide();
               
                if (c.Name.Equals("bt_E") || c.Name.Equals("bt_NE") || c.Name.Equals("btMusic"))
                {
                    c.Show();
                    c.Enabled = true;
                }
            }
        }

        private void bt_E_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() != typeof(Button))
                {
                    c.Hide();
                }
                else
                {
                    if (!c.Name.StartsWith("bt_E_") && !c.Name.Equals("bt_G_Home") && !c.Name.Equals("btMusic"))
                    {
                        c.Hide();
                    } else
                    {
                        c.Show();
                        c.Enabled = true;
                    }
                }
            }
        }

        private void bt_NE_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() != typeof(Button))
                {
                    c.Hide();
                }
                if (c.GetType() == typeof(Button))
                {
                    if (!c.Name.StartsWith("bt_NE_") && !c.Name.Equals("bt_G_Home") && !c.Name.Equals("btMusic"))
                    {
                        c.Hide();
                    }
                    else
                    {
                        c.Show();
                        c.Enabled = true;
                    }
                }
            }
        }

        private void resetAll()
        {
            frmHangman_Load1();
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    if (!c.Name.StartsWith("bt_G") && !c.Name.StartsWith("cmd") && !c.Name.Equals("btMusic"))
                    {
                        c.Hide();
                    }
                    else
                    {
                        c.Show();
                        c.Enabled = true;
                    }
                }
                else
                {
                    c.Show();
                }
                c.Enabled = true;
            }
        }

        private void bt_E_Easy_Click(object sender, EventArgs e)
        {
            engOrNonEng = "English";
            easyMedDiff = "Easy";
            resetAll();
        }

        private void bt_E_Med_Click(object sender, EventArgs e)
        {
            engOrNonEng = "English";
            easyMedDiff = "Medium";
            resetAll();
        }

        private void bt_E_Diff_Click(object sender, EventArgs e)
        {
            engOrNonEng = "English";
            easyMedDiff = "Difficult";
            resetAll();
        }

        private void bt_NE_Easy_Click(object sender, EventArgs e)
        {
            engOrNonEng = "NonEnglish";
            easyMedDiff = "Easy";
            resetAll();
        }

        private void bt_NE_Med_Click(object sender, EventArgs e)
        {
            engOrNonEng = "NonEnglish";
            easyMedDiff = "Medium";
            resetAll();
        }

        private void bt_NE_Diff_Click(object sender, EventArgs e)
        {
            engOrNonEng = "NonEnglish";
            easyMedDiff = "Difficult";
            resetAll();
        }

        private void loadWords()
        {
            char[] delimitChars = { ',' };

            string[] readText;
            try
            {
                if (engOrNonEng.Equals("English"))
                {
                    if (easyMedDiff.Equals("Easy"))
                    {
                        readText = File.ReadAllLines("Eng_Easy.csv");
                    }
                    else if (easyMedDiff.Equals("Medium"))
                    {
                        readText = File.ReadAllLines("Eng_Medium.csv");
                    }
                    else
                    {
                        readText = File.ReadAllLines("Eng_Difficult.csv");
                    }
                }
                else
                {
                    if (easyMedDiff == "Easy")
                    {
                        readText = File.ReadAllLines("Non_Eng_Easy.csv");
                    }
                    else if (easyMedDiff == "Medium")
                    {
                        readText = File.ReadAllLines("Non_Eng_Medium.csv");
                    }
                    else
                    {
                        readText = File.ReadAllLines("Non_Eng_Difficult.csv");
                    }
                }

                words = new string[readText.Length];
                hints = new string[readText.Length];

            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimitChars);
                words[index] = line[1];
                hints[index] = line[2];
                index++;
            }
        }
            catch (Exception fileNotFound)
            {
                hint.Text = fileNotFound.ToString();
            }
        }

        private void setUpWordChoice()
        {
            wrongGuesses = 0;
            hangImage.Image = hangImages[wrongGuesses];
            int guessIndex = (new Random().Next(words.Length));
            current = words[guessIndex];

            copyCurrent = "";

            for (int index = 0; index < current.Length; index++)
            {
                copyCurrent += "_";
            }
            hint.Text = hints[guessIndex];
            displayCopy();
        }

        private void displayCopy()
        {
            lblShowWord.Text = "";
            for (int index = 0; index < copyCurrent.Length; index++)
            {
                lblShowWord.Text += copyCurrent.Substring(index,1);
                lblShowWord.Text += " ";
            }
            int guessIndex = (new Random().Next(words.Length));
        }

        //private void updateCopy(char guess)
        //{

        //}

        private void guessClick(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled = false;
            if (current.Contains(choice.Text))
            {
                char[] temp = copyCurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);

                for(int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guessChar)
                    {
                        temp[index] = guessChar;
                    }
                }
                copyCurrent = new string(temp);
                displayCopy();
            } else
            {
                wrongGuesses++;
            }
            
            if (wrongGuesses < 6)
            {
                hangImage.Image = hangImages[wrongGuesses];
            }
            else
            {
                labelResult.Text = "You Lose!";
                hangImage.Image = hangImages[6];
                lblAnswer.Text = "Answer: " + current;
                if (!btMusic.Font.Strikeout)
                {
                    bgSound2.SoundLocation = "lose.wav";
                    bgSound2.Play();
                }
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(Button))
                    {
                        if (!c.Name.StartsWith("bt_G") && !c.Name.Equals("btMusic"))
                        {
                            c.Enabled = false;
                        }
                        else
                        {
                            c.Enabled = true;
                        }
                    }
                }
            }
            if (copyCurrent.Equals(current))
            {
                labelResult.Text = "You Win!";
                if (!btMusic.Font.Strikeout)
                {
                    bgSound2.SoundLocation = "win.wav";
                    bgSound2.Play();
                }
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(Button))
                    {
                        if (!c.Name.StartsWith("bt_G") && !c.Name.Equals("btMusic"))
                        {
                            c.Enabled = false;
                        }
                        else
                        {
                            c.Enabled = true;
                        }
                    }
                }
            }
        }

        private void frmHangman_Load(object sender, EventArgs e)
        {
            Button bn = sender as Button;
            loadWords();
            setUpWordChoice();
        }

        private void frmHangman_Load1()
        {
            try
            {
                loadWords();
                setUpWordChoice();
            }
            catch(Exception loadAndSetWordError)
            {
                hint.Text = loadAndSetWordError.ToString();
            }
        }

        private void reset()
        {
            try
            {
                setUpWordChoice();
            }
            catch (Exception setUpWordError)
            {
                hint.Text = setUpWordError.ToString();
            }
            
            labelResult.Text = "";
            lblAnswer.Text = "";

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Button) && c.Name.StartsWith("cmd"))
                {
                   c.Enabled = true;
                }
            }
        }

        private void restart_click(object sender, EventArgs e)
        {
            reset();
            if (!btMusic.Font.Strikeout)
            {
                bgSound.SoundLocation = "bgmusic.wav";
                bgSound.PlayLooping();
            }
        }

        private void btMusic_Click(object sender, EventArgs e)
        {
            if (!btMusic.Font.Strikeout)
            {
                Font fnt = new Font(btMusic.Font, FontStyle.Strikeout);
                btMusic.Font = fnt;
                bgSound.Stop();
            } else
            {
                Font fnt = new Font(btMusic.Font, FontStyle.Regular);
                btMusic.Font = fnt;
                bgSound.Play();
            }
        }
    }
}
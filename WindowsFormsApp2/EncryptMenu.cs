using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaLib;

namespace WindowsFormsApp2
{
    public partial class EncryptMenu : Form
    {
        private Enigma enigma = new Enigma();
        private string KeyPart1 = "a";
        private string KeyPart2 = "a";
        private string KeyPart3 = "a";


        public EncryptMenu()
        {
            InitializeComponent();
            var langs = new Languages();
            comboBox1.DataSource = langs.EnRLine.ToList();
            comboBox2.DataSource = langs.EnRLine.ToList();
            comboBox3.DataSource = langs.EnRLine.ToList();
            LangEn.Checked = true;
        }

        private void InterfaceLangSwitcher(string lang)
        {
            var langs = new Languages();

            switch (lang)
            {
                case "ru":
                    comboBox1.DataSource = langs.RuRLine.ToList();
                    comboBox2.DataSource = langs.RuRLine.ToList();
                    comboBox3.DataSource = langs.RuRLine.ToList();
                    break;

                case "en":
                    comboBox1.DataSource = langs.EnRLine.ToList();
                    comboBox2.DataSource = langs.EnRLine.ToList();
                    comboBox3.DataSource = langs.EnRLine.ToList();
                    break;

                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyPart1 = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyPart2 = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyPart3 = comboBox3.Text;
        }

        private void EncryptMenu_Load(object sender, EventArgs e)
        {

        }

        private void LangRu_CheckedChanged(object sender, EventArgs e)
        {
            enigma.SwithLang("ru");
            InterfaceLangSwitcher("ru");
        }

        private void LangEn_CheckedChanged(object sender, EventArgs e)
        {
            enigma.SwithLang("en");
            InterfaceLangSwitcher("en");
        }

        private void EncryptingButton_Click(object sender, EventArgs e)
        {
            progressBar2.Value = 0;
            textBox1.Text = null;
            char[] encryptMessage = MessageInput.Text.ToCharArray();
            char[] result = new char[encryptMessage.Length];

            if (encryptMessage.Length == 0)
                MessageBox.Show("Сначала введите сообщение.");

            progressBar2.Maximum = encryptMessage.Length;

            try
            {
                int counter = 0;

                foreach (char i in encryptMessage)
                {
                    result[counter] = enigma.Ecnrypt(i);
                    counter++;
                }

                foreach (char i in result)
                {
                    textBox1.Text += i;
                    textBox1.Update();
                    Thread.Sleep(200);
                    progressBar2.PerformStep();
                }

                Array.Clear(result);
            }

            catch
            {
                MessageBox.Show("Проверьте правильность раскладки введенного текста, а также его соответствие алфавиту.");
            }

        }

        private void MessageInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetKey_Click(object sender, EventArgs e)
        {
            enigma.SetKey(KeyPart1 + KeyPart2 + KeyPart3);
            MessageBox.Show($"Успешно установлен ключ: {KeyPart1} {KeyPart2} {KeyPart3}");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void ClearOutput_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            progressBar2.Value = 0;
        }

        private void ClearInput_Click(object sender, EventArgs e)
        {
            MessageInput.Text = null;
            progressBar2.Value = 0;
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}

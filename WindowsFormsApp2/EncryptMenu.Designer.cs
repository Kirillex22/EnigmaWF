namespace WindowsFormsApp2
{
    partial class EncryptMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptMenu));
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            LangRu = new System.Windows.Forms.RadioButton();
            LangEn = new System.Windows.Forms.RadioButton();
            SetKey = new System.Windows.Forms.Button();
            MessageInput = new System.Windows.Forms.TextBox();
            EncryptingButton = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            Logo = new System.Windows.Forms.PictureBox();
            ClearInput = new System.Windows.Forms.Button();
            ClearOutput = new System.Windows.Forms.Button();
            progressBar2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", "", ".", "!", "?", "\"", "-", ":" });
            comboBox1.Location = new System.Drawing.Point(22, 254);
            comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(93, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", "", ".", "!", "?", "\"", "-", ":" });
            comboBox2.Location = new System.Drawing.Point(123, 254);
            comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(93, 23);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", "", ".", "!", "?", "\"", "-", ":" });
            comboBox3.Location = new System.Drawing.Point(224, 254);
            comboBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(93, 23);
            comboBox3.TabIndex = 2;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // LangRu
            // 
            LangRu.AutoSize = true;
            LangRu.BackColor = System.Drawing.SystemColors.Window;
            LangRu.Location = new System.Drawing.Point(106, 335);
            LangRu.Name = "LangRu";
            LangRu.Size = new System.Drawing.Size(65, 19);
            LangRu.TabIndex = 3;
            LangRu.TabStop = true;
            LangRu.Text = "Russian";
            LangRu.UseVisualStyleBackColor = false;
            LangRu.CheckedChanged += LangRu_CheckedChanged;
            // 
            // LangEn
            // 
            LangEn.AutoSize = true;
            LangEn.BackColor = System.Drawing.SystemColors.Window;
            LangEn.Location = new System.Drawing.Point(106, 354);
            LangEn.Name = "LangEn";
            LangEn.Size = new System.Drawing.Size(63, 19);
            LangEn.TabIndex = 4;
            LangEn.TabStop = true;
            LangEn.Text = "English";
            LangEn.UseVisualStyleBackColor = false;
            LangEn.CheckedChanged += LangEn_CheckedChanged;
            // 
            // SetKey
            // 
            SetKey.Location = new System.Drawing.Point(22, 205);
            SetKey.Name = "SetKey";
            SetKey.Size = new System.Drawing.Size(295, 43);
            SetKey.TabIndex = 5;
            SetKey.Text = "Установить ключ";
            SetKey.UseVisualStyleBackColor = true;
            SetKey.Click += SetKey_Click;
            // 
            // MessageInput
            // 
            MessageInput.Location = new System.Drawing.Point(192, 334);
            MessageInput.Multiline = true;
            MessageInput.Name = "MessageInput";
            MessageInput.Size = new System.Drawing.Size(544, 39);
            MessageInput.TabIndex = 6;
            MessageInput.TextChanged += MessageInput_TextChanged;
            // 
            // EncryptingButton
            // 
            EncryptingButton.Location = new System.Drawing.Point(192, 379);
            EncryptingButton.Name = "EncryptingButton";
            EncryptingButton.Size = new System.Drawing.Size(460, 26);
            EncryptingButton.TabIndex = 7;
            EncryptingButton.Text = "Зашифровать сообщение";
            EncryptingButton.UseVisualStyleBackColor = true;
            EncryptingButton.Click += EncryptingButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(351, 205);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(544, 43);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.Window;
            label2.Location = new System.Drawing.Point(608, 251);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "Результат";
            label2.Click += label2_Click;
            // 
            // Logo
            // 
            Logo.Image = (System.Drawing.Image)resources.GetObject("Logo.Image");
            Logo.Location = new System.Drawing.Point(245, 12);
            Logo.Name = "Logo";
            Logo.Size = new System.Drawing.Size(423, 187);
            Logo.TabIndex = 12;
            Logo.TabStop = false;
            Logo.Click += Logo_Click;
            // 
            // ClearInput
            // 
            ClearInput.Location = new System.Drawing.Point(658, 379);
            ClearInput.Name = "ClearInput";
            ClearInput.Size = new System.Drawing.Size(78, 26);
            ClearInput.TabIndex = 13;
            ClearInput.Text = "Очистить";
            ClearInput.UseVisualStyleBackColor = true;
            ClearInput.Click += ClearInput_Click;
            // 
            // ClearOutput
            // 
            ClearOutput.Location = new System.Drawing.Point(817, 256);
            ClearOutput.Name = "ClearOutput";
            ClearOutput.Size = new System.Drawing.Size(78, 26);
            ClearOutput.TabIndex = 14;
            ClearOutput.Text = "Очистить";
            ClearOutput.UseVisualStyleBackColor = true;
            ClearOutput.Click += ClearOutput_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new System.Drawing.Point(192, 497);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new System.Drawing.Size(544, 10);
            progressBar2.TabIndex = 16;
            progressBar2.Click += progressBar2_Click;
            // 
            // EncryptMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(progressBar2);
            Controls.Add(ClearOutput);
            Controls.Add(ClearInput);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(EncryptingButton);
            Controls.Add(MessageInput);
            Controls.Add(SetKey);
            Controls.Add(LangEn);
            Controls.Add(LangRu);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(Logo);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EncryptMenu";
            Text = "EncryptMenu";
            Load += EncryptMenu_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RadioButton LangRu;
        private System.Windows.Forms.RadioButton LangEn;
        private System.Windows.Forms.Button SetKey;
        private System.Windows.Forms.TextBox MessageInput;
        private System.Windows.Forms.Button EncryptingButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button ClearInput;
        private System.Windows.Forms.Button ClearOutput;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}
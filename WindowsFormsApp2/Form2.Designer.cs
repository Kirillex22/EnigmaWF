namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            EncryptMenu = new System.Windows.Forms.Button();
            Exit = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // EncryptMenu
            // 
            EncryptMenu.Location = new System.Drawing.Point(243, 308);
            EncryptMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EncryptMenu.Name = "EncryptMenu";
            EncryptMenu.Size = new System.Drawing.Size(431, 37);
            EncryptMenu.TabIndex = 0;
            EncryptMenu.Text = "Шифрование";
            EncryptMenu.UseVisualStyleBackColor = true;
            EncryptMenu.Click += EncryptMenu_Click;
            // 
            // Exit
            // 
            Exit.Location = new System.Drawing.Point(243, 351);
            Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Exit.Name = "Exit";
            Exit.Size = new System.Drawing.Size(431, 37);
            Exit.TabIndex = 2;
            Exit.Text = "Выход";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(243, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(431, 193);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(pictureBox1);
            Controls.Add(Exit);
            Controls.Add(EncryptMenu);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button EncryptMenu;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
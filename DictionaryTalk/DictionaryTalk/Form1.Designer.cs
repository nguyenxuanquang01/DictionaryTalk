namespace DictionaryTalk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnSpeakEnglish = new Button();
            cbGetWord = new ComboBox();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            txbExplainDetail = new TextBox();
            txbMeaning = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSpeakEnglish);
            panel1.Controls.Add(cbGetWord);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 426);
            panel1.TabIndex = 0;
            // 
            // btnSpeakEnglish
            // 
            btnSpeakEnglish.BackgroundImage = (Image)resources.GetObject("btnSpeakEnglish.BackgroundImage");
            btnSpeakEnglish.BackgroundImageLayout = ImageLayout.Stretch;
            btnSpeakEnglish.Location = new Point(3, 7);
            btnSpeakEnglish.Name = "btnSpeakEnglish";
            btnSpeakEnglish.Size = new Size(33, 29);
            btnSpeakEnglish.TabIndex = 1;
            btnSpeakEnglish.UseVisualStyleBackColor = true;
            // 
            // cbGetWord
            // 
            cbGetWord.DropDownStyle = ComboBoxStyle.Simple;
            cbGetWord.FormattingEnabled = true;
            cbGetWord.Location = new Point(51, 7);
            cbGetWord.Name = "cbGetWord";
            cbGetWord.Size = new Size(151, 388);
            cbGetWord.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txbExplainDetail);
            panel2.Controls.Add(txbMeaning);
            panel2.Location = new Point(249, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 426);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(-1, 55);
            button2.Name = "button2";
            button2.Size = new Size(33, 29);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(0, 8);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // txbExplainDetail
            // 
            txbExplainDetail.Location = new Point(38, 55);
            txbExplainDetail.Multiline = true;
            txbExplainDetail.Name = "txbExplainDetail";
            txbExplainDetail.Size = new Size(471, 332);
            txbExplainDetail.TabIndex = 1;
            // 
            // txbMeaning
            // 
            txbMeaning.Location = new Point(38, 8);
            txbMeaning.Name = "txbMeaning";
            txbMeaning.Size = new Size(471, 27);
            txbMeaning.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Anh - Việt | Dictionary";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbGetWord;
        private Panel panel2;
        private TextBox txbExplainDetail;
        private TextBox txbMeaning;
        private Button btnSpeakEnglish;
        private Button button2;
        private Button button1;
    }
}

namespace DictionaryTalk
{
    public partial class Form1 : Form
    {
        DictionaryManager dictionary;
        SpeakText sptextVN;
        SpeakText sptextEL;
        bool isLoading1 = true;
        bool isLoadding2 = true;
        public Form1()
        {
            InitializeComponent();
            ChangeLoading();
            cbGetWord.DisplayMember = "Key";

            WebBrowser wbVN = new WebBrowser();
            wbVN.Width = 0;
            wbVN.Height = 0;
            wbVN.Visible = false;
            wbVN.ScriptErrorsSuppressed = true;
            wbVN.Navigate(Cons.VietNamLink);
            wbVN.DocumentCompleted += WbVN_DocumentCompleted;

            this.Controls.Add(wbVN);


            WebBrowser wbEL = new WebBrowser();
            wbEL.Width = 0;
            wbEL.Height = 0;
            wbEL.Visible = false;
            wbEL.ScriptErrorsSuppressed = true;
            wbEL.DocumentCompleted += WbEL_DocumentCompleted;
            wbEL.Navigate(Cons.EnglishLink);

            this.Controls.Add(wbEL);
            sptextVN = new SpeakText(wbVN);
            sptextEL = new SpeakText(wbEL);
            dictionary = new DictionaryManager();
            dictionary.LoadDataToComboBox(cbGetWord);
        }

        private void WbEL_DocumentCompleted(object? sender, WebBrowserDocumentCompletedEventArgs e)
        {
            isLoading1 = false;
            ChangeLoading();
        }

        private void WbVN_DocumentCompleted(object? sender, WebBrowserDocumentCompletedEventArgs e)
        {
            isLoadding2 = false;
            ChangeLoading();
        }

        void ChangeLoading()
        {
            this.Enabled = !(isLoading1 && isLoadding2);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát", "Thống báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            dictionary.Serialize();
        }

        private void cbGetWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb == null)
                return;

            DictionaryData data = cb.SelectedItem as DictionaryData;
            txbMeaning.Text = data.Meaning;
            txbExplainDetail.Text = data.Explaination;
        }

        private void btnSpeakEnglish_Click(object sender, EventArgs e)
        {
            sptextEL.Speak((cbGetWord.SelectedItem as DictionaryData).Key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sptextVN.Speak(txbMeaning.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sptextVN.Speak(txbExplainDetail.Text);
        }
    }
}

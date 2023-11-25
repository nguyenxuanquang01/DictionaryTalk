namespace DictionaryTalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chăn muốn thoát","Thống báo",MessageBoxButtons.OKCancel) != DialogResult.OK) 
            { 
                e.Cancel = true;
            }
        }
    }
}

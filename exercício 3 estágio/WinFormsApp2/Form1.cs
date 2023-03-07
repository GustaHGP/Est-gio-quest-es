namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 checar = new Class1();
            label2.Text = checar.analisar();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
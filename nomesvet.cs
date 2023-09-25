namespace Ex
{
    public partial class Form1 : Form
    {

        private string[] nomes = new string[5];
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (currentIndex < 5)
            {
                nomes[currentIndex] = textBox2.Text;
                currentIndex++;
                textBox2.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("O vetor está cheio.", "Erro");
            }
            textBox2.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Array.Sort(nomes);
            listBox2.Items.Clear();
            foreach (string nome in nomes)
            {
                if (nome != null)
                {
                    listBox2.Items.Add(nome);
                }
            }
        }
    }
}


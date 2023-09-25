namespace OrdenaVetores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] num = { 10, 90, 8, 17, 6, 5, 4 };
            int maior = num[0]; 
            int menor = num[0]; 
            int posicaoMaior = 0;
            int posicaoMenor = 0;

            for (int i = 0; i < 7; i++)
            {
                listBox1.Items.Add("Elemento [" + i + "] = " + num[i]);

                if (num[i] > maior)
                {
                    maior = num[i];
                    posicaoMaior = i;
                }
                if (num[i] < menor)
                {
                    menor = num[i];
                    posicaoMenor = i;
                }
            }

            label1.Text = string.Join(",", num);
            listBox1.Items.Add("Maior elemento: " + maior + ", Posição: " + posicaoMaior);
            listBox1.Items.Add("Menor elemento: " + menor + ", Posição: " + posicaoMenor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "";
        }
    }
}

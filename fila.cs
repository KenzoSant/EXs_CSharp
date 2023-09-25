namespace Ex_Fila
{
    public partial class GerarSenha : Form
    {
        private Queue<string> filaDeSenhas = new Queue<string>();

        public GerarSenha()
        {
            InitializeComponent();
        }
        private void AtualizarSenhasNaTela()
        {
            senhagerada.Text = string.Join(",", filaDeSenhas);
        }


        private void gerarsenhanormal_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numeroDaSenha = random.Next(1, 10);
            string senha = $"N{numeroDaSenha}";

            filaDeSenhas.Enqueue(senha);
            AtualizarSenhasNaTela();

        }

        private void senhapreferencial_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numeroDaSenha = random.Next(1, 10);
            string senha = $"P{numeroDaSenha}";

            filaDeSenhas.Enqueue(senha);
            AtualizarSenhasNaTela();
        }

        private void atendersenha_Click(object sender, EventArgs e)
        {
            if (filaDeSenhas.Count > 0)
            {
                string senhaAtendida = filaDeSenhas.Dequeue();
                MessageBox.Show($"Senha Atendida: {senhaAtendida}");
                AtualizarSenhasNaTela();
            }
            else
            {
                MessageBox.Show("Não há senhas na fila.");
            }
        }
    }
}

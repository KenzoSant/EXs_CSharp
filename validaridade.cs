namespace Ex2_Vali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = Int32.Parse(textBox1.Text);
            
            if(idade < 18)
            {
                label2.Text = "Sem Permissão";
                label2.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label2.Text = "Permissão Concedida";
                label2.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}

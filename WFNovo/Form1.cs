namespace WFNovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCliqueAqui_MouseClick(object sender, MouseEventArgs e)
        {
            if (lblNome.Text.Contains("Botão Clicado"))
            {
                lblNome.Text = "Clicou Denovo";
            }
            else
            {
                lblNome.Text = "Botão Clicado";
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

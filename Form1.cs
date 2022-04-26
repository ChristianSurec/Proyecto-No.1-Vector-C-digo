namespace Proyecto_No._1_Vector_Código
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGenerar generar = new FormGenerar();
            this.Hide();
            generar.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVerificar verificar = new FormVerificar();
            this.Hide();
            verificar.ShowDialog();
            this.Show();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
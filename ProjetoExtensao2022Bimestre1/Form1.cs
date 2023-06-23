using System;
using System.Windows.Forms;
using Npgsql;

namespace ProjetoExtensao2022Bimestre1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Opção 1");
            comboBox1.Items.Add("Opção 2");
            comboBox1.Items.Add("Opção 3");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String db = "Server=localhost;Port=5432;Database=ProjetoPACEX;" +
                "User Id=postgres;Password=123;";
            NpgsqlConnection conexao = new NpgsqlConnection(db);
            String comando = "INSERT INTO Avaliacao (ra_pessoa, nota, comentario) VALUES (002223, 5, 'ótima aula');";
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(comando, conexao);
                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Um erro ocorreu...");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

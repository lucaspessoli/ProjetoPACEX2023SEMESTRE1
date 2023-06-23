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
            comboBox1.Items.Add("Professor");
            comboBox1.Items.Add("Aluno");
            comboBox1.Items.Add("Infraestrutura");
            comboBox1.Items.Add("Funcionário");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idItem;
            int ra = Int32.Parse(textBox1.Text);
            int nota = Int32.Parse(textBox2.Text);
            String comentario = (textBox3.Text);
            String db = "Server=localhost;Port=5432;Database=ProjetoPACEX;" +
                "User Id=postgres;Password=123;";
            NpgsqlConnection conexao = new NpgsqlConnection(db);
            String item = comboBox1.SelectedItem.ToString();
            if(item == "Professor")
            {
                idItem = 1;
            }else if(item == "Aluno")
            {
                idItem = 2;
            }else if(item == "Infra-Estrutura")
            {
                idItem = 3;
            }
            else
            {
                idItem = 4;
            }
            String comando = "INSERT INTO Avaliacao (ra_pessoa,infra , nota, comentario)" +
                " VALUES (" + ra +  ", (SELECT descricao FROM Itens_avaliado WHERE id_item = " + idItem + ")," + nota + ",'" + comentario + "' );";
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(comando, conexao);
                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelecionado = comboBox1.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

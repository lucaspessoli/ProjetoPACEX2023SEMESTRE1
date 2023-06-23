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
            MessageBox.Show("O Sistema de Feedback \"Cavaleiros do Zodíaco\" é um projeto desenvolvido em C# e PostgreSQL com o objetivo de facilitar o processo de coleta e gerenciamento de feedback. O sistema oferece uma plataforma intuitiva e eficiente para que os usuários possam enviar feedback sobre diversos temas, como professores, alunos, infraestrutura, funcionários e muito mais.\r\n\r\nCom o \"Cavaleiros do Zodíaco\", os usuários têm a oportunidade de expressar suas opiniões e ideias de forma fácil e rápida. O sistema fornece um formulário de feedback abrangente, onde os usuários podem escolher o assunto, atribuir uma nota e fazer comentários sobre o tema." +
                "\n\nAo escolher o nome \"Cavaleiros do Zodíaco\" para o nosso sistema de feedback, buscamos incorporar os valores e as características lendárias e inspiradoras dos famosos personagens. Transmitindo esses valores e estimulando um ambiente positivo, colaborativo e de constante crescimento, onde cada colaborador possa se tornar um verdadeiro herói no cumprimento de suas responsabilidades e no alcance de seus objetivos profissionais.\r\n");
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
            }else if(item == "Infraestrutura")
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
                MessageBox.Show("Feeback enviado com sucesso!");
            }catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro! " + ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelecionado = comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ra = Int32.Parse(textBox4.Text);
            String nome = (textBox5.Text);
            String db = "Server=localhost;Port=5432;Database=ProjetoPACEX;" +
                "User Id=postgres;Password=123;";
            NpgsqlConnection conexao = new NpgsqlConnection(db);
            String comando = "INSERT INTO Pessoa VALUES (" + ra +",' " + nome + "'" + ")";
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(comando, conexao);
                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Conta criada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro! " + ex.ToString());
            }
        }
    }
}

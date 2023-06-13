using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // bora chamar a lista para o forms (fomulário)

        private List<Veiculos> veiculosList; // List<Veiculos> é uma lista de objetos, no qual armazena os dados.

        public Form1()
        {
            InitializeComponent();
            veiculosList = Veiculos.Lista();
            comboBox1.DataSource = veiculosList;
            comboBox1.Text = "[Seleção]"; // Era para substituir o text la no comboBox

        }

        private void button1_Click(object sender, EventArgs e) // Botão Ok
        {
            button1.Text = $"A opção selecionada é:  {((Veiculos)comboBox1.SelectedItem).Nome}";
            // Nessa linha esta pegando o botão, imprimindo o texto, e a informação do local da tela de datagridview, e da a possibilidade de muiti escolha com SelectedItem
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) /// dataGridView
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // ComboBox
        {// Aqui que gera a tabela com grade e linhas. (data grid view - traduzido.. (Dados, visão em grade)

            // Data Source serve para expor as informações, onde o data grid view agrupa e imprimi as informações com ele.

            dataGridView1.AutoGenerateColumns = true; // gera as colunas
            dataGridView1.DataSource = veiculosList; // imprimi as inforções de veiculoslist.


        }



        // Instruções adicionais:1-  Se caso da erro por que esta faltando alguma coisa, clique 2 vezes nos objetos criados
        // no forms Design. 
        // 2- Se não funcionar no método combo box, clique 2 vezes no fundo da janela, sera criado um forms_Load1, la voce coloque as informações
        // para criar as tabelas e imprimi-las.




    }
}

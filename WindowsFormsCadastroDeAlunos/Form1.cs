using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCadastroDeAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Add(TxtNome.Text, TxtCurso.Text);

            TxtNome.Text = "";
            TxtCurso.Text = "";

            MessageBox.Show("Aluno Incluido com sucesso", "Inclusão",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            LblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
              if (dgvAlunos.RowCount › 0)
           {
                // Remove a linha selecionada do Grid
                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);
                // Exibe uma mensagem ao usuário de exclusão com sucesso!
                MessageBox.Show("Aluno Excluido com sucesso", "Exclusão",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Exibe na label o contador de linhas do GridView atualizado após a remoção
                LblTotal.Text = dgvAlunos.RowCount.ToString();
           }
        }

        private void dvgAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica a existência de linhas no Grid
             if (dgvAlunos. RowCount › 0)
                {
                // Move o conteúdo da primeira célula da linha selecionada para a caixa de texto
                TxtAlteracao.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
                }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtAlteracao.Text != "")
             
           // Move o novo valor da caixa de texto Alteração para a célula selecionada
            dgvAlunos.CurrentRow.Cells[0].Value = TxtAlteracao.Text;
           // Exibe a mensagem de alteração com sucesso
            MessageBox.Show("Aluno Alterado com sucesso", "Exclusão",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            // Zera as linhas do grid, removendo as existentes
            dgvAlunos.RowCount = 0;
            // Exibe na label o contador de linhas do GridView após ser zerado
            LblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            private void btnFechar_Click(object sender, EventArgs e)
            {
                // Finaliza a aplicação
                Application.Exit();
            }
        }


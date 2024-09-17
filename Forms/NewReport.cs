using Npgsql;
using PGHrmlReport.Helpers;
using PGHrmlReport.Models;
using PGHrmlReport.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PGHrmlReport
{
    public partial class NewReport : Form
    {
        public NewReport()
        {
            InitializeComponent();
            TxtQuery.Multiline = true; // Permite múltiplas linhas
            TxtQuery.ScrollBars = ScrollBars.Vertical; // Opcional: adiciona barras de rolagem
            TxtQuery.WordWrap = true; // Quebra de linha automática (opcional)
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Descartar a inclusão?",
                                "Novo relatório",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {

                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private string Title()
        {
            return TxtTitle.Text.Trim();
        }
        private string Server()
        {
            return TxtServer.Text.Trim();
        }
        private string Database()
        {
            return TxtDatabase.Text.Trim();
        }
        private string User()
        {
            return TxtUser.Text.Trim();
        }
        private string Password()
        {
            return TxtPassword.Text.Trim();
        }
        private string Query()
        {
            return TxtQuery.Text.Trim();
        }

        private int Port()
        {
            return (int)NumPort.Value;
        }


        private bool ValidateConnection()
        {
            if (Server().Length == 0)
            {
                TxtServer.Focus();
                MessageBox.Show("Por favor, informe o ip do servidor do banco");
                return false;
            }
            if (Database().Length == 0)
            {
                TxtDatabase.Focus();
                MessageBox.Show("Por favor, informe o nome do banco");
                return false;
            }
            if (Port() == 0)
            {
                NumPort.Focus();
                MessageBox.Show("Por favor, informe a porta do banco");
                return false;
            }
            if (User().Length == 0)
            {
                TxtUser.Focus();
                MessageBox.Show("Por favor, informe o usuário do banco");
                return false;
            }
            if (Password().Length == 0)
            {
                TxtPassword.Focus();
                MessageBox.Show("Por favor, informe a senha do banco");
                return false;
            }

            var pg = new PGHelper(Server(), Database(), Port(), User(), Password());

            if (!pg.Test(pg.Connection()))
            {
                MessageBox.Show("Não consegui conectar ao banco de dados");
                return false;
            }

            return true;
        }
        private bool ValidateForm()
        {
            if (Title().Length == 0)
            {
                TxtTitle.Focus();
                MessageBox.Show("Por favor, informe o título do relatório");
                return false;
            }
            return ValidateConnection();
        }

        private bool SaveXML()
        {
            Report report = new Report();
            report.Title = Title();
            report.Query = Query();
            report.Connection = new Connection
            {
                Server = Server(),
                Database = Database(),
                Port = Port(),
                User = User(),
                Password = Password()
            };

            foreach (DataGridViewRow row in ColumnsGrid.Rows)
            {
                // Verifica se a célula FieldType existe e tem um valor válido antes de acessar
                var fieldTypeCell = row.Cells["FieldType"];
                if (fieldTypeCell != null && fieldTypeCell.Value != null)
                {
                    Column column = new Column
                    {
                        Title = row.Cells["EditableTitles"].Value.ToString(),
                        Value = row.Cells["OriginalTitles"].Value.ToString(),
                        Align = row.Cells["Alignment"].Value.ToString(),
                        Total = row.Cells["Totalize"].Value.ToString().Equals("Sim")
                    };
                    report.Columns.Add(column);
                }
            }

            return XmlGenerator.GenerateXml(report, $@"C:\PGHtmlReport\xml\{Title()}.xml");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            if (!SaveXML())
            {
                MessageBox.Show("Erro salvando o arquivo XML", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Aguarde(bool aguardando)
        {
            Cursor = Cursors.WaitCursor;
            GroupDados.Visible = !aguardando;
            GroupColunas.Visible = !aguardando;
            Cursor = Cursors.Default;
            Refresh();
        }

        private void Mensagem(string mensagem)
        {
            LabelMensagem.Text = mensagem;
        }

        private void PopulateColumnsGrid()
        {
            // Adiciona a primeira coluna não editável com o nome original dos campos
            DataGridViewTextBoxColumn originalColumn = new DataGridViewTextBoxColumn();
            originalColumn.Name = "OriginalTitles";
            originalColumn.HeaderText = "Coluna";
            originalColumn.ReadOnly = true; // Torna a coluna não editável
            ColumnsGrid.Columns.Add(originalColumn);

            // Adiciona a segunda coluna editável com os títulos que podem ser modificados
            DataGridViewTextBoxColumn editableColumn = new DataGridViewTextBoxColumn();
            editableColumn.Name = "EditableTitles";
            editableColumn.HeaderText = "Título";
            editableColumn.ReadOnly = false; // Permite edição
            ColumnsGrid.Columns.Add(editableColumn);

            // Adiciona a coluna para o tipo de campo
            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.Name = "FieldType";
            typeColumn.HeaderText = "Tipo";
            typeColumn.ReadOnly = true; // Não editável
            ColumnsGrid.Columns.Add(typeColumn);

            // Cria a coluna ComboBox para Alinhamento
            DataGridViewComboBoxColumn alignmentColumn = new DataGridViewComboBoxColumn();
            alignmentColumn.Name = "Alignment";
            alignmentColumn.HeaderText = "Alinhamento";
            alignmentColumn.Items.AddRange("Esquerda", "Centralizado", "Direita");
            ColumnsGrid.Columns.Add(alignmentColumn);

            // Adiciona a coluna para o combo "Totalizar"
            DataGridViewComboBoxColumn totalizeColumn = new DataGridViewComboBoxColumn();
            totalizeColumn.Name = "Totalize";
            totalizeColumn.HeaderText = "Totalizar";
            totalizeColumn.Items.AddRange("Não", "Sim"); // Opções do ComboBox
            totalizeColumn.DefaultCellStyle.NullValue = "Não"; // Define o valor padrão como "Não"
            ColumnsGrid.Columns.Add(totalizeColumn);

            // Itera sobre as colunas do primeiro DataGridView (myDataGridView)
            foreach (DataGridViewColumn column in ResultDataGrid.Columns)
            {
                // Obtem o tipo de dado da coluna
                string fieldType = column.ValueType != null ? column.ValueType.Name : "Desconhecido";

                // Determina se o campo é numérico (int, decimal, double, etc.)
                bool isNumeric = column.ValueType == typeof(int) ||
                                 column.ValueType == typeof(decimal) ||
                                 column.ValueType == typeof(double) ||
                                 column.ValueType == typeof(float);

                // Adiciona uma linha no ColumnsGrid com o título original, título editável, tipo de campo, alinhamento padrão e totalizar
                var alinhamento = isNumeric ? "Direita" : "Esquerda";

                ColumnsGrid.Rows.Add(column.HeaderText, $"{column.HeaderText.Substring(0, 1).ToUpper()}{column.HeaderText.Substring(1)}", fieldType, alinhamento, "Não");

            }

            // Desabilita o combo de Totalizar para campos não numéricos
            foreach (DataGridViewRow row in ColumnsGrid.Rows)
            {
                // Verifica se a célula FieldType existe e tem um valor válido antes de acessar
                var fieldTypeCell = row.Cells["FieldType"];
                if (fieldTypeCell != null && fieldTypeCell.Value != null)
                {
                    string fieldType = fieldTypeCell.Value.ToString();

                    // Se o campo não for numérico, desabilita o combo de totalizar
                    if (fieldType != "Int32" && fieldType != "Decimal" && fieldType != "Double" && fieldType != "Single")
                    {
                        var totalizeCell = row.Cells["Totalize"];
                        totalizeCell.ReadOnly = true; // Desabilita o combo
                        totalizeCell.Style.BackColor = ColumnsGrid.DefaultCellStyle.BackColor; // Mescla a célula com o fundo
                        totalizeCell.Value = "Não"; // Define o valor como "Não"
                    }
                }
            }
        }


        private void RunQuery()
        {
            if (!ValidateConnection())
            {
                return;
            }
            Mensagem("Aguarde um momento, por favor...");
            Aguarde(true);
            var pg = new PGHelper(Server(), Database(), Port(), User(), Password());
            var conn = pg.Connection();
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            // Limpa o ColumnsGrid antes de adicionar novos dados
            ColumnsGrid.Rows.Clear();
            ColumnsGrid.Columns.Clear();

            using var cmd = new NpgsqlCommand(Query(), conn);
            try
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    // Vinculando o DataTable ao DataGrid
                    ResultDataGrid.DataSource = dataTable.DefaultView;
                }
                var qtLinhas = ResultDataGrid.RowCount - 1;
                Mensagem(qtLinhas > 0 ? $"{qtLinhas} linha(s) retornada(s)" : "Nenhuma linha retornada");
                PopulateColumnsGrid();
            }
            catch (Exception ex)
            {
                Mensagem(ex.Message);
            }
            finally
            {
                Aguarde(false);
                conn.Close();
            }
        }

        private void BtnTestar_Click(object sender, EventArgs e)
        {
            RunQuery();
        }

        private void TxtQuery_TextChanged(object sender, EventArgs e)
        {
            BtnTestar.Enabled = Query().Length > 0;
        }



        private void NewReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && BtnTestar.Enabled)
            {
                BtnTestar.PerformClick();
            }
        }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            TxtQuery.Clear();
            var query = SQLFileSelector.SelectAndReadSQLFile();
            TxtQuery.Text = query;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtQuery.Clear();
        }
    }
}

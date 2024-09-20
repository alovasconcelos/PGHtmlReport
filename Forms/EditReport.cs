using Npgsql;
using PGHrmlReport.Models;
using PGHrmlReport.Util;
using System.Data;

namespace PGHrmlReport
{
    public partial class EditReport : Form
    {
        private Report originalReport = new Report();
        private Report report = new Report();
        public EditReport(string filePath = null)
        {
            Load += this.EditReport_Load;

            InitializeComponent();
            TxtQuery.Multiline = true; // Permite múltiplas linhas
            TxtQuery.ScrollBars = ScrollBars.Vertical; // Opcional: adiciona barras de rolagem
            TxtQuery.WordWrap = true; // Quebra de linha automática (opcional)
            if (filePath != null) {
                // Carrega o relatório
                report = XmlReaderHelper.ReadXml(filePath);
                originalReport = report;
                LoadReportDefinition();
                TxtQuery.ReadOnly = true;
                RunQuery();
            }
        }

        private void EditReport_Load(object? sender, EventArgs e)
        {
        }

        private void LoadReportDefinition()
        {
            TxtTitle.Text = report.Title;
            TxtDatabase.Text = report.Connection.Database;
            TxtServer.Text = report.Connection.Server;
            NumPort.Value = report.Connection.Port;
            TxtUser.Text = report.Connection.User;
            TxtPassword.Text = CriptoHelper.Decripto(report.Connection.Password, "P");
            SetQuery(report.Query);
            ColumnsGrid.DataSource = report.Columns;
            SetCustomColumnHeaders();
        }

        private void SetCustomColumnHeaders()
        {
            // Verifica se o DataSource foi carregado
            if (ColumnsGrid.DataSource != null)
            {
                // Ajusta o título da coluna "OriginalTitles" para "Título Original"
                ColumnsGrid.Columns["Value"].HeaderText = "Coluna";

                // Ajusta o título da coluna "EditableTitles" para "Título Editável"
                ColumnsGrid.Columns["Title"].HeaderText = "Título";

                // Ajusta o título da coluna "FieldType" para "Tipo"
                ColumnsGrid.Columns["Type"].HeaderText = "Tipo";

                // Ajusta o título da coluna "Alignment" para "Alinhamento"
                ColumnsGrid.Columns["Align"].HeaderText = "Alinhamento";

                // Ajusta o título da coluna "Totalize" para "Totalizar"
                ColumnsGrid.Columns["Total"].HeaderText = "Totalizar";
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (!report.Equals(originalReport))
            {
                var res = MessageBox.Show($"Descartar as alterações?",
                                    "Relatório",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2);
                if (res != DialogResult.Yes)
                {
                    return;
                }
            }
            Close();
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

        private void BuildReportObject()
        {
            report.Title = Title();
            report.Query = Query();
            report.Connection = new Connection
            {
                Server = Server(),
                Database = Database(),
                Port = Port(),
                User = User(),
                Password = CriptoHelper.Cripto(Password(), "P")
            };

            foreach (DataGridViewRow row in ColumnsGrid.Rows)
            {
                // Verifica se a célula FieldType existe e tem um valor válido antes de acessar
                var fieldTypeCell = row.Cells["Type"];
                if (fieldTypeCell != null && fieldTypeCell.Value != null)
                {
                    Column column = new Column
                    {
                        Title = row.Cells["Title"].Value.ToString(),
                        Value = row.Cells["Value"].Value.ToString(),
                        Type = row.Cells["Type"].Value.ToString(),
                        Align = row.Cells["Align"].Value.ToString(),
                        Total = row.Cells["Total"].Value.Equals(true),
                    };
                    report.Columns.Add(column);
                }
            }
        }

        private bool SaveXML()
        {
            return XmlGenerator.GenerateXml(report, $@"C:\PGHtmlReport\xml\{Title()}.xml");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            BuildReportObject();
            if (!SaveXML())
            {
                MessageBox.Show("Erro salvando o arquivo XML", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Aguarde(bool aguardando)
        {
            Cursor = Cursors.WaitCursor;
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
            originalColumn.Name = "Value";
            originalColumn.HeaderText = "Coluna";
            originalColumn.ReadOnly = true; // Torna a coluna não editável
            ColumnsGrid.Columns.Add(originalColumn);

            // Adiciona a segunda coluna editável com os títulos que podem ser modificados
            DataGridViewTextBoxColumn editableColumn = new DataGridViewTextBoxColumn();
            editableColumn.Name = "Title";
            editableColumn.HeaderText = "Título";
            editableColumn.ReadOnly = false; // Permite edição
            ColumnsGrid.Columns.Add(editableColumn);

            // Adiciona a coluna para o tipo de campo
            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "Tipo";
            typeColumn.ReadOnly = true; // Não editável
            ColumnsGrid.Columns.Add(typeColumn);

            // Cria a coluna ComboBox para Alinhamento
            DataGridViewComboBoxColumn alignmentColumn = new DataGridViewComboBoxColumn();
            alignmentColumn.Name = "Align";
            alignmentColumn.HeaderText = "Alinhamento";
            alignmentColumn.Items.AddRange("Esquerda", "Centralizado", "Direita");
            ColumnsGrid.Columns.Add(alignmentColumn);

            // Adiciona a coluna para o checkbox "Totalizar"
            DataGridViewCheckBoxColumn totalizeColumn = new DataGridViewCheckBoxColumn();
            totalizeColumn.Name = "Total";
            totalizeColumn.HeaderText = "Totalizar";
            ColumnsGrid.Columns.Add(totalizeColumn);

            foreach (DataColumn column in report.Data.Columns)
            {
                // Obtem o tipo de dado da coluna
                string fieldType = column.DataType != null ? column.DataType.Name : "Desconhecido";

                // Determina se o campo é numérico (int, decimal, double, etc.)
                bool isNumeric = column.DataType == typeof(int) ||
                                 column.DataType == typeof(decimal) ||
                                 column.DataType == typeof(double) ||
                                 column.DataType == typeof(float);

                // Adiciona uma linha no ColumnsGrid com o título original, título editável, tipo de campo, alinhamento padrão e totalizar (com "Não" como padrão)
//                ColumnsGrid.Rows.Add(column.ColumnName, column.ColumnName, fieldType, "Esquerda", "Não");
                var alinhamento = isNumeric ? "Direita" : "Esquerda";

                ColumnsGrid.Rows.Add(column.ColumnName,
                                    $"{column.ColumnName.Substring(0, 1).ToUpper()}{column.ColumnName.Substring(1)}",
                                    fieldType,
                                    alinhamento,
                                    false);
            }
            // Desabilita o combo de Totalizar para campos não numéricos
            foreach (DataGridViewRow row in ColumnsGrid.Rows)
            {
                // Verifica se a célula FieldType existe e tem um valor válido antes de acessar
                var fieldTypeCell = row.Cells["Type"];
                if (fieldTypeCell != null && fieldTypeCell.Value != null)
                {
                    string fieldType = fieldTypeCell.Value.ToString();

                    // Se o campo não for numérico, desabilita o combo de totalizar
                    if (fieldType != "Int32" && fieldType != "Decimal" && fieldType != "Double" && fieldType != "Single")
                    {
                        var totalizeCell = row.Cells["Total"];
                        totalizeCell.Value = false; // Remove o checkbox para campos não numéricos
                        totalizeCell.Style = new DataGridViewCellStyle { ForeColor = System.Drawing.Color.Transparent }; // Torna o texto invisível
                        totalizeCell.ReadOnly = true; // Impede a edição
                        totalizeCell.Style.BackColor = ColumnsGrid.DefaultCellStyle.BackColor; // Mescla a célula com o fundo
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
            if (!TxtQuery.ReadOnly && (report.Query == null || report.Query != Query()))
            {
                ColumnsGrid.Rows.Clear();
                ColumnsGrid.Columns.Clear();
            }

            using var cmd = new NpgsqlCommand(Query(), conn);
            try
            {
                DataTable dataTable = new DataTable();
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                var qtLinhas = dataTable.Rows.Count;
                report.Data = dataTable;
                Mensagem(qtLinhas > 0 ? $"{qtLinhas} linha(s) retornada(s)" : "Nenhuma linha retornada");
                if (!TxtQuery.ReadOnly && (report.Query == null || report.Query != Query()))
                {
                    PopulateColumnsGrid();
                    report.Query = Query();
                }
                PreviewAsync();

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

        private async Task PreviewAsync()
        {
            if (report.Query != null)
            {
                var htmlReport = new HtmlReport(report);
                var html = htmlReport.Render();
                try
                {
                    // Inicializa o WebView2 explicitamente
                    await WebView.EnsureCoreWebView2Async();

                    // Agora podemos navegar para o conteúdo HTML
                    WebView.CoreWebView2.NavigateToString(html);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao inicializar o WebView: {ex.Message}");
                }
            }
        }

        private void BtnTestar_Click(object sender, EventArgs e)
        {
            RunQuery();
        }

        private void TxtQuery_TextChanged(object sender, EventArgs e)
        {
            BtnTestar.Enabled = Query().Length > 0;
            BtnSalvar.Enabled = BtnTestar.Enabled;
        }



        private void NewReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && BtnTestar.Enabled)
            {
                BtnTestar.PerformClick();
            }
        }

        private void SetQuery(string sql)
        {
            TxtQuery.Text = sql.Replace("\n", Environment.NewLine);
        }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            TxtQuery.Clear();
            var query = SQLFileSelector.SelectAndReadSQLFile();
            SetQuery(query);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtQuery.Clear();
        }
    }
}

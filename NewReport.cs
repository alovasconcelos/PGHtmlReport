using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGHrmlReport
{
    public partial class NewReport : Form
    {
        public NewReport()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Descartar a inclusão?",
                                "Novo relatório",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.OK)
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
            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            if (!SaveXML())
            {
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
                Mensagem(qtLinhas > 0 ? $"{qtLinhas} linha(s) retornada(s)": "Nenhuma linha retornada");
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
    }
}

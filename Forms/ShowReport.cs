using Npgsql;
using PGHtmlReport.Models;
using PGHtmlReport.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGHtmlReport.Forms
{
    public partial class ShowReport : Form
    {
        public string FilePath { get; set; }
        private Report report;

        public ShowReport()
        {
            InitializeComponent();
            // Carrega o relatório

        }

        private void LoadData()
        {
            Cursor = Cursors.WaitCursor;
            var pg = new PGHelper(report.Connection.Server,
                                report.Connection.Database,
                                report.Connection.Port,
                                report.Connection.User,
                                CriptoHelper.Decripto(report.Connection.Password, "P"));
            var conn = pg.Connection();
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            using var cmd = new NpgsqlCommand(report.Query, conn);
            try
            {
                DataTable dataTable = new DataTable();
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                report.Data = dataTable;
                ViewAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                Cursor = Cursors.Default;
            }
        }
        private async Task ViewAsync()
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

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowReport_Shown(object sender, EventArgs e)
        {
            report = XmlReaderHelper.ReadXml(FilePath);
            LoadData();
        }
    }
}

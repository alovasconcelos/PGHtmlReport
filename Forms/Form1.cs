using PGHtmlReport.Forms;
using PGHtmlReport.Util;

namespace PGHtmlReport
{
    public partial class Form1 : Form
    {
        private ListView Arquivos = new ListView();

        public Form1()
        {
            InitializeComponent();
            Arquivos.BackColor = BackColor;
            Arquivos.Font = Font;
            Arquivos.ForeColor = ForeColor;        
            Arquivos.BorderStyle = BorderStyle.None;
            Arquivos.ItemActivate += Arquivos_ItemActivate;
            Arquivos.Cursor = Cursors.Hand;
        }

        private void Arquivos_ItemActivate(object? sender, EventArgs e)
        {
            if (Arquivos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Arquivos.SelectedItems[0];

                string filePath = selectedItem.Tag.ToString();

                var f = new ShowReport
                {
                    FilePath = filePath
                };
                OpenForm(f);
            }
        }


        public void LoadHrFilesIntoListView(string folderPath, ListView listView)
        {
            listView.Items.Clear();
            var imageList = new ImageList();
            listView.LargeImageList = imageList;
            listView.LargeImageList.ImageSize = new Size(32, 32); 
            
            try
            {
                string[] files = Directory.GetFiles(folderPath, "*.xml");

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);

                    Icon fileIcon = Icon.ExtractAssociatedIcon(file);
                    
                    listView.LargeImageList.Images.Add(fileName, fileIcon);

                    ListViewItem item = new ListViewItem
                    {
                        Text = fileName,
                        ImageKey = fileName,
                        Tag = file
                    };

                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro carregando arquivos: {ex.Message}");
            }
        }

        private void LoadFiles()
        {
            LoadHrFilesIntoListView(@"C:\PGHtmlReport\xml", Arquivos);
        }



        private void Form1_Shown(object sender, EventArgs e)
        {            
            LoadFiles();
            MainScreen();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenForm(Form form)
        {
            Cursor = Cursors.WaitCursor;
            // Esconde o menu principal
            menuStrip1.Visible = false;

            // Limpa o PanelMain de qualquer controle existente
            PanelMain.Controls.Clear();

            // Define o formulário como não sendo uma janela principal (sem bordas)
            form.TopLevel = false;

            // Define o formulário como filho do PanelMain
            form.FormBorderStyle = FormBorderStyle.None;

            // Preenche todo o espaço do PanelMain
            form.Dock = DockStyle.Fill;

            form.FormClosed += Form_FormClosed;

            // Adiciona o formulário ao PanelMain
            PanelMain.Controls.Add(form);

            // Exibe o formulário
            Cursor = Cursors.Default;
            form.Show();
        }

        private void Form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            MainScreen();
        }

        private void MainScreen()
        {
            PanelMain.Controls.Clear();
            Arquivos.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(Arquivos);
            menuStrip1.Visible = true;
        }

        private void novoRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new EditReport();
            OpenForm(f);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Define o filtro para exibir apenas arquivos XML
            openFileDialog.Filter = "Arquivos XML (*.xml)|*.xml";

            // Define o diretório inicial para a pasta desejada
            openFileDialog.InitialDirectory = @"C:\PGHtmlReport\xml";

            // Permite a seleção de apenas um arquivo
            openFileDialog.Multiselect = false;

            // Exibe o diálogo e verifica se o usuário selecionou um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtém o caminho completo do arquivo selecionado
                string filePath = openFileDialog.FileName;
                new EditReport(filePath).ShowDialog();
                LoadFiles();
            }
        }
    }
}

using PGHrmlReport.Forms;
using PGHrmlReport.Util;

namespace PGHrmlReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Arquivos.View = View.LargeIcon;
            Arquivos.ItemActivate += Arquivos_ItemActivate;
        }

        private void Arquivos_ItemActivate(object? sender, EventArgs e)
        {
            if (Arquivos.SelectedItems.Count > 0)
            {
                // Get the clicked item
                ListViewItem selectedItem = Arquivos.SelectedItems[0];

                // Retrieve the file path from the Tag property
                string filePath = selectedItem.Tag.ToString();

                // Call your function when the user double-clicks on an icon
                new ShowReport(filePath).ShowDialog();
            }
        }


        public void LoadHrFilesIntoListView(string folderPath, ListView listView)
        {
            // Clear existing items and icons
            listView.Items.Clear();
            listView.LargeImageList = new ImageList();
            listView.LargeImageList.ImageSize = new Size(32, 32); // Set the icon size

            try
            {
                // Get all .hr files from the specified folder
                string[] files = Directory.GetFiles(folderPath, "*.xml");

                // Loop through each file and add it to the ListView
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);

                    // Create a dummy icon for illustration (you can load specific icons here)
                    Icon fileIcon = Icon.ExtractAssociatedIcon(file);


                    // Add the icon to the ImageList
                    listView.LargeImageList.Images.Add(fileName, fileIcon);

                    // Create a ListViewItem with the file name as the label
                    ListViewItem item = new ListViewItem
                    {
                        Text = fileName,
                        ImageKey = fileName,
                        Tag = file
                    };

                    // Add the item to the ListView
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
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            new EditReport().ShowDialog();
            LoadFiles();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            
            if (Arquivos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione o relatório que deseja alterar");
                return;
            }
            
            // Get the clicked item
            ListViewItem selectedItem = Arquivos.SelectedItems[0];

            // Retrieve the file path from the Tag property
            string filePath = selectedItem.Tag.ToString();

            new EditReport(filePath).ShowDialog();
            LoadFiles();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PGHtmlReport.Util
{
    public class XmlFileSelector
    {
        public static string SelectAndReadXmlFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml";
                openFileDialog.Title = "Selecione um arquivo XML";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        // Carrega o conteúdo do arquivo XML
                        XDocument xmlDoc = XDocument.Load(filePath);

                        // Verifica se o arquivo XML começa com a tag <Report>
                        if (xmlDoc.Root.Name.LocalName == "Report")
                        {
                            return File.ReadAllText(filePath); // Retorna o conteúdo do arquivo
                        }
                        else
                        {
                            MessageBox.Show("O arquivo selecionado não é válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao ler o arquivo XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return null; // Retorna null caso a operação falhe ou o arquivo não seja válido
        }
    }
}

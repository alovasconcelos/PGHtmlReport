using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PGHtmlReport.Util
{
    public class SQLFileSelector
    {
        public static string SelectAndReadSQLFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQL files (*.sql)|*.sql";
                openFileDialog.Title = "Selecione um arquivo SQL";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    return File.ReadAllText(filePath); // Retorna o conteúdo do arquivo
                }
            }
            return null; // Retorna null caso a operação falhe ou o arquivo não seja válido
        }
    }
}

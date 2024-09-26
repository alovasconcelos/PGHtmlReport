using PGHtmlReport.Models;
using System.Xml.Serialization;

namespace PGHtmlReport.Util
{
    public class XmlReaderHelper
    {
        public static Report ReadXml(string filePath)
        {
            try
            {
                // Configuração do serializador para a classe Report
                XmlSerializer serializer = new XmlSerializer(typeof(Report));

                // Leitura do arquivo XML
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Desserialização do arquivo XML para o objeto Report
                    Report report = (Report)serializer.Deserialize(reader);
                    return report;
                }
            }
            catch (Exception ex)
            {                
                return null;
            }
        }
    }
}

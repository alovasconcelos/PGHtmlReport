using PGHtmlReport.Models;
using System.Xml;
using System.Xml.Serialization;

namespace PGHtmlReport.Util
{
    public class XmlGenerator
    {
        public static bool GenerateXml(Report report, string filePath)
        {
            try
            {
                // Configuração para serializar a classe Report
                XmlSerializer serializer = new XmlSerializer(typeof(Report));

                // Configuração para gravação do XML no arquivo
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Usando XmlWriter para personalizar a saída com CDATA
                    XmlWriterSettings settings = new XmlWriterSettings
                    {
                        Indent = true,
                        OmitXmlDeclaration = false
                    };

                    using (XmlWriter xmlWriter = XmlWriter.Create(writer, settings))
                    {
                        serializer.Serialize(xmlWriter, report, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));
                    }
                }

                
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

    }
}

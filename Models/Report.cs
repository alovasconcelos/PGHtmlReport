using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PGHrmlReport.Models
{
    public class Report
    {
        public string Title { get; set; }
        public Connection Connection { get; set; }

        [XmlIgnore]
        public string Query { get; set; }

        // Campo auxiliar para o CDATA
        [XmlElement("Query")]
        public XmlCDataSection CDataQuery
        {
            get
            {
                XmlDocument doc = new XmlDocument();
                return doc.CreateCDataSection(Query);
            }
            set { Query = value.Value; }
        }
        public List<Column> Columns { get; set; } = new List<Column>();

        public Report() { }

        public void AddColumn(Column column)
        {
            Columns.Add(column);
        }
    }
}

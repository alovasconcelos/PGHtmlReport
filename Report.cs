using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGHrmlReport
{
    public class Report
    {
        public string Title { get; set; }
        public Connection Connection { get; set; }
        public string Query { get; set; }
        public List<Column> Columns { get; set; } = new List<Column>();

        public Report() { }

        public void AddColumn(Column column)
        {
            Columns.Add(column);
        }
    }
}

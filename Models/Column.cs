using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGHrmlReport.Models
{
    public class Column
    {
        public string Title { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string Align { get; set; } = string.Empty;
        public bool Total { get; set; } = false;
    }
}

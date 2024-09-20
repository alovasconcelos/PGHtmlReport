using PGHrmlReport.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGHrmlReport.Util
{
    public class HtmlReport
    {
        private Report report;
        public HtmlReport(Report report)
        {
            this.report = report;
        }

        private string Style()
        {
            var ret = @"
<style>
    table {
      font-family: Arial, Helvetica, sans-serif;
      border-collapse: collapse;
      width: 100%;
    }

    table td, #customers th {
      border: 1px solid #ddd;
      padding: 8px;
    }

    table tr:nth-child(even){background-color: #f2f2f2;}

    table tr:hover {background-color: #ddd;}

    table th {
      padding-top: 12px;
      padding-bottom: 12px;
      text-align: left;
      background-color: #AAFFFF;
      color: black;
    }
    h3 {
      color: black;
      text-align: center;
      background-color: #AAFFFF;
    }
</style>";

            return ret;
        }
        private string TableHeader()
        {
            string columns = string.Empty;
            foreach (var c in report.Columns)
            {
                columns += $"<th>{c.Title}</th>";
            }
            string ret = $"<table><thead><tr>{columns}</tr></thead>";

            return ret;
        }

        private string TableFooter()
        {
            string ret = string.Empty;
            ret += "<tfoot>";

            ret += "</tfoot></table>";
            return ret;
        }

        private string TableData()
        {
            string lines = string.Empty;
            foreach (DataRow row in report.Data.Rows)
            {
                lines += "<tr>";
                foreach(var col in report.Columns)
                {
                    lines += "<td>";
                    lines += row[col.Value];
                    lines += "</td>";
                }
                lines += "</tr>";
            }
            return lines;
        }

        private string HtmlHead()
        {
            var ret = $"<head>{Style()}</head>";

            return ret;
        }

        private string HtmlBody()
        {
            var ret = $"<body>{ReportBody()}</body>";

            return ret;
        }

        private string ReportBody()
        {
            string ret = string.Empty;
            ret += ReportHeader();
            ret += TableHeader();
            ret += TableData();
            ret += TableFooter();
            return ret;
        }

        private string ReportHeader()
        {
            string ret = $@"<p style='text-align: center;'><h3>{report.Title}</h3></p>";

            return ret;
        }

        public string Render()
        {
            string ret = $"<html>{HtmlHead()}{HtmlBody()}</html>";
            return ret;
        }
    }
}

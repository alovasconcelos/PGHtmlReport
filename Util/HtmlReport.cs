using PGHrmlReport.Models;
using System;
using System.Collections.Generic;
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
    /* Define o tamanho da página como A4 */
    @page {
        size: A4;
        margin: 10mm; /* Define a margem da página (opcional) */
    }

    /* Estilo geral para o conteúdo da página */
    body {
        width: 210mm;
        height: 297mm;
        margin: 0;
        padding: 10mm;
        box-sizing: border-box;
        font-family: Arial, sans-serif;
    }

    /* Se necessário, defina uma área de conteúdo específica */
    .content {
        width: 100%;
        height: 100%;
        overflow: hidden;
    }

    /* Forçar a visualização da página em modo retrato (opcional) */
    @media print {
        body {
            width: auto;
            height: 100%;
        }
    }
    h3 {
      color: black;
      text-align: center;
      background-color: #e4d3cf;
    }
</style>                    ";

            return ret;
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

            return ret;
        }

        // TODO - associar arquivos do tipo css para definições de estilos das seções
        private string ReportHeader(string title)
        {
            string ret = $@"<h3>{title}</h3>";

            return ret;
        }



        public string Render()
        {
            string ret = $"<html>{HtmlHead()}";
            ret += HtmlBody();
            ret += "</html>";
            return ret;
        }
    }
}

﻿namespace PGHtmlReport.Models
{
    public class Connection
    {
        public string Server { get; set; } = string.Empty;
        public string Database { get; set; } = string.Empty;
        public int Port { get; set; }
        public string User { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}

public class CssFileComboBox : UserControl
{
    private ComboBox CmbCSS;

    public CssFileComboBox()
    {
        // Inicializar ComboBox
        CmbCSS = new ComboBox();
        CmbCSS.Dock = DockStyle.Fill;
        CmbCSS.BackColor = Color.Black;
        CmbCSS.ForeColor = Color.White;
        this.Controls.Add(CmbCSS);

        // Carregar arquivos CSS no ComboBox
        CarregarArquivosCSS();
    }

    // Propriedade para o caminho completo do arquivo selecionado
    public string CaminhoCompletoArquivoSelecionado
    {
        get
        {
            if (CmbCSS.SelectedItem != null)
            {
                // Retorna o caminho completo do arquivo selecionado
                string diretorioCSS = @"C:\PGHtmlReport\css";
                string nomeArquivoSemExtensao = CmbCSS.SelectedItem.ToString();
                return Path.Combine(diretorioCSS, $"{nomeArquivoSemExtensao}.css");
            }
            return string.Empty;
        }
    }

    private void CarregarArquivosCSS()
    {
        string diretorioCSS = @"C:\PGHtmlReport\css";

        if (Directory.Exists(diretorioCSS))
        {
            // Obter arquivos .css e remover as extensões
            var arquivosCSS = Directory.GetFiles(diretorioCSS, "*.css")
                                       .Select(Path.GetFileNameWithoutExtension)
                                       .ToArray();

            // Adicionar os nomes ao ComboBox
            if (arquivosCSS.Length > 0)
            {
                CmbCSS.Items.AddRange(arquivosCSS);

                // Selecionar o primeiro arquivo automaticamente
                CmbCSS.SelectedIndex = 0;
            }
        }
    }

    // Evento para mudança de seleção
    public event EventHandler SelectionChanged
    {
        add { CmbCSS.SelectedIndexChanged += value; }
        remove { CmbCSS.SelectedIndexChanged -= value; }
    }
}

namespace PGHtmlReport
{
    partial class EditReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReport));
            label1 = new Label();
            TxtTitle = new TextBox();
            NumPort = new NumericUpDown();
            label6 = new Label();
            TxtPassword = new TextBox();
            label5 = new Label();
            TxtUser = new TextBox();
            label4 = new Label();
            TxtDatabase = new TextBox();
            label3 = new Label();
            TxtServer = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            TxtQuery = new TextBox();
            PanelBottom = new Panel();
            LabelMensagem = new Label();
            PanelTop = new Panel();
            PanelPreview = new Panel();
            groupBox3 = new GroupBox();
            WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            PanelCSS = new Panel();
            PanelResult = new Panel();
            GroupColunas = new GroupBox();
            ColumnsGrid = new DataGridView();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            BtnSalvar = new ToolStripMenuItem();
            BtnSalvarComo = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            BtnFechar = new ToolStripMenuItem();
            queryToolStripMenuItem = new ToolStripMenuItem();
            BtnTestar = new ToolStripMenuItem();
            BtnCarregar = new ToolStripMenuItem();
            BtnLimpar = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)NumPort).BeginInit();
            groupBox2.SuspendLayout();
            PanelBottom.SuspendLayout();
            PanelTop.SuspendLayout();
            PanelPreview.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WebView).BeginInit();
            PanelResult.SuspendLayout();
            GroupColunas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ColumnsGrid).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 14);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 0;
            label1.Text = "Título";
            // 
            // TxtTitle
            // 
            TxtTitle.BackColor = Color.Black;
            TxtTitle.Font = new Font("Segoe UI", 12F);
            TxtTitle.ForeColor = Color.White;
            TxtTitle.Location = new Point(9, 45);
            TxtTitle.MaxLength = 80;
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(307, 34);
            TxtTitle.TabIndex = 0;
            // 
            // NumPort
            // 
            NumPort.BackColor = Color.Black;
            NumPort.Font = new Font("Segoe UI", 12F);
            NumPort.ForeColor = Color.White;
            NumPort.Location = new Point(610, 45);
            NumPort.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            NumPort.Name = "NumPort";
            NumPort.Size = new Size(84, 34);
            NumPort.TabIndex = 2;
            NumPort.Value = new decimal(new int[] { 5434, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(610, 14);
            label6.Name = "label6";
            label6.Size = new Size(58, 28);
            label6.TabIndex = 8;
            label6.Text = "Porta";
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.Black;
            TxtPassword.Font = new Font("Segoe UI", 12F);
            TxtPassword.ForeColor = Color.White;
            TxtPassword.Location = new Point(848, 45);
            TxtPassword.MaxLength = 80;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(165, 34);
            TxtPassword.TabIndex = 4;
            TxtPassword.Text = "acesse2006";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(846, 14);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 7;
            label5.Text = "Senha";
            // 
            // TxtUser
            // 
            TxtUser.BackColor = Color.Black;
            TxtUser.Font = new Font("Segoe UI", 12F);
            TxtUser.ForeColor = Color.White;
            TxtUser.Location = new Point(701, 45);
            TxtUser.MaxLength = 80;
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(141, 34);
            TxtUser.TabIndex = 3;
            TxtUser.Text = "acesse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(700, 14);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 5;
            label4.Text = "Usuário";
            // 
            // TxtDatabase
            // 
            TxtDatabase.BackColor = Color.Black;
            TxtDatabase.Font = new Font("Segoe UI", 12F);
            TxtDatabase.ForeColor = Color.White;
            TxtDatabase.Location = new Point(464, 45);
            TxtDatabase.MaxLength = 80;
            TxtDatabase.Name = "TxtDatabase";
            TxtDatabase.Size = new Size(140, 34);
            TxtDatabase.TabIndex = 1;
            TxtDatabase.Text = "banco002";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(464, 14);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 3;
            label3.Text = "Banco";
            // 
            // TxtServer
            // 
            TxtServer.BackColor = Color.Black;
            TxtServer.Font = new Font("Segoe UI", 12F);
            TxtServer.ForeColor = Color.White;
            TxtServer.Location = new Point(322, 45);
            TxtServer.MaxLength = 80;
            TxtServer.Name = "TxtServer";
            TxtServer.Size = new Size(139, 34);
            TxtServer.TabIndex = 0;
            TxtServer.Text = "localhost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(322, 14);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 1;
            label2.Text = "Servidor";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(TxtQuery);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(9, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1110, 211);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "SQL";
            // 
            // TxtQuery
            // 
            TxtQuery.AcceptsReturn = true;
            TxtQuery.AcceptsTab = true;
            TxtQuery.BackColor = Color.Black;
            TxtQuery.BorderStyle = BorderStyle.None;
            TxtQuery.Cursor = Cursors.IBeam;
            TxtQuery.Dock = DockStyle.Fill;
            TxtQuery.Font = new Font("Courier New", 9F);
            TxtQuery.ForeColor = Color.White;
            TxtQuery.Location = new Point(3, 30);
            TxtQuery.MaxLength = 2147483646;
            TxtQuery.Multiline = true;
            TxtQuery.Name = "TxtQuery";
            TxtQuery.ScrollBars = ScrollBars.Both;
            TxtQuery.Size = new Size(1104, 178);
            TxtQuery.TabIndex = 0;
            TxtQuery.TextChanged += TxtQuery_TextChanged;
            // 
            // PanelBottom
            // 
            PanelBottom.Controls.Add(LabelMensagem);
            PanelBottom.Dock = DockStyle.Bottom;
            PanelBottom.Location = new Point(0, 718);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(1126, 68);
            PanelBottom.TabIndex = 6;
            // 
            // LabelMensagem
            // 
            LabelMensagem.Dock = DockStyle.Fill;
            LabelMensagem.Font = new Font("Segoe UI", 12F);
            LabelMensagem.ForeColor = Color.Yellow;
            LabelMensagem.Location = new Point(0, 0);
            LabelMensagem.Name = "LabelMensagem";
            LabelMensagem.Size = new Size(1126, 68);
            LabelMensagem.TabIndex = 3;
            LabelMensagem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(TxtPassword);
            PanelTop.Controls.Add(label5);
            PanelTop.Controls.Add(NumPort);
            PanelTop.Controls.Add(TxtUser);
            PanelTop.Controls.Add(label6);
            PanelTop.Controls.Add(label4);
            PanelTop.Controls.Add(TxtTitle);
            PanelTop.Controls.Add(label1);
            PanelTop.Controls.Add(TxtDatabase);
            PanelTop.Controls.Add(label3);
            PanelTop.Controls.Add(groupBox2);
            PanelTop.Controls.Add(TxtServer);
            PanelTop.Controls.Add(label2);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 28);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1126, 306);
            PanelTop.TabIndex = 10;
            // 
            // PanelPreview
            // 
            PanelPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelPreview.Controls.Add(groupBox3);
            PanelPreview.Location = new Point(547, 350);
            PanelPreview.Name = "PanelPreview";
            PanelPreview.Size = new Size(575, 370);
            PanelPreview.TabIndex = 12;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(WebView);
            groupBox3.Controls.Add(PanelCSS);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(575, 370);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Preview";
            // 
            // WebView
            // 
            WebView.AllowExternalDrop = true;
            WebView.BackColor = Color.Black;
            WebView.CreationProperties = null;
            WebView.DefaultBackgroundColor = Color.White;
            WebView.Dock = DockStyle.Fill;
            WebView.ForeColor = Color.Black;
            WebView.Location = new Point(3, 73);
            WebView.Name = "WebView";
            WebView.Padding = new Padding(5);
            WebView.Size = new Size(569, 294);
            WebView.TabIndex = 0;
            WebView.ZoomFactor = 1D;
            // 
            // PanelCSS
            // 
            PanelCSS.Dock = DockStyle.Top;
            PanelCSS.Location = new Point(3, 30);
            PanelCSS.Name = "PanelCSS";
            PanelCSS.Size = new Size(569, 43);
            PanelCSS.TabIndex = 1;
            // 
            // PanelResult
            // 
            PanelResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelResult.Controls.Add(GroupColunas);
            PanelResult.Location = new Point(12, 350);
            PanelResult.Name = "PanelResult";
            PanelResult.Size = new Size(529, 370);
            PanelResult.TabIndex = 11;
            // 
            // GroupColunas
            // 
            GroupColunas.Controls.Add(ColumnsGrid);
            GroupColunas.Dock = DockStyle.Fill;
            GroupColunas.Font = new Font("Segoe UI", 12F);
            GroupColunas.ForeColor = Color.White;
            GroupColunas.Location = new Point(0, 0);
            GroupColunas.Name = "GroupColunas";
            GroupColunas.Size = new Size(529, 370);
            GroupColunas.TabIndex = 7;
            GroupColunas.TabStop = false;
            GroupColunas.Text = "Colunas";
            // 
            // ColumnsGrid
            // 
            ColumnsGrid.BackgroundColor = Color.Black;
            ColumnsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ColumnsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnsGrid.Dock = DockStyle.Fill;
            ColumnsGrid.GridColor = Color.Black;
            ColumnsGrid.Location = new Point(3, 30);
            ColumnsGrid.Name = "ColumnsGrid";
            ColumnsGrid.RowHeadersWidth = 51;
            ColumnsGrid.Size = new Size(523, 337);
            ColumnsGrid.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, queryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1126, 28);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BtnSalvar, BtnSalvarComo, toolStripMenuItem1, BtnFechar });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Image = (Image)resources.GetObject("BtnSalvar.Image");
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.ShortcutKeys = Keys.Control | Keys.S;
            BtnSalvar.Size = new Size(264, 26);
            BtnSalvar.Text = "Salvar";
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnSalvarComo
            // 
            BtnSalvarComo.Image = (Image)resources.GetObject("BtnSalvarComo.Image");
            BtnSalvarComo.Name = "BtnSalvarComo";
            BtnSalvarComo.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            BtnSalvarComo.Size = new Size(264, 26);
            BtnSalvarComo.Text = "Salvar como";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(261, 6);
            // 
            // BtnFechar
            // 
            BtnFechar.Image = (Image)resources.GetObject("BtnFechar.Image");
            BtnFechar.Name = "BtnFechar";
            BtnFechar.ShortcutKeys = Keys.Alt | Keys.F4;
            BtnFechar.Size = new Size(264, 26);
            BtnFechar.Text = "Fechar";
            BtnFechar.Click += BtnFechar_Click;
            // 
            // queryToolStripMenuItem
            // 
            queryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BtnTestar, BtnCarregar, BtnLimpar });
            queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            queryToolStripMenuItem.Size = new Size(62, 24);
            queryToolStripMenuItem.Text = "Query";
            // 
            // BtnTestar
            // 
            BtnTestar.Enabled = false;
            BtnTestar.Image = (Image)resources.GetObject("BtnTestar.Image");
            BtnTestar.Name = "BtnTestar";
            BtnTestar.ShortcutKeys = Keys.F5;
            BtnTestar.Size = new Size(224, 26);
            BtnTestar.Text = "Executar";
            BtnTestar.Click += BtnTestar_Click;
            // 
            // BtnCarregar
            // 
            BtnCarregar.Image = (Image)resources.GetObject("BtnCarregar.Image");
            BtnCarregar.Name = "BtnCarregar";
            BtnCarregar.ShortcutKeys = Keys.Control | Keys.O;
            BtnCarregar.Size = new Size(224, 26);
            BtnCarregar.Text = "Carregar";
            BtnCarregar.Click += BtnCarregar_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Image = (Image)resources.GetObject("BtnLimpar.Image");
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.ShortcutKeys = Keys.Control | Keys.L;
            BtnLimpar.Size = new Size(224, 26);
            BtnLimpar.Text = "Limpar";
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // EditReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1126, 786);
            Controls.Add(PanelPreview);
            Controls.Add(PanelResult);
            Controls.Add(PanelTop);
            Controls.Add(PanelBottom);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "EditReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edição de relatório";
            WindowState = FormWindowState.Maximized;
            KeyDown += NewReport_KeyDown;
            ((System.ComponentModel.ISupportInitialize)NumPort).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            PanelBottom.ResumeLayout(false);
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            PanelPreview.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WebView).EndInit();
            PanelResult.ResumeLayout(false);
            GroupColunas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ColumnsGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtTitle;
        private Label label2;
        private TextBox TxtServer;
        private TextBox TxtPassword;
        private Label label5;
        private TextBox TxtUser;
        private Label label4;
        private TextBox TxtDatabase;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox TxtQuery;
        private Panel PanelBottom;
        private Label label6;
        private NumericUpDown NumPort;
        private Label LabelMensagem;
        private Panel PanelTop;
        private Panel PanelPreview;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
        private GroupBox groupBox3;
        private Panel PanelResult;
        private GroupBox GroupColunas;
        private DataGridView ColumnsGrid;
        private Panel PanelCSS;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem BtnSalvar;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem BtnFechar;
        private ToolStripMenuItem queryToolStripMenuItem;
        private ToolStripMenuItem BtnTestar;
        private ToolStripMenuItem BtnCarregar;
        private ToolStripMenuItem BtnLimpar;
        private ToolStripMenuItem BtnSalvarComo;
    }
}
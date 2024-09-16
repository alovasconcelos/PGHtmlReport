namespace PGHrmlReport
{
    partial class NewReport
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewReport));
            label1 = new Label();
            TxtTitle = new TextBox();
            groupBox1 = new GroupBox();
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
            GroupDados = new GroupBox();
            ResultDataGrid = new DataGridView();
            GroupColunas = new GroupBox();
            ColumnsGrid = new DataGridView();
            PanelBottom = new Panel();
            LabelMensagem = new Label();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            BtnTestar = new Button();
            BtnLimpar = new Button();
            BtnCarregar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumPort).BeginInit();
            groupBox2.SuspendLayout();
            GroupDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ResultDataGrid).BeginInit();
            GroupColunas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ColumnsGrid).BeginInit();
            PanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 33);
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
            TxtTitle.Location = new Point(12, 64);
            TxtTitle.MaxLength = 80;
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(371, 34);
            TxtTitle.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NumPort);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TxtPassword);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtUser);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtDatabase);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtServer);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 202);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conexão com o banco";
            // 
            // NumPort
            // 
            NumPort.BackColor = Color.Black;
            NumPort.ForeColor = Color.White;
            NumPort.Location = new Point(325, 65);
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
            label6.Location = new Point(325, 34);
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
            TxtPassword.Location = new Point(179, 148);
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
            label5.Location = new Point(179, 117);
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
            TxtUser.Location = new Point(8, 148);
            TxtUser.MaxLength = 80;
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(165, 34);
            TxtUser.TabIndex = 3;
            TxtUser.Text = "acesse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(8, 117);
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
            TxtDatabase.Location = new Point(179, 65);
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
            label3.Location = new Point(179, 30);
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
            TxtServer.Location = new Point(8, 65);
            TxtServer.MaxLength = 80;
            TxtServer.Name = "TxtServer";
            TxtServer.Size = new Size(165, 34);
            TxtServer.TabIndex = 0;
            TxtServer.Text = "localhost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 34);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 1;
            label2.Text = "Servidor";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtQuery);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(435, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(663, 284);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "SQL";
            // 
            // TxtQuery
            // 
            TxtQuery.BackColor = Color.Black;
            TxtQuery.BorderStyle = BorderStyle.None;
            TxtQuery.Dock = DockStyle.Fill;
            TxtQuery.Font = new Font("Segoe UI", 12F);
            TxtQuery.ForeColor = Color.White;
            TxtQuery.Location = new Point(3, 30);
            TxtQuery.MaxLength = 80;
            TxtQuery.Multiline = true;
            TxtQuery.Name = "TxtQuery";
            TxtQuery.Size = new Size(657, 251);
            TxtQuery.TabIndex = 0;
            TxtQuery.TextChanged += TxtQuery_TextChanged;
            // 
            // GroupDados
            // 
            GroupDados.Controls.Add(ResultDataGrid);
            GroupDados.Font = new Font("Segoe UI", 12F);
            GroupDados.ForeColor = Color.White;
            GroupDados.Location = new Point(12, 323);
            GroupDados.Name = "GroupDados";
            GroupDados.Size = new Size(1172, 224);
            GroupDados.TabIndex = 4;
            GroupDados.TabStop = false;
            GroupDados.Text = "Dados";
            // 
            // ResultDataGrid
            // 
            ResultDataGrid.BackgroundColor = Color.Black;
            ResultDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ResultDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            ResultDataGrid.Dock = DockStyle.Fill;
            ResultDataGrid.GridColor = Color.Black;
            ResultDataGrid.Location = new Point(3, 30);
            ResultDataGrid.Name = "ResultDataGrid";
            ResultDataGrid.RowHeadersWidth = 51;
            ResultDataGrid.Size = new Size(1166, 191);
            ResultDataGrid.TabIndex = 0;
            // 
            // GroupColunas
            // 
            GroupColunas.Controls.Add(ColumnsGrid);
            GroupColunas.Font = new Font("Segoe UI", 12F);
            GroupColunas.ForeColor = Color.White;
            GroupColunas.Location = new Point(12, 553);
            GroupColunas.Name = "GroupColunas";
            GroupColunas.Size = new Size(1169, 222);
            GroupColunas.TabIndex = 5;
            GroupColunas.TabStop = false;
            GroupColunas.Text = "Colunas";
            // 
            // ColumnsGrid
            // 
            ColumnsGrid.BackgroundColor = Color.Black;
            ColumnsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ColumnsGrid.Dock = DockStyle.Fill;
            ColumnsGrid.GridColor = Color.Black;
            ColumnsGrid.Location = new Point(3, 30);
            ColumnsGrid.Name = "ColumnsGrid";
            ColumnsGrid.RowHeadersWidth = 51;
            ColumnsGrid.Size = new Size(1163, 189);
            ColumnsGrid.TabIndex = 1;
            // 
            // PanelBottom
            // 
            PanelBottom.Controls.Add(LabelMensagem);
            PanelBottom.Controls.Add(BtnSalvar);
            PanelBottom.Controls.Add(BtnFechar);
            PanelBottom.Dock = DockStyle.Bottom;
            PanelBottom.Location = new Point(0, 781);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(1189, 105);
            PanelBottom.TabIndex = 6;
            // 
            // LabelMensagem
            // 
            LabelMensagem.Dock = DockStyle.Left;
            LabelMensagem.Font = new Font("Segoe UI", 12F);
            LabelMensagem.ForeColor = Color.Yellow;
            LabelMensagem.Location = new Point(0, 0);
            LabelMensagem.Name = "LabelMensagem";
            LabelMensagem.Size = new Size(906, 105);
            LabelMensagem.TabIndex = 3;
            LabelMensagem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.Transparent;
            BtnSalvar.Cursor = Cursors.Hand;
            BtnSalvar.Dock = DockStyle.Right;
            BtnSalvar.FlatStyle = FlatStyle.Popup;
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Image = (Image)resources.GetObject("BtnSalvar.Image");
            BtnSalvar.Location = new Point(915, 0);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Padding = new Padding(10);
            BtnSalvar.Size = new Size(137, 105);
            BtnSalvar.TabIndex = 0;
            BtnSalvar.Text = "    Salvar";
            BtnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.Transparent;
            BtnFechar.Cursor = Cursors.Hand;
            BtnFechar.Dock = DockStyle.Right;
            BtnFechar.FlatStyle = FlatStyle.Popup;
            BtnFechar.ForeColor = Color.White;
            BtnFechar.Image = (Image)resources.GetObject("BtnFechar.Image");
            BtnFechar.Location = new Point(1052, 0);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Padding = new Padding(10);
            BtnFechar.Size = new Size(137, 105);
            BtnFechar.TabIndex = 2;
            BtnFechar.Text = "    Fechar";
            BtnFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnTestar
            // 
            BtnTestar.BackColor = Color.Transparent;
            BtnTestar.Cursor = Cursors.Hand;
            BtnTestar.Enabled = false;
            BtnTestar.FlatStyle = FlatStyle.Popup;
            BtnTestar.ForeColor = Color.White;
            BtnTestar.Image = (Image)resources.GetObject("BtnTestar.Image");
            BtnTestar.ImageAlign = ContentAlignment.TopCenter;
            BtnTestar.Location = new Point(1104, 48);
            BtnTestar.Name = "BtnTestar";
            BtnTestar.Size = new Size(82, 72);
            BtnTestar.TabIndex = 1;
            BtnTestar.Text = "Testar";
            BtnTestar.TextAlign = ContentAlignment.BottomCenter;
            BtnTestar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnTestar.UseVisualStyleBackColor = false;
            BtnTestar.Click += BtnTestar_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.BackColor = Color.Transparent;
            BtnLimpar.Cursor = Cursors.Hand;
            BtnLimpar.FlatStyle = FlatStyle.Popup;
            BtnLimpar.ForeColor = Color.White;
            BtnLimpar.Image = (Image)resources.GetObject("BtnLimpar.Image");
            BtnLimpar.ImageAlign = ContentAlignment.TopCenter;
            BtnLimpar.Location = new Point(1104, 204);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(82, 72);
            BtnLimpar.TabIndex = 8;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.TextAlign = ContentAlignment.BottomCenter;
            BtnLimpar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnLimpar.UseVisualStyleBackColor = false;
            // 
            // BtnCarregar
            // 
            BtnCarregar.BackColor = Color.Transparent;
            BtnCarregar.Cursor = Cursors.Hand;
            BtnCarregar.FlatStyle = FlatStyle.Popup;
            BtnCarregar.ForeColor = Color.White;
            BtnCarregar.Image = (Image)resources.GetObject("BtnCarregar.Image");
            BtnCarregar.ImageAlign = ContentAlignment.TopCenter;
            BtnCarregar.Location = new Point(1104, 126);
            BtnCarregar.Name = "BtnCarregar";
            BtnCarregar.Size = new Size(82, 72);
            BtnCarregar.TabIndex = 9;
            BtnCarregar.Text = "Carregar";
            BtnCarregar.TextAlign = ContentAlignment.BottomCenter;
            BtnCarregar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCarregar.UseVisualStyleBackColor = false;
            // 
            // NewReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1189, 886);
            ControlBox = false;
            Controls.Add(BtnCarregar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnTestar);
            Controls.Add(PanelBottom);
            Controls.Add(GroupColunas);
            Controls.Add(GroupDados);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(TxtTitle);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "NewReport";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumPort).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            GroupDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ResultDataGrid).EndInit();
            GroupColunas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ColumnsGrid).EndInit();
            PanelBottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtTitle;
        private GroupBox groupBox1;
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
        private GroupBox GroupDados;
        private DataGridView ResultDataGrid;
        private GroupBox GroupColunas;
        private DataGridView ColumnsGrid;
        private Panel PanelBottom;
        private Button BtnSalvar;
        private Button BtnFechar;
        private Button BtnTestar;
        private Button BtnLimpar;
        private Button BtnCarregar;
        private Label label6;
        private NumericUpDown NumPort;
        private Label LabelMensagem;
    }
}
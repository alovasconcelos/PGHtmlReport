namespace PGHrmlReport
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Arquivos = new ListView();
            BtnNovo = new Button();
            BtnAlterar = new Button();
            BtnGerar = new Button();
            BtnSair = new Button();
            PanelMenu = new Panel();
            PanelMain = new Panel();
            PanelMenu.SuspendLayout();
            PanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // Arquivos
            // 
            Arquivos.BackColor = Color.Black;
            Arquivos.Cursor = Cursors.Hand;
            Arquivos.Dock = DockStyle.Fill;
            Arquivos.ForeColor = Color.White;
            Arquivos.Location = new Point(0, 0);
            Arquivos.Margin = new Padding(20);
            Arquivos.Name = "Arquivos";
            Arquivos.Size = new Size(804, 530);
            Arquivos.TabIndex = 0;
            Arquivos.UseCompatibleStateImageBehavior = false;
            // 
            // BtnNovo
            // 
            BtnNovo.BackColor = Color.Transparent;
            BtnNovo.Cursor = Cursors.Hand;
            BtnNovo.Dock = DockStyle.Top;
            BtnNovo.FlatStyle = FlatStyle.Popup;
            BtnNovo.ForeColor = Color.White;
            BtnNovo.Image = (Image)resources.GetObject("BtnNovo.Image");
            BtnNovo.Location = new Point(0, 0);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Padding = new Padding(10);
            BtnNovo.Size = new Size(137, 77);
            BtnNovo.TabIndex = 1;
            BtnNovo.Text = "    Novo";
            BtnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNovo.UseVisualStyleBackColor = false;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.BackColor = Color.Transparent;
            BtnAlterar.Cursor = Cursors.Hand;
            BtnAlterar.Dock = DockStyle.Top;
            BtnAlterar.FlatStyle = FlatStyle.Popup;
            BtnAlterar.ForeColor = Color.White;
            BtnAlterar.Image = (Image)resources.GetObject("BtnAlterar.Image");
            BtnAlterar.Location = new Point(0, 77);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Padding = new Padding(10);
            BtnAlterar.Size = new Size(137, 77);
            BtnAlterar.TabIndex = 2;
            BtnAlterar.Text = "    Alterar";
            BtnAlterar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAlterar.UseVisualStyleBackColor = false;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnGerar
            // 
            BtnGerar.BackColor = Color.Transparent;
            BtnGerar.Cursor = Cursors.Hand;
            BtnGerar.Dock = DockStyle.Top;
            BtnGerar.FlatStyle = FlatStyle.Popup;
            BtnGerar.ForeColor = Color.White;
            BtnGerar.Image = (Image)resources.GetObject("BtnGerar.Image");
            BtnGerar.Location = new Point(0, 154);
            BtnGerar.Name = "BtnGerar";
            BtnGerar.Padding = new Padding(10);
            BtnGerar.Size = new Size(137, 77);
            BtnGerar.TabIndex = 3;
            BtnGerar.Text = "    Gerar";
            BtnGerar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGerar.UseVisualStyleBackColor = false;
            // 
            // BtnSair
            // 
            BtnSair.BackColor = Color.Transparent;
            BtnSair.Cursor = Cursors.Hand;
            BtnSair.Dock = DockStyle.Bottom;
            BtnSair.FlatStyle = FlatStyle.Popup;
            BtnSair.ForeColor = Color.White;
            BtnSair.Image = (Image)resources.GetObject("BtnSair.Image");
            BtnSair.Location = new Point(0, 453);
            BtnSair.Name = "BtnSair";
            BtnSair.Padding = new Padding(10);
            BtnSair.Size = new Size(137, 77);
            BtnSair.TabIndex = 4;
            BtnSair.Text = "    Sair";
            BtnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(BtnGerar);
            PanelMenu.Controls.Add(BtnAlterar);
            PanelMenu.Controls.Add(BtnNovo);
            PanelMenu.Controls.Add(BtnSair);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(137, 530);
            PanelMenu.TabIndex = 5;
            // 
            // PanelMain
            // 
            PanelMain.Controls.Add(Arquivos);
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(137, 0);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(804, 530);
            PanelMain.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(941, 530);
            Controls.Add(PanelMain);
            Controls.Add(PanelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PGHtmlReport - 1.0.0";
            Shown += Form1_Shown;
            PanelMenu.ResumeLayout(false);
            PanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView Arquivos;
        private Button BtnNovo;
        private Button BtnAlterar;
        private Button BtnGerar;
        private Button BtnSair;
        private Panel PanelMenu;
        private Panel PanelMain;
    }
}

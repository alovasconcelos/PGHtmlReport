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
            PanelMain = new Panel();
            menuStrip1 = new MenuStrip();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            novoRelatórioToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem2 = new ToolStripMenuItem();
            conexãoToolStripMenuItem1 = new ToolStripMenuItem();
            testarToolStripMenuItem = new ToolStripMenuItem();
            PanelMain.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMain
            // 
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(0, 28);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(941, 502);
            PanelMain.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { relatórioToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(941, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoRelatórioToolStripMenuItem, exportarToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem1, sairToolStripMenuItem });
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(84, 24);
            relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // novoRelatórioToolStripMenuItem
            // 
            novoRelatórioToolStripMenuItem.Image = (Image)resources.GetObject("novoRelatórioToolStripMenuItem.Image");
            novoRelatórioToolStripMenuItem.Name = "novoRelatórioToolStripMenuItem";
            novoRelatórioToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            novoRelatórioToolStripMenuItem.Size = new Size(224, 26);
            novoRelatórioToolStripMenuItem.Text = "Novo";
            novoRelatórioToolStripMenuItem.Click += novoRelatórioToolStripMenuItem_Click;
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.Image = (Image)resources.GetObject("exportarToolStripMenuItem.Image");
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exportarToolStripMenuItem.Size = new Size(224, 26);
            exportarToolStripMenuItem.Text = "Exportar";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.Control | Keys.O;
            toolStripMenuItem2.Size = new Size(224, 26);
            toolStripMenuItem2.Text = "Abrir";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            sairToolStripMenuItem.Size = new Size(224, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatórioToolStripMenuItem2, conexãoToolStripMenuItem1, testarToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(81, 24);
            editarToolStripMenuItem.Text = "Conexão";
            // 
            // relatórioToolStripMenuItem2
            // 
            relatórioToolStripMenuItem2.Image = (Image)resources.GetObject("relatórioToolStripMenuItem2.Image");
            relatórioToolStripMenuItem2.Name = "relatórioToolStripMenuItem2";
            relatórioToolStripMenuItem2.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            relatórioToolStripMenuItem2.Size = new Size(220, 26);
            relatórioToolStripMenuItem2.Text = "Nova";
            // 
            // conexãoToolStripMenuItem1
            // 
            conexãoToolStripMenuItem1.Image = (Image)resources.GetObject("conexãoToolStripMenuItem1.Image");
            conexãoToolStripMenuItem1.Name = "conexãoToolStripMenuItem1";
            conexãoToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
            conexãoToolStripMenuItem1.Size = new Size(220, 26);
            conexãoToolStripMenuItem1.Text = "Abrir";
            // 
            // testarToolStripMenuItem
            // 
            testarToolStripMenuItem.Image = (Image)resources.GetObject("testarToolStripMenuItem.Image");
            testarToolStripMenuItem.Name = "testarToolStripMenuItem";
            testarToolStripMenuItem.Size = new Size(220, 26);
            testarToolStripMenuItem.Text = "Testar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(941, 530);
            Controls.Add(PanelMain);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PGHtmlReport - 1.0.0";
            WindowState = FormWindowState.Maximized;
            Shown += Form1_Shown;
            PanelMain.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelMain;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem novoRelatórioToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem2;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem conexãoToolStripMenuItem1;
        private ToolStripMenuItem testarToolStripMenuItem;
    }
}

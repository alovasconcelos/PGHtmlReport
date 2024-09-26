namespace PGHtmlReport
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
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMain
            // 
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(0, 28);
            PanelMain.Name = "PanelMain";
            PanelMain.Padding = new Padding(10);
            PanelMain.Size = new Size(1059, 582);
            PanelMain.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { relatórioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1059, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoRelatórioToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem1, sairToolStripMenuItem });
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1059, 610);
            Controls.Add(PanelMain);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PGHtmlReport - 1.0.0";
            WindowState = FormWindowState.Maximized;
            Shown += Form1_Shown;
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
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}

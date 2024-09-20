namespace PGHrmlReport.Forms
{
    partial class ShowReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowReport));
            PanelBottom = new Panel();
            BtnFechar = new Button();
            WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WebView).BeginInit();
            SuspendLayout();
            // 
            // PanelBottom
            // 
            PanelBottom.Controls.Add(BtnFechar);
            PanelBottom.Dock = DockStyle.Bottom;
            PanelBottom.Location = new Point(0, 354);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(796, 92);
            PanelBottom.TabIndex = 0;
            // 
            // BtnFechar
            // 
            BtnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnFechar.BackColor = Color.Transparent;
            BtnFechar.Cursor = Cursors.Hand;
            BtnFechar.FlatStyle = FlatStyle.Popup;
            BtnFechar.ForeColor = Color.White;
            BtnFechar.Image = (Image)resources.GetObject("BtnFechar.Image");
            BtnFechar.Location = new Point(647, 15);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Padding = new Padding(10);
            BtnFechar.Size = new Size(137, 65);
            BtnFechar.TabIndex = 3;
            BtnFechar.Text = "    Fechar";
            BtnFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // WebView
            // 
            WebView.AllowExternalDrop = true;
            WebView.BackColor = Color.Black;
            WebView.CreationProperties = null;
            WebView.DefaultBackgroundColor = Color.White;
            WebView.Dock = DockStyle.Fill;
            WebView.ForeColor = Color.Black;
            WebView.Location = new Point(0, 0);
            WebView.Name = "WebView";
            WebView.Padding = new Padding(5);
            WebView.Size = new Size(796, 354);
            WebView.TabIndex = 1;
            WebView.ZoomFactor = 1D;
            // 
            // ShowReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(796, 446);
            ControlBox = false;
            Controls.Add(WebView);
            Controls.Add(PanelBottom);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ShowReport";
            ShowIcon = false;
            ShowInTaskbar = false;
            WindowState = FormWindowState.Maximized;
            Shown += ShowReport_Shown;
            PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WebView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBottom;
        private Button BtnFechar;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
    }
}
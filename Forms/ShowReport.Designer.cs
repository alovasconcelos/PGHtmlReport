namespace PGHtmlReport.Forms
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
            WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            BtnFechar = new Button();
            PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WebView).BeginInit();
            SuspendLayout();
            // 
            // PanelBottom
            // 
            PanelBottom.Controls.Add(BtnFechar);
            PanelBottom.Dock = DockStyle.Top;
            PanelBottom.Location = new Point(0, 0);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(792, 62);
            PanelBottom.TabIndex = 0;
            // 
            // WebView
            // 
            WebView.AllowExternalDrop = true;
            WebView.BackColor = Color.Black;
            WebView.CreationProperties = null;
            WebView.DefaultBackgroundColor = Color.White;
            WebView.Dock = DockStyle.Fill;
            WebView.ForeColor = Color.Black;
            WebView.Location = new Point(0, 62);
            WebView.Name = "WebView";
            WebView.Padding = new Padding(5);
            WebView.Size = new Size(792, 380);
            WebView.TabIndex = 1;
            WebView.ZoomFactor = 1D;
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.Transparent;
            BtnFechar.Cursor = Cursors.Hand;
            BtnFechar.Dock = DockStyle.Right;
            BtnFechar.FlatStyle = FlatStyle.Popup;
            BtnFechar.ForeColor = Color.White;
            BtnFechar.Image = (Image)resources.GetObject("BtnFechar.Image");
            BtnFechar.ImageAlign = ContentAlignment.TopCenter;
            BtnFechar.Location = new Point(696, 0);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(96, 62);
            BtnFechar.TabIndex = 15;
            BtnFechar.Text = "Fechar";
            BtnFechar.TextAlign = ContentAlignment.BottomCenter;
            BtnFechar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // ShowReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(792, 442);
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
        private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
        private Button BtnFechar;
    }
}
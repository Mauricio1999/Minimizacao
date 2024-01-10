namespace MinimizacaoLoja
{
    partial class FormModeloDialogo
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FormModeloDialogo));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteOSiteDoSistemaHiperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreOITecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.arquivoToolStripMenuItem, this.ajudaToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.menuBar.Size = new System.Drawing.Size(628, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Enabled = false;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.arquivoToolStripMenuItem.Text = "Hiper Loja";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.visiteOSiteDoSistemaHiperToolStripMenuItem, this.toolStripSeparator2,
                this.sobreOITecToolStripMenuItem
            });
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // visiteOSiteDoSistemaHiperToolStripMenuItem
            // 
            this.visiteOSiteDoSistemaHiperToolStripMenuItem.Name = "visiteOSiteDoSistemaHiperToolStripMenuItem";
            this.visiteOSiteDoSistemaHiperToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.visiteOSiteDoSistemaHiperToolStripMenuItem.Text = "Visite o site do Sistema Hiper";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(269, 6);
            // 
            // sobreOITecToolStripMenuItem
            // 
            this.sobreOITecToolStripMenuItem.Name = "sobreOITecToolStripMenuItem";
            this.sobreOITecToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.sobreOITecToolStripMenuItem.Text = "Sobre o Sistema Hiper";
            // 
            // FormModeloDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 518);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormModeloDialogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormModeloDialogo_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormModeloDialogo_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormModeloDialogo_KeyUp);
            this.Resize += new System.EventHandler(this.FormModeloDialogo_Resize);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sobreOITecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteOSiteDoSistemaHiperToolStripMenuItem;
    }
}
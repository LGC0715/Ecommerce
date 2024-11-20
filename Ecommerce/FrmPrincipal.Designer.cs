
namespace Ecommerce
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.blaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uSUÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // blaToolStripMenuItem
            // 
            this.blaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdPrincipal,
            this.vENDASToolStripMenuItem,
            this.uSUÁRIOSToolStripMenuItem});
            this.blaToolStripMenuItem.Name = "blaToolStripMenuItem";
            this.blaToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.blaToolStripMenuItem.Text = "E-COMMERCE";
            this.blaToolStripMenuItem.Click += new System.EventHandler(this.blaToolStripMenuItem_Click);
            // 
            // ProdPrincipal
            // 
            this.ProdPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProdPrincipal.Name = "ProdPrincipal";
            this.ProdPrincipal.Size = new System.Drawing.Size(180, 22);
            this.ProdPrincipal.Text = "PRODUTOS";
            this.ProdPrincipal.Click += new System.EventHandler(this.pRODUTOSToolStripMenuItem_Click);
            // 
            // vENDASToolStripMenuItem
            // 
            this.vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
            this.vENDASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vENDASToolStripMenuItem.Text = "VENDAS";
            this.vENDASToolStripMenuItem.Click += new System.EventHandler(this.vENDASToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uSUÁRIOSToolStripMenuItem
            // 
            this.uSUÁRIOSToolStripMenuItem.Name = "uSUÁRIOSToolStripMenuItem";
            this.uSUÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uSUÁRIOSToolStripMenuItem.Text = "USUÁRIOS";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ecommerce.Properties.Resources.tendencias_ecommerce_BR_Capterra_Header;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem blaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProdPrincipal;
        private System.Windows.Forms.ToolStripMenuItem vENDASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUÁRIOSToolStripMenuItem;
    }
}
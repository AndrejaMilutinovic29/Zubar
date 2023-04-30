
namespace Zubar
{
    partial class Glavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.progranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izadjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.šifarniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijagnozeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.papirologijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartoniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiPoPacijentimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiPoDoktorimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progranToolStripMenuItem,
            this.šifarniciToolStripMenuItem,
            this.osobeToolStripMenuItem,
            this.papirologijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1363, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // progranToolStripMenuItem
            // 
            this.progranToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zatvoriToolStripMenuItem,
            this.izadjiToolStripMenuItem});
            this.progranToolStripMenuItem.Name = "progranToolStripMenuItem";
            this.progranToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.progranToolStripMenuItem.Text = "Program";
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // izadjiToolStripMenuItem
            // 
            this.izadjiToolStripMenuItem.Name = "izadjiToolStripMenuItem";
            this.izadjiToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.izadjiToolStripMenuItem.Text = "Izadji";
            this.izadjiToolStripMenuItem.Click += new System.EventHandler(this.izadjiToolStripMenuItem_Click);
            // 
            // šifarniciToolStripMenuItem
            // 
            this.šifarniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dijagnozeTSMI});
            this.šifarniciToolStripMenuItem.Name = "šifarniciToolStripMenuItem";
            this.šifarniciToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.šifarniciToolStripMenuItem.Text = "Šifarnici";
            // 
            // dijagnozeTSMI
            // 
            this.dijagnozeTSMI.Name = "dijagnozeTSMI";
            this.dijagnozeTSMI.Size = new System.Drawing.Size(160, 26);
            this.dijagnozeTSMI.Text = "Dijagnoze";
            this.dijagnozeTSMI.Click += new System.EventHandler(this.dijagnozeTSMI_Click);
            // 
            // osobeToolStripMenuItem
            // 
            this.osobeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacijentiToolStripMenuItem,
            this.doktoriToolStripMenuItem});
            this.osobeToolStripMenuItem.Name = "osobeToolStripMenuItem";
            this.osobeToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.osobeToolStripMenuItem.Text = "Osobe";
            // 
            // pacijentiToolStripMenuItem
            // 
            this.pacijentiToolStripMenuItem.Name = "pacijentiToolStripMenuItem";
            this.pacijentiToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.pacijentiToolStripMenuItem.Text = "Pacijenti";
            this.pacijentiToolStripMenuItem.Click += new System.EventHandler(this.pacijentiToolStripMenuItem_Click);
            // 
            // doktoriToolStripMenuItem
            // 
            this.doktoriToolStripMenuItem.Name = "doktoriToolStripMenuItem";
            this.doktoriToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.doktoriToolStripMenuItem.Text = "Doktori";
            this.doktoriToolStripMenuItem.Click += new System.EventHandler(this.doktoriToolStripMenuItem_Click);
            // 
            // papirologijaToolStripMenuItem
            // 
            this.papirologijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kartoniToolStripMenuItem,
            this.terminiToolStripMenuItem,
            this.terminiPoPacijentimaToolStripMenuItem,
            this.terminiPoDoktorimaToolStripMenuItem});
            this.papirologijaToolStripMenuItem.Name = "papirologijaToolStripMenuItem";
            this.papirologijaToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.papirologijaToolStripMenuItem.Text = "Papirologija";
            // 
            // kartoniToolStripMenuItem
            // 
            this.kartoniToolStripMenuItem.Name = "kartoniToolStripMenuItem";
            this.kartoniToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.kartoniToolStripMenuItem.Text = "Kartoni";
            this.kartoniToolStripMenuItem.Click += new System.EventHandler(this.kartoniToolStripMenuItem_Click);
            // 
            // terminiToolStripMenuItem
            // 
            this.terminiToolStripMenuItem.Name = "terminiToolStripMenuItem";
            this.terminiToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.terminiToolStripMenuItem.Text = "Termini";
            this.terminiToolStripMenuItem.Click += new System.EventHandler(this.terminiToolStripMenuItem_Click);
            // 
            // terminiPoPacijentimaToolStripMenuItem
            // 
            this.terminiPoPacijentimaToolStripMenuItem.Name = "terminiPoPacijentimaToolStripMenuItem";
            this.terminiPoPacijentimaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.terminiPoPacijentimaToolStripMenuItem.Text = "Termini po pacijentima";
            this.terminiPoPacijentimaToolStripMenuItem.Click += new System.EventHandler(this.terminiPoPacijentimaToolStripMenuItem_Click);
            // 
            // terminiPoDoktorimaToolStripMenuItem
            // 
            this.terminiPoDoktorimaToolStripMenuItem.Name = "terminiPoDoktorimaToolStripMenuItem";
            this.terminiPoDoktorimaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.terminiPoDoktorimaToolStripMenuItem.Text = "Termini po doktorima";
            this.terminiPoDoktorimaToolStripMenuItem.Click += new System.EventHandler(this.terminiPoDoktorimaToolStripMenuItem_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1363, 729);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Glavna";
            this.Text = "Zubar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem šifarniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijagnozeTSMI;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem papirologijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartoniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izadjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiPoPacijentimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiPoDoktorimaToolStripMenuItem;
    }
}


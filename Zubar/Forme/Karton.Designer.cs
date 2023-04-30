
namespace Zubar.Forme
{
    partial class Karton
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
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPOSLEDNJI = new System.Windows.Forms.Button();
            this.btnSLEDECI = new System.Windows.Forms.Button();
            this.btnIZMENI = new System.Windows.Forms.Button();
            this.btnPRETHODNI = new System.Windows.Forms.Button();
            this.btnPRVI = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPacijent = new System.Windows.Forms.TextBox();
            this.cbDoktor = new System.Windows.Forms.ComboBox();
            this.tbStanje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(193, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pacijent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Izabrani Zubar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stanje:";
            // 
            // btnPOSLEDNJI
            // 
            this.btnPOSLEDNJI.Location = new System.Drawing.Point(653, 361);
            this.btnPOSLEDNJI.Name = "btnPOSLEDNJI";
            this.btnPOSLEDNJI.Size = new System.Drawing.Size(66, 29);
            this.btnPOSLEDNJI.TabIndex = 30;
            this.btnPOSLEDNJI.Text = ">>";
            this.btnPOSLEDNJI.UseVisualStyleBackColor = true;
            this.btnPOSLEDNJI.Click += new System.EventHandler(this.btnPOSLEDNJI_Click);
            // 
            // btnSLEDECI
            // 
            this.btnSLEDECI.Location = new System.Drawing.Point(572, 361);
            this.btnSLEDECI.Name = "btnSLEDECI";
            this.btnSLEDECI.Size = new System.Drawing.Size(66, 29);
            this.btnSLEDECI.TabIndex = 29;
            this.btnSLEDECI.Text = ">";
            this.btnSLEDECI.UseVisualStyleBackColor = true;
            this.btnSLEDECI.Click += new System.EventHandler(this.btnSLEDECI_Click);
            // 
            // btnIZMENI
            // 
            this.btnIZMENI.Location = new System.Drawing.Point(410, 361);
            this.btnIZMENI.Name = "btnIZMENI";
            this.btnIZMENI.Size = new System.Drawing.Size(66, 29);
            this.btnIZMENI.TabIndex = 27;
            this.btnIZMENI.Text = "Izmeni";
            this.btnIZMENI.UseVisualStyleBackColor = true;
            this.btnIZMENI.Click += new System.EventHandler(this.btnIZMENI_Click);
            // 
            // btnPRETHODNI
            // 
            this.btnPRETHODNI.Location = new System.Drawing.Point(248, 361);
            this.btnPRETHODNI.Name = "btnPRETHODNI";
            this.btnPRETHODNI.Size = new System.Drawing.Size(66, 29);
            this.btnPRETHODNI.TabIndex = 25;
            this.btnPRETHODNI.Text = "<";
            this.btnPRETHODNI.UseVisualStyleBackColor = true;
            this.btnPRETHODNI.Click += new System.EventHandler(this.btnPRETHODNI_Click);
            // 
            // btnPRVI
            // 
            this.btnPRVI.Location = new System.Drawing.Point(167, 361);
            this.btnPRVI.Name = "btnPRVI";
            this.btnPRVI.Size = new System.Drawing.Size(66, 29);
            this.btnPRVI.TabIndex = 24;
            this.btnPRVI.Text = "<<";
            this.btnPRVI.UseVisualStyleBackColor = true;
            this.btnPRVI.Click += new System.EventHandler(this.btnPRVI_Click);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(329, 63);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(208, 20);
            this.tbID.TabIndex = 31;
            // 
            // tbPacijent
            // 
            this.tbPacijent.Enabled = false;
            this.tbPacijent.Location = new System.Drawing.Point(329, 123);
            this.tbPacijent.Name = "tbPacijent";
            this.tbPacijent.Size = new System.Drawing.Size(208, 20);
            this.tbPacijent.TabIndex = 32;
            // 
            // cbDoktor
            // 
            this.cbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoktor.FormattingEnabled = true;
            this.cbDoktor.Location = new System.Drawing.Point(329, 192);
            this.cbDoktor.Name = "cbDoktor";
            this.cbDoktor.Size = new System.Drawing.Size(208, 21);
            this.cbDoktor.TabIndex = 33;
            // 
            // tbStanje
            // 
            this.tbStanje.Location = new System.Drawing.Point(329, 253);
            this.tbStanje.Multiline = true;
            this.tbStanje.Name = "tbStanje";
            this.tbStanje.Size = new System.Drawing.Size(208, 82);
            this.tbStanje.TabIndex = 34;
            // 
            // Karton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 511);
            this.Controls.Add(this.tbStanje);
            this.Controls.Add(this.cbDoktor);
            this.Controls.Add(this.tbPacijent);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnPOSLEDNJI);
            this.Controls.Add(this.btnSLEDECI);
            this.Controls.Add(this.btnIZMENI);
            this.Controls.Add(this.btnPRETHODNI);
            this.Controls.Add(this.btnPRVI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Name = "Karton";
            this.Text = "Karton";
            this.Load += new System.EventHandler(this.Karton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPOSLEDNJI;
        private System.Windows.Forms.Button btnSLEDECI;
        private System.Windows.Forms.Button btnIZMENI;
        private System.Windows.Forms.Button btnPRETHODNI;
        private System.Windows.Forms.Button btnPRVI;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPacijent;
        private System.Windows.Forms.ComboBox cbDoktor;
        private System.Windows.Forms.TextBox tbStanje;
    }
}
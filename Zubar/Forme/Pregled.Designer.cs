
namespace Zubar.Forme
{
    partial class Pregled
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
            this.lbIme = new System.Windows.Forms.Label();
            this.cbKljuc = new System.Windows.Forms.ComboBox();
            this.dgPregled = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPregled)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(222, 35);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(46, 17);
            this.lbIme.TabIndex = 0;
            this.lbIme.Text = "label1";
            // 
            // cbKljuc
            // 
            this.cbKljuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKljuc.FormattingEnabled = true;
            this.cbKljuc.Location = new System.Drawing.Point(330, 32);
            this.cbKljuc.Name = "cbKljuc";
            this.cbKljuc.Size = new System.Drawing.Size(337, 24);
            this.cbKljuc.TabIndex = 1;
            this.cbKljuc.SelectedIndexChanged += new System.EventHandler(this.cbKljuc_SelectedIndexChanged);
            // 
            // dgPregled
            // 
            this.dgPregled.AllowUserToAddRows = false;
            this.dgPregled.AllowUserToDeleteRows = false;
            this.dgPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPregled.Location = new System.Drawing.Point(119, 85);
            this.dgPregled.Name = "dgPregled";
            this.dgPregled.ReadOnly = true;
            this.dgPregled.RowHeadersWidth = 51;
            this.dgPregled.RowTemplate.Height = 24;
            this.dgPregled.Size = new System.Drawing.Size(947, 372);
            this.dgPregled.TabIndex = 2;
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 629);
            this.Controls.Add(this.dgPregled);
            this.Controls.Add(this.cbKljuc);
            this.Controls.Add(this.lbIme);
            this.Name = "Pregled";
            this.Text = "Pregled";
            ((System.ComponentModel.ISupportInitialize)(this.dgPregled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.ComboBox cbKljuc;
        private System.Windows.Forms.DataGridView dgPregled;
    }
}
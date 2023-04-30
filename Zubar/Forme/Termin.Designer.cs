
namespace Zubar.Forme
{
    partial class Termin
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
            this.btnIZMENI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPacijent = new System.Windows.Forms.ComboBox();
            this.cbDoktor = new System.Windows.Forms.ComboBox();
            this.cbDijagnoza = new System.Windows.Forms.ComboBox();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.cbPocetak = new System.Windows.Forms.ComboBox();
            this.cbZavrsetak = new System.Windows.Forms.ComboBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIZMENI
            // 
            this.btnIZMENI.Location = new System.Drawing.Point(567, 555);
            this.btnIZMENI.Margin = new System.Windows.Forms.Padding(4);
            this.btnIZMENI.Name = "btnIZMENI";
            this.btnIZMENI.Size = new System.Drawing.Size(88, 36);
            this.btnIZMENI.TabIndex = 33;
            this.btnIZMENI.Text = "Dodaj";
            this.btnIZMENI.UseVisualStyleBackColor = true;
            this.btnIZMENI.Click += new System.EventHandler(this.btnIZMENI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Pacijent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Doktor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Dijagnoza: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Datum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Početak:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Završetak:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Cena:";
            // 
            // cbPacijent
            // 
            this.cbPacijent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacijent.FormattingEnabled = true;
            this.cbPacijent.Location = new System.Drawing.Point(372, 48);
            this.cbPacijent.Name = "cbPacijent";
            this.cbPacijent.Size = new System.Drawing.Size(283, 24);
            this.cbPacijent.TabIndex = 43;
            this.cbPacijent.SelectedIndexChanged += new System.EventHandler(this.cbPacijent_SelectedIndexChanged);
            // 
            // cbDoktor
            // 
            this.cbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoktor.FormattingEnabled = true;
            this.cbDoktor.Location = new System.Drawing.Point(372, 107);
            this.cbDoktor.Name = "cbDoktor";
            this.cbDoktor.Size = new System.Drawing.Size(283, 24);
            this.cbDoktor.TabIndex = 44;
            // 
            // cbDijagnoza
            // 
            this.cbDijagnoza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDijagnoza.FormattingEnabled = true;
            this.cbDijagnoza.Location = new System.Drawing.Point(372, 177);
            this.cbDijagnoza.Name = "cbDijagnoza";
            this.cbDijagnoza.Size = new System.Drawing.Size(283, 24);
            this.cbDijagnoza.TabIndex = 45;
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(372, 247);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(283, 22);
            this.dtDatum.TabIndex = 46;
            // 
            // cbPocetak
            // 
            this.cbPocetak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPocetak.FormattingEnabled = true;
            this.cbPocetak.Location = new System.Drawing.Point(372, 320);
            this.cbPocetak.Name = "cbPocetak";
            this.cbPocetak.Size = new System.Drawing.Size(121, 24);
            this.cbPocetak.TabIndex = 47;
            this.cbPocetak.SelectedValueChanged += new System.EventHandler(this.cbPocetak_SelectedValueChanged);
            // 
            // cbZavrsetak
            // 
            this.cbZavrsetak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZavrsetak.FormattingEnabled = true;
            this.cbZavrsetak.Location = new System.Drawing.Point(372, 379);
            this.cbZavrsetak.Name = "cbZavrsetak";
            this.cbZavrsetak.Size = new System.Drawing.Size(121, 24);
            this.cbZavrsetak.TabIndex = 48;
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(372, 450);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(121, 22);
            this.tbCena.TabIndex = 49;
            this.tbCena.TextChanged += new System.EventHandler(this.tbCena_TextChanged);
            // 
            // Termin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 629);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.cbZavrsetak);
            this.Controls.Add(this.cbPocetak);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.cbDijagnoza);
            this.Controls.Add(this.cbDoktor);
            this.Controls.Add(this.cbPacijent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIZMENI);
            this.Name = "Termin";
            this.Text = "Termin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIZMENI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPacijent;
        private System.Windows.Forms.ComboBox cbDoktor;
        private System.Windows.Forms.ComboBox cbDijagnoza;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.ComboBox cbPocetak;
        private System.Windows.Forms.ComboBox cbZavrsetak;
        private System.Windows.Forms.TextBox tbCena;
    }
}
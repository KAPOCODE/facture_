namespace facture_
{
    partial class frmEnrProd
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
            this.textProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textQte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textref = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomProduit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textProd
            // 
            this.textProd.Location = new System.Drawing.Point(28, 195);
            this.textProd.Multiline = true;
            this.textProd.Name = "textProd";
            this.textProd.Size = new System.Drawing.Size(316, 44);
            this.textProd.TabIndex = 3;
            this.textProd.TextChanged += new System.EventHandler(this.textProd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom produit";
            // 
            // textPrix
            // 
            this.textPrix.Location = new System.Drawing.Point(28, 317);
            this.textPrix.Multiline = true;
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(316, 44);
            this.textPrix.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reference";
            // 
            // textQte
            // 
            this.textQte.Location = new System.Drawing.Point(28, 443);
            this.textQte.Multiline = true;
            this.textQte.Name = "textQte";
            this.textQte.Size = new System.Drawing.Size(316, 44);
            this.textQte.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantite";
            // 
            // textref
            // 
            this.textref.Location = new System.Drawing.Point(28, 81);
            this.textref.Multiline = true;
            this.textref.Name = "textref";
            this.textref.Size = new System.Drawing.Size(316, 44);
            this.textref.TabIndex = 9;
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(610, 503);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(178, 81);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = "Enregistrer";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(827, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 81);
            this.button1.TabIndex = 11;
            this.button1.Text = "FACTURER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Reference,
            this.NomProduit,
            this.Prix,
            this.Qte});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(368, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 432);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Reference
            // 
            this.Reference.Text = "Reference";
            // 
            // NomProduit
            // 
            this.NomProduit.Text = "NomProduit";
            // 
            // Prix
            // 
            this.Prix.Text = "Prix";
            // 
            // Qte
            // 
            this.Qte.Text = "Qte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Prix";
            // 
            // frmEnrProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.textref);
            this.Controls.Add(this.textQte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textProd);
            this.Controls.Add(this.label2);
            this.Name = "frmEnrProd";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textQte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textref;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Reference;
        private System.Windows.Forms.ColumnHeader NomProduit;
        private System.Windows.Forms.ColumnHeader Prix;
        private System.Windows.Forms.ColumnHeader Qte;
        private System.Windows.Forms.Label label1;
    }
}


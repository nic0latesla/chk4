namespace HSBC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lista = new System.Windows.Forms.TextBox();
            this.INICIAR = new System.Windows.Forms.Button();
            this.PAUSAR = new System.Windows.Forms.Button();
            this.ap = new System.Windows.Forms.TextBox();
            this.rp = new System.Windows.Forms.TextBox();
            this.txt_zip = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.SystemColors.InfoText;
            this.lista.ForeColor = System.Drawing.Color.Blue;
            this.lista.Location = new System.Drawing.Point(6, 173);
            this.lista.Multiline = true;
            this.lista.Name = "lista";
            this.lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lista.Size = new System.Drawing.Size(616, 193);
            this.lista.TabIndex = 0;
            // 
            // INICIAR
            // 
            this.INICIAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.INICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INICIAR.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INICIAR.Location = new System.Drawing.Point(6, 372);
            this.INICIAR.Name = "INICIAR";
            this.INICIAR.Size = new System.Drawing.Size(198, 33);
            this.INICIAR.TabIndex = 1;
            this.INICIAR.Text = "INICIAR";
            this.INICIAR.UseVisualStyleBackColor = true;
            this.INICIAR.Click += new System.EventHandler(this.INICIAR_Click);
            // 
            // PAUSAR
            // 
            this.PAUSAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PAUSAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PAUSAR.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAUSAR.Location = new System.Drawing.Point(210, 372);
            this.PAUSAR.Name = "PAUSAR";
            this.PAUSAR.Size = new System.Drawing.Size(190, 33);
            this.PAUSAR.TabIndex = 2;
            this.PAUSAR.Text = "PAUSAR";
            this.PAUSAR.UseVisualStyleBackColor = true;
            this.PAUSAR.Click += new System.EventHandler(this.PAUSAR_Click);
            // 
            // ap
            // 
            this.ap.BackColor = System.Drawing.SystemColors.InfoText;
            this.ap.ForeColor = System.Drawing.Color.Lime;
            this.ap.Location = new System.Drawing.Point(6, 411);
            this.ap.Multiline = true;
            this.ap.Name = "ap";
            this.ap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ap.Size = new System.Drawing.Size(616, 103);
            this.ap.TabIndex = 3;
            // 
            // rp
            // 
            this.rp.BackColor = System.Drawing.SystemColors.InfoText;
            this.rp.ForeColor = System.Drawing.Color.Red;
            this.rp.Location = new System.Drawing.Point(6, 520);
            this.rp.Multiline = true;
            this.rp.Name = "rp";
            this.rp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rp.Size = new System.Drawing.Size(616, 103);
            this.rp.TabIndex = 4;
            // 
            // txt_zip
            // 
            this.txt_zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_zip.Location = new System.Drawing.Point(223, 120);
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.ShortcutsEnabled = false;
            this.txt_zip.Size = new System.Drawing.Size(100, 24);
            this.txt_zip.TabIndex = 17;
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(223, 84);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(160, 24);
            this.txt_city.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Zipcode:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 26);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(222, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 26);
            this.comboBox2.TabIndex = 15;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(406, 372);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(216, 33);
            this.btn_limpiar.TabIndex = 16;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 625);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_zip);
            this.Controls.Add(this.rp);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.PAUSAR);
            this.Controls.Add(this.INICIAR);
            this.Controls.Add(this.lista);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T3SL4 CHECKER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lista;
        private System.Windows.Forms.Button INICIAR;
        private System.Windows.Forms.Button PAUSAR;
        private System.Windows.Forms.TextBox ap;
        private System.Windows.Forms.TextBox rp;
        private System.Windows.Forms.TextBox txt_zip;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_limpiar;
    }
}


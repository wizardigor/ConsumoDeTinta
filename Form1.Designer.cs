namespace ConsumoDeTinta
{
    partial class frmConsumoDeTinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsumoDeTinta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCilindro = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCilindro = new System.Windows.Forms.TextBox();
            this.pbCilindro = new System.Windows.Forms.PictureBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLatas = new System.Windows.Forms.Label();
            this.lbPrecoCilindro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotalLatas = new System.Windows.Forms.Label();
            this.lbTotalPreco = new System.Windows.Forms.Label();
            this.gbCilindro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCilindro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raio:";
            // 
            // gbCilindro
            // 
            this.gbCilindro.Controls.Add(this.label5);
            this.gbCilindro.Controls.Add(this.txtCilindro);
            this.gbCilindro.Controls.Add(this.pbCilindro);
            this.gbCilindro.Controls.Add(this.btCalcular);
            this.gbCilindro.Controls.Add(this.txtRaio);
            this.gbCilindro.Controls.Add(this.txtAltura);
            this.gbCilindro.Controls.Add(this.label1);
            this.gbCilindro.Controls.Add(this.label2);
            this.gbCilindro.Location = new System.Drawing.Point(12, 12);
            this.gbCilindro.Name = "gbCilindro";
            this.gbCilindro.Size = new System.Drawing.Size(251, 131);
            this.gbCilindro.TabIndex = 2;
            this.gbCilindro.TabStop = false;
            this.gbCilindro.Text = "Cilindro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cilindros:";
            // 
            // txtCilindro
            // 
            this.txtCilindro.Location = new System.Drawing.Point(56, 69);
            this.txtCilindro.Name = "txtCilindro";
            this.txtCilindro.Size = new System.Drawing.Size(100, 20);
            this.txtCilindro.TabIndex = 3;
            this.txtCilindro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAltura_KeyDown);
            // 
            // pbCilindro
            // 
            this.pbCilindro.Image = ((System.Drawing.Image)(resources.GetObject("pbCilindro.Image")));
            this.pbCilindro.Location = new System.Drawing.Point(167, 23);
            this.pbCilindro.Name = "pbCilindro";
            this.pbCilindro.Size = new System.Drawing.Size(70, 93);
            this.pbCilindro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCilindro.TabIndex = 3;
            this.pbCilindro.TabStop = false;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(56, 95);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(100, 23);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(56, 43);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 20);
            this.txtRaio.TabIndex = 2;
            this.txtRaio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAltura_KeyDown);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(56, 16);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAltura_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total de Latas a ser usadas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotalLatas);
            this.groupBox1.Controls.Add(this.lbTotalPreco);
            this.groupBox1.Controls.Add(this.lbLatas);
            this.groupBox1.Controls.Add(this.lbPrecoCilindro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 109);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lbLatas
            // 
            this.lbLatas.AutoSize = true;
            this.lbLatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLatas.Location = new System.Drawing.Point(12, 39);
            this.lbLatas.Name = "lbLatas";
            this.lbLatas.Size = new System.Drawing.Size(24, 20);
            this.lbLatas.TabIndex = 8;
            this.lbLatas.Text = "...";
            // 
            // lbPrecoCilindro
            // 
            this.lbPrecoCilindro.AutoSize = true;
            this.lbPrecoCilindro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoCilindro.Location = new System.Drawing.Point(131, 39);
            this.lbPrecoCilindro.Name = "lbPrecoCilindro";
            this.lbPrecoCilindro.Size = new System.Drawing.Size(24, 20);
            this.lbPrecoCilindro.TabIndex = 7;
            this.lbPrecoCilindro.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade de Latas por Cilindro:";
            // 
            // lbTotalLatas
            // 
            this.lbTotalLatas.AutoSize = true;
            this.lbTotalLatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalLatas.Location = new System.Drawing.Point(12, 84);
            this.lbTotalLatas.Name = "lbTotalLatas";
            this.lbTotalLatas.Size = new System.Drawing.Size(24, 20);
            this.lbTotalLatas.TabIndex = 10;
            this.lbTotalLatas.Text = "...";
            // 
            // lbTotalPreco
            // 
            this.lbTotalPreco.AutoSize = true;
            this.lbTotalPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPreco.Location = new System.Drawing.Point(131, 84);
            this.lbTotalPreco.Name = "lbTotalPreco";
            this.lbTotalPreco.Size = new System.Drawing.Size(24, 20);
            this.lbTotalPreco.TabIndex = 9;
            this.lbTotalPreco.Text = "...";
            // 
            // frmConsumoDeTinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCilindro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsumoDeTinta";
            this.Text = "Consumo de Tinta";
            this.gbCilindro.ResumeLayout(false);
            this.gbCilindro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCilindro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCilindro;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.PictureBox pbCilindro;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCilindro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbLatas;
        private System.Windows.Forms.Label lbPrecoCilindro;
        private System.Windows.Forms.Label lbTotalLatas;
        private System.Windows.Forms.Label lbTotalPreco;
    }
}


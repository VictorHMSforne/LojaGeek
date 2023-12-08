namespace LojaGeek
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblProduto = new System.Windows.Forms.Label();
            this.pbxProduto = new System.Windows.Forms.PictureBox();
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pbxVendas = new System.Windows.Forms.PictureBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVendas = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblProduto.Location = new System.Drawing.Point(54, 151);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(138, 25);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "PRODUTOS";
            // 
            // pbxProduto
            // 
            this.pbxProduto.BackColor = System.Drawing.Color.Transparent;
            this.pbxProduto.Image = ((System.Drawing.Image)(resources.GetObject("pbxProduto.Image")));
            this.pbxProduto.Location = new System.Drawing.Point(47, 25);
            this.pbxProduto.Name = "pbxProduto";
            this.pbxProduto.Size = new System.Drawing.Size(135, 123);
            this.pbxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProduto.TabIndex = 2;
            this.pbxProduto.TabStop = false;
            this.pbxProduto.Click += new System.EventHandler(this.pbxProduto_Click);
            // 
            // pbxCliente
            // 
            this.pbxCliente.BackColor = System.Drawing.Color.Transparent;
            this.pbxCliente.Image = global::LojaGeek.Properties.Resources.Client;
            this.pbxCliente.Location = new System.Drawing.Point(203, 25);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(138, 123);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCliente.TabIndex = 3;
            this.pbxCliente.TabStop = false;
            this.pbxCliente.Click += new System.EventHandler(this.pbxCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblCliente.Location = new System.Drawing.Point(213, 151);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(122, 25);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "CLIENTES";
            // 
            // pbxVendas
            // 
            this.pbxVendas.BackColor = System.Drawing.Color.Transparent;
            this.pbxVendas.Image = global::LojaGeek.Properties.Resources.Vendas;
            this.pbxVendas.Location = new System.Drawing.Point(347, 25);
            this.pbxVendas.Name = "pbxVendas";
            this.pbxVendas.Size = new System.Drawing.Size(136, 123);
            this.pbxVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVendas.TabIndex = 5;
            this.pbxVendas.TabStop = false;
            this.pbxVendas.Click += new System.EventHandler(this.pbxVendas_Click);
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.BackColor = System.Drawing.Color.Transparent;
            this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaida.Location = new System.Drawing.Point(750, 443);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(79, 25);
            this.lblSaida.TabIndex = 6;
            this.lblSaida.Text = "SAÍDA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LojaGeek.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(722, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.BackColor = System.Drawing.Color.Transparent;
            this.lblVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblVendas.Location = new System.Drawing.Point(379, 151);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(104, 25);
            this.lblVendas.TabIndex = 8;
            this.lblVendas.Text = "VENDAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LojaGeek.Properties.Resources.Caixa;
            this.pictureBox2.Location = new System.Drawing.Point(527, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(500, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "TIPOS DE PRODUTO";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaGeek.Properties.Resources.Fundo_edit_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblVendas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.pbxVendas);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.pbxCliente);
            this.Controls.Add(this.pbxProduto);
            this.Controls.Add(this.lblProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geek House";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.PictureBox pbxProduto;
        private System.Windows.Forms.PictureBox pbxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.PictureBox pbxVendas;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}


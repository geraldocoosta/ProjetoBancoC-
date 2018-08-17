namespace ProjetoBanco
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.GrupoConta = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoSaca = new System.Windows.Forms.Button();
            this.botaoDeposita = new System.Windows.Forms.Button();
            this.saldo = new System.Windows.Forms.Label();
            this.numeroConta = new System.Windows.Forms.Label();
            this.nomeTitular = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.GrupoBuscaContas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.GrupoConta.SuspendLayout();
            this.GrupoBuscaContas.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(126, 17);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.ReadOnly = true;
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(126, 43);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.ReadOnly = true;
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(126, 69);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.ReadOnly = true;
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // GrupoConta
            // 
            this.GrupoConta.Controls.Add(this.label2);
            this.GrupoConta.Controls.Add(this.botaoSaca);
            this.GrupoConta.Controls.Add(this.botaoDeposita);
            this.GrupoConta.Controls.Add(this.saldo);
            this.GrupoConta.Controls.Add(this.numeroConta);
            this.GrupoConta.Controls.Add(this.nomeTitular);
            this.GrupoConta.Controls.Add(this.textoValor);
            this.GrupoConta.Controls.Add(this.textoTitular);
            this.GrupoConta.Controls.Add(this.textoSaldo);
            this.GrupoConta.Controls.Add(this.textoNumero);
            this.GrupoConta.Location = new System.Drawing.Point(12, 130);
            this.GrupoConta.Name = "GrupoConta";
            this.GrupoConta.Size = new System.Drawing.Size(256, 171);
            this.GrupoConta.TabIndex = 3;
            this.GrupoConta.TabStop = false;
            this.GrupoConta.Text = "Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor (sem centavos)";
            // 
            // botaoSaca
            // 
            this.botaoSaca.Location = new System.Drawing.Point(45, 126);
            this.botaoSaca.Name = "botaoSaca";
            this.botaoSaca.Size = new System.Drawing.Size(75, 23);
            this.botaoSaca.TabIndex = 9;
            this.botaoSaca.Text = "Sacar";
            this.botaoSaca.UseVisualStyleBackColor = true;
            this.botaoSaca.Click += new System.EventHandler(this.botaoSaca_Click);
            // 
            // botaoDeposita
            // 
            this.botaoDeposita.Location = new System.Drawing.Point(126, 126);
            this.botaoDeposita.Name = "botaoDeposita";
            this.botaoDeposita.Size = new System.Drawing.Size(75, 23);
            this.botaoDeposita.TabIndex = 8;
            this.botaoDeposita.Text = "Depositar";
            this.botaoDeposita.UseVisualStyleBackColor = true;
            this.botaoDeposita.Click += new System.EventHandler(this.botaoDeposita_Click);
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Location = new System.Drawing.Point(16, 72);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(34, 13);
            this.saldo.TabIndex = 6;
            this.saldo.Text = "Saldo";
            // 
            // numeroConta
            // 
            this.numeroConta.AutoSize = true;
            this.numeroConta.Location = new System.Drawing.Point(15, 46);
            this.numeroConta.Name = "numeroConta";
            this.numeroConta.Size = new System.Drawing.Size(90, 13);
            this.numeroConta.TabIndex = 5;
            this.numeroConta.Text = "Numero da Conta";
            // 
            // nomeTitular
            // 
            this.nomeTitular.AutoSize = true;
            this.nomeTitular.Location = new System.Drawing.Point(16, 20);
            this.nomeTitular.Name = "nomeTitular";
            this.nomeTitular.Size = new System.Drawing.Size(36, 13);
            this.nomeTitular.TabIndex = 4;
            this.nomeTitular.Text = "Titular";
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(126, 95);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 3;
            this.textoValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoValor_KeyPress);
            this.textoValor.Leave += new System.EventHandler(this.textoValor_Leave);
            // 
            // GrupoBuscaContas
            // 
            this.GrupoBuscaContas.Controls.Add(this.label1);
            this.GrupoBuscaContas.Controls.Add(this.comboContas);
            this.GrupoBuscaContas.Location = new System.Drawing.Point(12, 12);
            this.GrupoBuscaContas.Name = "GrupoBuscaContas";
            this.GrupoBuscaContas.Size = new System.Drawing.Size(256, 85);
            this.GrupoBuscaContas.TabIndex = 4;
            this.GrupoBuscaContas.TabStop = false;
            this.GrupoBuscaContas.Text = "Buscar Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha a Conta";
            // 
            // comboContas
            // 
            this.comboContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(126, 42);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(100, 21);
            this.comboContas.TabIndex = 0;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(27, 319);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(75, 23);
            this.botaoNovaConta.TabIndex = 3;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 362);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.GrupoBuscaContas);
            this.Controls.Add(this.GrupoConta);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Contas Banco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrupoConta.ResumeLayout(false);
            this.GrupoConta.PerformLayout();
            this.GrupoBuscaContas.ResumeLayout(false);
            this.GrupoBuscaContas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.GroupBox GrupoConta;
        private System.Windows.Forms.Button botaoSaca;
        private System.Windows.Forms.Button botaoDeposita;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label numeroConta;
        private System.Windows.Forms.Label nomeTitular;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.GroupBox GrupoBuscaContas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Label label2;
    }
}


namespace ProjetoBanco
{
    partial class FormCadastroConta
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.GrupoCadastro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipoConta = new System.Windows.Forms.ComboBox();
            this.GrupoCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(91, 29);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 1;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(91, 55);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.ReadOnly = true;
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero";
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(69, 149);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastro.TabIndex = 5;
            this.botaoCadastro.Text = "Cadastrar";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
            // 
            // GrupoCadastro
            // 
            this.GrupoCadastro.Controls.Add(this.label3);
            this.GrupoCadastro.Controls.Add(this.comboTipoConta);
            this.GrupoCadastro.Controls.Add(this.textoTitular);
            this.GrupoCadastro.Controls.Add(this.botaoCadastro);
            this.GrupoCadastro.Controls.Add(this.textoNumero);
            this.GrupoCadastro.Controls.Add(this.label2);
            this.GrupoCadastro.Controls.Add(this.label1);
            this.GrupoCadastro.Location = new System.Drawing.Point(12, 12);
            this.GrupoCadastro.Name = "GrupoCadastro";
            this.GrupoCadastro.Size = new System.Drawing.Size(226, 178);
            this.GrupoCadastro.TabIndex = 6;
            this.GrupoCadastro.TabStop = false;
            this.GrupoCadastro.Text = "Cadastro novo cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo Conta";
            // 
            // comboTipoConta
            // 
            this.comboTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoConta.FormattingEnabled = true;
            this.comboTipoConta.Items.AddRange(new object[] {
            "Conta Corrente",
            "Conta Poupança"});
            this.comboTipoConta.Location = new System.Drawing.Point(81, 81);
            this.comboTipoConta.Name = "comboTipoConta";
            this.comboTipoConta.Size = new System.Drawing.Size(121, 21);
            this.comboTipoConta.TabIndex = 6;
            this.comboTipoConta.SelectedIndexChanged += new System.EventHandler(this.comboTipoConta_SelectedIndexChanged);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 202);
            this.Controls.Add(this.GrupoCadastro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroConta";
            this.Text = "Cadastro Conta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.GrupoCadastro.ResumeLayout(false);
            this.GrupoCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.GroupBox GrupoCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTipoConta;
    }
}
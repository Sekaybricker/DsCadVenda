namespace CadVendas
{
    partial class DetVendas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbProduto = new System.Windows.Forms.ComboBox();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.MtPreco = new System.Windows.Forms.MaskedTextBox();
            this.MtTotal = new System.Windows.Forms.MaskedTextBox();
            this.MtSubtotal = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(310, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(473, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(392, 18);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(148, 18);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(229, 18);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(67, 18);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 16;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "&Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "&Qtd.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "&Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "&Subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "&Total";
            // 
            // CbProduto
            // 
            this.CbProduto.FormattingEnabled = true;
            this.CbProduto.Location = new System.Drawing.Point(123, 77);
            this.CbProduto.Name = "CbProduto";
            this.CbProduto.Size = new System.Drawing.Size(66, 21);
            this.CbProduto.TabIndex = 28;
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(242, 78);
            this.nudQtd.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(46, 20);
            this.nudQtd.TabIndex = 29;
            this.nudQtd.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // MtPreco
            // 
            this.MtPreco.Location = new System.Drawing.Point(334, 78);
            this.MtPreco.Name = "MtPreco";
            this.MtPreco.Size = new System.Drawing.Size(100, 20);
            this.MtPreco.TabIndex = 30;
            // 
            // MtTotal
            // 
            this.MtTotal.Location = new System.Drawing.Point(344, 342);
            this.MtTotal.Name = "MtTotal";
            this.MtTotal.Size = new System.Drawing.Size(100, 20);
            this.MtTotal.TabIndex = 31;
            // 
            // MtSubtotal
            // 
            this.MtSubtotal.Location = new System.Drawing.Point(492, 78);
            this.MtSubtotal.Name = "MtSubtotal";
            this.MtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.MtSubtotal.TabIndex = 32;
            // 
            // DetVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MtSubtotal);
            this.Controls.Add(this.MtTotal);
            this.Controls.Add(this.MtPreco);
            this.Controls.Add(this.nudQtd);
            this.Controls.Add(this.CbProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Name = "DetVendas";
            this.Size = new System.Drawing.Size(614, 372);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbProduto;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.MaskedTextBox MtPreco;
        private System.Windows.Forms.MaskedTextBox MtTotal;
        private System.Windows.Forms.MaskedTextBox MtSubtotal;
    }
}

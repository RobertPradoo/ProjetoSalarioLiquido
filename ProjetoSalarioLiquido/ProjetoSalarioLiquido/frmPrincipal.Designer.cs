namespace ProjetoSalarioLiquido
{
    partial class frmPrincipal
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
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtDescontos = new System.Windows.Forms.TextBox();
            this.LblDescontos = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbValeTransporte = new System.Windows.Forms.CheckBox();
            this.cbValeAlimentacao = new System.Windows.Forms.CheckBox();
            this.cbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.cbContribuicaoSindical = new System.Windows.Forms.CheckBox();
            this.grbDescontosInss = new System.Windows.Forms.GroupBox();
            this.lblTotalINSS = new System.Windows.Forms.Label();
            this.lblTituloTotal = new System.Windows.Forms.Label();
            this.lblDescFaixa4 = new System.Windows.Forms.Label();
            this.lblTituloFaixa4 = new System.Windows.Forms.Label();
            this.lblDescFaixa3 = new System.Windows.Forms.Label();
            this.lblTituloFaixa3 = new System.Windows.Forms.Label();
            this.lblDescFaixa2 = new System.Windows.Forms.Label();
            this.lblTituloFaixa2 = new System.Windows.Forms.Label();
            this.lblDescFaixa1 = new System.Windows.Forms.Label();
            this.lblTituloFaixa1 = new System.Windows.Forms.Label();
            this.txtAdmissao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTrienio = new System.Windows.Forms.RadioButton();
            this.rbQuinquenio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescIRRF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescContribSindical = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescPlanoSaude = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDescValeAlimentacao = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDescValeTransporte = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grbDescontosInss.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(34, 30);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalarioBruto.TabIndex = 0;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(118, 30);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(148, 20);
            this.txtSalarioBruto.TabIndex = 1;
            // 
            // txtDescontos
            // 
            this.txtDescontos.Location = new System.Drawing.Point(118, 424);
            this.txtDescontos.Name = "txtDescontos";
            this.txtDescontos.ReadOnly = true;
            this.txtDescontos.Size = new System.Drawing.Size(155, 20);
            this.txtDescontos.TabIndex = 4;
            // 
            // LblDescontos
            // 
            this.LblDescontos.AutoSize = true;
            this.LblDescontos.Location = new System.Drawing.Point(34, 427);
            this.LblDescontos.Name = "LblDescontos";
            this.LblDescontos.Size = new System.Drawing.Size(85, 13);
            this.LblDescontos.TabIndex = 3;
            this.LblDescontos.Text = "Total Descontos";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(372, 424);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(155, 20);
            this.txtSalarioLiquido.TabIndex = 6;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(288, 427);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(78, 13);
            this.lblSalarioLiquido.TabIndex = 5;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(37, 171);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(490, 44);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbValeTransporte
            // 
            this.cbValeTransporte.AutoSize = true;
            this.cbValeTransporte.Location = new System.Drawing.Point(37, 66);
            this.cbValeTransporte.Name = "cbValeTransporte";
            this.cbValeTransporte.Size = new System.Drawing.Size(186, 17);
            this.cbValeTransporte.TabIndex = 8;
            this.cbValeTransporte.Text = "Vale Transporte (desconto de 6%)";
            this.cbValeTransporte.UseVisualStyleBackColor = true;
            // 
            // cbValeAlimentacao
            // 
            this.cbValeAlimentacao.AutoSize = true;
            this.cbValeAlimentacao.Location = new System.Drawing.Point(37, 89);
            this.cbValeAlimentacao.Name = "cbValeAlimentacao";
            this.cbValeAlimentacao.Size = new System.Drawing.Size(202, 17);
            this.cbValeAlimentacao.TabIndex = 9;
            this.cbValeAlimentacao.Text = "Vale Alimentação (desconto de 3,5%)";
            this.cbValeAlimentacao.UseVisualStyleBackColor = true;
            // 
            // cbPlanoSaude
            // 
            this.cbPlanoSaude.AutoSize = true;
            this.cbPlanoSaude.Location = new System.Drawing.Point(37, 112);
            this.cbPlanoSaude.Name = "cbPlanoSaude";
            this.cbPlanoSaude.Size = new System.Drawing.Size(206, 17);
            this.cbPlanoSaude.TabIndex = 10;
            this.cbPlanoSaude.Text = "Plano de Saúde (desconto de 116,00)";
            this.cbPlanoSaude.UseVisualStyleBackColor = true;
            // 
            // cbContribuicaoSindical
            // 
            this.cbContribuicaoSindical.AutoSize = true;
            this.cbContribuicaoSindical.Location = new System.Drawing.Point(37, 135);
            this.cbContribuicaoSindical.Name = "cbContribuicaoSindical";
            this.cbContribuicaoSindical.Size = new System.Drawing.Size(229, 17);
            this.cbContribuicaoSindical.TabIndex = 11;
            this.cbContribuicaoSindical.Text = "Contribuição Sindical (desconto de 143,15)";
            this.cbContribuicaoSindical.UseVisualStyleBackColor = true;
            // 
            // grbDescontosInss
            // 
            this.grbDescontosInss.Controls.Add(this.lblTotalINSS);
            this.grbDescontosInss.Controls.Add(this.lblTituloTotal);
            this.grbDescontosInss.Controls.Add(this.lblDescFaixa4);
            this.grbDescontosInss.Controls.Add(this.lblTituloFaixa4);
            this.grbDescontosInss.Controls.Add(this.lblDescFaixa3);
            this.grbDescontosInss.Controls.Add(this.lblTituloFaixa3);
            this.grbDescontosInss.Controls.Add(this.lblDescFaixa2);
            this.grbDescontosInss.Controls.Add(this.lblTituloFaixa2);
            this.grbDescontosInss.Controls.Add(this.lblDescFaixa1);
            this.grbDescontosInss.Controls.Add(this.lblTituloFaixa1);
            this.grbDescontosInss.Location = new System.Drawing.Point(39, 232);
            this.grbDescontosInss.Name = "grbDescontosInss";
            this.grbDescontosInss.Size = new System.Drawing.Size(234, 166);
            this.grbDescontosInss.TabIndex = 12;
            this.grbDescontosInss.TabStop = false;
            this.grbDescontosInss.Text = "Descontos INSS";
            // 
            // lblTotalINSS
            // 
            this.lblTotalINSS.AutoSize = true;
            this.lblTotalINSS.Location = new System.Drawing.Point(124, 137);
            this.lblTotalINSS.Name = "lblTotalINSS";
            this.lblTotalINSS.Size = new System.Drawing.Size(10, 13);
            this.lblTotalINSS.TabIndex = 9;
            this.lblTotalINSS.Text = "-";
            // 
            // lblTituloTotal
            // 
            this.lblTituloTotal.AutoSize = true;
            this.lblTituloTotal.Location = new System.Drawing.Point(22, 137);
            this.lblTituloTotal.Name = "lblTituloTotal";
            this.lblTituloTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTituloTotal.TabIndex = 8;
            this.lblTituloTotal.Text = "Total";
            // 
            // lblDescFaixa4
            // 
            this.lblDescFaixa4.AutoSize = true;
            this.lblDescFaixa4.Location = new System.Drawing.Point(124, 109);
            this.lblDescFaixa4.Name = "lblDescFaixa4";
            this.lblDescFaixa4.Size = new System.Drawing.Size(10, 13);
            this.lblDescFaixa4.TabIndex = 7;
            this.lblDescFaixa4.Text = "-";
            // 
            // lblTituloFaixa4
            // 
            this.lblTituloFaixa4.AutoSize = true;
            this.lblTituloFaixa4.Location = new System.Drawing.Point(22, 109);
            this.lblTituloFaixa4.Name = "lblTituloFaixa4";
            this.lblTituloFaixa4.Size = new System.Drawing.Size(70, 13);
            this.lblTituloFaixa4.TabIndex = 6;
            this.lblTituloFaixa4.Text = "Faixa 4 (14%)";
            // 
            // lblDescFaixa3
            // 
            this.lblDescFaixa3.AutoSize = true;
            this.lblDescFaixa3.Location = new System.Drawing.Point(124, 82);
            this.lblDescFaixa3.Name = "lblDescFaixa3";
            this.lblDescFaixa3.Size = new System.Drawing.Size(10, 13);
            this.lblDescFaixa3.TabIndex = 5;
            this.lblDescFaixa3.Text = "-";
            // 
            // lblTituloFaixa3
            // 
            this.lblTituloFaixa3.AutoSize = true;
            this.lblTituloFaixa3.Location = new System.Drawing.Point(22, 82);
            this.lblTituloFaixa3.Name = "lblTituloFaixa3";
            this.lblTituloFaixa3.Size = new System.Drawing.Size(70, 13);
            this.lblTituloFaixa3.TabIndex = 4;
            this.lblTituloFaixa3.Text = "Faixa 3 (12%)";
            // 
            // lblDescFaixa2
            // 
            this.lblDescFaixa2.AutoSize = true;
            this.lblDescFaixa2.Location = new System.Drawing.Point(124, 55);
            this.lblDescFaixa2.Name = "lblDescFaixa2";
            this.lblDescFaixa2.Size = new System.Drawing.Size(10, 13);
            this.lblDescFaixa2.TabIndex = 3;
            this.lblDescFaixa2.Text = "-";
            // 
            // lblTituloFaixa2
            // 
            this.lblTituloFaixa2.AutoSize = true;
            this.lblTituloFaixa2.Location = new System.Drawing.Point(22, 55);
            this.lblTituloFaixa2.Name = "lblTituloFaixa2";
            this.lblTituloFaixa2.Size = new System.Drawing.Size(64, 13);
            this.lblTituloFaixa2.TabIndex = 2;
            this.lblTituloFaixa2.Text = "Faixa 2 (9%)";
            // 
            // lblDescFaixa1
            // 
            this.lblDescFaixa1.AutoSize = true;
            this.lblDescFaixa1.Location = new System.Drawing.Point(124, 29);
            this.lblDescFaixa1.Name = "lblDescFaixa1";
            this.lblDescFaixa1.Size = new System.Drawing.Size(10, 13);
            this.lblDescFaixa1.TabIndex = 1;
            this.lblDescFaixa1.Text = "-";
            // 
            // lblTituloFaixa1
            // 
            this.lblTituloFaixa1.AutoSize = true;
            this.lblTituloFaixa1.Location = new System.Drawing.Point(22, 29);
            this.lblTituloFaixa1.Name = "lblTituloFaixa1";
            this.lblTituloFaixa1.Size = new System.Drawing.Size(73, 13);
            this.lblTituloFaixa1.TabIndex = 0;
            this.lblTituloFaixa1.Text = "Faixa 1 (7,5%)";
            // 
            // txtAdmissao
            // 
            this.txtAdmissao.Location = new System.Drawing.Point(400, 30);
            this.txtAdmissao.Name = "txtAdmissao";
            this.txtAdmissao.Size = new System.Drawing.Size(129, 20);
            this.txtAdmissao.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data de Admissão";
            // 
            // rbTrienio
            // 
            this.rbTrienio.AutoSize = true;
            this.rbTrienio.Checked = true;
            this.rbTrienio.Location = new System.Drawing.Point(304, 65);
            this.rbTrienio.Name = "rbTrienio";
            this.rbTrienio.Size = new System.Drawing.Size(57, 17);
            this.rbTrienio.TabIndex = 15;
            this.rbTrienio.TabStop = true;
            this.rbTrienio.Text = "Triênio";
            this.rbTrienio.UseVisualStyleBackColor = true;
            // 
            // rbQuinquenio
            // 
            this.rbQuinquenio.AutoSize = true;
            this.rbQuinquenio.Location = new System.Drawing.Point(304, 88);
            this.rbQuinquenio.Name = "rbQuinquenio";
            this.rbQuinquenio.Size = new System.Drawing.Size(79, 17);
            this.rbQuinquenio.TabIndex = 16;
            this.rbQuinquenio.Text = "Quinquênio";
            this.rbQuinquenio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDescIRRF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDescContribSindical);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDescPlanoSaude);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblDescValeAlimentacao);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblDescValeTransporte);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(295, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 166);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outros descontos";
            // 
            // lblDescIRRF
            // 
            this.lblDescIRRF.AutoSize = true;
            this.lblDescIRRF.Location = new System.Drawing.Point(124, 137);
            this.lblDescIRRF.Name = "lblDescIRRF";
            this.lblDescIRRF.Size = new System.Drawing.Size(10, 13);
            this.lblDescIRRF.TabIndex = 9;
            this.lblDescIRRF.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IRRF";
            // 
            // lblDescContribSindical
            // 
            this.lblDescContribSindical.AutoSize = true;
            this.lblDescContribSindical.Location = new System.Drawing.Point(124, 109);
            this.lblDescContribSindical.Name = "lblDescContribSindical";
            this.lblDescContribSindical.Size = new System.Drawing.Size(10, 13);
            this.lblDescContribSindical.TabIndex = 7;
            this.lblDescContribSindical.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contrib. Sindical";
            // 
            // lblDescPlanoSaude
            // 
            this.lblDescPlanoSaude.AutoSize = true;
            this.lblDescPlanoSaude.Location = new System.Drawing.Point(124, 82);
            this.lblDescPlanoSaude.Name = "lblDescPlanoSaude";
            this.lblDescPlanoSaude.Size = new System.Drawing.Size(10, 13);
            this.lblDescPlanoSaude.TabIndex = 5;
            this.lblDescPlanoSaude.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Plano de Saúde";
            // 
            // lblDescValeAlimentacao
            // 
            this.lblDescValeAlimentacao.AutoSize = true;
            this.lblDescValeAlimentacao.Location = new System.Drawing.Point(124, 55);
            this.lblDescValeAlimentacao.Name = "lblDescValeAlimentacao";
            this.lblDescValeAlimentacao.Size = new System.Drawing.Size(10, 13);
            this.lblDescValeAlimentacao.TabIndex = 3;
            this.lblDescValeAlimentacao.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Vale Alimentação";
            // 
            // lblDescValeTransporte
            // 
            this.lblDescValeTransporte.AutoSize = true;
            this.lblDescValeTransporte.Location = new System.Drawing.Point(124, 29);
            this.lblDescValeTransporte.Name = "lblDescValeTransporte";
            this.lblDescValeTransporte.Size = new System.Drawing.Size(10, 13);
            this.lblDescValeTransporte.TabIndex = 1;
            this.lblDescValeTransporte.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Vale Transporte";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbQuinquenio);
            this.Controls.Add(this.rbTrienio);
            this.Controls.Add(this.txtAdmissao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbDescontosInss);
            this.Controls.Add(this.cbContribuicaoSindical);
            this.Controls.Add(this.cbPlanoSaude);
            this.Controls.Add(this.cbValeAlimentacao);
            this.Controls.Add(this.cbValeTransporte);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.txtDescontos);
            this.Controls.Add(this.LblDescontos);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.lblSalarioBruto);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Salário Líquido";
            this.grbDescontosInss.ResumeLayout(false);
            this.grbDescontosInss.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtDescontos;
        private System.Windows.Forms.Label LblDescontos;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox cbValeTransporte;
        private System.Windows.Forms.CheckBox cbValeAlimentacao;
        private System.Windows.Forms.CheckBox cbPlanoSaude;
        private System.Windows.Forms.CheckBox cbContribuicaoSindical;
        private System.Windows.Forms.GroupBox grbDescontosInss;
        private System.Windows.Forms.Label lblDescFaixa4;
        private System.Windows.Forms.Label lblTituloFaixa4;
        private System.Windows.Forms.Label lblDescFaixa3;
        private System.Windows.Forms.Label lblTituloFaixa3;
        private System.Windows.Forms.Label lblDescFaixa2;
        private System.Windows.Forms.Label lblTituloFaixa2;
        private System.Windows.Forms.Label lblDescFaixa1;
        private System.Windows.Forms.Label lblTituloFaixa1;
        private System.Windows.Forms.Label lblTotalINSS;
        private System.Windows.Forms.Label lblTituloTotal;
        private System.Windows.Forms.TextBox txtAdmissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTrienio;
        private System.Windows.Forms.RadioButton rbQuinquenio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescIRRF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescContribSindical;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDescPlanoSaude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDescValeAlimentacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDescValeTransporte;
        private System.Windows.Forms.Label label11;
    }
}


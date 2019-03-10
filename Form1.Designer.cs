namespace Trabalho_IA_03
{
    partial class lbteste
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
            this.components = new System.ComponentModel.Container();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ZedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.lbMenorDistancia = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lbEvolucoes = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnCriarPop = new System.Windows.Forms.Button();
            this.gpMutacao = new System.Windows.Forms.GroupBox();
            this.rbGenesPop = new System.Windows.Forms.RadioButton();
            this.rbPopulacao = new System.Windows.Forms.RadioButton();
            this.rbNovoIndivido = new System.Windows.Forms.RadioButton();
            this.txtTorneio = new System.Windows.Forms.MaskedTextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtQtdEleti = new System.Windows.Forms.MaskedTextBox();
            this.chEletismo = new System.Windows.Forms.CheckBox();
            this.txtEvolucoes = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxaMutacao = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxaCross = new System.Windows.Forms.MaskedTextBox();
            this.txtTamPop = new System.Windows.Forms.MaskedTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbQtdCidade = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbComplex = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.gpMutacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel1.Controls.Add(this.ZedGraphControl1);
            this.Panel1.Controls.Add(this.lbMenorDistancia);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.lbEvolucoes);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.btnLimpar);
            this.Panel1.Controls.Add(this.btnExecutar);
            this.Panel1.Controls.Add(this.btnCriarPop);
            this.Panel1.Controls.Add(this.gpMutacao);
            this.Panel1.Controls.Add(this.txtTorneio);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.txtQtdEleti);
            this.Panel1.Controls.Add(this.chEletismo);
            this.Panel1.Controls.Add(this.txtEvolucoes);
            this.Panel1.Controls.Add(this.txtTaxaMutacao);
            this.Panel1.Controls.Add(this.txtTaxaCross);
            this.Panel1.Controls.Add(this.txtTamPop);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(1, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(466, 578);
            this.Panel1.TabIndex = 1;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // ZedGraphControl1
            // 
            this.ZedGraphControl1.Location = new System.Drawing.Point(20, 347);
            this.ZedGraphControl1.Name = "ZedGraphControl1";
            this.ZedGraphControl1.ScrollGrace = 0D;
            this.ZedGraphControl1.ScrollMaxX = 0D;
            this.ZedGraphControl1.ScrollMaxY = 0D;
            this.ZedGraphControl1.ScrollMaxY2 = 0D;
            this.ZedGraphControl1.ScrollMinX = 0D;
            this.ZedGraphControl1.ScrollMinY = 0D;
            this.ZedGraphControl1.ScrollMinY2 = 0D;
            this.ZedGraphControl1.Size = new System.Drawing.Size(424, 213);
            this.ZedGraphControl1.TabIndex = 20;
            // 
            // lbMenorDistancia
            // 
            this.lbMenorDistancia.AutoSize = true;
            this.lbMenorDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenorDistancia.Location = new System.Drawing.Point(181, 295);
            this.lbMenorDistancia.Name = "lbMenorDistancia";
            this.lbMenorDistancia.Size = new System.Drawing.Size(29, 20);
            this.lbMenorDistancia.TabIndex = 19;
            this.lbMenorDistancia.Text = "00";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(22, 295);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(153, 20);
            this.Label7.TabIndex = 18;
            this.Label7.Text = "Menor Distância:";
            // 
            // lbEvolucoes
            // 
            this.lbEvolucoes.AutoSize = true;
            this.lbEvolucoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvolucoes.Location = new System.Drawing.Point(181, 260);
            this.lbEvolucoes.Name = "lbEvolucoes";
            this.lbEvolucoes.Size = new System.Drawing.Size(29, 20);
            this.lbEvolucoes.TabIndex = 17;
            this.lbEvolucoes.Text = "00";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(22, 260);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(101, 20);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Evoluções:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(300, 177);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(144, 42);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Enabled = false;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(300, 123);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(144, 42);
            this.btnExecutar.TabIndex = 15;
            this.btnExecutar.Text = "Executar / Continuar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            // 
            // btnCriarPop
            // 
            this.btnCriarPop.Enabled = false;
            this.btnCriarPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPop.Location = new System.Drawing.Point(300, 75);
            this.btnCriarPop.Name = "btnCriarPop";
            this.btnCriarPop.Size = new System.Drawing.Size(144, 42);
            this.btnCriarPop.TabIndex = 14;
            this.btnCriarPop.Text = "Criar Poupulação";
            this.btnCriarPop.UseVisualStyleBackColor = true;
            this.btnCriarPop.Click += new System.EventHandler(this.btnCriarPop_Click);
            // 
            // gpMutacao
            // 
            this.gpMutacao.Controls.Add(this.rbGenesPop);
            this.gpMutacao.Controls.Add(this.rbPopulacao);
            this.gpMutacao.Controls.Add(this.rbNovoIndivido);
            this.gpMutacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpMutacao.Location = new System.Drawing.Point(11, 141);
            this.gpMutacao.Name = "gpMutacao";
            this.gpMutacao.Size = new System.Drawing.Size(262, 116);
            this.gpMutacao.TabIndex = 13;
            this.gpMutacao.TabStop = false;
            this.gpMutacao.Text = "Mutação:";
            // 
            // rbGenesPop
            // 
            this.rbGenesPop.AutoSize = true;
            this.rbGenesPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenesPop.Location = new System.Drawing.Point(22, 84);
            this.rbGenesPop.Name = "rbGenesPop";
            this.rbGenesPop.Size = new System.Drawing.Size(163, 24);
            this.rbGenesPop.TabIndex = 2;
            this.rbGenesPop.Text = "Genes Poupulação";
            this.rbGenesPop.UseVisualStyleBackColor = true;
            // 
            // rbPopulacao
            // 
            this.rbPopulacao.AutoSize = true;
            this.rbPopulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPopulacao.Location = new System.Drawing.Point(22, 54);
            this.rbPopulacao.Name = "rbPopulacao";
            this.rbPopulacao.Size = new System.Drawing.Size(154, 24);
            this.rbPopulacao.TabIndex = 1;
            this.rbPopulacao.Text = "Poupulação Geral";
            this.rbPopulacao.UseVisualStyleBackColor = true;
            // 
            // rbNovoIndivido
            // 
            this.rbNovoIndivido.AutoSize = true;
            this.rbNovoIndivido.Checked = true;
            this.rbNovoIndivido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNovoIndivido.Location = new System.Drawing.Point(22, 25);
            this.rbNovoIndivido.Name = "rbNovoIndivido";
            this.rbNovoIndivido.Size = new System.Drawing.Size(121, 24);
            this.rbNovoIndivido.TabIndex = 0;
            this.rbNovoIndivido.TabStop = true;
            this.rbNovoIndivido.Text = "Novo Individo";
            this.rbNovoIndivido.UseVisualStyleBackColor = true;
            // 
            // txtTorneio
            // 
            this.txtTorneio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTorneio.Location = new System.Drawing.Point(405, 45);
            this.txtTorneio.Mask = "0";
            this.txtTorneio.Name = "txtTorneio";
            this.txtTorneio.Size = new System.Drawing.Size(30, 24);
            this.txtTorneio.TabIndex = 12;
            this.txtTorneio.Text = "4";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(319, 42);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(66, 20);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Torneio:";
            // 
            // txtQtdEleti
            // 
            this.txtQtdEleti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdEleti.Location = new System.Drawing.Point(405, 12);
            this.txtQtdEleti.Mask = "0";
            this.txtQtdEleti.Name = "txtQtdEleti";
            this.txtQtdEleti.Size = new System.Drawing.Size(30, 24);
            this.txtQtdEleti.TabIndex = 10;
            this.txtQtdEleti.Text = "3";
            // 
            // chEletismo
            // 
            this.chEletismo.AutoSize = true;
            this.chEletismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chEletismo.Location = new System.Drawing.Point(300, 17);
            this.chEletismo.Name = "chEletismo";
            this.chEletismo.Size = new System.Drawing.Size(85, 22);
            this.chEletismo.TabIndex = 9;
            this.chEletismo.Text = "Eletismo";
            this.chEletismo.UseVisualStyleBackColor = true;
            // 
            // txtEvolucoes
            // 
            this.txtEvolucoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvolucoes.Location = new System.Drawing.Point(167, 109);
            this.txtEvolucoes.Mask = "0000";
            this.txtEvolucoes.Name = "txtEvolucoes";
            this.txtEvolucoes.Size = new System.Drawing.Size(97, 26);
            this.txtEvolucoes.TabIndex = 8;
            this.txtEvolucoes.Text = "100";
            // 
            // txtTaxaMutacao
            // 
            this.txtTaxaMutacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaMutacao.Location = new System.Drawing.Point(167, 76);
            this.txtTaxaMutacao.Mask = "0.0000";
            this.txtTaxaMutacao.Name = "txtTaxaMutacao";
            this.txtTaxaMutacao.Size = new System.Drawing.Size(97, 26);
            this.txtTaxaMutacao.TabIndex = 7;
            this.txtTaxaMutacao.Text = "0001";
            // 
            // txtTaxaCross
            // 
            this.txtTaxaCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaCross.Location = new System.Drawing.Point(167, 45);
            this.txtTaxaCross.Mask = "0.000";
            this.txtTaxaCross.Name = "txtTaxaCross";
            this.txtTaxaCross.Size = new System.Drawing.Size(97, 26);
            this.txtTaxaCross.TabIndex = 6;
            this.txtTaxaCross.Text = "0600";
            // 
            // txtTamPop
            // 
            this.txtTamPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamPop.Location = new System.Drawing.Point(167, 11);
            this.txtTamPop.Mask = "00000";
            this.txtTamPop.Name = "txtTamPop";
            this.txtTamPop.Size = new System.Drawing.Size(97, 26);
            this.txtTamPop.TabIndex = 5;
            this.txtTamPop.Text = "50";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(22, 115);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(90, 20);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Evoluções :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(22, 82);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(139, 20);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Taxa de Mutação :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(22, 51);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(139, 20);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Taxa de Crossver :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(22, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(116, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Tamanho Pop :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(473, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Quantidade de Cidades:";
            // 
            // lbQtdCidade
            // 
            this.lbQtdCidade.AutoSize = true;
            this.lbQtdCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdCidade.Location = new System.Drawing.Point(659, 9);
            this.lbQtdCidade.Name = "lbQtdCidade";
            this.lbQtdCidade.Size = new System.Drawing.Size(19, 20);
            this.lbQtdCidade.TabIndex = 3;
            this.lbQtdCidade.Text = "--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(473, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Complexidade:";
            // 
            // lbComplex
            // 
            this.lbComplex.AutoSize = true;
            this.lbComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplex.Location = new System.Drawing.Point(578, 548);
            this.lbComplex.Name = "lbComplex";
            this.lbComplex.Size = new System.Drawing.Size(18, 20);
            this.lbComplex.TabIndex = 5;
            this.lbComplex.Text = "0";
            // 
            // lbteste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1140, 573);
            this.Controls.Add(this.lbComplex);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbQtdCidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Panel1);
            this.Name = "lbteste";
            this.Text = "teste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.gpMutacao.ResumeLayout(false);
            this.gpMutacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal ZedGraph.ZedGraphControl ZedGraphControl1;
        internal System.Windows.Forms.Label lbMenorDistancia;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label lbEvolucoes;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnLimpar;
        internal System.Windows.Forms.Button btnExecutar;
        internal System.Windows.Forms.Button btnCriarPop;
        internal System.Windows.Forms.GroupBox gpMutacao;
        internal System.Windows.Forms.RadioButton rbGenesPop;
        internal System.Windows.Forms.RadioButton rbPopulacao;
        internal System.Windows.Forms.RadioButton rbNovoIndivido;
        internal System.Windows.Forms.MaskedTextBox txtTorneio;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.MaskedTextBox txtQtdEleti;
        internal System.Windows.Forms.CheckBox chEletismo;
        internal System.Windows.Forms.MaskedTextBox txtEvolucoes;
        internal System.Windows.Forms.MaskedTextBox txtTaxaMutacao;
        internal System.Windows.Forms.MaskedTextBox txtTaxaCross;
        internal System.Windows.Forms.MaskedTextBox txtTamPop;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label lbQtdCidade;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label lbComplex;
    }
}


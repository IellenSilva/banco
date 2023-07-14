
namespace Aula04AppBanco
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.bntExtrato = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnsacar = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conradito\'s Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seu saldo atual:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(148, 96);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(39, 16);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "R$ 0";
            // 
            // bntExtrato
            // 
            this.bntExtrato.Location = new System.Drawing.Point(540, 89);
            this.bntExtrato.Name = "bntExtrato";
            this.bntExtrato.Size = new System.Drawing.Size(88, 30);
            this.bntExtrato.TabIndex = 3;
            this.bntExtrato.Text = "Ver extrato";
            this.bntExtrato.UseVisualStyleBackColor = true;
            this.bntExtrato.Click += new System.EventHandler(this.bntExtrato_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsacar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnDepositar);
            this.groupBox1.Location = new System.Drawing.Point(151, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 255);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operação disponiveis";
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDepositar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDepositar.Location = new System.Drawing.Point(17, 33);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(183, 46);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnsacar
            // 
            this.btnsacar.Location = new System.Drawing.Point(225, 33);
            this.btnsacar.Name = "btnsacar";
            this.btnsacar.Size = new System.Drawing.Size(193, 46);
            this.btnsacar.TabIndex = 1;
            this.btnsacar.Text = "Sacar";
            this.btnsacar.UseVisualStyleBackColor = true;
            this.btnsacar.Click += new System.EventHandler(this.btnsacar_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(30, 16);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(81, 20);
            this.lblOperacao.TabIndex = 2;
            this.lblOperacao.Text = "Depósito";
            this.lblOperacao.Click += new System.EventHandler(this.lblOperacao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Infome o valor:";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(34, 82);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(285, 20);
            this.textValor.TabIndex = 4;
            this.textValor.TextChanged += new System.EventHandler(this.textValor_TextChanged);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(34, 108);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(285, 23);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textValor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblOperacao);
            this.groupBox2.Controls.Add(this.btnsalvar);
            this.groupBox2.Location = new System.Drawing.Point(34, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 141);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntExtrato);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button bntExtrato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


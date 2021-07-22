
namespace CadastroDeAluno
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mtxtUF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbDadosEscolares = new System.Windows.Forms.GroupBox();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtRA = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblQtdd = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gbDadosPessoais.SuspendLayout();
            this.gbDadosEscolares.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.mtxtUF);
            this.gbDadosPessoais.Controls.Add(this.label5);
            this.gbDadosPessoais.Controls.Add(this.mtxtCPF);
            this.gbDadosPessoais.Controls.Add(this.mtxtTelefone);
            this.gbDadosPessoais.Controls.Add(this.mtxtNascimento);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.label4);
            this.gbDadosPessoais.Controls.Add(this.label3);
            this.gbDadosPessoais.Controls.Add(this.label2);
            this.gbDadosPessoais.Controls.Add(this.label1);
            this.gbDadosPessoais.Location = new System.Drawing.Point(12, 51);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(527, 144);
            this.gbDadosPessoais.TabIndex = 0;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // mtxtUF
            // 
            this.mtxtUF.Location = new System.Drawing.Point(249, 95);
            this.mtxtUF.Mask = "AA";
            this.mtxtUF.Name = "mtxtUF";
            this.mtxtUF.Size = new System.Drawing.Size(29, 26);
            this.mtxtUF.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "UF:";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(73, 98);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(120, 26);
            this.mtxtCPF.TabIndex = 7;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(368, 66);
            this.mtxtTelefone.Mask = "(00) 00000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(131, 26);
            this.mtxtTelefone.TabIndex = 6;
            // 
            // mtxtNascimento
            // 
            this.mtxtNascimento.Location = new System.Drawing.Point(188, 66);
            this.mtxtNascimento.Mask = "00/00/0000";
            this.mtxtNascimento.Name = "mtxtNascimento";
            this.mtxtNascimento.Size = new System.Drawing.Size(90, 26);
            this.mtxtNascimento.TabIndex = 5;
            this.mtxtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(417, 26);
            this.txtNome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // gbDadosEscolares
            // 
            this.gbDadosEscolares.Controls.Add(this.cbPeriodo);
            this.gbDadosEscolares.Controls.Add(this.label7);
            this.gbDadosEscolares.Controls.Add(this.mtxtRA);
            this.gbDadosEscolares.Controls.Add(this.label6);
            this.gbDadosEscolares.Location = new System.Drawing.Point(12, 201);
            this.gbDadosEscolares.Name = "gbDadosEscolares";
            this.gbDadosEscolares.Size = new System.Drawing.Size(527, 72);
            this.gbDadosEscolares.TabIndex = 1;
            this.gbDadosEscolares.TabStop = false;
            this.gbDadosEscolares.Text = "Dados Escolares";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "Diurno",
            "Noturno"});
            this.cbPeriodo.Location = new System.Drawing.Point(239, 29);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(121, 28);
            this.cbPeriodo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Período:";
            // 
            // mtxtRA
            // 
            this.mtxtRA.Location = new System.Drawing.Point(62, 31);
            this.mtxtRA.Mask = "000000000";
            this.mtxtRA.Name = "mtxtRA";
            this.mtxtRA.Size = new System.Drawing.Size(98, 26);
            this.mtxtRA.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "RA:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(442, 279);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 29);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Quantidade de alunos cadastrados:";
            // 
            // lblQtdd
            // 
            this.lblQtdd.AutoSize = true;
            this.lblQtdd.BackColor = System.Drawing.SystemColors.Control;
            this.lblQtdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblQtdd.Location = new System.Drawing.Point(279, 283);
            this.lblQtdd.Name = "lblQtdd";
            this.lblQtdd.Size = new System.Drawing.Size(31, 20);
            this.lblQtdd.TabIndex = 4;
            this.lblQtdd.Text = "XX";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(551, 34);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(287, 29);
            this.toolStripButton1.Text = "Salvar dados em Arquivo de Texto";
            this.toolStripButton1.Click += new System.EventHandler(this.tsSalvar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 318);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblQtdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbDadosEscolares);
            this.Controls.Add(this.gbDadosPessoais);
            this.Name = "frmCadastro";
            this.Text = "Cadastro de Alunos";
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbDadosEscolares.ResumeLayout(false);
            this.gbDadosEscolares.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox gbDadosPessoais;
        public System.Windows.Forms.MaskedTextBox mtxtUF;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox mtxtCPF;
        public System.Windows.Forms.MaskedTextBox mtxtTelefone;
        public System.Windows.Forms.MaskedTextBox mtxtNascimento;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.GroupBox gbDadosEscolares;
        public System.Windows.Forms.ComboBox cbPeriodo;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox mtxtRA;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblQtdd;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}


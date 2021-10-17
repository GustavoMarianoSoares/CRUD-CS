
namespace CRUD
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.dtpDataMatricula = new System.Windows.Forms.DateTimePicker();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.rdbSexoMasc = new System.Windows.Forms.RadioButton();
            this.rdbSexoFemin = new System.Windows.Forms.RadioButton();
            this.cmbPlano = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data da matricula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Plano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(98, 12);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(337, 22);
            this.txtMatricula.TabIndex = 7;
            // 
            // dtpDataMatricula
            // 
            this.dtpDataMatricula.Location = new System.Drawing.Point(149, 56);
            this.dtpDataMatricula.Name = "dtpDataMatricula";
            this.dtpDataMatricula.Size = new System.Drawing.Size(286, 22);
            this.dtpDataMatricula.TabIndex = 8;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Location = new System.Drawing.Point(168, 134);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(267, 22);
            this.dtpDataNasc.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(358, 22);
            this.txtNome.TabIndex = 9;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(62, 178);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(373, 22);
            this.txtCPF.TabIndex = 11;
            // 
            // rdbSexoMasc
            // 
            this.rdbSexoMasc.AutoSize = true;
            this.rdbSexoMasc.Location = new System.Drawing.Point(74, 224);
            this.rdbSexoMasc.Name = "rdbSexoMasc";
            this.rdbSexoMasc.Size = new System.Drawing.Size(92, 21);
            this.rdbSexoMasc.TabIndex = 12;
            this.rdbSexoMasc.TabStop = true;
            this.rdbSexoMasc.Text = "Masculino";
            this.rdbSexoMasc.UseVisualStyleBackColor = true;
            // 
            // rdbSexoFemin
            // 
            this.rdbSexoFemin.AutoSize = true;
            this.rdbSexoFemin.Location = new System.Drawing.Point(172, 224);
            this.rdbSexoFemin.Name = "rdbSexoFemin";
            this.rdbSexoFemin.Size = new System.Drawing.Size(86, 21);
            this.rdbSexoFemin.TabIndex = 13;
            this.rdbSexoFemin.TabStop = true;
            this.rdbSexoFemin.Text = "Feminino";
            this.rdbSexoFemin.UseVisualStyleBackColor = true;
            // 
            // cmbPlano
            // 
            this.cmbPlano.FormattingEnabled = true;
            this.cmbPlano.Location = new System.Drawing.Point(77, 263);
            this.cmbPlano.Name = "cmbPlano";
            this.cmbPlano.Size = new System.Drawing.Size(358, 24);
            this.cmbPlano.TabIndex = 14;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(150, 356);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(161, 32);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(326, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 32);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Deletar);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 356);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 32);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.Atualizar);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(237, 407);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(161, 32);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(418, 407);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(161, 32);
            this.btnExibir.TabIndex = 19;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(459, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(329, 275);
            this.dataGridView1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbPlano);
            this.Controls.Add(this.rdbSexoFemin);
            this.Controls.Add(this.rdbSexoMasc);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtpDataMatricula);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.DateTimePicker dtpDataMatricula;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.RadioButton rdbSexoMasc;
        private System.Windows.Forms.RadioButton rdbSexoFemin;
        private System.Windows.Forms.ComboBox cmbPlano;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


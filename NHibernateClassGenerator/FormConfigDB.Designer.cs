namespace NHibernateClassGenerator
{
    partial class FormConfigDB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImp_TestarConexao = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbImp_TipoBanco = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImp_Porta = new System.Windows.Forms.TextBox();
            this.txtImp_Senha = new System.Windows.Forms.TextBox();
            this.txtImp_Usuario = new System.Windows.Forms.TextBox();
            this.txtImp_Banco = new System.Windows.Forms.TextBox();
            this.txtImp_Ip = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.BgBancoImp = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 49);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Config";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblStatus);
            this.panel5.Controls.Add(this.btnSair);
            this.panel5.Controls.Add(this.btnSalvar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 510);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(815, 67);
            this.panel5.TabIndex = 1022;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(708, 15);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 31);
            this.btnSair.TabIndex = 1020;
            this.btnSair.Text = "Exit";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(627, 15);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 31);
            this.btnSalvar.TabIndex = 1010;
            this.btnSalvar.Text = "Save";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnImp_TestarConexao);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cbImp_TipoBanco);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtImp_Porta);
            this.panel3.Controls.Add(this.txtImp_Senha);
            this.panel3.Controls.Add(this.txtImp_Usuario);
            this.panel3.Controls.Add(this.txtImp_Banco);
            this.panel3.Controls.Add(this.txtImp_Ip);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 461);
            this.panel3.TabIndex = 1023;
            // 
            // btnImp_TestarConexao
            // 
            this.btnImp_TestarConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImp_TestarConexao.Location = new System.Drawing.Point(240, 223);
            this.btnImp_TestarConexao.Name = "btnImp_TestarConexao";
            this.btnImp_TestarConexao.Size = new System.Drawing.Size(75, 31);
            this.btnImp_TestarConexao.TabIndex = 111;
            this.btnImp_TestarConexao.Text = "Test";
            this.btnImp_TestarConexao.UseVisualStyleBackColor = true;
            this.btnImp_TestarConexao.Click += new System.EventHandler(this.btnImp_TestarConexao_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Database Type:";
            // 
            // cbImp_TipoBanco
            // 
            this.cbImp_TipoBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbImp_TipoBanco.FormattingEnabled = true;
            this.cbImp_TipoBanco.Items.AddRange(new object[] {
            "Sql Server",
            "Oracle",
            "Mysql",
            "Postgres",
            "Firebird"});
            this.cbImp_TipoBanco.Location = new System.Drawing.Point(115, 65);
            this.cbImp_TipoBanco.Name = "cbImp_TipoBanco";
            this.cbImp_TipoBanco.Size = new System.Drawing.Size(200, 23);
            this.cbImp_TipoBanco.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Database configuration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Port:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Pass:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "User:";
            // 
            // txtImp_Porta
            // 
            this.txtImp_Porta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImp_Porta.Location = new System.Drawing.Point(115, 196);
            this.txtImp_Porta.Name = "txtImp_Porta";
            this.txtImp_Porta.Size = new System.Drawing.Size(200, 21);
            this.txtImp_Porta.TabIndex = 110;
            // 
            // txtImp_Senha
            // 
            this.txtImp_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImp_Senha.Location = new System.Drawing.Point(115, 170);
            this.txtImp_Senha.Name = "txtImp_Senha";
            this.txtImp_Senha.PasswordChar = '*';
            this.txtImp_Senha.Size = new System.Drawing.Size(200, 21);
            this.txtImp_Senha.TabIndex = 100;
            // 
            // txtImp_Usuario
            // 
            this.txtImp_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImp_Usuario.Location = new System.Drawing.Point(115, 144);
            this.txtImp_Usuario.Name = "txtImp_Usuario";
            this.txtImp_Usuario.Size = new System.Drawing.Size(200, 21);
            this.txtImp_Usuario.TabIndex = 90;
            // 
            // txtImp_Banco
            // 
            this.txtImp_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImp_Banco.Location = new System.Drawing.Point(115, 118);
            this.txtImp_Banco.Name = "txtImp_Banco";
            this.txtImp_Banco.Size = new System.Drawing.Size(200, 21);
            this.txtImp_Banco.TabIndex = 80;
            // 
            // txtImp_Ip
            // 
            this.txtImp_Ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImp_Ip.Location = new System.Drawing.Point(115, 92);
            this.txtImp_Ip.Name = "txtImp_Ip";
            this.txtImp_Ip.Size = new System.Drawing.Size(200, 21);
            this.txtImp_Ip.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Database:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "IP:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(18, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 13);
            this.lblStatus.TabIndex = 1021;
            this.lblStatus.Text = "...";
            // 
            // BgBancoImp
            // 
            this.BgBancoImp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgBancoImp_DoWork);
            this.BgBancoImp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgBancoImp_RunWorkerCompleted);
            // 
            // FormConfigDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "FormConfigDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfigDB";
            this.Load += new System.EventHandler(this.FormConfigDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnImp_TestarConexao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbImp_TipoBanco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtImp_Porta;
        private System.Windows.Forms.TextBox txtImp_Senha;
        private System.Windows.Forms.TextBox txtImp_Usuario;
        private System.Windows.Forms.TextBox txtImp_Banco;
        private System.Windows.Forms.TextBox txtImp_Ip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker BgBancoImp;
    }
}
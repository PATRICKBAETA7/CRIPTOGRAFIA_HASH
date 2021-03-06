﻿namespace WindowsFormsApp {
    partial class CadastroeLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroeLogin));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbSenhaDigitada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.btVoltarPrincipal = new System.Windows.Forms.Button();
            this.btEncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 63);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(223, 20);
            this.tbEmail.TabIndex = 13;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(74, 29);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(86, 31);
            this.lbEmail.TabIndex = 15;
            this.lbEmail.Text = "Email";
            // 
            // tbSenhaDigitada
            // 
            this.tbSenhaDigitada.Location = new System.Drawing.Point(12, 143);
            this.tbSenhaDigitada.Name = "tbSenhaDigitada";
            this.tbSenhaDigitada.Size = new System.Drawing.Size(223, 20);
            this.tbSenhaDigitada.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Senha";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(12, 183);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(84, 43);
            this.btCadastrar.TabIndex = 22;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(139, 183);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(84, 43);
            this.btLogin.TabIndex = 23;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btVoltarPrincipal
            // 
            this.btVoltarPrincipal.Location = new System.Drawing.Point(676, 12);
            this.btVoltarPrincipal.Name = "btVoltarPrincipal";
            this.btVoltarPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btVoltarPrincipal.TabIndex = 24;
            this.btVoltarPrincipal.Text = "PRINCIPAL";
            this.btVoltarPrincipal.UseVisualStyleBackColor = true;
            this.btVoltarPrincipal.Click += new System.EventHandler(this.btVoltarPrincipal_Click);
            // 
            // btEncerrar
            // 
            this.btEncerrar.Location = new System.Drawing.Point(676, 41);
            this.btEncerrar.Name = "btEncerrar";
            this.btEncerrar.Size = new System.Drawing.Size(75, 23);
            this.btEncerrar.TabIndex = 25;
            this.btEncerrar.Text = "FECHAR";
            this.btEncerrar.UseVisualStyleBackColor = true;
            this.btEncerrar.Click += new System.EventHandler(this.btEncerrar_Click);
            // 
            // CadastroeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.btEncerrar);
            this.Controls.Add(this.btVoltarPrincipal);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSenhaDigitada);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbSenhaDigitada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btVoltarPrincipal;
        private System.Windows.Forms.Button btEncerrar;
    }
}
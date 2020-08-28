namespace DancoDeBados
{
    partial class Logar
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
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(149, 132);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(393, 39);
            this.txt_login.TabIndex = 0;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(149, 215);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(393, 39);
            this.txt_senha.TabIndex = 1;
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(149, 294);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(150, 46);
            this.btn_logar.TabIndex = 2;
            this.btn_logar.Text = "Login";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Location = new System.Drawing.Point(392, 294);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(150, 46);
            this.btn_cadastro.TabIndex = 3;
            this.btn_cadastro.Text = "Cadastrar";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_login);
            this.Name = "Logar";
            this.Text = "Logar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_cadastro;
    }
}
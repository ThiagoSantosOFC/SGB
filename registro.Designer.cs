namespace SGB
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.voltarlink = new System.Windows.Forms.LinkLabel();
            this.username_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.confirmarPassword_txb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password_txb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voltarlink
            // 
            this.voltarlink.AutoSize = true;
            this.voltarlink.Location = new System.Drawing.Point(757, 506);
            this.voltarlink.Name = "voltarlink";
            this.voltarlink.Size = new System.Drawing.Size(123, 18);
            this.voltarlink.TabIndex = 1;
            this.voltarlink.TabStop = true;
            this.voltarlink.Text = "Voltar para o inicio";
            this.voltarlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.voltarlink_LinkClicked);
            // 
            // username_txb
            // 
            this.username_txb.Location = new System.Drawing.Point(301, 191);
            this.username_txb.Name = "username_txb";
            this.username_txb.Size = new System.Drawing.Size(242, 26);
            this.username_txb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 78);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bem-vindo ao registro SGB";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(232, 394);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(379, 106);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Criar conta!";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // confirmarPassword_txb
            // 
            this.confirmarPassword_txb.Location = new System.Drawing.Point(301, 341);
            this.confirmarPassword_txb.Name = "confirmarPassword_txb";
            this.confirmarPassword_txb.Size = new System.Drawing.Size(242, 26);
            this.confirmarPassword_txb.TabIndex = 14;
            this.confirmarPassword_txb.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Confirmar password:";
            // 
            // password_txb
            // 
            this.password_txb.Location = new System.Drawing.Point(301, 291);
            this.password_txb.Name = "password_txb";
            this.password_txb.Size = new System.Drawing.Size(242, 26);
            this.password_txb.TabIndex = 16;
            this.password_txb.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:";
            // 
            // email_txb
            // 
            this.email_txb.Location = new System.Drawing.Point(301, 241);
            this.email_txb.Name = "email_txb";
            this.email_txb.Size = new System.Drawing.Size(242, 26);
            this.email_txb.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email:";
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 540);
            this.Controls.Add(this.email_txb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_txb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmarPassword_txb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.username_txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.voltarlink);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar conta SGB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel voltarlink;
        private TextBox username_txb;
        private Label label2;
        private Label label1;
        private Button btnLogin;
        private TextBox confirmarPassword_txb;
        private Label label5;
        private TextBox password_txb;
        private Label label4;
        private TextBox email_txb;
        private Label label3;
    }
}
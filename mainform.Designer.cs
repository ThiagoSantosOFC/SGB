namespace SGB
{
    partial class mainform
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
            this.datagridLivros = new System.Windows.Forms.DataGridView();
            this.sairConta = new System.Windows.Forms.LinkLabel();
            this.attDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridLivros
            // 
            this.datagridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridLivros.Location = new System.Drawing.Point(12, 9);
            this.datagridLivros.Name = "datagridLivros";
            this.datagridLivros.RowTemplate.Height = 25;
            this.datagridLivros.Size = new System.Drawing.Size(557, 360);
            this.datagridLivros.TabIndex = 0;
            // 
            // sairConta
            // 
            this.sairConta.AutoSize = true;
            this.sairConta.Location = new System.Drawing.Point(635, 9);
            this.sairConta.Name = "sairConta";
            this.sairConta.Size = new System.Drawing.Size(84, 18);
            this.sairConta.TabIndex = 1;
            this.sairConta.TabStop = true;
            this.sairConta.Text = "Fazer logout";
            this.sairConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sairConta_LinkClicked);
            // 
            // attDados
            // 
            this.attDados.Location = new System.Drawing.Point(13, 380);
            this.attDados.Name = "attDados";
            this.attDados.Size = new System.Drawing.Size(149, 53);
            this.attDados.TabIndex = 2;
            this.attDados.Text = "Atualizar dados";
            this.attDados.UseVisualStyleBackColor = true;
            this.attDados.Click += new System.EventHandler(this.attDados_Click);
            // 
            // mainform
            // 
            this.ClientSize = new System.Drawing.Size(741, 504);
            this.Controls.Add(this.attDados);
            this.Controls.Add(this.sairConta);
            this.Controls.Add(this.datagridLivros);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagridLivros;
        private DataGridViewTextBoxColumn id;
        private LinkLabel sairConta;
        private Button attDados;
    }
}
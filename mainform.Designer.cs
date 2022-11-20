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
            this.components = new System.ComponentModel.Container();
            this.datagridLivros = new System.Windows.Forms.DataGridView();
            this.idlivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sairConta = new System.Windows.Forms.LinkLabel();
            this.attDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridLivros
            // 
            this.datagridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlivro,
            this.titulo,
            this.autor,
            this.isbn,
            this.editora,
            this.ano,
            this.categoria});
            this.datagridLivros.Location = new System.Drawing.Point(12, 9);
            this.datagridLivros.Name = "datagridLivros";
            this.datagridLivros.RowTemplate.Height = 25;
            this.datagridLivros.Size = new System.Drawing.Size(741, 360);
            this.datagridLivros.TabIndex = 0;
            this.datagridLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridLivros_CellContentClick);
            // 
            // idlivro
            // 
            this.idlivro.HeaderText = "idlivro";
            this.idlivro.Name = "idlivro";
            // 
            // titulo
            // 
            this.titulo.HeaderText = "titulo";
            this.titulo.Name = "titulo";
            // 
            // autor
            // 
            this.autor.HeaderText = "autor";
            this.autor.Name = "autor";
            // 
            // isbn
            // 
            this.isbn.HeaderText = "isbn";
            this.isbn.Name = "isbn";
            // 
            // editora
            // 
            this.editora.HeaderText = "editora";
            this.editora.Name = "editora";
            // 
            // ano
            // 
            this.ano.HeaderText = "ano";
            this.ano.Name = "ano";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "categoria";
            this.categoria.Name = "categoria";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(biblioteca.models.Book);
            // 
            // sairConta
            // 
            this.sairConta.AutoSize = true;
            this.sairConta.Location = new System.Drawing.Point(771, 9);
            this.sairConta.Name = "sairConta";
            this.sairConta.Size = new System.Drawing.Size(84, 18);
            this.sairConta.TabIndex = 1;
            this.sairConta.TabStop = true;
            this.sairConta.Text = "Fazer logout";
            this.sairConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sairConta_LinkClicked);
            // 
            // attDados
            // 
            this.attDados.Location = new System.Drawing.Point(12, 439);
            this.attDados.Name = "attDados";
            this.attDados.Size = new System.Drawing.Size(149, 53);
            this.attDados.TabIndex = 2;
            this.attDados.Text = "Atualizar dados";
            this.attDados.UseVisualStyleBackColor = true;
            this.attDados.Click += new System.EventHandler(this.attDados_Click);
            // 
            // mainform
            // 
            this.ClientSize = new System.Drawing.Size(867, 504);
            this.Controls.Add(this.attDados);
            this.Controls.Add(this.sairConta);
            this.Controls.Add(this.datagridLivros);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagridLivros;
        private DataGridViewTextBoxColumn id;
        private LinkLabel sairConta;
        private Button attDados;
        private BindingSource bookBindingSource;
        private DataGridViewTextBoxColumn idlivro;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn isbn;
        private DataGridViewTextBoxColumn editora;
        private DataGridViewTextBoxColumn ano;
        private DataGridViewTextBoxColumn categoria;
    }
}
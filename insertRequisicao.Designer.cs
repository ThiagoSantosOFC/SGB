namespace SGB
{
    partial class insertRequisicao
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
            this.bootTitleTxb = new System.Windows.Forms.TextBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bootTitleTxb
            // 
            this.bootTitleTxb.Location = new System.Drawing.Point(22, 52);
            this.bootTitleTxb.Name = "bootTitleTxb";
            this.bootTitleTxb.Size = new System.Drawing.Size(268, 23);
            this.bootTitleTxb.TabIndex = 0;
            this.bootTitleTxb.TextChanged += new System.EventHandler(this.bootTitleTxb_TextChanged);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(22, 94);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(96, 42);
            this.confirm_btn.TabIndex = 1;
            this.confirm_btn.Text = "Confirmar";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(196, 94);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(94, 42);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancelar";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titulo do livro";
            // 
            // insertRequisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.bootTitleTxb);
            this.Name = "insertRequisicao";
            this.Text = "insertRequisicao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox bootTitleTxb;
        private Button confirm_btn;
        private Button cancel_btn;
        private Label label1;
    }
}
namespace SGB
{
    partial class editBooks
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
            this.titleTxb = new System.Windows.Forms.TextBox();
            this.authorTxb = new System.Windows.Forms.TextBox();
            this.isbnTxb = new System.Windows.Forms.TextBox();
            this.publisherTxb = new System.Windows.Forms.TextBox();
            this.yearTxb = new System.Windows.Forms.TextBox();
            this.categoryTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTxb
            // 
            this.titleTxb.Location = new System.Drawing.Point(11, 39);
            this.titleTxb.Name = "titleTxb";
            this.titleTxb.Size = new System.Drawing.Size(234, 23);
            this.titleTxb.TabIndex = 0;
            // 
            // authorTxb
            // 
            this.authorTxb.Location = new System.Drawing.Point(11, 84);
            this.authorTxb.Name = "authorTxb";
            this.authorTxb.Size = new System.Drawing.Size(234, 23);
            this.authorTxb.TabIndex = 1;
            // 
            // isbnTxb
            // 
            this.isbnTxb.Location = new System.Drawing.Point(11, 127);
            this.isbnTxb.Name = "isbnTxb";
            this.isbnTxb.Size = new System.Drawing.Size(234, 23);
            this.isbnTxb.TabIndex = 2;
            // 
            // publisherTxb
            // 
            this.publisherTxb.Location = new System.Drawing.Point(11, 171);
            this.publisherTxb.Name = "publisherTxb";
            this.publisherTxb.Size = new System.Drawing.Size(234, 23);
            this.publisherTxb.TabIndex = 3;
            // 
            // yearTxb
            // 
            this.yearTxb.Location = new System.Drawing.Point(11, 215);
            this.yearTxb.Name = "yearTxb";
            this.yearTxb.Size = new System.Drawing.Size(234, 23);
            this.yearTxb.TabIndex = 4;
            // 
            // categoryTxb
            // 
            this.categoryTxb.Location = new System.Drawing.Point(12, 259);
            this.categoryTxb.Name = "categoryTxb";
            this.categoryTxb.Size = new System.Drawing.Size(234, 23);
            this.categoryTxb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Isbn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Editora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ano";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Categoria";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(11, 303);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(93, 35);
            this.confirm_btn.TabIndex = 13;
            this.confirm_btn.Text = "Confirmar";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(154, 303);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(91, 36);
            this.cancel_btn.TabIndex = 14;
            this.cancel_btn.Text = "Cancelar";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // editBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 349);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryTxb);
            this.Controls.Add(this.yearTxb);
            this.Controls.Add(this.publisherTxb);
            this.Controls.Add(this.isbnTxb);
            this.Controls.Add(this.authorTxb);
            this.Controls.Add(this.titleTxb);
            this.Name = "editBooks";
            this.Text = "editBooks";
            this.Load += new System.EventHandler(this.editBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox titleTxb;
        private TextBox authorTxb;
        private TextBox isbnTxb;
        private TextBox publisherTxb;
        private TextBox yearTxb;
        private TextBox categoryTxb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button confirm_btn;
        private Button cancel_btn;
    }
}
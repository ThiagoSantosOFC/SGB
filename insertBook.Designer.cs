namespace SGB
{
    partial class insertBook
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryTxb = new System.Windows.Forms.TextBox();
            this.yearTxb = new System.Windows.Forms.TextBox();
            this.publisherTxb = new System.Windows.Forms.TextBox();
            this.isbnTxb = new System.Windows.Forms.TextBox();
            this.authorTxb = new System.Windows.Forms.TextBox();
            this.titleTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(167, 294);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(91, 36);
            this.cancel_btn.TabIndex = 28;
            this.cancel_btn.Text = "Cancelar";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(24, 294);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(93, 35);
            this.confirm_btn.TabIndex = 27;
            this.confirm_btn.Text = "Confirmar";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Editora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Isbn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Titulo";
            // 
            // categoryTxb
            // 
            this.categoryTxb.Location = new System.Drawing.Point(25, 250);
            this.categoryTxb.Name = "categoryTxb";
            this.categoryTxb.Size = new System.Drawing.Size(234, 23);
            this.categoryTxb.TabIndex = 20;
            // 
            // yearTxb
            // 
            this.yearTxb.Location = new System.Drawing.Point(24, 206);
            this.yearTxb.Name = "yearTxb";
            this.yearTxb.Size = new System.Drawing.Size(234, 23);
            this.yearTxb.TabIndex = 19;
            // 
            // publisherTxb
            // 
            this.publisherTxb.Location = new System.Drawing.Point(24, 162);
            this.publisherTxb.Name = "publisherTxb";
            this.publisherTxb.Size = new System.Drawing.Size(234, 23);
            this.publisherTxb.TabIndex = 18;
            // 
            // isbnTxb
            // 
            this.isbnTxb.Location = new System.Drawing.Point(24, 118);
            this.isbnTxb.Name = "isbnTxb";
            this.isbnTxb.Size = new System.Drawing.Size(234, 23);
            this.isbnTxb.TabIndex = 17;
            // 
            // authorTxb
            // 
            this.authorTxb.Location = new System.Drawing.Point(24, 75);
            this.authorTxb.Name = "authorTxb";
            this.authorTxb.Size = new System.Drawing.Size(234, 23);
            this.authorTxb.TabIndex = 16;
            // 
            // titleTxb
            // 
            this.titleTxb.Location = new System.Drawing.Point(24, 30);
            this.titleTxb.Name = "titleTxb";
            this.titleTxb.Size = new System.Drawing.Size(234, 23);
            this.titleTxb.TabIndex = 15;
            // 
            // insertBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 340);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryTxb);
            this.Controls.Add(this.yearTxb);
            this.Controls.Add(this.publisherTxb);
            this.Controls.Add(this.isbnTxb);
            this.Controls.Add(this.authorTxb);
            this.Controls.Add(this.titleTxb);
            this.Name = "insertBook";
            this.Text = "insertBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancel_btn;
        private Button confirm_btn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox categoryTxb;
        private TextBox yearTxb;
        private TextBox publisherTxb;
        private TextBox isbnTxb;
        private TextBox authorTxb;
        private TextBox titleTxb;
    }
}
namespace GerenciadorCadastrarPecas.View
{
    partial class Alterar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigopeca = new System.Windows.Forms.TextBox();
            this.txtpeca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcapacidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o código que deseja alterar";
            // 
            // txtcodigopeca
            // 
            this.txtcodigopeca.Location = new System.Drawing.Point(28, 27);
            this.txtcodigopeca.Name = "txtcodigopeca";
            this.txtcodigopeca.Size = new System.Drawing.Size(255, 23);
            this.txtcodigopeca.TabIndex = 1;
            this.txtcodigopeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpeca
            // 
            this.txtpeca.Location = new System.Drawing.Point(28, 199);
            this.txtpeca.Name = "txtpeca";
            this.txtpeca.Size = new System.Drawing.Size(123, 23);
            this.txtpeca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peça";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(28, 257);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(149, 23);
            this.txtmarca.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // txtcapacidade
            // 
            this.txtcapacidade.Location = new System.Drawing.Point(28, 317);
            this.txtcapacidade.Name = "txtcapacidade";
            this.txtcapacidade.Size = new System.Drawing.Size(171, 23);
            this.txtcapacidade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Capacidade";
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnalterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnalterar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnalterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnalterar.Location = new System.Drawing.Point(12, 364);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(290, 42);
            this.btnalterar.TabIndex = 8;
            this.btnalterar.Text = "Alterar Dados";
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(98, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(28, 149);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(84, 23);
            this.txtcodigo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código";
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 418);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.txtcapacidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpeca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigopeca);
            this.Controls.Add(this.label1);
            this.Name = "Alterar";
            this.Text = "Alterar";
            this.Load += new System.EventHandler(this.Alterar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtcodigopeca;
        private TextBox txtpeca;
        private Label label2;
        private TextBox txtmarca;
        private Label label3;
        private TextBox txtcapacidade;
        private Label label4;
        private Button btnalterar;
        private Button button2;
        private TextBox txtcodigo;
        private Label label5;
    }
}
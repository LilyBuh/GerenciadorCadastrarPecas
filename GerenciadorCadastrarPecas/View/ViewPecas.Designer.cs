namespace GerenciadorCadastrarPecas.View
{
    partial class ViewPecas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpeca = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtcapacidade = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peça";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidade";
            // 
            // txtpeca
            // 
            this.txtpeca.Location = new System.Drawing.Point(36, 107);
            this.txtpeca.Name = "txtpeca";
            this.txtpeca.Size = new System.Drawing.Size(144, 23);
            this.txtpeca.TabIndex = 4;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(36, 172);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(144, 23);
            this.txtmarca.TabIndex = 5;
            // 
            // txtcapacidade
            // 
            this.txtcapacidade.Location = new System.Drawing.Point(36, 239);
            this.txtcapacidade.Name = "txtcapacidade";
            this.txtcapacidade.Size = new System.Drawing.Size(144, 23);
            this.txtcapacidade.TabIndex = 6;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncadastrar.Location = new System.Drawing.Point(12, 304);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(358, 35);
            this.btncadastrar.TabIndex = 7;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // ViewPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 351);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtcapacidade);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtpeca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewPecas";
            this.Text = "ViewPecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtpeca;
        private TextBox txtmarca;
        private TextBox txtcapacidade;
        private Button btncadastrar;
    }
}
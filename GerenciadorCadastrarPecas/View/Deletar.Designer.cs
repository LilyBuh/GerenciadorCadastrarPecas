namespace GerenciadorCadastrarPecas.View
{
    partial class Deletar
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
            this.btndeletar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o código da peça que deseja deletar";
            // 
            // txtcodigopeca
            // 
            this.txtcodigopeca.Location = new System.Drawing.Point(47, 27);
            this.txtcodigopeca.Name = "txtcodigopeca";
            this.txtcodigopeca.Size = new System.Drawing.Size(273, 23);
            this.txtcodigopeca.TabIndex = 1;
            this.txtcodigopeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpeca
            // 
            this.txtpeca.Location = new System.Drawing.Point(3, 114);
            this.txtpeca.Name = "txtpeca";
            this.txtpeca.Size = new System.Drawing.Size(135, 23);
            this.txtpeca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peça";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(3, 171);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(135, 23);
            this.txtmarca.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // txtcapacidade
            // 
            this.txtcapacidade.Location = new System.Drawing.Point(221, 171);
            this.txtcapacidade.Name = "txtcapacidade";
            this.txtcapacidade.Size = new System.Drawing.Size(137, 23);
            this.txtcapacidade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(221, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Capacidade";
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeletar.Location = new System.Drawing.Point(12, 268);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(336, 41);
            this.btndeletar.TabIndex = 8;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(221, 114);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(135, 23);
            this.txtcodigo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(221, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Código";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.Location = new System.Drawing.Point(130, 54);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(103, 23);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Deletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 351);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.txtcapacidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpeca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigopeca);
            this.Controls.Add(this.label1);
            this.Name = "Deletar";
            this.Text = "Deletar";
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
        private Button btndeletar;
        private TextBox txtcodigo;
        private Label label5;
        private Button btnbuscar;
    }
}
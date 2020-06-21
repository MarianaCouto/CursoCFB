namespace Componentes
{
    partial class F_Combobox
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_resetarElementos = new System.Windows.Forms.Button();
            this.btn_adicionarTransporte = new System.Windows.Forms.Button();
            this.tb_transporte = new System.Windows.Forms.TextBox();
            this.btn_limparElementos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 13);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(200, 21);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionado
            // 
            this.btn_mostrarSelecionado.Location = new System.Drawing.Point(220, 13);
            this.btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
            this.btn_mostrarSelecionado.Size = new System.Drawing.Size(220, 30);
            this.btn_mostrarSelecionado.TabIndex = 1;
            this.btn_mostrarSelecionado.Text = "Mostrar Selecionado";
            this.btn_mostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionado.Click += new System.EventHandler(this.btn_mostrarSelecionado_Click);
            // 
            // btn_resetarElementos
            // 
            this.btn_resetarElementos.Location = new System.Drawing.Point(220, 86);
            this.btn_resetarElementos.Name = "btn_resetarElementos";
            this.btn_resetarElementos.Size = new System.Drawing.Size(220, 30);
            this.btn_resetarElementos.TabIndex = 3;
            this.btn_resetarElementos.Text = "Resetar Elementos";
            this.btn_resetarElementos.UseVisualStyleBackColor = true;
            this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
            // 
            // btn_adicionarTransporte
            // 
            this.btn_adicionarTransporte.Location = new System.Drawing.Point(219, 198);
            this.btn_adicionarTransporte.Name = "btn_adicionarTransporte";
            this.btn_adicionarTransporte.Size = new System.Drawing.Size(220, 30);
            this.btn_adicionarTransporte.TabIndex = 4;
            this.btn_adicionarTransporte.Text = "Adicionar Transporte";
            this.btn_adicionarTransporte.UseVisualStyleBackColor = true;
            this.btn_adicionarTransporte.Click += new System.EventHandler(this.btn_adicionarTransporte_Click);
            // 
            // tb_transporte
            // 
            this.tb_transporte.Location = new System.Drawing.Point(219, 172);
            this.tb_transporte.Name = "tb_transporte";
            this.tb_transporte.Size = new System.Drawing.Size(220, 20);
            this.tb_transporte.TabIndex = 5;
            // 
            // btn_limparElementos
            // 
            this.btn_limparElementos.Location = new System.Drawing.Point(219, 50);
            this.btn_limparElementos.Name = "btn_limparElementos";
            this.btn_limparElementos.Size = new System.Drawing.Size(220, 30);
            this.btn_limparElementos.TabIndex = 6;
            this.btn_limparElementos.Text = "Limpar Elementos";
            this.btn_limparElementos.UseVisualStyleBackColor = true;
            this.btn_limparElementos.Click += new System.EventHandler(this.btn_limparElementos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite um novo transporte:";
            // 
            // F_Combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limparElementos);
            this.Controls.Add(this.tb_transporte);
            this.Controls.Add(this.btn_adicionarTransporte);
            this.Controls.Add(this.btn_resetarElementos);
            this.Controls.Add(this.btn_mostrarSelecionado);
            this.Controls.Add(this.cb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_Combobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionado;
        private System.Windows.Forms.Button btn_resetarElementos;
        private System.Windows.Forms.Button btn_adicionarTransporte;
        private System.Windows.Forms.TextBox tb_transporte;
        private System.Windows.Forms.Button btn_limparElementos;
        private System.Windows.Forms.Label label1;
    }
}
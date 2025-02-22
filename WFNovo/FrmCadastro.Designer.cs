namespace WFNovo
{
    partial class FrmCadastro
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
            lblTop = new Label();
            lblNome = new Label();
            lblEndereco = new Label();
            lblBairro = new Label();
            lblEstado = new Label();
            lblTel = new Label();
            lblCel = new Label();
            lblEmail = new Label();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            cbxEstado = new ComboBox();
            txtTel = new TextBox();
            txtCel = new TextBox();
            txtEmail = new TextBox();
            btnCadastro = new Button();
            btnNewCadastro = new Button();
            btnVerCadastro = new Button();
            SuspendLayout();
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop.Location = new Point(21, 25);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(367, 26);
            lblTop.TabIndex = 0;
            lblTop.Text = "Preencha os campos e clique em Gravar Dados";
            lblTop.Click += label1_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblNome.Location = new Point(45, 85);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(51, 23);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            lblNome.Click += label2_Click;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblEndereco.Location = new Point(45, 119);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(76, 23);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereço:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblBairro.Location = new Point(45, 156);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(57, 23);
            lblBairro.TabIndex = 3;
            lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblEstado.Location = new Point(45, 193);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(58, 23);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblTel.Location = new Point(45, 232);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(69, 23);
            lblTel.TabIndex = 5;
            lblTel.Text = "Telefone:";
            // 
            // lblCel
            // 
            lblCel.AutoSize = true;
            lblCel.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblCel.Location = new Point(45, 267);
            lblCel.Name = "lblCel";
            lblCel.Size = new Size(61, 23);
            lblCel.TabIndex = 6;
            lblCel.Text = "Celular:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblEmail.Location = new Point(45, 309);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 23);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(149, 85);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 8;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(149, 119);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(100, 23);
            txtEndereco.TabIndex = 9;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(149, 156);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 10;
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "ES", "MG", "RJ", "SP" });
            cbxEstado.Location = new Point(149, 193);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 23);
            cbxEstado.TabIndex = 11;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(149, 232);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(100, 23);
            txtTel.TabIndex = 12;
            // 
            // txtCel
            // 
            txtCel.Location = new Point(149, 267);
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(100, 23);
            txtCel.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 309);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 14;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(45, 366);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(102, 41);
            btnCadastro.TabIndex = 15;
            btnCadastro.Text = "Gravar Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            // 
            // btnNewCadastro
            // 
            btnNewCadastro.Location = new Point(170, 366);
            btnNewCadastro.Name = "btnNewCadastro";
            btnNewCadastro.Size = new Size(103, 41);
            btnNewCadastro.TabIndex = 16;
            btnNewCadastro.Text = "Novo Cadastro";
            btnNewCadastro.UseVisualStyleBackColor = true;
            // 
            // btnVerCadastro
            // 
            btnVerCadastro.Location = new Point(295, 366);
            btnVerCadastro.Name = "btnVerCadastro";
            btnVerCadastro.Size = new Size(103, 41);
            btnVerCadastro.TabIndex = 17;
            btnVerCadastro.Text = "Ver Contatos";
            btnVerCadastro.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 439);
            Controls.Add(btnVerCadastro);
            Controls.Add(btnNewCadastro);
            Controls.Add(btnCadastro);
            Controls.Add(txtEmail);
            Controls.Add(txtCel);
            Controls.Add(txtTel);
            Controls.Add(cbxEstado);
            Controls.Add(txtBairro);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(lblEmail);
            Controls.Add(lblCel);
            Controls.Add(lblTel);
            Controls.Add(lblEstado);
            Controls.Add(lblBairro);
            Controls.Add(lblEndereco);
            Controls.Add(lblNome);
            Controls.Add(lblTop);
            Name = "FrmCadastro";
            Text = "Cadastro de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTop;
        private Label lblNome;
        private Label lblEndereco;
        private Label lblBairro;
        private Label lblEstado;
        private Label lblTel;
        private Label lblCel;
        private Label lblEmail;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private ComboBox cbxEstado;
        private TextBox txtTel;
        private TextBox txtCel;
        private TextBox txtEmail;
        private Button btnCadastro;
        private Button btnNewCadastro;
        private Button btnVerCadastro;
    }
}
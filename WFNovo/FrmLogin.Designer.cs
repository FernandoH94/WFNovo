namespace WFNovo
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            btnCliqueAqui = new Button();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(37, 46);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(99, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Username:";
            // 
            // btnCliqueAqui
            // 
            btnCliqueAqui.Location = new Point(169, 128);
            btnCliqueAqui.Name = "btnCliqueAqui";
            btnCliqueAqui.Size = new Size(75, 23);
            btnCliqueAqui.TabIndex = 1;
            btnCliqueAqui.Text = "Login";
            btnCliqueAqui.UseVisualStyleBackColor = true;
            btnCliqueAqui.Click += btnLogar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 91);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 2;
            label1.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(160, 43);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(139, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(139, 23);
            txtPassword.TabIndex = 4;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 194);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(btnCliqueAqui);
            Controls.Add(lblNome);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Button btnCliqueAqui;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}

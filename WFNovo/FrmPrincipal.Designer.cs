namespace WFNovo
{
    partial class FrmPrincipal
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
            btnLogor = new Button();
            SuspendLayout();
            // 
            // btnLogor
            // 
            btnLogor.Location = new Point(488, 12);
            btnLogor.Name = "btnLogor";
            btnLogor.Size = new Size(117, 42);
            btnLogor.TabIndex = 0;
            btnLogor.Text = "Logar";
            btnLogor.UseVisualStyleBackColor = true;
            btnLogor.Click += btnLogor_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 379);
            Controls.Add(btnLogor);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogor;
    }
}
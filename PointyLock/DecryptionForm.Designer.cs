namespace PointyLock
{
    partial class DecryptionForm
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
            enterPasswordLbl = new Label();
            decryptPasswordTextBx = new TextBox();
            decryptBtn = new Button();
            decryptCancelBtn = new Button();
            SuspendLayout();
            // 
            // enterPasswordLbl
            // 
            enterPasswordLbl.AutoSize = true;
            enterPasswordLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterPasswordLbl.ForeColor = SystemColors.Control;
            enterPasswordLbl.Location = new Point(12, 9);
            enterPasswordLbl.Name = "enterPasswordLbl";
            enterPasswordLbl.Size = new Size(153, 30);
            enterPasswordLbl.TabIndex = 0;
            enterPasswordLbl.Text = "Enter Password";
            // 
            // decryptPasswordTextBx
            // 
            decryptPasswordTextBx.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            decryptPasswordTextBx.Location = new Point(12, 53);
            decryptPasswordTextBx.Name = "decryptPasswordTextBx";
            decryptPasswordTextBx.PlaceholderText = "Enter password";
            decryptPasswordTextBx.Size = new Size(399, 25);
            decryptPasswordTextBx.TabIndex = 1;
            decryptPasswordTextBx.UseSystemPasswordChar = true;
            // 
            // decryptBtn
            // 
            decryptBtn.Location = new Point(12, 105);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(84, 29);
            decryptBtn.TabIndex = 2;
            decryptBtn.Text = "Decrypt";
            decryptBtn.UseVisualStyleBackColor = true;
            // 
            // decryptCancelBtn
            // 
            decryptCancelBtn.Location = new Point(327, 105);
            decryptCancelBtn.Name = "decryptCancelBtn";
            decryptCancelBtn.Size = new Size(84, 29);
            decryptCancelBtn.TabIndex = 3;
            decryptCancelBtn.Text = "Cancel";
            decryptCancelBtn.UseVisualStyleBackColor = true;
            decryptCancelBtn.Click += decryptCancelBtn_Click;
            // 
            // DecryptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(423, 146);
            Controls.Add(decryptCancelBtn);
            Controls.Add(decryptBtn);
            Controls.Add(decryptPasswordTextBx);
            Controls.Add(enterPasswordLbl);
            Name = "DecryptionForm";
            Text = "PointyLock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enterPasswordLbl;
        private TextBox decryptPasswordTextBx;
        private Button decryptBtn;
        private Button decryptCancelBtn;
    }
}
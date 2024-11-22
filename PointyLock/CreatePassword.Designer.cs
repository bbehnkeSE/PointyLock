namespace PointyLock
{
    partial class CreatePassword
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
            passwordTextBx = new TextBox();
            passwordConfirmTextBx = new TextBox();
            passwordConfirmBtn = new Button();
            passwordConfirmCancelBtn = new Button();
            createPasswordLbl = new Label();
            SuspendLayout();
            // 
            // passwordTextBx
            // 
            passwordTextBx.Location = new Point(12, 52);
            passwordTextBx.Name = "passwordTextBx";
            passwordTextBx.PlaceholderText = "Enter a password";
            passwordTextBx.Size = new Size(399, 25);
            passwordTextBx.TabIndex = 0;
            passwordTextBx.UseSystemPasswordChar = true;
            // 
            // passwordConfirmTextBx
            // 
            passwordConfirmTextBx.Location = new Point(12, 94);
            passwordConfirmTextBx.Name = "passwordConfirmTextBx";
            passwordConfirmTextBx.PlaceholderText = "Confirm password";
            passwordConfirmTextBx.Size = new Size(399, 25);
            passwordConfirmTextBx.TabIndex = 1;
            passwordConfirmTextBx.UseSystemPasswordChar = true;
            // 
            // passwordConfirmBtn
            // 
            passwordConfirmBtn.Location = new Point(12, 139);
            passwordConfirmBtn.Name = "passwordConfirmBtn";
            passwordConfirmBtn.Size = new Size(84, 29);
            passwordConfirmBtn.TabIndex = 2;
            passwordConfirmBtn.Text = "Encrypt";
            passwordConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // passwordConfirmCancelBtn
            // 
            passwordConfirmCancelBtn.Location = new Point(327, 139);
            passwordConfirmCancelBtn.Name = "passwordConfirmCancelBtn";
            passwordConfirmCancelBtn.Size = new Size(84, 29);
            passwordConfirmCancelBtn.TabIndex = 3;
            passwordConfirmCancelBtn.Text = "Cancel";
            passwordConfirmCancelBtn.UseVisualStyleBackColor = true;
            passwordConfirmCancelBtn.Click += passwordConfirmCancelBtn_Click;
            // 
            // createPasswordLbl
            // 
            createPasswordLbl.AutoSize = true;
            createPasswordLbl.BackColor = SystemColors.ControlDarkDark;
            createPasswordLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPasswordLbl.ForeColor = SystemColors.Control;
            createPasswordLbl.Location = new Point(12, 9);
            createPasswordLbl.Name = "createPasswordLbl";
            createPasswordLbl.Size = new Size(165, 30);
            createPasswordLbl.TabIndex = 4;
            createPasswordLbl.Text = "Create Password";
            // 
            // CreatePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(423, 180);
            Controls.Add(createPasswordLbl);
            Controls.Add(passwordConfirmCancelBtn);
            Controls.Add(passwordConfirmBtn);
            Controls.Add(passwordConfirmTextBx);
            Controls.Add(passwordTextBx);
            Font = new Font("Segoe UI", 10F);
            Name = "CreatePassword";
            Text = "PointyLock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBx;
        private TextBox passwordConfirmTextBx;
        private Button passwordConfirmBtn;
        private Button passwordConfirmCancelBtn;
        private Label createPasswordLbl;
    }
}
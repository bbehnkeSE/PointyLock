namespace PointyLock
{
    partial class PointyLock
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
            dirPathBx = new TextBox();
            addBtn = new Button();
            browseBtn = new Button();
            fileListBx = new ListBox();
            encryptBtn = new Button();
            decryptBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // dirPathBx
            // 
            dirPathBx.AcceptsReturn = true;
            dirPathBx.Location = new Point(12, 12);
            dirPathBx.Name = "dirPathBx";
            dirPathBx.PlaceholderText = "Enter path to a file or directory";
            dirPathBx.Size = new Size(443, 29);
            dirPathBx.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.AutoSize = true;
            addBtn.Location = new Point(12, 47);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(108, 31);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(351, 48);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(104, 30);
            browseBtn.TabIndex = 2;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            // 
            // fileListBx
            // 
            fileListBx.BackColor = SystemColors.ScrollBar;
            fileListBx.FormattingEnabled = true;
            fileListBx.ItemHeight = 21;
            fileListBx.Location = new Point(12, 105);
            fileListBx.Name = "fileListBx";
            fileListBx.Size = new Size(443, 403);
            fileListBx.TabIndex = 3;
            // 
            // encryptBtn
            // 
            encryptBtn.Location = new Point(12, 514);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(108, 31);
            encryptBtn.TabIndex = 4;
            encryptBtn.Text = "Encrypt";
            encryptBtn.UseVisualStyleBackColor = true;
            // 
            // decryptBtn
            // 
            decryptBtn.Location = new Point(351, 514);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(104, 31);
            decryptBtn.TabIndex = 5;
            decryptBtn.Text = "Decrypt";
            decryptBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(443, 2);
            label1.TabIndex = 6;
            // 
            // PointyLock
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(467, 556);
            Controls.Add(label1);
            Controls.Add(decryptBtn);
            Controls.Add(encryptBtn);
            Controls.Add(fileListBx);
            Controls.Add(browseBtn);
            Controls.Add(addBtn);
            Controls.Add(dirPathBx);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "PointyLock";
            Text = "PointyLock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dirPathBx;
        private Button addBtn;
        private Button browseBtn;
        private ListBox fileListBx;
        private Button encryptBtn;
        private Button decryptBtn;
        private Label label1;
    }
}

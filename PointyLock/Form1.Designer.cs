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
            dirPathBx.Location = new Point(9, 10);
            dirPathBx.Margin = new Padding(2);
            dirPathBx.Name = "dirPathBx";
            dirPathBx.PlaceholderText = "Enter path to a file or directory";
            dirPathBx.Size = new Size(345, 25);
            dirPathBx.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.AutoSize = true;
            addBtn.Location = new Point(9, 38);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(84, 29);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(273, 39);
            browseBtn.Margin = new Padding(2);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(81, 28);
            browseBtn.TabIndex = 2;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // fileListBx
            // 
            fileListBx.AllowDrop = true;
            fileListBx.BackColor = SystemColors.ScrollBar;
            fileListBx.ForeColor = SystemColors.WindowText;
            fileListBx.FormattingEnabled = true;
            fileListBx.HorizontalScrollbar = true;
            fileListBx.ItemHeight = 17;
            fileListBx.Location = new Point(9, 85);
            fileListBx.Margin = new Padding(2);
            fileListBx.Name = "fileListBx";
            fileListBx.RightToLeft = RightToLeft.No;
            fileListBx.Size = new Size(345, 327);
            fileListBx.TabIndex = 3;
            fileListBx.Click += fileListBx_Click;
            fileListBx.DragDrop += fileListBx_DragDrop;
            fileListBx.DragEnter += fileListBx_DragEnter;
            fileListBx.DragLeave += fileListBx_DragLeave;
            // 
            // encryptBtn
            // 
            encryptBtn.Location = new Point(11, 416);
            encryptBtn.Margin = new Padding(2);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(84, 29);
            encryptBtn.TabIndex = 4;
            encryptBtn.Text = "Encrypt";
            encryptBtn.UseVisualStyleBackColor = true;
            encryptBtn.Click += encryptBtn_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Location = new Point(273, 416);
            decryptBtn.Margin = new Padding(2);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(81, 29);
            decryptBtn.TabIndex = 5;
            decryptBtn.Text = "Decrypt";
            decryptBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(9, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(345, 2);
            label1.TabIndex = 6;
            // 
            // PointyLock
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(363, 450);
            Controls.Add(label1);
            Controls.Add(decryptBtn);
            Controls.Add(encryptBtn);
            Controls.Add(fileListBx);
            Controls.Add(browseBtn);
            Controls.Add(addBtn);
            Controls.Add(dirPathBx);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
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

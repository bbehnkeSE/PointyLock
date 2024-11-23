using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointyLock
{
    public partial class CreatePassword : Form
    {
        public CreatePassword()
        {
            InitializeComponent();
        }

        private void passwordConfirmCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordConfirmBtn_Click(object sender, EventArgs e)
        {
            if (passwordTextBx.Text != passwordConfirmTextBx.Text)
            {
                return;
            }
            byte[] hash = Encrypt.HashPassword(passwordTextBx.Text);
            System.Diagnostics.Debug.WriteLine(Convert.ToHexString(hash));

            foreach (string path in PointyLock.dirList)
            {
                if (Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        Encrypt.EncryptPath(file);
                    }
                }
                else if (File.Exists(path))
                {
                    Encrypt.EncryptPath(path);
                }
                else
                    return;

            }
        }
    }
}

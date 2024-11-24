using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointyLock
{
    public partial class DecryptionForm : Form
    {
        public DecryptionForm()
        {
            InitializeComponent();
        }

        private void decryptCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            byte[] hash = Encrypt.HashPassword(decryptPasswordTextBx.Text);
            System.Diagnostics.Debug.WriteLine(Convert.ToHexString(hash));
            System.Diagnostics.Debug.WriteLine(hash.Length);

            foreach (string path in PointyLock.dirList)
            {
                if (Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        Encrypt.DecryptFile(file, hash);
                    }
                }
                else if (File.Exists(path))
                {
                    Encrypt.DecryptFile(path, hash);
                }
                else
                    return;
            }
        }
    }
}

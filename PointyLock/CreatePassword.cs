using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
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
            if (passwordTextBx.Text == passwordConfirmTextBx.Text)
            {
                byte[] hash = Encrypt.HashPassword(passwordTextBx.Text);
                System.Diagnostics.Debug.WriteLine(Convert.ToHexString(hash));
            }
        }
    }
}

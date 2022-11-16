using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passBox.AutoSize = false;
            this.passBox.Size = new Size(this.passBox.Size.Width, this.loginBox.Size.Height);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            User user = new User(loginBox.Text, passBox.Text);
            user.LoginUser();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event.Views
{
    public partial class WelcomeView : Form
    {
        public WelcomeView()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginView form = new LoginView();
            form.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterView form = new RegisterView();
            form.Show();
        }
    }
}

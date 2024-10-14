using System;
using System.Windows.Forms;

namespace ph
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement authentication logic
            // For now, let's just open the EmployeeForm
            if (usernameTextBox.Text == "employee" && passwordTextBox.Text == "password"){
                this.Hide();
                Form1 form1 = new Form1("Employee");
                form1.Show();
            }else if (usernameTextBox.Text == "manager" && passwordTextBox.Text == "password"){
                this.Hide();
                Form1 form1 = new Form1("Project Manager");
                form1.Show();
            }else{
                MessageBox.Show("Login creditials may be incorrect!");
            }
        }
    }
}

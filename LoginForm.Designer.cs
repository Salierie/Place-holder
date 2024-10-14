namespace ph
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.usernameTextBox = new TextBox();
            this.passwordTextBox = new TextBox();
            this.loginButton = new Button();

            // Username TextBox
            this.usernameTextBox.Location = new System.Drawing.Point(100, 50);
            this.usernameTextBox.Size = new System.Drawing.Size(200, 30);
            this.usernameTextBox.PlaceholderText = "Username";

            // Password TextBox
            this.passwordTextBox.Location = new System.Drawing.Point(100, 100);
            this.passwordTextBox.Size = new System.Drawing.Size(200, 30);
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.UseSystemPasswordChar = true;

            // Login Button
            this.loginButton.Text = "Login";
            this.loginButton.Location = new System.Drawing.Point(100, 150);
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);

            // LoginForm Properties
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginButton);
            this.Text = "Login";
        }
    }
}

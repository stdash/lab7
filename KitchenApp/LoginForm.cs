namespace KitchenApp
{
    public partial class LoginForm : Form
    {
        private TextBox phoneTextBox;
        private Button getCodeButton;
        private TextBox codeTextBox;
        private Button clientLoginButton;

        // Staff Login Controls
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button staffLoginButton;
        private LinkLabel staffRegisterLink;
        private LinkLabel staffForgotPassword;
        public LoginForm()
        {
            InitializeComponent();
            loginPanel.Visible = false; 
        }
        private void clientButton_Click(object sender, EventArgs e)
        {
            ShowClientLogin();    
        }

        private void stuffButton_Click(object sender, EventArgs e)
        {
            ShowStuffLogin();
        }

        private void ShowClientLogin()
        {
            ClearControls();

            phoneTextBox = new TextBox { Width = 200, Height = 40, PlaceholderText = "Введите номер телефона" };
            getCodeButton = new Button { Text = "Получить код", Height = 40, Width = 200 };
            codeTextBox = new TextBox { Width = 200, Height = 40, PlaceholderText = "Введите код" };
            clientLoginButton = new Button { Text = "Войти", Height = 40, Width = 200 };

            clientLoginButton.Click += ClientLoginButton_Click;

            loginPanel.Controls.Add(phoneTextBox);
            loginPanel.Controls.Add(getCodeButton);
            loginPanel.Controls.Add(codeTextBox);
            loginPanel.Controls.Add(clientLoginButton);

            phoneTextBox.Location = new Point(500, 10);
            getCodeButton.Location = new Point(500, 40);
            codeTextBox.Location = new Point(500, 90);
            clientLoginButton.Location = new Point(500, 120);

            loginPanel.Visible = true;
        }
        private void ShowStuffLogin()
        {
            ClearControls(); 

            usernameTextBox = new TextBox { Width = 200, PlaceholderText = "username" };
            passwordTextBox = new TextBox { Width = 200, UseSystemPasswordChar = true, PlaceholderText = "Пароль" };
            staffLoginButton = new Button { Text = "Войти", Width = 200, Height = 40, };
            staffRegisterLink = new LinkLabel { Text = "Регистрация", ActiveLinkColor = Color.Orange, Width = 200, Height = 40 };
            staffForgotPassword = new LinkLabel { Text = "Забыли пароль?", ActiveLinkColor = Color.Orange, Width = 200, Height = 40 };

            staffLoginButton.Click += StaffLoginButton_Click;

            loginPanel.Controls.Add(usernameTextBox);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(staffLoginButton);
            loginPanel.Controls.Add(staffRegisterLink);
            loginPanel.Controls.Add(staffForgotPassword);

            usernameTextBox.Location = new Point(500, 10);
            passwordTextBox.Location = new Point(500, 50);
            staffLoginButton.Location = new Point(500, 90);
            staffRegisterLink.Location = new Point(543, 150);
            staffForgotPassword.Location = new Point(530, 190);

            loginPanel.Visible = true;
        }

        private void ClearControls()
        {
            loginPanel.Controls.Clear();
        }
        private void ClientLoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Client Login Clicked!"); 
        }

        private void StaffLoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff Login Clicked!"); 
        }
    }
}

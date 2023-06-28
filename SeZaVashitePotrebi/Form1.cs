namespace SeZaVashitePotrebi
{
    public partial class Form1 : Form
    {

        private List<User> registeredUsers = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsernameInput.Text;
            string password = txtPasswordInput.Text;
            string email = txtEmailInput.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (registeredUsers.Any(user => user.Username == username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User
            {
                Username = username,
                Email = email,
                Password = password
            };

            registeredUsers.Add(user);

            MessageBox.Show("Registration successful!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUsernameInput.Clear();
            txtPasswordInput.Clear();
            txtEmailInput.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameInput.Text;
            string password = txtPasswordInput.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the user exists
            User user = registeredUsers.FirstOrDefault(u => u.Username == username);

            if (user == null || user.Password != password)
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the login form
            txtUsernameInput.Clear();
            txtPasswordInput.Clear();
        }
    }
}
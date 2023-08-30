# SeZaVashitePotrebi

Windows Forms App that allows you as an User to login and buy or rent some of the items that are listed on the App. 


## 1. Window Form App Architecture
	- Classes
		- AppUser
		- Item
	- Forms
		- Form1 (Main Form)
		- LoginForm
		- RegisterForm
		- MyAccountForm
		- CartForm
		- PostItemForm
		- ItemDetailsForm
	- ItemDisplayControl
## 2. Quick Function Tutorial
```cs btnLogIn_Click Function
private void btnLogIn_Click(object sender, EventArgs e)
{
    string username = tbUserName.Text;
    string password = tbPassword.Text;

    if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
    {
        MessageBox.Show("Please enter your username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Check if the user exists
    user = users.FirstOrDefault(u => u.Username == username);

    if (user == null || user.Password != password)
    {
        MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    MessageBox.Show("Login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

    this.DialogResult = DialogResult.OK;
}
```
```cs I'm tab B
console.log('Code Tab B');
```


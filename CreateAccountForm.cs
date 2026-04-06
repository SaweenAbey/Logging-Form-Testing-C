namespace WinFormsApp1;

public partial class CreateAccountForm : Form
{
    private readonly StudentRepository _repository;

    public CreateAccountForm(StudentRepository repository)
    {
        InitializeComponent();
        _repository = repository;
        StartPosition = FormStartPosition.CenterParent;
    }

    private void CreateAccountForm_Load(object sender, EventArgs e)
    {
        txtNewUsername.Focus();
    }

    private void btnClearAccount_Click(object sender, EventArgs e)
    {
        txtNewUsername.Clear();
        txtNewPassword.Clear();
        txtConfirmPassword.Clear();
        txtNewUsername.Focus();
    }

    private void btnCancelAccount_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnCreateUser_Click(object sender, EventArgs e)
    {
        var username = txtNewUsername.Text.Trim();
        var password = txtNewPassword.Text;
        var confirmPassword = txtConfirmPassword.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Username and Password are required.", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!string.Equals(password, confirmPassword, StringComparison.Ordinal))
        {
            MessageBox.Show("Password and Confirm Password do not match.", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_repository.UserExists(username))
        {
            MessageBox.Show("Username already exists. Please choose another username.", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _repository.CreateUser(username, password);

        MessageBox.Show("Account created successfully.", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DialogResult = DialogResult.OK;
        Close();
    }
}

namespace WinFormsApp1;

partial class CreateAccountForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblCreateTitle = new Label();
        lblNewUsername = new Label();
        lblNewPassword = new Label();
        lblConfirmPassword = new Label();
        txtNewUsername = new TextBox();
        txtNewPassword = new TextBox();
        txtConfirmPassword = new TextBox();
        btnCreateUser = new Button();
        btnClearAccount = new Button();
        btnCancelAccount = new Button();
        SuspendLayout();
        // 
        // lblCreateTitle
        // 
        lblCreateTitle.AutoSize = true;
        lblCreateTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblCreateTitle.Location = new Point(92, 18);
        lblCreateTitle.Name = "lblCreateTitle";
        lblCreateTitle.Size = new Size(166, 30);
        lblCreateTitle.TabIndex = 0;
        lblCreateTitle.Text = "Create Account";
        // 
        // lblNewUsername
        // 
        lblNewUsername.AutoSize = true;
        lblNewUsername.Location = new Point(30, 78);
        lblNewUsername.Name = "lblNewUsername";
        lblNewUsername.Size = new Size(92, 15);
        lblNewUsername.TabIndex = 1;
        lblNewUsername.Text = "New Username";
        // 
        // lblNewPassword
        // 
        lblNewPassword.AutoSize = true;
        lblNewPassword.Location = new Point(30, 117);
        lblNewPassword.Name = "lblNewPassword";
        lblNewPassword.Size = new Size(86, 15);
        lblNewPassword.TabIndex = 2;
        lblNewPassword.Text = "New Password";
        // 
        // lblConfirmPassword
        // 
        lblConfirmPassword.AutoSize = true;
        lblConfirmPassword.Location = new Point(30, 156);
        lblConfirmPassword.Name = "lblConfirmPassword";
        lblConfirmPassword.Size = new Size(103, 15);
        lblConfirmPassword.TabIndex = 3;
        lblConfirmPassword.Text = "Confirm Password";
        // 
        // txtNewUsername
        // 
        txtNewUsername.Location = new Point(149, 75);
        txtNewUsername.Name = "txtNewUsername";
        txtNewUsername.Size = new Size(182, 23);
        txtNewUsername.TabIndex = 4;
        // 
        // txtNewPassword
        // 
        txtNewPassword.Location = new Point(149, 114);
        txtNewPassword.Name = "txtNewPassword";
        txtNewPassword.PasswordChar = '*';
        txtNewPassword.Size = new Size(182, 23);
        txtNewPassword.TabIndex = 5;
        // 
        // txtConfirmPassword
        // 
        txtConfirmPassword.Location = new Point(149, 153);
        txtConfirmPassword.Name = "txtConfirmPassword";
        txtConfirmPassword.PasswordChar = '*';
        txtConfirmPassword.Size = new Size(182, 23);
        txtConfirmPassword.TabIndex = 6;
        // 
        // btnCreateUser
        // 
        btnCreateUser.Location = new Point(30, 202);
        btnCreateUser.Name = "btnCreateUser";
        btnCreateUser.Size = new Size(95, 32);
        btnCreateUser.TabIndex = 7;
        btnCreateUser.Text = "Create";
        btnCreateUser.UseVisualStyleBackColor = true;
        btnCreateUser.Click += btnCreateUser_Click;
        // 
        // btnClearAccount
        // 
        btnClearAccount.Location = new Point(142, 202);
        btnClearAccount.Name = "btnClearAccount";
        btnClearAccount.Size = new Size(95, 32);
        btnClearAccount.TabIndex = 8;
        btnClearAccount.Text = "Clear";
        btnClearAccount.UseVisualStyleBackColor = true;
        btnClearAccount.Click += btnClearAccount_Click;
        // 
        // btnCancelAccount
        // 
        btnCancelAccount.Location = new Point(253, 202);
        btnCancelAccount.Name = "btnCancelAccount";
        btnCancelAccount.Size = new Size(95, 32);
        btnCancelAccount.TabIndex = 9;
        btnCancelAccount.Text = "Cancel";
        btnCancelAccount.UseVisualStyleBackColor = true;
        btnCancelAccount.Click += btnCancelAccount_Click;
        // 
        // CreateAccountForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(380, 260);
        Controls.Add(btnCancelAccount);
        Controls.Add(btnClearAccount);
        Controls.Add(btnCreateUser);
        Controls.Add(txtConfirmPassword);
        Controls.Add(txtNewPassword);
        Controls.Add(txtNewUsername);
        Controls.Add(lblConfirmPassword);
        Controls.Add(lblNewPassword);
        Controls.Add(lblNewUsername);
        Controls.Add(lblCreateTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CreateAccountForm";
        Text = "Create Account - Skills International";
        Load += CreateAccountForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblCreateTitle;
    private Label lblNewUsername;
    private Label lblNewPassword;
    private Label lblConfirmPassword;
    private TextBox txtNewUsername;
    private TextBox txtNewPassword;
    private TextBox txtConfirmPassword;
    private Button btnCreateUser;
    private Button btnClearAccount;
    private Button btnCancelAccount;
}

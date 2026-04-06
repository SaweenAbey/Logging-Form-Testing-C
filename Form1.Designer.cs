namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            pictureBoxLogo = new PictureBox();
            groupBoxLogin = new GroupBox();
            btnLogin = new Button();
            btnClear = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(143, 176);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(343, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Skills International";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(218, 38);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(180, 140);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(btnLogin);
            groupBoxLogin.Controls.Add(btnClear);
            groupBoxLogin.Controls.Add(txtPassword);
            groupBoxLogin.Controls.Add(txtUsername);
            groupBoxLogin.Controls.Add(lblPassword);
            groupBoxLogin.Controls.Add(lblUsername);
            groupBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxLogin.Location = new Point(99, 243);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(439, 242);
            groupBoxLogin.TabIndex = 2;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(292, 177);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(44, 177);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 36);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 114);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(227, 29);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(160, 63);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(227, 29);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(43, 117);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(43, 66);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(84, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(24, 507);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 36);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 561);
            Controls.Add(btnExit);
            Controls.Add(groupBoxLogin);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Login - Skills International";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pictureBoxLogo;
        private GroupBox groupBoxLogin;
        private Button btnLogin;
        private Button btnClear;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
        private Button btnExit;
    }
}

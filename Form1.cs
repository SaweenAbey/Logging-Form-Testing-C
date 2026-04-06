namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly StudentRepository _repository = new();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtUsername.Focus();
            InitializeDefaultLogo();
        }

        private void InitializeDefaultLogo()
        {
            if (pictureBoxLogo.Image is null)
            {
                pictureBoxLogo.Image = CreateSkillsLogoImage();
            }
        }

        private static Image CreateSkillsLogoImage()
        {
            var bitmap = new Bitmap(180, 140);
            using var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.Clear(Color.White);

            using var magentaPen = new Pen(Color.DeepPink, 5);
            using var greenPen = new Pen(Color.MediumSeaGreen, 5);
            using var bluePen = new Pen(Color.RoyalBlue, 5);
            graphics.DrawArc(magentaPen, 40, 8, 100, 100, 35, 300);
            graphics.DrawArc(greenPen, 48, 16, 84, 84, 35, 300);
            graphics.DrawArc(bluePen, 56, 24, 68, 68, 35, 300);

            using var titleFont = new Font("Segoe UI", 24, FontStyle.Bold, GraphicsUnit.Point);
            using var brush = new SolidBrush(Color.Black);
            graphics.DrawString("SKILLS", titleFont, brush, new PointF(6, 56));

            using var subtitleFont = new Font("Segoe UI", 8, FontStyle.Regular, GraphicsUnit.Point);
            graphics.DrawString("International", subtitleFont, Brushes.DeepPink, new PointF(28, 92));

            return bitmap;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            try
            {
                _repository.EnsureDatabaseAndTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Database setup failed. Please verify your database server is running and credentials are correct.\n\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;

            if (_repository.ValidateLogin(username, password))
            {
                MessageBox.Show(
                    "Login successful.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                var registrationForm = new RegistrationForm(_repository)
                {
                    Owner = this
                };

                registrationForm.FormClosed += (_, _) =>
                {
                    if (!IsDisposed)
                    {
                        txtPassword.Clear();
                        Show();
                        txtUsername.Focus();
                    }
                };

                Hide();
                registrationForm.Show();
                return;
            }

            MessageBox.Show(
                "Invalid Login credentials, please check Username and Password and try again",
                "Invalid login Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            using var createAccountForm = new CreateAccountForm(_repository);
            createAccountForm.ShowDialog(this);
        }
    }
}

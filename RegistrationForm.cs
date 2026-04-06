namespace WinFormsApp1;

public partial class RegistrationForm : Form
{
    private readonly StudentRepository _repository;
    private bool _isLoadingCombo;

    public RegistrationForm(StudentRepository repository)
    {
        InitializeComponent();
        _repository = repository;
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void RegistrationForm_Load(object sender, EventArgs e)
    {
        LoadRegNoList();
        SetNextRegNoText();
        txtFirstName.Focus();
    }

    private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Close();
    }

    private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearFields(keepRegNo: true);
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        if (!TryBuildRecord(out var record))
        {
            return;
        }

        var existing = _repository.GetStudentByRegNo(record.RegNo);
        if (existing is not null)
        {
            MessageBox.Show("Registration number already exists.", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _repository.AddStudent(record);
        MessageBox.Show("Record Added Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

        LoadRegNoList();
        ClearFields(keepRegNo: false);
        SetNextRegNoText();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (!TryBuildRecord(out var record))
        {
            return;
        }

        var existing = _repository.GetStudentByRegNo(record.RegNo);
        if (existing is null)
        {
            MessageBox.Show("Record not found for update.", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _repository.UpdateStudent(record);
        MessageBox.Show("Record Updated Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

        LoadRegNoList();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(comboRegNo.Text.Trim(), out var regNo))
        {
            MessageBox.Show("Enter/select a valid Reg No.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmation = MessageBox.Show(
            "Are you sure, Do you really want to Delete this Record...?",
            "Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        _repository.DeleteStudent(regNo);
        MessageBox.Show("Record Deleted Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

        LoadRegNoList();
        ClearFields(keepRegNo: false);
        SetNextRegNoText();
    }

    private void comboRegNo_TextChanged(object sender, EventArgs e)
    {
        if (_isLoadingCombo)
        {
            return;
        }

        if (!int.TryParse(comboRegNo.Text.Trim(), out var regNo))
        {
            return;
        }

        var student = _repository.GetStudentByRegNo(regNo);
        if (student is null)
        {
            return;
        }

        BindStudent(student);
    }

    private void LoadRegNoList()
    {
        _isLoadingCombo = true;
        try
        {
            var regNos = _repository.GetRegistrationNumbers();
            comboRegNo.Items.Clear();
            foreach (var regNo in regNos)
            {
                comboRegNo.Items.Add(regNo.ToString());
            }
        }
        finally
        {
            _isLoadingCombo = false;
        }
    }

    private void SetNextRegNoText()
    {
        comboRegNo.Text = _repository.GetNextRegistrationNumber().ToString();
    }

    private void BindStudent(StudentRecord student)
    {
        comboRegNo.Text = student.RegNo.ToString();
        txtFirstName.Text = student.FirstName;
        txtLastName.Text = student.LastName;
        dtpDateOfBirth.Value = student.DateOfBirth == default ? DateTime.Today : student.DateOfBirth;
        rbMale.Checked = string.Equals(student.Gender, "Male", StringComparison.OrdinalIgnoreCase);
        rbFemale.Checked = string.Equals(student.Gender, "Female", StringComparison.OrdinalIgnoreCase);
        txtAddress.Text = student.Address;
        txtEmail.Text = student.Email;
        txtMobilePhone.Text = student.MobilePhone?.ToString() ?? string.Empty;
        txtHomePhone.Text = student.HomePhone?.ToString() ?? string.Empty;
        txtParentName.Text = student.ParentName;
        txtNic.Text = student.Nic;
        txtContactNo.Text = student.ContactNo?.ToString() ?? string.Empty;
    }

    private bool TryBuildRecord(out StudentRecord record)
    {
        record = new StudentRecord();

        if (!int.TryParse(comboRegNo.Text.Trim(), out var regNo))
        {
            MessageBox.Show("Enter a valid Reg No.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        record.RegNo = regNo;
        record.FirstName = txtFirstName.Text.Trim();
        record.LastName = txtLastName.Text.Trim();
        record.DateOfBirth = dtpDateOfBirth.Value.Date;
        record.Gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : string.Empty;
        record.Address = txtAddress.Text.Trim();
        record.Email = txtEmail.Text.Trim();
        record.MobilePhone = ParseOptionalInt(txtMobilePhone.Text);
        record.HomePhone = ParseOptionalInt(txtHomePhone.Text);
        record.ParentName = txtParentName.Text.Trim();
        record.Nic = txtNic.Text.Trim();
        record.ContactNo = ParseOptionalInt(txtContactNo.Text);

        if (string.IsNullOrWhiteSpace(record.FirstName) || string.IsNullOrWhiteSpace(record.LastName))
        {
            MessageBox.Show("First Name and Last Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!rbMale.Checked && !rbFemale.Checked)
        {
            MessageBox.Show("Please select a Gender.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!IsOptionalInt(txtMobilePhone.Text) || !IsOptionalInt(txtHomePhone.Text) || !IsOptionalInt(txtContactNo.Text))
        {
            MessageBox.Show("Mobile Phone, Home Phone and Contact Number must be numeric.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private static bool IsOptionalInt(string input)
    {
        var value = input.Trim();
        return string.IsNullOrEmpty(value) || int.TryParse(value, out _);
    }

    private static int? ParseOptionalInt(string input)
    {
        return int.TryParse(input.Trim(), out var number) ? number : null;
    }

    private void ClearFields(bool keepRegNo)
    {
        if (!keepRegNo)
        {
            comboRegNo.Text = string.Empty;
        }

        txtFirstName.Clear();
        txtLastName.Clear();
        dtpDateOfBirth.Value = DateTime.Today;
        rbMale.Checked = false;
        rbFemale.Checked = false;
        txtAddress.Clear();
        txtEmail.Clear();
        txtMobilePhone.Clear();
        txtHomePhone.Clear();
        txtParentName.Clear();
        txtNic.Clear();
        txtContactNo.Clear();
        txtFirstName.Focus();
    }
}

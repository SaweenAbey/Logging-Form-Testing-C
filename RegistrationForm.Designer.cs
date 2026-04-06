namespace WinFormsApp1;

partial class RegistrationForm
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
        linkLogout = new LinkLabel();
        lblHeader = new Label();
        groupStudentRegistration = new GroupBox();
        btnDelete = new Button();
        btnClear = new Button();
        btnUpdate = new Button();
        btnRegister = new Button();
        groupParentDetails = new GroupBox();
        txtContactNo = new TextBox();
        txtNic = new TextBox();
        txtParentName = new TextBox();
        lblContactNo = new Label();
        lblNic = new Label();
        lblParentName = new Label();
        groupContactDetails = new GroupBox();
        txtHomePhone = new TextBox();
        lblHomePhone = new Label();
        txtMobilePhone = new TextBox();
        lblMobilePhone = new Label();
        txtEmail = new TextBox();
        txtAddress = new TextBox();
        lblEmail = new Label();
        lblAddress = new Label();
        groupBasicDetails = new GroupBox();
        rbFemale = new RadioButton();
        rbMale = new RadioButton();
        dtpDateOfBirth = new DateTimePicker();
        txtLastName = new TextBox();
        txtFirstName = new TextBox();
        lblGender = new Label();
        lblDateOfBirth = new Label();
        lblLastName = new Label();
        lblFirstName = new Label();
        comboRegNo = new ComboBox();
        lblRegNo = new Label();
        linkExit = new LinkLabel();
        groupStudentRegistration.SuspendLayout();
        groupParentDetails.SuspendLayout();
        groupContactDetails.SuspendLayout();
        groupBasicDetails.SuspendLayout();
        SuspendLayout();
        // 
        // linkLogout
        // 
        linkLogout.AutoSize = true;
        linkLogout.Location = new Point(21, 16);
        linkLogout.Name = "linkLogout";
        linkLogout.Size = new Size(44, 15);
        linkLogout.TabIndex = 0;
        linkLogout.TabStop = true;
        linkLogout.Text = "Logout";
        linkLogout.LinkClicked += linkLogout_LinkClicked;
        // 
        // lblHeader
        // 
        lblHeader.AutoSize = true;
        lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblHeader.Location = new Point(167, 16);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new Size(343, 45);
        lblHeader.TabIndex = 1;
        lblHeader.Text = "Skills International";
        // 
        // groupStudentRegistration
        // 
        groupStudentRegistration.Controls.Add(btnDelete);
        groupStudentRegistration.Controls.Add(btnClear);
        groupStudentRegistration.Controls.Add(btnUpdate);
        groupStudentRegistration.Controls.Add(btnRegister);
        groupStudentRegistration.Controls.Add(groupParentDetails);
        groupStudentRegistration.Controls.Add(groupContactDetails);
        groupStudentRegistration.Controls.Add(groupBasicDetails);
        groupStudentRegistration.Controls.Add(comboRegNo);
        groupStudentRegistration.Controls.Add(lblRegNo);
        groupStudentRegistration.Location = new Point(21, 76);
        groupStudentRegistration.Name = "groupStudentRegistration";
        groupStudentRegistration.Size = new Size(651, 665);
        groupStudentRegistration.TabIndex = 2;
        groupStudentRegistration.TabStop = false;
        groupStudentRegistration.Text = "Student Registration";
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(527, 620);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(95, 30);
        btnDelete.TabIndex = 8;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(414, 620);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(95, 30);
        btnClear.TabIndex = 7;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(124, 620);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(95, 30);
        btnUpdate.TabIndex = 6;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(20, 620);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(95, 30);
        btnRegister.TabIndex = 5;
        btnRegister.Text = "Register";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // groupParentDetails
        // 
        groupParentDetails.Controls.Add(txtContactNo);
        groupParentDetails.Controls.Add(txtNic);
        groupParentDetails.Controls.Add(txtParentName);
        groupParentDetails.Controls.Add(lblContactNo);
        groupParentDetails.Controls.Add(lblNic);
        groupParentDetails.Controls.Add(lblParentName);
        groupParentDetails.Location = new Point(20, 468);
        groupParentDetails.Name = "groupParentDetails";
        groupParentDetails.Size = new Size(602, 133);
        groupParentDetails.TabIndex = 4;
        groupParentDetails.TabStop = false;
        groupParentDetails.Text = "Parent Details";
        // 
        // txtContactNo
        // 
        txtContactNo.Location = new Point(108, 94);
        txtContactNo.Name = "txtContactNo";
        txtContactNo.Size = new Size(368, 23);
        txtContactNo.TabIndex = 5;
        // 
        // txtNic
        // 
        txtNic.Location = new Point(108, 61);
        txtNic.Name = "txtNic";
        txtNic.Size = new Size(368, 23);
        txtNic.TabIndex = 4;
        // 
        // txtParentName
        // 
        txtParentName.Location = new Point(108, 28);
        txtParentName.Name = "txtParentName";
        txtParentName.Size = new Size(368, 23);
        txtParentName.TabIndex = 3;
        // 
        // lblContactNo
        // 
        lblContactNo.AutoSize = true;
        lblContactNo.Location = new Point(16, 97);
        lblContactNo.Name = "lblContactNo";
        lblContactNo.Size = new Size(68, 15);
        lblContactNo.TabIndex = 2;
        lblContactNo.Text = "Contact No";
        // 
        // lblNic
        // 
        lblNic.AutoSize = true;
        lblNic.Location = new Point(16, 64);
        lblNic.Name = "lblNic";
        lblNic.Size = new Size(27, 15);
        lblNic.TabIndex = 1;
        lblNic.Text = "NIC";
        // 
        // lblParentName
        // 
        lblParentName.AutoSize = true;
        lblParentName.Location = new Point(16, 31);
        lblParentName.Name = "lblParentName";
        lblParentName.Size = new Size(75, 15);
        lblParentName.TabIndex = 0;
        lblParentName.Text = "Parent Name";
        // 
        // groupContactDetails
        // 
        groupContactDetails.Controls.Add(txtHomePhone);
        groupContactDetails.Controls.Add(lblHomePhone);
        groupContactDetails.Controls.Add(txtMobilePhone);
        groupContactDetails.Controls.Add(lblMobilePhone);
        groupContactDetails.Controls.Add(txtEmail);
        groupContactDetails.Controls.Add(txtAddress);
        groupContactDetails.Controls.Add(lblEmail);
        groupContactDetails.Controls.Add(lblAddress);
        groupContactDetails.Location = new Point(20, 275);
        groupContactDetails.Name = "groupContactDetails";
        groupContactDetails.Size = new Size(602, 183);
        groupContactDetails.TabIndex = 3;
        groupContactDetails.TabStop = false;
        groupContactDetails.Text = "Contact Details";
        // 
        // txtHomePhone
        // 
        txtHomePhone.Location = new Point(378, 139);
        txtHomePhone.Name = "txtHomePhone";
        txtHomePhone.Size = new Size(146, 23);
        txtHomePhone.TabIndex = 7;
        // 
        // lblHomePhone
        // 
        lblHomePhone.AutoSize = true;
        lblHomePhone.Location = new Point(292, 142);
        lblHomePhone.Name = "lblHomePhone";
        lblHomePhone.Size = new Size(76, 15);
        lblHomePhone.TabIndex = 6;
        lblHomePhone.Text = "Home Phone";
        // 
        // txtMobilePhone
        // 
        txtMobilePhone.Location = new Point(108, 139);
        txtMobilePhone.Name = "txtMobilePhone";
        txtMobilePhone.Size = new Size(146, 23);
        txtMobilePhone.TabIndex = 5;
        // 
        // lblMobilePhone
        // 
        lblMobilePhone.AutoSize = true;
        lblMobilePhone.Location = new Point(16, 142);
        lblMobilePhone.Name = "lblMobilePhone";
        lblMobilePhone.Size = new Size(79, 15);
        lblMobilePhone.TabIndex = 4;
        lblMobilePhone.Text = "Mobile Phone";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(108, 98);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(416, 23);
        txtEmail.TabIndex = 3;
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(108, 28);
        txtAddress.Multiline = true;
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(416, 59);
        txtAddress.TabIndex = 2;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(16, 101);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(36, 15);
        lblEmail.TabIndex = 1;
        lblEmail.Text = "Email";
        // 
        // lblAddress
        // 
        lblAddress.AutoSize = true;
        lblAddress.Location = new Point(16, 31);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new Size(49, 15);
        lblAddress.TabIndex = 0;
        lblAddress.Text = "Address";
        // 
        // groupBasicDetails
        // 
        groupBasicDetails.Controls.Add(rbFemale);
        groupBasicDetails.Controls.Add(rbMale);
        groupBasicDetails.Controls.Add(dtpDateOfBirth);
        groupBasicDetails.Controls.Add(txtLastName);
        groupBasicDetails.Controls.Add(txtFirstName);
        groupBasicDetails.Controls.Add(lblGender);
        groupBasicDetails.Controls.Add(lblDateOfBirth);
        groupBasicDetails.Controls.Add(lblLastName);
        groupBasicDetails.Controls.Add(lblFirstName);
        groupBasicDetails.Location = new Point(20, 76);
        groupBasicDetails.Name = "groupBasicDetails";
        groupBasicDetails.Size = new Size(602, 189);
        groupBasicDetails.TabIndex = 2;
        groupBasicDetails.TabStop = false;
        groupBasicDetails.Text = "Basic Details";
        // 
        // rbFemale
        // 
        rbFemale.AutoSize = true;
        rbFemale.Location = new Point(222, 149);
        rbFemale.Name = "rbFemale";
        rbFemale.Size = new Size(63, 19);
        rbFemale.TabIndex = 8;
        rbFemale.TabStop = true;
        rbFemale.Text = "Female";
        rbFemale.UseVisualStyleBackColor = true;
        // 
        // rbMale
        // 
        rbMale.AutoSize = true;
        rbMale.Location = new Point(108, 149);
        rbMale.Name = "rbMale";
        rbMale.Size = new Size(51, 19);
        rbMale.TabIndex = 7;
        rbMale.TabStop = true;
        rbMale.Text = "Male";
        rbMale.UseVisualStyleBackColor = true;
        // 
        // dtpDateOfBirth
        // 
        dtpDateOfBirth.Format = DateTimePickerFormat.Short;
        dtpDateOfBirth.Location = new Point(108, 109);
        dtpDateOfBirth.Name = "dtpDateOfBirth";
        dtpDateOfBirth.Size = new Size(145, 23);
        dtpDateOfBirth.TabIndex = 6;
        // 
        // txtLastName
        // 
        txtLastName.Location = new Point(108, 71);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(416, 23);
        txtLastName.TabIndex = 5;
        // 
        // txtFirstName
        // 
        txtFirstName.Location = new Point(108, 33);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(416, 23);
        txtFirstName.TabIndex = 4;
        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.Location = new Point(16, 151);
        lblGender.Name = "lblGender";
        lblGender.Size = new Size(45, 15);
        lblGender.TabIndex = 3;
        lblGender.Text = "Gender";
        // 
        // lblDateOfBirth
        // 
        lblDateOfBirth.AutoSize = true;
        lblDateOfBirth.Location = new Point(16, 113);
        lblDateOfBirth.Name = "lblDateOfBirth";
        lblDateOfBirth.Size = new Size(70, 15);
        lblDateOfBirth.TabIndex = 2;
        lblDateOfBirth.Text = "Date of Birth";
        // 
        // lblLastName
        // 
        lblLastName.AutoSize = true;
        lblLastName.Location = new Point(16, 74);
        lblLastName.Name = "lblLastName";
        lblLastName.Size = new Size(63, 15);
        lblLastName.TabIndex = 1;
        lblLastName.Text = "Last Name";
        // 
        // lblFirstName
        // 
        lblFirstName.AutoSize = true;
        lblFirstName.Location = new Point(16, 36);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Size = new Size(64, 15);
        lblFirstName.TabIndex = 0;
        lblFirstName.Text = "First Name";
        // 
        // comboRegNo
        // 
        comboRegNo.FormattingEnabled = true;
        comboRegNo.Location = new Point(128, 32);
        comboRegNo.Name = "comboRegNo";
        comboRegNo.Size = new Size(145, 23);
        comboRegNo.TabIndex = 1;
        comboRegNo.TextChanged += comboRegNo_TextChanged;
        // 
        // lblRegNo
        // 
        lblRegNo.AutoSize = true;
        lblRegNo.Location = new Point(20, 35);
        lblRegNo.Name = "lblRegNo";
        lblRegNo.Size = new Size(47, 15);
        lblRegNo.TabIndex = 0;
        lblRegNo.Text = "Reg No";
        // 
        // linkExit
        // 
        linkExit.AutoSize = true;
        linkExit.Location = new Point(648, 744);
        linkExit.Name = "linkExit";
        linkExit.Size = new Size(25, 15);
        linkExit.TabIndex = 3;
        linkExit.TabStop = true;
        linkExit.Text = "Exit";
        linkExit.LinkClicked += linkExit_LinkClicked;
        // 
        // RegistrationForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(694, 768);
        Controls.Add(linkExit);
        Controls.Add(groupStudentRegistration);
        Controls.Add(lblHeader);
        Controls.Add(linkLogout);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "RegistrationForm";
        Text = "Student Registration - Skills International";
        Load += RegistrationForm_Load;
        groupStudentRegistration.ResumeLayout(false);
        groupStudentRegistration.PerformLayout();
        groupParentDetails.ResumeLayout(false);
        groupParentDetails.PerformLayout();
        groupContactDetails.ResumeLayout(false);
        groupContactDetails.PerformLayout();
        groupBasicDetails.ResumeLayout(false);
        groupBasicDetails.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private LinkLabel linkLogout;
    private Label lblHeader;
    private GroupBox groupStudentRegistration;
    private ComboBox comboRegNo;
    private Label lblRegNo;
    private GroupBox groupBasicDetails;
    private RadioButton rbFemale;
    private RadioButton rbMale;
    private DateTimePicker dtpDateOfBirth;
    private TextBox txtLastName;
    private TextBox txtFirstName;
    private Label lblGender;
    private Label lblDateOfBirth;
    private Label lblLastName;
    private Label lblFirstName;
    private GroupBox groupContactDetails;
    private TextBox txtHomePhone;
    private Label lblHomePhone;
    private TextBox txtMobilePhone;
    private Label lblMobilePhone;
    private TextBox txtEmail;
    private TextBox txtAddress;
    private Label lblEmail;
    private Label lblAddress;
    private GroupBox groupParentDetails;
    private TextBox txtContactNo;
    private TextBox txtNic;
    private TextBox txtParentName;
    private Label lblContactNo;
    private Label lblNic;
    private Label lblParentName;
    private Button btnDelete;
    private Button btnClear;
    private Button btnUpdate;
    private Button btnRegister;
    private LinkLabel linkExit;
}

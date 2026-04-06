using Microsoft.Data.SqlClient;

namespace WinFormsApp1;

public class StudentRepository
{
    private const string MasterConnectionString = "Server=localhost;Database=master;Integrated Security=True;TrustServerCertificate=True;";
    private const string StudentConnectionString = "Server=localhost;Database=Student;Integrated Security=True;TrustServerCertificate=True;";

    public void EnsureDatabaseAndTables()
    {
        using (var connection = new SqlConnection(MasterConnectionString))
        {
            connection.Open();

            var createDatabaseSql = @"
IF DB_ID('Student') IS NULL
BEGIN
    CREATE DATABASE Student;
END";

            using var createDbCommand = new SqlCommand(createDatabaseSql, connection);
            createDbCommand.ExecuteNonQuery();
        }

        using (var connection = new SqlConnection(StudentConnectionString))
        {
            connection.Open();

            var createLoginsTableSql = @"
IF OBJECT_ID('dbo.Logins', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Logins
    (
        username NVARCHAR(50) NOT NULL PRIMARY KEY,
        password NVARCHAR(50) NOT NULL
    );
END";

            using var createLoginsTableCommand = new SqlCommand(createLoginsTableSql, connection);
            createLoginsTableCommand.ExecuteNonQuery();

            var createRegistrationTableSql = @"
IF OBJECT_ID('dbo.Registration', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Registration
    (
        regNo INT NOT NULL PRIMARY KEY,
        firstName NVARCHAR(50) NULL,
        lastName NVARCHAR(50) NULL,
        dateOfBirth DATE NULL,
        gender NVARCHAR(50) NULL,
        address NVARCHAR(100) NULL,
        email NVARCHAR(100) NULL,
        mobilePhone INT NULL,
        homePhone INT NULL,
        parentName NVARCHAR(100) NULL,
        nic NVARCHAR(50) NULL,
        contactNo INT NULL
    );
END";

            using var createRegistrationTableCommand = new SqlCommand(createRegistrationTableSql, connection);
            createRegistrationTableCommand.ExecuteNonQuery();

            var ensureAdminSql = @"
IF NOT EXISTS (SELECT 1 FROM dbo.Logins WHERE username = 'Admin')
BEGIN
    INSERT INTO dbo.Logins(username, password)
    VALUES ('Admin', 'Skills@123');
END";

            using var ensureAdminCommand = new SqlCommand(ensureAdminSql, connection);
            ensureAdminCommand.ExecuteNonQuery();
        }
    }

    public bool ValidateLogin(string username, string password)
    {
        using var connection = new SqlConnection(StudentConnectionString);
        connection.Open();

        const string sql = "SELECT COUNT(1) FROM dbo.Logins WHERE username = @username AND password = @password;";
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@username", username);
        command.Parameters.AddWithValue("@password", password);

        var count = Convert.ToInt32(command.ExecuteScalar());
        return count > 0;
    }

    public bool UserExists(string username)
    {
        using var connection = new SqlConnection(StudentConnectionString);
        connection.Open();

        const string sql = "SELECT COUNT(1) FROM dbo.Logins WHERE username = @username;";
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@username", username);

        var count = Convert.ToInt32(command.ExecuteScalar());
        return count > 0;
    }

    public void CreateUser(string username, string password)
    {
        using var connection = new SqlConnection(StudentConnectionString);
        connection.Open();

        const string sql = "INSERT INTO dbo.Logins(username, password) VALUES(@username, @password);";
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@username", username);
        command.Parameters.AddWithValue("@password", password);
        command.ExecuteNonQuery();
    }

    public List<int> GetRegistrationNumbers()
    {
        using var connection = new SqlConnection(StudentConnectionString);
        connection.Open();

        const string sql = "SELECT regNo FROM dbo.Registration ORDER BY regNo;";
        using var command = new SqlCommand(sql, connection);
        using var reader = command.ExecuteReader();

        var regNos = new List<int>();
        while (reader.Read())
        {
            regNos.Add(reader.GetInt32(0));
        }

        return regNos;
    }

    public StudentRecord? GetStudentByRegNo(int regNo)
    {
        using var connection = new SqlConnection(StudentConnectionString);
        connection.Open();

        const string sql = @"
SELECT regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo
FROM dbo.Registration
WHERE regNo = @regNo;";

    using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@regNo", regNo);
        using var reader = command.ExecuteReader();

        if (!reader.Read())
        {
            return null;
        }

        return new StudentRecord
        {
            RegNo = reader.GetInt32(0),
            FirstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
            LastName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
            DateOfBirth = reader.IsDBNull(3) ? DateTime.Today : reader.GetDateTime(3),
            Gender = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
            Address = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
            Email = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
            MobilePhone = reader.IsDBNull(7) ? null : reader.GetInt32(7),
            HomePhone = reader.IsDBNull(8) ? null : reader.GetInt32(8),
            ParentName = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
            Nic = reader.IsDBNull(10) ? string.Empty : reader.GetString(10),
            ContactNo = reader.IsDBNull(11) ? null : reader.GetInt32(11)
        };
    }

    public void AddStudent(StudentRecord record)
    {
        using var connection = new SqlConnection(StudentConnectionString);
        connection.Open();

        const string sql = @"
INSERT INTO dbo.Registration
(regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo)
VALUES
(@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo);";

        using var command = new SqlCommand(sql, connection);
        AddStudentParameters(command, record);
        command.ExecuteNonQuery();
    }

    public void UpdateStudent(StudentRecord record)
    {
        using var connection = new SqlConnection(StudentConnectionString);
        connection.Open();

        const string sql = @"
    UPDATE dbo.Registration
SET firstName = @firstName,
    lastName = @lastName,
    dateOfBirth = @dateOfBirth,
    gender = @gender,
    address = @address,
    email = @email,
    mobilePhone = @mobilePhone,
    homePhone = @homePhone,
    parentName = @parentName,
    nic = @nic,
    contactNo = @contactNo
WHERE regNo = @regNo;";

        using var command = new SqlCommand(sql, connection);
        AddStudentParameters(command, record);
        command.ExecuteNonQuery();
    }

    public void DeleteStudent(int regNo)
    {
        using var connection = new SqlConnection(StudentConnectionString);
        connection.Open();

        const string sql = "DELETE FROM dbo.Registration WHERE regNo = @regNo;";
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@regNo", regNo);
        command.ExecuteNonQuery();
    }

    public int GetNextRegistrationNumber()
    {
        using var connection = new SqlConnection(StudentConnectionString);
        connection.Open();

        const string sql = "SELECT ISNULL(MAX(regNo), 0) + 1 FROM dbo.Registration;";
        using var command = new SqlCommand(sql, connection);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    private static void AddStudentParameters(SqlCommand command, StudentRecord record)
    {
        command.Parameters.AddWithValue("@regNo", record.RegNo);
        command.Parameters.AddWithValue("@firstName", ToDbValue(record.FirstName));
        command.Parameters.AddWithValue("@lastName", ToDbValue(record.LastName));
        command.Parameters.AddWithValue("@dateOfBirth", record.DateOfBirth);
        command.Parameters.AddWithValue("@gender", ToDbValue(record.Gender));
        command.Parameters.AddWithValue("@address", ToDbValue(record.Address));
        command.Parameters.AddWithValue("@email", ToDbValue(record.Email));
        command.Parameters.AddWithValue("@mobilePhone", ToDbValue(record.MobilePhone));
        command.Parameters.AddWithValue("@homePhone", ToDbValue(record.HomePhone));
        command.Parameters.AddWithValue("@parentName", ToDbValue(record.ParentName));
        command.Parameters.AddWithValue("@nic", ToDbValue(record.Nic));
        command.Parameters.AddWithValue("@contactNo", ToDbValue(record.ContactNo));
    }

    private static object ToDbValue(string value)
    {
        return string.IsNullOrWhiteSpace(value) ? DBNull.Value : value;
    }

    private static object ToDbValue(int? value)
    {
        return value.HasValue ? value.Value : DBNull.Value;
    }
}

using StudentNameSpace;

namespace StudentRegistrationApplication
{
    public partial class frmStudentInfo : Form
    {
        //Simulate a database with a list
        List<StudentInfo> students = new List<StudentInfo>();

        public frmStudentInfo()
        {
            InitializeComponent();

            //Populate Date ComboBox
            for (int day = 1; day <= 31; day++)
            {
                Date.Items.Add(day.ToString("D2")); // D2 formats the number to two digits
            }

            //Populate Month ComboBox
            Month.Items.AddRange(new string[]
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            });

            //Populate Year ComboBox
            for (int year = DateTime.Now.Year; year >= 1900; year--)
            {
                Year.Items.Add(year.ToString());
            }

            //Populate Program ComboBox
            Programs.Items.AddRange(new string[]
            {
                "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Tourism",
                "Psychology", "Adonis Dancer", "Nursing", "Criminology", "Engineering", "Education", "Business Administration"
            });
        }

        public void browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        public void RegisterButton_Click(object sender, EventArgs e)
        {
            //Check if First Name, Middle Name, Last Name and Program are filled
            if (string.IsNullOrWhiteSpace(firstName.Text) ||
                string.IsNullOrWhiteSpace(lastName.Text) ||
                Programs.SelectedItem == null)
            {
                MessageBox.Show("Please fill in First Name, Last Name and Program", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create StudentInfo object
            string fName = firstName.Text.Trim();
            string mName = middleName.Text.Trim();
            string lName = lastName.Text.Trim();
            string program = Programs.SelectedItem.ToString();

            StudentInfo studentInfo = new StudentInfo();
            studentInfo.FirstName = fName;
            studentInfo.MiddleName = mName;
            studentInfo.LastName = lName;
            studentInfo.Program = program;

            if ((!male_radio.Checked && !female_radio.Checked) && (Date.SelectedItem == null || Month.SelectedItem == null || Year.SelectedItem == null))
            {
                students.Add(studentInfo);
                ShowStudentInfo(fName, mName, lName, program);
                return;
            }

            string gender = "";
            if (male_radio.Checked)
            {
                studentInfo.Gender = "Male";
                gender = "Male";
            }
            else if (female_radio.Checked)
            {
                studentInfo.Gender = "Female";
                gender = "Female";
            }

            string dateStr = "";
            if (!(Date.SelectedItem == null || Month.SelectedItem == null || Year.SelectedItem == null))
            {
                dateStr = $"{Date.SelectedItem}/{Month.SelectedItem}/{Year.SelectedItem}";
                DateTime dateTime = DateTime.Parse(dateStr);
                studentInfo.DateOfBirth = dateTime;
            } else
            {
                students.Add(studentInfo);
                ShowStudentInfo(fName, mName, lName, gender, program);
                return;
            }

            students.Add(studentInfo);
            ShowStudentInfo(firstName.Text.Trim(), middleName.Text.Trim(), lastName.Text.Trim(), gender, studentInfo.DateOfBirth, program);


        }

        // Overload 1: Display only name and program
        private void ShowStudentInfo(string firstName, string middleName, string lastName, string program)
        {
            string message = $"Student Name: {firstName} {middleName} {lastName}\n" +
                            $"Program: {program}";
            ;
            MessageBox.Show(message, "Student Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Overload 2: Display all details
        private void ShowStudentInfo(string firstName, string middleName, string lastName, string gender, DateTime dob, string program)
        {
            string optGender = gender == "" ? "" : $"Gender: {gender}\n";
            string message = $"Student Name: {firstName} {middleName} {lastName}\n" +
                             optGender +
                             $"Date of Birth: {dob:dd/MMMM/yyyy}\n" +
                             $"Program: {program}";
            MessageBox.Show(message, "Student Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Overload 3: Display all details without date of birth
        private void ShowStudentInfo(string firstName, string middleName, string lastName, string gender, string program)
        {
            string message = $"Student Name: {firstName} {middleName} {lastName}\n" +
                             $"Gender: {gender}\n" +
                             $"Program: {program}";
            MessageBox.Show(message, "Student Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

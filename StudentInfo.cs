using System;

namespace StudentNameSpace
{
	public class StudentInfo
	{
		private string _firstName;
		private string _middleName;
		private string _lastName;
		private string _gender;
		private DateTime _dateOfBirth;
		private string _program;


		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

		public string MiddleName
		{
			get { return _middleName; }
			set { _middleName = value; }
		}

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

		public string Gender
		{
			get { return _gender; }
			set { _gender = value; }
        }

		public DateTime DateOfBirth
		{
			get { return _dateOfBirth; }
			set { _dateOfBirth = value; }
        }

		public string Program
		{
			get { return _program; }
			set { _program = value; }
        }

		public StudentInfo(string firstName, string middleName, string lastName, string gender, DateTime dateOfBirth, string program)
		{
			this._firstName = firstName;
			this._middleName = middleName;
			this._lastName = lastName;

			this._gender = gender;
			this._dateOfBirth = dateOfBirth;
			this._program = program;
        }

		public StudentInfo()
		{

		}
    }
}

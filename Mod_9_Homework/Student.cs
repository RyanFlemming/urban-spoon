using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
	public class Student
	{
		private int id;
		private string firstName;
		private string lastName;
		private string city;

		public string City
		{
			get { return city; }
			set { city = value; }
		}
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}
		public int ID
		{
			get { return id; }
			set { id = value; }
		}
	}
}

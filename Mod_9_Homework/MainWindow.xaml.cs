using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
	public partial class MainWindow : Window
	{
		int counter = 0; // For searching students

		Student searchResult = new Student();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
		{
			counter++;
			// Creating our student and assigning values from text boxes
			Student student = new Student();
			
			student.ID = counter;
			student.FirstName = txtFirstName.Text;
			student.LastName = txtLastName.Text;
			student.City = txtCity.Text;

			// Adding student to our list collection
			student.studentCollection.Add(student);

			Clear();
		}

		private void Clear()
		{
			txtFirstName.Clear();
			txtLastName.Clear();
			txtCity.Clear();
		}

		private void btnPrevious_Click(object sender, RoutedEventArgs e)
		{
			counter -= 1;
			if (counter < 0)
			{
				counter = 0;
			}
			searchResult = studentCollection[counter] as Student;
			DisplayResult(searchResult);
		}

		private void btnNext_Click(object sender, RoutedEventArgs e)
		{
			counter += 1;
			if (counter == studentCollection.Count)
			{
				counter = 0;
				MessageBox.Show("Last result reached. Wrapping around.");
			}
			Student searchResult = studentCollection[counter] as Student;
			DisplayResult(searchResult);
		}

		private void DisplayResult(Student student)
		{
			txtFirstName.Text = student.FirstName;
			txtLastName.Text = student.LastName;
			txtCity.Text = student.City;
		}
	}
}

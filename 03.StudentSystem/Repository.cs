using _03.StudentSystem;
using System;
using System.Collections.Generic;
using System.Text;


 public static class Repository
{
	private static List<Student> studentsList;

	static Repository()
	{
		studentsList = new List<Student>();
	}

	public static void AddStudent(Student student)
	{
		studentsList.Add(student);
	}

	public static void Show(string studentName)
	{
		foreach (var student in studentsList)
		{
			if (studentName == student.Name)
			{
				Console.WriteLine(student.ToString());
			}
		}
	}
}

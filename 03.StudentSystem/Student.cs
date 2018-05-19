using System;
using System.Collections.Generic;
using System.Text;

namespace _03.StudentSystem
{
	public class Student
	{
		private string commentary;

		public Student(string name, int age, double grade)
		{
			this.Name = name;
			this.Age = age;
			this.Grade = grade;

			this.Commentary();
		}

		public string Name { get; set; }
		public int Age { get; set; }
		public double Grade { get; set; }

		private string Commentary()
		{
			if (this.Grade >= 5)
			{
				commentary = "Excellent student.";
			}
			else if (this.Grade < 5 && Grade > 4)
			{
				commentary = "Average student.";
			}
			else
			{
				commentary = "Poor student.";
			}

			return commentary;
		}

		public override string ToString()
		{
			return $"{this.Name} is {this.Age} years old. {this.commentary}";
		}
	}
}

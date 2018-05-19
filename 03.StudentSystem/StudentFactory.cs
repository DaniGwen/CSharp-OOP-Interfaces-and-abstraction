using System;
using System.Collections.Generic;
using System.Text;

namespace _03.StudentSystem
{
    public static class StudentFactory
    {
		public static void Create(string studentName,int studentAge,double studentGrade)
		{
			Student student = new Student(studentName , studentAge , studentGrade);

			Repository.AddStudent(student);

		}
    }
}

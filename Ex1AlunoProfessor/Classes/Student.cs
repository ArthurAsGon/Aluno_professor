using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Student : Person
{
    private int nCourses;
    private String[] courses;
    private int[] grades;

    public Student(String name, String address) : base(name, address)
    {
        this.nCourses = 0;
        this.courses = new String[10];
        this.grades = new int[10];
    }

    public void addCourseGrade(String course, int grade)
    {
        if (nCourses == courses.Length)
        {
            String[] newCourses = new String[courses.Length * 2];
            int[] newGrades = new int[grades.Length * 2];
            Array.Copy(courses, newCourses, courses.Length);
            Array.Copy(grades, newGrades, grades.Length);
            courses = newCourses;
            grades = newGrades;
        }
        courses[nCourses] = course;
        grades[nCourses] = grade;
        nCourses++;
    }

    public void printGrades()
    {
        for (int i = 0; i < nCourses; i++)
        {
            Console.WriteLine(grades[i]);
        }
    }

    public double getAverageGrade()
    {
        int sum = 0;
        for (int i = 0; i < nCourses; i++)
        {
            sum += grades[i];
        }

        return (double)sum / nCourses;
    }

    public override string ToString()
    {
        string result = "Student[name = " + this.getName + ", address = " + this.getAddress + ", courses = ( ";
        for (int i = 0; i < nCourses; i++)
        {
            result += courses[i] + " " + grades[i] + " ";
        }
        result += ")]";
        return result;
    }
}
using System;

public abstract class Teacher
{
    // Atributos
    private string name;
    private string address;
    private string[] courses;
    private int nCourses;

    // Construtor
    public Teacher(string name, string address)
    {
        this.name = name;
        this.address = address;
        this.courses = new string[10];
        this.nCourses = 0;
    }

    // Métodos
    public bool AddCourse(string course)
    {
        if (ContainsCourse(course))
        {
            return false;
        }
        else
        {
            if (nCourses == courses.Length)
            {
                string[] newCourses = new string[courses.Length * 2];
                Array.Copy(courses, newCourses, courses.Length);
                courses = newCourses;
            }
            courses[nCourses] = course;
            nCourses++;
            return true;
        }
    }

    public bool RemoveCourse(string course)
    {
        if (!ContainsCourse(course))
        {
            return false;
        }
        else
        {
            int index = -1;
            for (int i = 0; i < nCourses; i++)
            {
                if (courses[i].Equals(course))
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                return false;
            }
            else
            {
                for (int i = index; i < nCourses - 1; i++)
                {
                    courses[i] = courses[i + 1];
                }
                nCourses--;
                return true;
            }
        }
    }

    public abstract double CalculateWeeklyPay();

    public override string ToString()
    {
        string result = "Teacher [name = " + this.name + ", address = " + this.address + ", courses = ( ";
        for (int i = 0; i < nCourses; i++)
        {
            result += courses[i] + " ";
        }
        result += ")]";
        return result;
    }

    private bool ContainsCourse(string course)
    {
        for (int i = 0; i < nCourses; i++)
        {
            if (courses[i].Equals(course))
            {
                return true;
            }
        }
        return false;
    }
}
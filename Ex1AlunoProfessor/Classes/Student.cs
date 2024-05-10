using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Student : Person{
    private int nCourses;
    private String [] courses ;
    private int [] grades;


    public Student(String name, String address) : base(name, address){
  
    }
    public void addCourseGrade(String course, int grade) {
        int i =0;
        courses = new String[10];
        grades = new int[10];
        for (i=0; i<course.Length;i++){
            if(course[i] == null){
                courses[i] = course;
                grades[i] = grade;
            }
        }
    
    }
    public void printGrades(){
       for (int i=0;i<grades.Length; i++){
            Console.WriteLine(grades[i]);
       }
    }
    public double getAverageGrade(){
        int sum = 0;
       for (int i=0;i<grades.Length; i++){
            sum+=grades[i];
        }

        return sum/grades.Length;
    }
    public string toString(){
        return "Student[name = ";
    }




}
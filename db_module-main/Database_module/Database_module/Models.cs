using System.ComponentModel.DataAnnotations;

namespace Database_module
{
    // Teacher.cs
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Department.cs
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    // Subject.cs
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
    }

    // Grade.cs
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string GradeName { get; set; }
    }

    // Classroom.cs
    public class Classroom
    {
        [Key]
        public int ClassroomId { get; set; }
        public string ClassroomName { get; set; }
    }

    // Assignment.cs
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }
        public string AssignmentName { get; set; }
        public int SubjectId { get; set; }
        public DateTime Deadline { get; set; }
    }

    // Exam.cs
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public int SubjectId { get; set; }
        public DateTime Date { get; set; }
    }
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }

    // Enrollment.cs
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        // Navigation property
        public List<Enrollment> Enrollments { get; set; }
    }
}


    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    namespace Database_module
    {
    public class SchoolSeed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SchoolDbContext>();

                context.Database.EnsureCreated();

                // Check if there are any students in the database
                if (!context.Students.Any())
                {
                    // Seed students
                    context.Students.AddRange(new List<Student>
                    {
                        new Student
                        {
                            FirstName = "John",
                            LastName = "Doe",
                            Age = 18,
                            Grade = 12,
                         //   DepartmentId = 1 // Set the department ID based on your actual data
                        },
                        new Student
                        {
                            FirstName = "Alice",
                            LastName = "Smith",
                            Age = 17,
                            Grade = 11,
                           // DepartmentId = 2 // Set the department ID based on your actual data
                        },
                        // Add more students as needed
                    });

                    context.SaveChanges();
                }

                // Check if there are any courses in the database
                if (!context.Courses.Any())
                {
                    // Seed courses
                    context.Courses.AddRange(new List<Course>
                    {
                        new Course { CourseName = "Mathematics" },
                        new Course { CourseName = "History" },
                        // Add more courses as needed
                    });

                    context.SaveChanges();
                }

                // Check if there are any teachers in the database
                if (!context.Teachers.Any())
                {
                    // Seed teachers
                    context.Teachers.AddRange(new List<Teacher>
                    {
                        new Teacher { FirstName = "Professor", LastName = "Smith" },
                        new Teacher { FirstName = "Dr.", LastName = "Johnson" },
                        // Add more teachers as needed
                    });

                    context.SaveChanges();
                }

                // Add more seeding logic for other entities (e.g., Departments, Subjects, etc.) as needed
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstName="Carson",LastName="Henry",EnrollmentDate=DateTime.Parse("2021-01-18")},
                new Student{FirstName="Mary",LastName="Jane",EnrollmentDate=DateTime.Parse("2021-01-18")},
                new Student{FirstName="Bryan",LastName="Griffin",EnrollmentDate=DateTime.Parse("2021-01-18")},
                new Student{FirstName="Ken",LastName="Rogers",EnrollmentDate=DateTime.Parse("2021-01-18")},
                new Student{FirstName="Hailey",LastName="Lloyd",EnrollmentDate=DateTime.Parse("2021-01-18")},

            };

            var courses = new List<Course>
            {
                new Course{CourseID=1542,Title="Principles of Commercial Programming", Credits=1},
                new Course{CourseID=1541,Title="Information Systems", Credits=1},
                new Course{CourseID=1642,Title="Databases", Credits=1},
                new Course{CourseID=1641,Title="Information Systems and Packages", Credits=1},

            };

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1542, Grade="A"},
                new Enrollment{StudentID=1,CourseID=1541, Grade="A"},
                new Enrollment{StudentID=1,CourseID=1642, Grade="A"},
                new Enrollment{StudentID=1,CourseID=1641, Grade="A"},
                new Enrollment{StudentID=2,CourseID=1542, Grade="A"},
                new Enrollment{StudentID=2,CourseID=1541, Grade="C"},
                new Enrollment{StudentID=2,CourseID=1642, Grade="A"},
                new Enrollment{StudentID=2,CourseID=1641, Grade="B"},
                new Enrollment{StudentID=3,CourseID=1542, Grade="F"},
                new Enrollment{StudentID=3,CourseID=1541, Grade="C"},
                new Enrollment{StudentID=3,CourseID=1642, Grade="A"},
                new Enrollment{StudentID=3,CourseID=1641, Grade="B"},

            };

            students.ForEach(student => context.Students.Add(student));
            context.SaveChanges();

            courses.ForEach(course => context.Courses.Add(course));
            context.SaveChanges();

            enrollments.ForEach(enrollment => context.Enrollments.Add(enrollment));
            context.SaveChanges();

        }
    }
}

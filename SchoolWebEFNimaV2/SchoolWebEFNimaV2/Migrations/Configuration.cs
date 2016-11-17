namespace SchoolWebEFNimaV2.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolWebEFNimaV2.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SchoolWebEFNimaV2.Models.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Teachers.AddOrUpdate(
              p => p.TeacherName,
              new Teacher { TeacherName = "Mike", TeacherLastName = "Ash" },
              new Teacher { TeacherName = "Ulf", TeacherLastName = "Bregsson" },
              new Teacher { TeacherName = "Marcus", TeacherLastName = "Svenson" }
            );

            context.Students.AddOrUpdate(
              p => p.StudentFirstName,
              new Student { StudentFirstName = "Nima", StudentLastName ="Azizi" },
              new Student { StudentFirstName = "Davis", StudentLastName = "Davissss" },
              new Student { StudentFirstName = "Marcus", StudentLastName = "MArcusss" }
            );

            context.Assignments.AddOrUpdate(
              p => p.AssignmentName,
              new Assignment { AssignmentName = "Assignment 1", UploadDate = new DateTime(2016, 6, 10), DeadlineDate = new DateTime(2016, 12, 10) },
              new Assignment { AssignmentName = "Assignment 2", UploadDate = new DateTime(2016, 6, 10), DeadlineDate = new DateTime(2016, 12, 10) },
              new Assignment { AssignmentName = "Assignment 3", UploadDate = new DateTime(2016, 6, 10), DeadlineDate = new DateTime(2016, 12, 10) }
            );

            context.Courses.AddOrUpdate(
              p => p.CourseName,
              new Course { CourseName = "C#", StartDate = new DateTime(2016, 6, 10), EndDate = new DateTime(2016, 12, 10) },
              new Course { CourseName = ".Net", StartDate = new DateTime(2016, 6, 10), EndDate = new DateTime(2016, 12, 10) },
              new Course { CourseName = "SQL", StartDate = new DateTime(2016, 6, 10), EndDate = new DateTime(2016, 12, 10) }
            );
        }
    }
}

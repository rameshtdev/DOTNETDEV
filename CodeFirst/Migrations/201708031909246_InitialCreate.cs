namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        EnrollmentId = c.Int(nullable: false, identity: true),
                        CourseCourseId = c.Int(nullable: false),
                        StudentStudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnrollmentId)
                .ForeignKey("dbo.Courses", t => t.CourseCourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentStudentId, cascadeDelete: true)
                .Index(t => t.CourseCourseId)
                .Index(t => t.StudentStudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentStudentId", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "CourseCourseId", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "StudentStudentId" });
            DropIndex("dbo.Enrollments", new[] { "CourseCourseId" });
            DropTable("dbo.Students");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Courses");
        }
    }
}

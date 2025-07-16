using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using StudieApplication.Models;

namespace StudieApplication.Context
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> myContext) : base(myContext)
        {
            //
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            base.OnConfiguring(dbContextOptionsBuilder);
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true,
                reloadOnChange: true);
            IConfiguration config = builder.Build();
            var conString = config.GetConnectionString("MyDbConnectionString");
            dbContextOptionsBuilder.UseSqlServer(conString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

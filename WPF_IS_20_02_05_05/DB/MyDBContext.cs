using Microsoft.EntityFrameworkCore;


namespace WPF_IS_20_02_05_05.DB
{
    public class MyDBContext : DbContext
    {
        public string connectionString
            = "Server=192.168.10.134; Database=Antyamov_IS_20_20_05_05; user id=stud; password=stud;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Student> Students { get; set; }

    }
}

//add-migration
//update-database

using BenivoProject.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System;

namespace Benivo.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {       }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Bookmark> Bukmarks { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Role adminRole = new Role { Id = 1, Name = "admin" };
            Role userRole = new Role { Id = 2, Name = "user" };
            User adminUser = new User
            {
                Id = 1,
                UserName = "adminUserName",
                Password = "123456",
                RoleId = adminRole.Id
            };
            Category[] categories = new Category[]
            {
                new Category{ CreationDate=DateTime.Now, Id=1,Name="Software development"},
                new Category{ CreationDate=DateTime.Now, Id=2,Name="Quality Assurance"},
                new Category{ CreationDate=DateTime.Now, Id=3,Name="Web/Graphic design"},
                new Category{ CreationDate=DateTime.Now, Id=4,Name="Product/Project Management"},
                new Category{ CreationDate=DateTime.Now, Id=5,Name="Other IT"},
            };
            Location[] locations = new Location[]
            {
                new Location{CreationDate=DateTime.Now,Id=1,Country="Armenia",Region="Yerevan"},
                new Location{CreationDate=DateTime.Now,Id=2,Country="US",Region="CA",City="San Francisco"}
            };
            EmploymentType[] employmentType = new EmploymentType[]
            {
                new EmploymentType{Id=1,Name="Full Time"},
                new EmploymentType{Id=2,Name="Part Time"},
                new EmploymentType{Id=3,Name="Contractor"},
                new EmploymentType{Id=4,Name="Intern"},
                new EmploymentType{Id=5,Name="Seasonal/Temp"}
            };
            Job[] jobs = new Job[]
            {
                new Job{CreationDate=DateTime.Now,Id=1,CategoriId=1,EmploymentTypeId=1,LocationId=1,Title="Senior Web developer",Image="/Images/Benivo.png",Company="Benivo",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                new Job{CreationDate=DateTime.Now,Id=2,CategoriId=2,EmploymentTypeId=3,LocationId=2,Title="Quality developer",Image="/Images/Google.jpg",Company="Google",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                new Job{CreationDate=DateTime.Now,Id=3,CategoriId=3,EmploymentTypeId=1,LocationId=2,Title="Design developer",Image="/Images/Benivo.png",Company="Benivo",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                new Job{CreationDate=DateTime.Now,Id=4,CategoriId=2,EmploymentTypeId=2,LocationId=1,Title="Senior Quality developer",Image="/Images/Facebook.png",Company="Facebook",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                new Job{CreationDate=DateTime.Now,Id=5,CategoriId=1,EmploymentTypeId=1,LocationId=1,Title="Web developer",Image="/Images/Benivo.png",Company="Benivo",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
            };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Location>().HasData(locations);
            modelBuilder.Entity<Job>().HasData(jobs);
            modelBuilder.Entity<EmploymentType>().HasData(employmentType);
            base.OnModelCreating(modelBuilder);
        }

    }
}

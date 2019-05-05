using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ExamUpdateMethode.Dal
{
    public class ExamContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;initial catalog=ExamDb;integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Person> people { get; set; }
        public DbSet<Student> Students { get; set; }


        /// <summary>
        /// this great function made to custom update on some spacial field
        /// </summary>
        /// <typeparam name="Entity">
        /// Type what Entity you want to make any change on it
        /// </typeparam>
        /// <param name="e">
        /// The entity
        /// </param>
        /// <param name="ls">
        /// The list of field you want to update with this function
        /// </param>
        public void CustumUpdate<Entity>(Entity e ,List<string> ls)
        {
            foreach (var item in ls)
            {
                Entry(e).Property(item).IsModified = true;
                Console.WriteLine("{0} has status: " + Entry(e).Property(item).IsModified, e.ToString());
            }
            SaveChanges();
        }
    }
}

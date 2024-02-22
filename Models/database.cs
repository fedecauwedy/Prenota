
using Microsoft.EntityFrameworkCore;
using Prenota.Models;
public class dataBase : DbContext
    {
        private readonly DbContextOptions? _options;
        public dataBase(){}

        protected override void 
                OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=MioDB.db");

        public DbSet<Utente> Utenti { get ; set; }
    }

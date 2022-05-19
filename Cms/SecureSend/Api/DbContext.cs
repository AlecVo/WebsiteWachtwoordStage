using EncryptieAPI.Models;
using Microsoft.EntityFrameworkCore;

public class EncrypieContext : DbContext
    {
        public EncrypieContext(DbContextOptions options) : base(options) { }

        public DbSet<Bericht> Berichten { get; set; }
    }

using Microsoft.EntityFrameworkCore;

namespace note_api.Data
{
    public class NoteDataContext : DbContext
    {
        public NoteDataContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<Note> Notes { get; set; }
    }
}
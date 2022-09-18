namespace QuestionArea.DataAccess.DatabaseContexts;

using Microsoft.EntityFrameworkCore;

using Entities.Questionnaire;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Questionnaire?> Questionnaires { get; set; }
}
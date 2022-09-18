namespace QuestionArea.DataAccess.Repositories;

using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;

using DatabaseContexts;
using Entities.Questionnaire;
using Interfaces;

public class QuestionnaireRepository : IRepository<Questionnaire>
{
    private readonly DatabaseContext _context;

    public QuestionnaireRepository(DatabaseContext context)
    {
        _context = context;
    }
    
    public async Task<Questionnaire?> GetAsync(Expression<Func<Questionnaire, bool>> condition)
    {
        return await _context.Questionnaires
            .FirstOrDefaultAsync(condition!);
    }

    public async Task<List<Questionnaire?>> GetAllAsync()
    {
        return await _context.Questionnaires
            .ToListAsync();
    }

    public async Task<List<Questionnaire?>> GetAllAsync(Expression<Func<Questionnaire, bool>> condition)
    {
        return await _context.Questionnaires
            .Where(condition!)
            .AsQueryable()
            .ToListAsync();
    }

    public async Task AddAsync(Questionnaire item)
    {
        await _context.Questionnaires.AddAsync(item);
    }

    public Task UpdateAsync(Questionnaire item)
    {
        _context.Questionnaires.Update(item);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Expression<Func<Questionnaire, bool>> condition)
    {
        IEnumerable<Questionnaire?> removeItems = _context.Questionnaires.Where(condition!);
        _context.RemoveRange(removeItems!);
        return Task.CompletedTask;
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}
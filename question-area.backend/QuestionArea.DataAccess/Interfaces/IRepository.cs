using QuestionArea.Entities.Questionnaire;

namespace QuestionArea.DataAccess.Interfaces;

using System.Linq.Expressions;

public interface IRepository<T>
{
    Task<Questionnaire?> GetAsync(Expression<Func<T, bool>> condition);

    Task<List<Questionnaire?>> GetAllAsync();

    Task<List<Questionnaire?>> GetAllAsync(Expression<Func<T, bool>> condition);

    Task AddAsync(T item);

    Task UpdateAsync(T item);

    Task DeleteAsync(Expression<Func<T, bool>> condition);

    Task SaveAsync();
}
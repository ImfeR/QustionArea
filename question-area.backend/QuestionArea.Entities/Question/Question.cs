namespace QuestionArea.Entities.Question;

using Answer;

/// <summary>
/// Базовый класс вопроса
/// </summary>
public class Question
{
    public string Qustion { get; set; }

    /// <summary>
    /// Является ли вопрос с несколькими варинтами ответов.
    /// </summary>
    public bool IsMultipleAnswer { get; set; }

    /// <summary>
    /// Является ли вопрос обязательным для ответа.
    /// </summary>
    public bool IsRequiredAnswer { get; set; }
    
    /// <summary>
    /// Доступные ответы
    /// </summary>
    public List<Answer> AvailableAnswerList { get; set; }
}
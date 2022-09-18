namespace QuestionArea.Entities.Questionnaire;

using Question;

public class Questionnaire
{
    /// <summary>
    /// Навзание опросника
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Список вопросов
    /// </summary>
    public List<Question> QuestionList {get; set; }
}
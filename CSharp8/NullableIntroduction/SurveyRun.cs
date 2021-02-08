using System.Collections.Generic;

namespace CSharp8.NullableIntroduction
{
    public enum QuestionType
    {
        YesNo,
        Number,
        Text
    }

    public class SurveyQuestion
    {
        public string QuestionText { get; }
        public QuestionType TypeOfQuestion { get; }

        public SurveyQuestion(QuestionType typeOfQuestion, string text) =>
            (TypeOfQuestion, QuestionText) = (typeOfQuestion, text);
    }

    public class SurveyRun
    {
        public List<SurveyQuestion> SurveyQuestions = new List<SurveyQuestion>();

        public void AddQuestion(QuestionType type, string question) =>
            AddQuestion(new SurveyQuestion(type, question));

        public void AddQuestion(SurveyQuestion surveyQuestion) =>
            SurveyQuestions.Add(surveyQuestion);
    }
}

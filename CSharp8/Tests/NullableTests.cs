using CSharp8.NullableIntroduction;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CSharp8.Tests
{
    public class NullableTests : BaseTest
    {
        public NullableTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestAddSurvey()
        {
            var surveyRun = new SurveyRun();
            surveyRun.AddQuestion(QuestionType.YesNo, "Has your code ever thrown a NullReferenceException?");
            surveyRun.AddQuestion(new SurveyQuestion(QuestionType.Number, "How many times (to the nearest 100) has that happened?"));
            surveyRun.AddQuestion(QuestionType.Text, "What is your favorite color?");

            Output.WriteLine(JsonConvert.SerializeObject(surveyRun));
            Assert.True(surveyRun.SurveyQuestions.Count == 3);
        }
    }
}

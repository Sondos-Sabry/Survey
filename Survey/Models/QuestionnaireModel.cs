namespace Survey.Models
{
    public class Questionnaire
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public int Id { get; set; }
        public string Body { get; set; }
        //public List<Answer> Answers { get; set; }
        public List<Answer> Answers { get; set; } //to avoid null refrence exception


    }

    public class Answer
    {
        public int Id { get; set; }

        public string Text { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
        //public int Points { get; set; }
    }

    public class UserResponse
    {
        public int Id { get; set; }
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }

        //public Answer Answer { get; set; }
    }

}

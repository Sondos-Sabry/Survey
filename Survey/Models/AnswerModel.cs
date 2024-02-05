namespace Survey.Models
{
	public class AnswerModel
	{
		public int Id { get; set; }
		public string AnswerText { get; set; }
		public int SurveyId { get; set; }
		public SurveyModel Survey { get; set; }
	}
}

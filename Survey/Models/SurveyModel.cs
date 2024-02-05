namespace Survey.Models
{
	public class SurveyModel
	{
		public int Id { get; set; }
		public string Question { get; set; }
		public ICollection<AnswerModel> Answers { get; set; }
	}


}

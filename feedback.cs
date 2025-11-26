namespace FeedbackWebApplication.Models
{
    public class feedback
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string Rating { get; set; }
        public string Sentiment { get; set; }
        public DateTime SubmittedAt {  get; set; }
    }
}

namespace BSIT_32E1_Elective_2_Assignment_1.Models
{
    public class QuizQuestion
    {
        public int Number { get; set; }
        public string Question { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new();
        public string CorrectAnswer { get; set; } = string.Empty;
    }
}
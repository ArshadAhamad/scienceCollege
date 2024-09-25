using System.Text.Json.Serialization;

namespace scienceCollege.Exams.Modles
{
    public class ExamModel
    {
        public int Id { get; set; }
        public string? ExamName { get; set; }
        public string? Module { get; set; }
        
        public DateTime? ExamDate { get; set; }
       
        public string? Department { get; set; }
        public string? Specialization { get; set; }
        public int Year { get; set; }
        public int NoOfQuestion { get; set; }
    }
}

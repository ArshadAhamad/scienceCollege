using System.Reflection;

namespace scienceCollege.Exams.Data
{
    public class ExamDataService
    {
        public static List<Modles.ExamModel> exams = new List<Modles.ExamModel>()
        {
            new Modles.ExamModel {Id = 1, ExamName = "Mid",Module = "MTIT", ExamDate = new DateTime(2023, 04, 25), Department = "FOC", Specialization = "IT", Year = 4, NoOfQuestion = 50 },
            new Modles.ExamModel {Id = 2, ExamName ="Mid",Module = "MTIT", ExamDate = new DateTime(2023, 04, 25), Department = "FOC", Specialization = "SE", Year = 4, NoOfQuestion = 50 },
            new Modles.ExamModel {Id = 3, ExamName ="Mid",Module = "MTIT", ExamDate = new DateTime(2023, 04, 25), Department = "FOC", Specialization = "IT", Year = 4, NoOfQuestion = 50 },
            new Modles.ExamModel {Id = 4, ExamName ="Mid",Module = "MTIT", ExamDate = new DateTime(2023, 04, 25), Department = "FOC", Specialization = "SE", Year = 4, NoOfQuestion = 50 },
        };
    }
}

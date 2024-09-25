using System.Reflection;

namespace scienceCollege.Exams.Services
{
    public interface IExamService
    {

        List<Modles.ExamModel> GetExams();
        Modles.ExamModel? GetExams(int id);
        Modles.ExamModel? AddExams(Modles.ExamModel Exams);
        Modles.ExamModel? UpdateExams(Modles.ExamModel Exams);
        bool? DeleteExams(int id);
    }
}

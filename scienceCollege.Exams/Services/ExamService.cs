using scienceCollege.Exams.Data;
using System.Reflection;
using scienceCollege.Exams.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scienceCollege.Exams.Services
{
   
        public class ExamService:IExamService
        {
            public List<Modles.ExamModel> GetExams()
            {
                return ExamDataService.exams;

            }
            public Modles.ExamModel? GetExams(int id)
            {
                return ExamDataService.exams.FirstOrDefault(x => x.Id == id);
            }
            public Modles.ExamModel? AddExams(Modles.ExamModel exam)
            {
                ExamDataService.exams.Add(exam);
                return exam;
            }
            public Modles.ExamModel? UpdateExams(Modles.ExamModel exam)
            {
                Modles.ExamModel selectedExam = ExamDataService.exams.FirstOrDefault(x => x.Id == exam.Id);
                if (selectedExam != null)
                {
                    selectedExam.ExamName = exam.ExamName;
                    selectedExam.Module = exam.Module;
                    selectedExam.ExamDate = exam.ExamDate;
                    selectedExam.Department = exam.Department;
                    selectedExam.Specialization = exam.Specialization;
                    selectedExam.Year = exam.Year;
                    selectedExam.NoOfQuestion = exam.NoOfQuestion;
                    return selectedExam;
                }

                return selectedExam;
            }

            public bool? DeleteExams(int id)
            {
               Modles.ExamModel selectedExam = ExamDataService.exams.FirstOrDefault(x => x.Id == id);
                if (selectedExam != null)
                {
                    ExamDataService.exams.Remove(selectedExam);
                    return true;
                }
                return false;
            }
        }
    }


using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Survey.Interface
{
   public interface ITechSurveyRepository
    {
        Task<IEnumerable<TechSurvey>> GetTechSurvey();
        Task<TechSurvey> GetTechSurveyById(string id);
        Task<bool> PostTechSurvey(TechSurvey obj);
        Task<bool> UpdateTechSurvey(TechSurvey obj);
        Task<bool> DeleteTechSurvey(string id);
    }
}

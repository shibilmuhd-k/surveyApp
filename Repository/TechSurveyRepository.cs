using Survey.DBContext;
using Survey.Interface;
using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Survey.Repository
{
    public class TechSurveyRepository : ITechSurveyRepository
    {
        private readonly SQLContext _dbContext;
        public TechSurveyRepository(SQLContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<IEnumerable<TechSurvey>> GetTechSurvey()
        {
            try
            {
                var TechSurveyList = (IEnumerable<TechSurvey>)_dbContext.TechSurvey;
                if (TechSurveyList != null && TechSurveyList.Count() > 0)
                {
                    return Task.FromResult(TechSurveyList);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<TechSurvey> GetTechSurveyById(string TechSurveyID)
        {
            try
            {
                TechSurvey result = new TechSurvey();
                TechSurvey TechSurveyObj = _dbContext.TechSurvey.Where(TechSurvey => TechSurvey.id == TechSurveyID).FirstOrDefault();
                if (TechSurveyObj != null)
                {
                    return Task.FromResult(TechSurveyObj);
                }
                else
                {
                    return Task.FromResult(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<bool> PostTechSurvey(TechSurvey obj)
        {
            bool result = false;
            try
            {
                obj.id = Guid.NewGuid().ToString();
                obj.createdDate = DateTime.Now.ToString();
                _dbContext.TechSurvey.Add(obj);
                var result1 = _dbContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Task.FromResult(result);
        }

        public Task<bool> UpdateTechSurvey(TechSurvey obj)
        {
            bool result = false;
            try
            {
                TechSurvey TechSurveyObj = _dbContext.TechSurvey.Where(TechSurvey => TechSurvey.id == obj.id).FirstOrDefault();
                if (TechSurveyObj != null)
                {
                    if (TechSurveyObj.id != null && obj.id == TechSurveyObj.id && obj.id == TechSurveyObj.id)
                    {
                        TechSurveyObj.id = obj.id;
                        TechSurveyObj.question = obj.question;
                        TechSurveyObj.type = obj.type;
                        TechSurveyObj.updatedDate = DateTime.Now.ToString();
                        TechSurveyObj.createdDate = obj.createdDate;

                        _dbContext.TechSurvey.Update(TechSurveyObj);
                        result = Convert.ToBoolean(_dbContext.SaveChanges());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Task.FromResult(result);
        }

        public Task<bool> DeleteTechSurvey(string TechSurveyID)
        {
            bool result = false;
            try
            {
                var obj = _dbContext.TechSurvey.Where(TechSurvey => TechSurvey.id == TechSurveyID).FirstOrDefault();
                if (obj != null)
                {
                    _dbContext.TechSurvey.Remove(obj);
                    result = Convert.ToBoolean(_dbContext.SaveChanges());
                }
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

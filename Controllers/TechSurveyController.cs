using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survey.Interface;
using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Controllers
{
    /// <summary>
    /// API: Tech Survey Controller
    /// Date: 19/01/2022
    /// Name: Muhammed Shibil K
    /// </summary>
    /// <param name=""></param>
    /// <returns></returns>

    [Route("api/[controller]")]
    [ApiController]
    public class TechSurveyController : ControllerBase
    {
        private readonly ITechSurveyRepository _techSurveyRepository;
        public TechSurveyController(ITechSurveyRepository techSurveyRepository)
        {
            _techSurveyRepository = techSurveyRepository;
        }

        /// <summary>
        /// Method is to get TechSurvey data fron dbo.TechSurvey
        /// </summary>
        /// <param name=""></param>
        /// <returns>TechSurvey data</returns>


        // GET: api/<TechSurveyController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var techSurvey = await _techSurveyRepository.GetTechSurvey();
                if (techSurvey != null)
                {
                    return Ok(techSurvey);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method is to get TechSurvey data fron dbo.TechSurvey by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TechSurvey data</returns>

        // GET api/<TechSurveyController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {

            try
            {
                TechSurvey techSurvey = await _techSurveyRepository.GetTechSurveyById(id);
                if (techSurvey != null)
                {
                    return Ok(techSurvey);
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

        /// <summary>
        /// Method is to post TechSurvey data in dbo.TechSurvey
        /// </summary>
        /// <param class="TechSurvey"></param>
        /// <returns>bool</returns>

        [HttpPost]
        public async Task<bool> Post(TechSurvey obj)
        {
            try
            {
                var result = await _techSurveyRepository.PostTechSurvey(obj);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method is to update TechSurvey data in dbo.TechSurvey
        /// </summary>
        /// <param class="TechSurvey"></param>
        /// <returns>bool</returns>

        [HttpPut]
        public async Task<bool> Put(TechSurvey obj)
        {
            try
            {
                var result = await _techSurveyRepository.UpdateTechSurvey(obj);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method is to delete TechSurvey data in dbo.TechSurvey by id
        /// </summary>
        /// <param class="TechSurvey"></param>
        /// <returns>bool</returns>


        [HttpPost("{id}")]
        public async Task<bool> Delete(string id)
        {
            try
            {
                var result = await _techSurveyRepository.DeleteTechSurvey(id);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


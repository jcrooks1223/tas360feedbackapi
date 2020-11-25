using System.Net.Mime;
using System.IO.Pipes;
using System.Xml.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Database;
using API.Models;
using API.Models.Interfaces;
using Microsoft.AspNetCore.Cors;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class feedbackController : ControllerBase
    {
        // GET: api/feedback
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Survey> Get()
        {

            //ISeedData seedObj = new SaveData();
            //seedObj.SeedData(); 

            IGetAllSurveys readObj = new ReadFeedbackData();
            return readObj.GetAllSurveys();
        }

        // GET: api/feedback/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public Survey Get(int id)
        {
            IGetSurvey readObj = new ReadFeedbackData();
            return readObj.GetSurvey(id);
        }

        // POST: api/feedback
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] Survey value)
        {
            IInsertSurvey saveObject = new SaveSurvey();
            saveObject.InsertSurvey(value); 
        }

        // PUT: api/feedback/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

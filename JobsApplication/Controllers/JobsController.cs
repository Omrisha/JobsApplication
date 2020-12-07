using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobsApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private IJobsServices _jobsServices;
        public JobsController(IJobsServices jobsServices)
        {
            _jobsServices = jobsServices;
        }

        // GET: api/Jobs/dr
        [HttpGet("Titles/{prefex}")]
        public string[] Titles(string prefex)
        {
            return _jobsServices.findEntitiesForAutoCompleteContains(prefex).ToArray();
        }

        [HttpGet("{title}")]
        // GET: api/Jobs/Driver
        public string[] Get(string title)
        {
            return _jobsServices.findEntities(title).ToArray();
        }
    }
}

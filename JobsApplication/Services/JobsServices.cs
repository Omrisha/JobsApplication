using System;
using System.Collections.Generic;
using System.Linq;

namespace JobsApplication.Services
{
    public class JobsServices : IJobsServices
    {
        private JobDbContext jobDbContext;

        public JobsServices(JobDbContext _jobDbContext)
        {
            jobDbContext = _jobDbContext;
        }

        public List<string> findEntitiesForAutoCompleteContains(string prefix)
        {
            var jobs = new List<string>();

            if (prefix.Length >= 2)
            {
                jobs = jobDbContext.JobTitles.Where(j => j.Name.ToLower().Contains(prefix)).Select(job => job.Name).ToList();
                return jobs;
            }
            else
                return jobs;
        }

        public List<string> findEntities(string title)
        {
            var jobs = new List<string>();

            var jobTitle = jobDbContext.JobTitles.Where(j => j.Name == title).FirstOrDefault();
            var jobsPerTitle = jobDbContext.Jobs.Where(j => j.TitleId == jobTitle.Id && j.CategoryId == jobTitle.CategoryId).Select(job => job).ToList();

            if (jobsPerTitle.Count > 0)
            {
                jobs.Add("The relevant jobs are:");
                jobsPerTitle.ForEach(j => jobs.Add($"{jobTitle.Name} in {j.City}, {j.State}"));

                var removedDuplicates = jobs.Distinct(); 
                return removedDuplicates.ToList();
            }
            else
            {
                jobs.Add("No relevant jobs are found.");
                return jobs;
            }
        }
    }
}

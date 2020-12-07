using System.Collections.Generic;

namespace JobsApplication.Services
{
    public interface IJobsServices
    {
        List<string> findEntities(string title);
        List<string> findEntitiesForAutoCompleteContains(string prefix);
    }
}
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public  interface IJobRepository
    {
        public List<Jobs> GetJobs();
        public Jobs GetJobDetails(int jobId);

    }
}

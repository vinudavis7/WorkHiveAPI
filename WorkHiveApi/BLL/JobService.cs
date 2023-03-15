﻿using BLL.Interface;
using DAL;
using DAL.Repository;
using DAL.Repository.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class JobService:IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public List<Job> GetJobs()
        {
            try
            {
                return _jobRepository.GetJobs();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Job GetJobDetails(int jobId)
        {
            try
            {
                return _jobRepository.GetJobDetails(jobId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Job CreateJob(Job job)
        {
            try
            {
                return _jobRepository.CreateJob(job);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Job UpdateJob(Job job)
        {
            try
            {
                return _jobRepository.UpdateJob(job);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
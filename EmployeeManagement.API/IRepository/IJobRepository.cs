﻿using EmployeeManagement.API.DTOs.Job;

namespace EmployeeManagement.API.IRepository
{
    public interface IJobRepository
    {
        Task<int> CreateJobAsync(JobCreate jobCreate);
        Task UpdateJobAsync(JobUpdate jobUpdate);
        Task<List<JobGet>> GetJobsAsync();
        Task<JobGet> GetJobAsync(int id);
        Task DeleteJobAsync(JobDelete jobDelete);
    }
}

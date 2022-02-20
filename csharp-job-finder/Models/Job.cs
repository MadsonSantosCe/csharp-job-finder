using System;
using System.ComponentModel.DataAnnotations;

namespace csharp_job_finder.Models
{
    public class Job
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description  { get; set; }
        
        public decimal Salary { get; set; }

        public string Company { get; set; }
        
        public string Email { get; set; }        

        public DateTime? CreatedAt { get; set; }

        public bool? NewJob { get; set; }

        public Job()
        {

        }
        
    }
}

﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Job
    {
        public int JobId { get; set; }  
        public string Title { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Budget { get; set; }
        public string SkillTags { get; set; }
        public string JobType { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime DatePosted { get; set; }
        public virtual ICollection<Bid> Bids { get; set; } =
        new List<Bid>();

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movil.Models
{
    public class CourseContent
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }

        public string Description { get; set; }
        
        public int Cost { get; set; }

        public bool Status { get; set; }

        public Course Course { get; set; }

        public ICollection<CourseContentOrder> CourseContentOrders { get; set; }
    }
}

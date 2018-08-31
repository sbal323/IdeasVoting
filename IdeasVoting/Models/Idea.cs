﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeasVoting.Models
{
    public class Idea
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //ES Properties
        public IdeaStatus Status { get; set; }
    }
}

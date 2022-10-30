﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Kentucky_Semester_One_Final_Project
{
    internal class Post
    {
        public int? position { get; set; }
        public string? album_id { get; set; }
        public string? artist { get; set; }
        public object? name { get; set; }
        public int? date { get; set; }
        public string? genres { get; set; }
        public float? rating { get; set; }
        public int? num_ratings { get; set; }
        public int? num_reviews { get; set; }
    }
}
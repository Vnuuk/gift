﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NS.Elenalife.UI
{
    [Table("Post")]
    public class Post 
    {
        public Post()
        {
            Images = new List<Image>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
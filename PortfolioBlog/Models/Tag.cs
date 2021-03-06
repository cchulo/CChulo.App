﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cchulo.App.PortfolioBlog.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<BlogPost> BlogPosts { get; set; }
    }

    public class TagsType
    {
        public List<Tag> Tags { get; set; }
    }
}

﻿using System.Collections.Generic;
using Newtonsoft.Json;
using TypeGen.Core.TypeAnnotations;

namespace cchulo.App.PortfolioBlog.Models
{
    
    [ExportTsClass]
    public class BlogPost
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [JsonProperty(PropertyName = "published_at")]
        public string PublishedAt { get; set; }

        public string Description { get; set; }

        public string Contents { get; set; }

        public UploadFile Banner { get; set; }

        public List<UploadFile> Resources { get; set; }

        public List<UploadFile> Downloadable { get; set; }

        public List<Tag> Tags { get; set; }
    }

    public class BlogPostsType
    {
        public List<BlogPost> BlogPosts { get; set; }
    }
}

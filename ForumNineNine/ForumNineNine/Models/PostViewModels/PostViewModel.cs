﻿using ForumNineNine.Models.ForumViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumNineNine.Models.PostViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int AuthorRating { get; set; }
        public string AuthorId { get; set; }
        
        public string DatePosted { get; set; }

        public ForumViewModel Forum { get; set; }
        public int RepliesCount { get; set; }
    }
}
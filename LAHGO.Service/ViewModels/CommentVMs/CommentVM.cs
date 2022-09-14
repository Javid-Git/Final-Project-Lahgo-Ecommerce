﻿using LAHGO.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAHGO.Service.ViewModels.CommentVMs
{
    public class CommentVM
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Nullable<int> ProductId { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int Rating { get; set; }
    }
}

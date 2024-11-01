﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Shared.Categories
{
    //dung de chua cac tham so cap nhat
    public class UpdateCategoryRequest
    {
        [Required]
        public string Id { set; get; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string UrlPath { get; set; }
    }
}
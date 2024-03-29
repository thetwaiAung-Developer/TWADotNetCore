﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TWADotNetCore.MinimalApi.Models
{
    [Table("Tbl_Blog1")]
    public class BlogModel
    {
        [Key]
        public int Blog_Id { get; set; }
        public string Blog_Title { get; set; }
        public string Blog_Content { get; set; }
        public string Blog_Author { get; set; }
    }
}

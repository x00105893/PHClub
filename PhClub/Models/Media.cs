﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhClub.Models
{
    public class Media
    {
        public int Id { get; set; }

        public string title { get; set; }
        public string description { get; set; }
        [Required, StringLength(2048), DataType(DataType.MultilineText)]
        public string body { get; set; }
    }
}
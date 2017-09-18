
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhClub.Models
{
    public class Video
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Required, StringLength(512)]
        [AllowHtml]
        public string Description { get; set; }
        [Required]
        [AllowHtml]
        public string Body { get; set; }
        public string VideoLink { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string tags { get; set; }
        public string ImagePath { get; set; }
    }

}

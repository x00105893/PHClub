using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhClub.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhClub.Models
{
    public class Media
    {
        public int Id { get; set; }

        public string title { get; set; }
        [Required, StringLength(512)]
        public string description { get; set; }
        [Required]
        //DataType(DataType.MultilineText), StringLength(2048)
        [AllowHtml]
        public string body { get; set; }
        public string ImagePath { get; set; }

        public string VideoLink { get; set; }

        public string Source { get; set; }
        public string tags { get; set; }
        public TagsEnum TagsEnum { get; set; }


        //[DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        [DisplayFormat(DataFormatString = "{0:dd MMMM , yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? NewsDate { get; set; }

    }
}
    
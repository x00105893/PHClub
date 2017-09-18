using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PhClub.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required, StringLength(512)]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM , yyyy HH:mm}", ApplyFormatInEditMode = true)]

        public DateTime Date { get; set; }
        public string DayOfEvent {

            get {
                string dayOfWeek = Date.ToString("dddd", new System.Globalization.CultureInfo("ru-RU"));
                dayOfWeek = char.ToUpper(dayOfWeek[0]) + dayOfWeek.Substring(1);
                return dayOfWeek + "  " + Date.ToShortDateString() + "  " + Date.TimeOfDay.ToString();
            }
        }

        //public string Time { get; set; }
        public string Location { get; set; }
        public string Responsible { get; set; }
        [Required, StringLength(2048), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Keywords { get; set; }

    }
}
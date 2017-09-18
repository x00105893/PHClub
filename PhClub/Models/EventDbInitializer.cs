using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhClub.Models
{
    public class EventDbInitializer : DropCreateDatabaseAlways<EventsContext>
    {
        protected override void Seed(EventsContext db)
        {
            //db.Events.Add(new Event { Title = "Name of Event", Date = 18/11/2017, Time = "20:00", Location = "Adress", Responsible = "Name" });
           // db.Events.Add(new Event { Title = "Name of Event", Date = 03/03/2017, Time = "19:00", Location = "Adress", Responsible = "Name2" });
             //db.Events.Add(new Event { Title = "Занятие 3", Date = "04/03/2017", Time = "217:00", Location = "Школа", Responsible = "Вадим"});
            //db.Medias.Add(new Media { title = "1 Новость", description = "Описание тут", body = "Текст", ImagePath = "", VideoLink = "", Source = "", TagsEnum = "Здоровье" });

            base.Seed(db);
        }
    }

}

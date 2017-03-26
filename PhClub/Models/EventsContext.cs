﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhClub.Models
{
    public class EventsContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Media> Medias { get; set; }
        
      
    }
 
}

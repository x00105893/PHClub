﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;


namespace PhClub.Models
{
    public class ApplicationManager : UserManager<ApplicationUser>
    {
        public ApplicationManager(IUserStore<ApplicationUser> store)
            : base(store)
        {
        }
        public static ApplicationManager Create(IdentityFactoryOptions<ApplicationManager> options,
                                            IOwinContext context)
        {
            EventsContext db = context.Get<EventsContext>();
            ApplicationManager manager = new ApplicationManager(new UserStore<ApplicationUser>(db));
            return manager;
        }
    }
}
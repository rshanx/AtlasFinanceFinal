﻿using System.Web.Mvc;

namespace Falcon.Areas.User
{
  public class UserAreaRegistration : AreaRegistration
  {
    public override string AreaName
    {
      get
      {
        return "User";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      context.MapRoute(
          "UserManagement",
          "User/{controller}/{action}/{id}",
          new { action = "Index", id = UrlParameter.Optional }
      );
    }
  }
}
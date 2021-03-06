﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace LogbookUI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));


            config.Routes.MapHttpRoute(
                name: "GetActivitiesForApp",
                routeTemplate: "api/activities/{userid}", 
                defaults: new { controller = "Api", action = "GetActivitiesForApp" }
            );
            config.Routes.MapHttpRoute(
                name: "GetLogbooksForUser",
                routeTemplate: "api/logbooks/{userid}",
                defaults: new { controller = "Api", action = "GetLogbooksForUser" }
            );
            config.Routes.MapHttpRoute(
                name: "Ping",
                routeTemplate: "api/ping/",
                defaults: new { controller = "Api", action = "Ping" }
            );
            config.Routes.MapHttpRoute(
                name: "GetEntries",
                routeTemplate: "api/getentries/{userId}",
                defaults: new { controller = "Api", action = "GetEntries" }
            );
            config.Routes.MapHttpRoute(
                name: "GetFields",
                routeTemplate: "api/getfields/{userId}",
                defaults: new { controller = "Api", action = "GetFieldsForUser" }
            );
            config.Routes.MapHttpRoute(
                name: "GetFieldOptions",
                routeTemplate: "api/getfieldoptions/{userId}",
                defaults: new { controller = "Api", action = "GetFieldOptionsForUser" }
            );
            config.Routes.MapHttpRoute(
                name: "Login",
                routeTemplate: "api/login/",
                defaults: new { controller = "Api", action = "Login" }
            );
            config.Routes.MapHttpRoute(
                name: "DeleteEntry",
                routeTemplate: "api/deleteentry/{entryId}",
                defaults: new { controller = "Api", action = "DeleteEntry" }
            );
            config.Routes.MapHttpRoute(
                name: "Upload",
                routeTemplate: "api/upload/{userId}",
                defaults: new { controller = "Api", action = "SyncAll" }
            );
            config.Routes.MapHttpRoute(
                name: "Export",
                routeTemplate: "api/export/",
                defaults: new { controller = "Api", action = "Export" }
            );




            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

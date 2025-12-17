using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace PracticeForWebApp.Basics.Middlewares
{
    public class ConfigUsingUseMethod
    {
        /*
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            //Configuring First Middleware Component using Use Extension Method
            app.Use(async (context, next) => 
            {
                await context.Response.WriteAsync("Getting Response from first middleware");
                await next();
            });

            //Configuring Second Middleware Component using Run Extension Method
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("\nGetting response from second middleware");
            });

            app.Run();
        }
        */
    }
}

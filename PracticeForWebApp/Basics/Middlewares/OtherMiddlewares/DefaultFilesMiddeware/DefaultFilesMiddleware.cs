using Microsoft.AspNetCore.Http;

namespace PracticeForWebApp.Basics.Middlewares.OtherMiddlewares.DefaultFilesMiddeware
{
    public class DefaultFilesMiddleware
    {
        /*
        public static void Main(string[] args)
        {
            // Initializes the configuration for the web application
            var builder = WebApplication.CreateBuilder();

            // Builds the web application based on the configured settings
            var app = builder.Build();

            //Setting the Default Files
            app.UseDefaultFiles();

            //Adding Static Files Middleware Component to serve the static files
            app.UseStaticFiles();

            //Adding Another Middleware Component to the Request Processing Pipeline
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Request Handled and Response Generated");
            });

            app.Run();
        }
        */
    }
}

// Note: You need to add the UseDefaultFiles() middleware before the UseStaticFiles() middleware to serve the default file. Remember that the UseDefaultFiles() middleware is just a URL rewriter, and it never serves static files. Its job is to simply rewrite the incoming URL to the default file, which will then be served by the Static Files Middleware.

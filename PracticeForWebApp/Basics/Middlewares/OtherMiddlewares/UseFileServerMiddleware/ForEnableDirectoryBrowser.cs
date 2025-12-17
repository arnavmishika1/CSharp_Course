using Microsoft.Extensions.FileProviders;

namespace PracticeForWebApp.Basics.Middlewares.OtherMiddlewares.UseFileServerMiddleware
{
    public class ForEnableDirectoryBrowser
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            // Configure FileServer options for root directory browsing
            var fileServerOption = new FileServerOptions
            {
                EnableDirectoryBrowsing = true, // Enable directory browsing at the root URL
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"))
            };

            // Enable Default File, Static File, and Directory Browsing at the root URL
            app.UseFileServer(fileServerOption);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Request handled and response generated");
            });

            app.Run();
        }
    }
}

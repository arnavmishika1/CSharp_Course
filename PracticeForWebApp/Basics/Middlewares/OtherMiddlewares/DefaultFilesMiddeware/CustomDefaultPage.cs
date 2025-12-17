namespace PracticeForWebApp.Basics.Middlewares.OtherMiddlewares.DefaultFilesMiddeware
{
    public class CustomDefaultPage
    {
        /*
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            //First Create an Instance of DefaultFilesOptions
            var defaultOptions = new DefaultFilesOptions();

            //Clear any DefaultFileNames if already there
            defaultOptions.DefaultFileNames.Clear();

            //Add the default HTML Page to the DefaultFilesOptions Instance
            defaultOptions.DefaultFileNames.Add("MyCustomeDefaultPage.html");

            //Setting the Default Files
            //Pass the DefaultFilesOptions Instance to the UseDefaultFiles Middleware Component
            app.UseDefaultFiles(defaultOptions);

            //Adding Static Files Middleware Component to serve the static files
            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Request handled and response generated");
            });

            app.Run();
        }
        */
    }
}

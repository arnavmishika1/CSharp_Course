namespace PracticeForWebApp.Basics.Middlewares
{
    public class UseMethodAsATerminalMiddleware
    {
        /*
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder();

            var app = builder.Build();

            app.Use(async (HttpContext context, RequestDelegate next) =>
            {
                await context.Response.WriteAsync("Getting response from First middleware");
                // Here we are not calling the next method to prevent call to next middleware
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Getting response from Second middlerware");
            });

            app.Run();
        }
        */
    }
}

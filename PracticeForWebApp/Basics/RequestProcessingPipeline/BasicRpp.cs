namespace PracticeForWebApp.Basics.RequestProcessingPipeline
{
    public class BasicRpp
    {
        /*
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder();

            var app = builder.Build();

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Middleware1: Incoming Request\n");
                await next();
                await context.Response.WriteAsync("Middleware1: Outgoing Response\n");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Middleware2: Incoming Request\n");
                await next();
                await context.Response.WriteAsync("Middleware2: Outgoing Response\n");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Middleware3: Incoming Request handled and response generated\n");
                //Terminal Middleware Component i.e. cannot call the Next Component
            });

            app.Run();
        }
        */
    }
}

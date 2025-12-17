namespace PracticeForWebApp.Basics.Middlewares
{
    public class ConfigUsingRunMethod
    {
        /*
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder();

            var app = builder.Build();

            //Configuring First Middleware Component using Run Extension Method
            app.Run(async (context) => 
            {
                await context.Response.WriteAsync("Getting response from first middleware");
            });

            //Configuring Second Middleware Component using Run Extension Method
            // When we register a middleware component using the Run() extension method, that component becomes a terminal component, meaning it will not call the next middleware component registered in the request processing pipeline.
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Getting response from second middleware");
            });

            app.Run();
        }
        */
    }
}

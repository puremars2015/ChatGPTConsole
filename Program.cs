using OpenAI_API;

namespace ChatGPTConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }

        private static string Demo()
        {
            OpenAIAPI api = new OpenAIAPI("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");
            api.
        }
    }
}
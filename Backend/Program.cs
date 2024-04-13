namespace Backend;

public static class Program
{
    public static void Main(string[] args)
    {
        var webApplicationBuilder = WebApplication.CreateBuilder(args);

        var webApplication = webApplicationBuilder.Build();

        webApplication.UseDefaultFiles();
        webApplication.UseStaticFiles();

        webApplication.MapFallbackToFile("index.html");

        webApplication.Run();
    }
}
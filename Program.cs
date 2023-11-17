namespace WebApplication6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute("main", "{controller=Home}/{action=Index}/{id?}");

            app.UseStatusCodePages(async context =>
            {
                if (context.HttpContext.Response.StatusCode == 404)
                {
                    context.HttpContext.Response.Redirect("/");
                }
            }
            );


            app.Run();
        }
    }
}
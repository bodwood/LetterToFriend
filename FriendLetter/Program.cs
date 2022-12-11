using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace FriendLetter
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //creates a web app

      builder.Services.AddControllersWithViews();

      WebApplication app = builder.Build(); //createswebapplication host app

      app.UseHttpsRedirection();  //configure our host to redirect to HTTPS when web app is accessed via HTTP

      app.UseRouting();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run();
    }
  }
}
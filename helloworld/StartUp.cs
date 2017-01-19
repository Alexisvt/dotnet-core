using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    class StartUp
  {
    public void Configure(IApplicationBuilder app)
    {
      app.Run(
        context => context.Response.WriteAsync("Hello Alexis on the web!")
      );
    }
  }
}
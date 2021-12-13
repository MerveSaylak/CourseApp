var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc(option => option.EnableEndpointRouting=false);

var app = builder.Build();

app.UseStaticFiles();

app.UseMvc(routes =>
{
    routes.MapRoute(
      "CoursesByReleased",
      "courses/released/{year}/{month}",
       new { controller = "Course", action = "ByReleased" }
     );
    routes.MapRoute(
        name: "default", 
        template:"{controller=Home}/{action=Index}/{id?}"
      );        
 });


//app.MapGet("/", () => "Hello World!");

app.Run();


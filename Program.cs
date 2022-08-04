// the variable Builder is an  instance of the WebApplication class
var builder = WebApplication.CreateBuilder(args);
// we are adding a so-called "service" into our application's Service Container. This makes the specified service available to the rest of your application in a number of ways
builder.Services.AddControllersWithViews();
// build is  
var app = builder.Build();
// we need to use  this  after we set up the app variable to be Builder to implement MVC on its entirety
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
// "Pattern" is what allows us to specify methods of our route in our Controller files
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

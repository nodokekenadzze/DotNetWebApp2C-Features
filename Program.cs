// Creates a new WebApplicationBuilder instance for configuring the web application
var builder = WebApplication.CreateBuilder(args);

// Adds services to the container for MVC support (controllers and views)
builder.Services.AddControllersWithViews();

// Builds the application from the configuration specified in the builder
var app = builder.Build();

// Maps the default route for MVC controllers (essentially wires up controller actions to routes)
app.MapDefaultControllerRoute();

// Starts the application and begins listening for HTTP requests
app.Run();

using Dependency_Injection_Demo.Services.AddScoped;
using Dependency_Injection_Demo.Services.AddSingleton;
using Dependency_Injection_Demo.Services.AddTransient;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ISingletonService, MySingletonService>();
//builder.Services.AddTransient<ITransientService, MyTransientService>();
//builder.Services.AddScoped<IScopedService, MyScopedService>();
//builder.Services.AddTransient<IMyService, TransientService>();
//builder.Services.AddScoped<IMyService, ScopedService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using Dependency_Injection_Demo.Services.AddScoped;
using Dependency_Injection_Demo.Services.AddSingleton;
using Dependency_Injection_Demo.Services.AddTransient;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ISingletonService, MySingletonService>();
builder.Services.AddTransient<ITransientService, MyTransientService>();
builder.Services.AddScoped<IScopedService, MyScopedService>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

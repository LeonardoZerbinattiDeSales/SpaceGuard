using SpaceGuard.Interfaces;
using SpaceGuard.Repositories;
using SpaceGuard.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Dependency Injection
builder.Services.AddScoped<ISateliteRepository, SateliteRepository>();
builder.Services.AddScoped<IIndicadorRepository, IndicadorRepository>();
builder.Services.AddScoped<IAlertaRepository, AlertaRepository>();

builder.Services.AddScoped<ISateliteService, SateliteService>();
builder.Services.AddScoped<IIndicadorService, IndicadorService>();
builder.Services.AddScoped<IAlertaService, AlertaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
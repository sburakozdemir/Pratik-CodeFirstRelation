using Microsoft.EntityFrameworkCore;
using Pratik_CodeFirstRelation.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<PatikaSecondDbContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();

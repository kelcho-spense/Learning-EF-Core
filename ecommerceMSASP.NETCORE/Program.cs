using ecommerceMSASP.NETCORE.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//add ecommerceDBContext

builder.Services.AddDbContext<EcommercedbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ecommerceDBContextConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

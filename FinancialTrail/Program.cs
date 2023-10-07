using FinancialTrail.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string _ApiKey = builder.Configuration.GetValue<string>("FMP_API_Key");
ApiInfo._ApiKey = _ApiKey;
string _ApiUriBase = builder.Configuration.GetValue<string>("ApiUriBase");
ApiInfo._ApiUriBase = _ApiUriBase;

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

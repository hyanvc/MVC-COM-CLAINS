using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Estrutura de autenticação//
builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        //caminho de autenticacao do login //
        option.LoginPath = "/Login/Login";
        option.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        //caminho de error de autenticacao //
        option.AccessDeniedPath = "/Login/denied";

    });
builder.Services.AddAuthorization(options =>
{
    // adiciona a política padrão
    //options.AddPolicy("defaultPolicy", policy =>
    //{
    //    policy.RequireAuthenticatedUser();
    //});

    // adiciona a nova política
    options.AddPolicy("teste", policy =>
    {
        policy.RequireClaim("Role", "Role");
    });
});



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
app.UseAuthentication();
app.UseAuthorization();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();

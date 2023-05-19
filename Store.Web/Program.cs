using System.Net;
using Store;
using Store.Memory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IBookRepository, BookRepository>();
builder.Services.AddTransient<BookService>();

// распределенная память 
builder.Services.AddDistributedMemoryCache();

//наша корзина храниться в переменной сессии
builder.Services.AddSession(options =>
{
    // задали вермя жизни сессии
    options.IdleTimeout = TimeSpan.FromMinutes(20);
    
    // HttpOnly = доступ к нашим кукам будет из локальных js. скриптов (только сервер может образаться сюда)
    options.Cookie.HttpOnly = true;                
    
    // тех. информация не отсносится к пользователю
    options.Cookie.IsEssential = true;
});

// builder.Services.AddTransient<>()

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

// запускаем саму сессию
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
var builder = WebApplication.CreateBuilder(args);

// Thêm dịch vụ MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Cấu hình môi trường và xử lý lỗi
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Cấu hình middleware
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Cấu hình routing mới với Endpoint Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Index}/{id?}");


//app.Urls.Add("http://localhost:5000");
app.Run();

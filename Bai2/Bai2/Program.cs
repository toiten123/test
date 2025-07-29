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
    app.UseExceptionHandler("/Student/Index");
    app.UseHsts();
}

// Cấu hình middleware
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Cấu hình Attribute Routing và Convention-based Routing
app.MapControllers();  // Sử dụng Attribute Routing từ controller

// Cấu hình convention-based routing nếu cần thiết
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Chạy ứng dụng
app.Run();

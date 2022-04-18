var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

// 1.當想要在 自定義的 Class 取得如同 ASP NET MVC 的 HttpContext.Current.User 要加入什麼配置
// 使用AddHttpContextAccessor
//builder.Services.AddHttpContextAccessor();
// AddScoped 為依賴注入
//builder.Services.AddScoped(Class);


var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


//TODO:add route
//TODO:(1) 加入預設頁(進網站自動導入的第一頁) http://localhost:5179
//TODO:(2) 加入區域的路由，請讓以下網址可以正常運作: http://localhost:5179/Account/Info/Detail
//TODO:(3) 加入自訂區域的路由，請讓以下網址可以正常運作: http://localhost:5179/最新消息/Congratulations on completing an assignment

app.Run();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();


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

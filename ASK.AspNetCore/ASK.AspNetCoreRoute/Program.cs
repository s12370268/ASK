var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

// 1.��Q�n�b �۩w�q�� Class ���o�p�P ASP NET MVC �� HttpContext.Current.User �n�[�J����t�m
// �ϥ�AddHttpContextAccessor
//builder.Services.AddHttpContextAccessor();
// AddScoped ���̿�`�J
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
//TODO:(1) �[�J�w�]��(�i�����۰ʾɤJ���Ĥ@��) http://localhost:5179
//TODO:(2) �[�J�ϰ쪺���ѡA�����H�U���}�i�H���`�B�@: http://localhost:5179/Account/Info/Detail
//TODO:(3) �[�J�ۭq�ϰ쪺���ѡA�����H�U���}�i�H���`�B�@: http://localhost:5179/�̷s����/Congratulations on completing an assignment

app.Run();

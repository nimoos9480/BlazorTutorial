using BlazorSignalRApp.Components;
using Microsoft.AspNetCore.ResponseCompression;
using BlazorSignalRApp.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); // AddInteractiveServerComponents() 메서드 호출 추가


builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
          new[] { "application/octet-stream" });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

// 응답 압축 미들웨어를 요청 처리 파이프라인에 추가
app.UseResponseCompression();

// SignalR 허브를 엔드포인트에 매핑
app.MapHub<ChatHub>("/chathub");

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

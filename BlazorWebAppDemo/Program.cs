using BlazorWebAppDemo;
using BlazorWebAppDemo.Components;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();

static void ConfigureServices(IServiceCollection services) 
{
    // ConfigureServices 메서드는 서비스 컨테이너에 서비스를 등록하는 역할

    // Add services to the container.
    services.AddRazorComponents()
        .AddInteractiveServerComponents();

	//services.AddSingleton<ContactService>(); ==> 애플리케이션 전체에서 공유
	// services.AddTransient<ContactService>();  ==> 일시적 사용

	services.AddSingleton<IContactService, ContactServiceTesting>();

}
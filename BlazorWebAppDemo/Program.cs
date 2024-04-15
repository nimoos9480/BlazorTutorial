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
    // ConfigureServices �޼���� ���� �����̳ʿ� ���񽺸� ����ϴ� ����

    // Add services to the container.
    services.AddRazorComponents()
        .AddInteractiveServerComponents();

	//services.AddSingleton<ContactService>(); ==> ���ø����̼� ��ü���� ����
	// services.AddTransient<ContactService>();  ==> �Ͻ��� ���

	services.AddSingleton<IContactService, ContactServiceTesting>();

}
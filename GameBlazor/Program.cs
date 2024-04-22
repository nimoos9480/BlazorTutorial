using GameBlazor.Clients;
using GameBlazor.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
						   .AddInteractiveServerComponents();

// var gameBlazorApiUrl = "http://localhost:5163";
var gameBlazorApiUrl = builder.Configuration["GameBlazorApiUrl"] ?? 
																													throw new Exception("GameBlazorApiUrl is not set");

builder.Services.AddHttpClient<GamesClient>(client => client.BaseAddress = new Uri(gameBlazorApiUrl));
builder.Services.AddHttpClient<GenresClient>(client => client.BaseAddress = new Uri(gameBlazorApiUrl));

// 종속성 주입 - 위 HttpClient 주입으로 생략
//builder.Services.AddSingleton<GamesClient> ();
//builder.Services.AddSingleton<GenresClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	app.UseHsts();
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
	  .AddInteractiveServerRenderMode();

app.Run();

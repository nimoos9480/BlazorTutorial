using GameBlazor.API.Data;
using GameBlazor.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// sqlite �����ͺ��̽� ����
var connString = builder.Configuration.GetConnectionString("GameStore");    // appsettings.json ���� ���ڿ�
builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

app.MapGamesEndpoints();
app.MapGenresEndpoints();

await app.MigrateDbAsync();

app.Run();

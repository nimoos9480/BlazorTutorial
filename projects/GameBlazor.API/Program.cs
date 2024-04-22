using GameBlazor.API.Data;
using GameBlazor.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// sqlite 데이터베이스 연결
var connString = builder.Configuration.GetConnectionString("GameStore");    // appsettings.json 연결 문자열
builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

app.MapGamesEndpoints();
app.MapGenresEndpoints();

await app.MigrateDbAsync();

app.Run();

using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace GameBlazor.API.Data
{
    public static class DataExtensions
    {
        public static async Task MigrateDbAsync(this WebApplication app) 
        { 
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
            await dbContext.Database.MigrateAsync();
        }
    }
}

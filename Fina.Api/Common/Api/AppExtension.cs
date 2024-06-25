namespace Fina.Api.Common.Api;

public static class AppExtension
{
    public static void ConfiguraDevEnvironment(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        //app.MapSwagger().RequireAuthorization();
    }
}

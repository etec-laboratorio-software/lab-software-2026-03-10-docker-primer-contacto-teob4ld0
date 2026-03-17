using Microsoft.AspNetCore.Mvc;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton(
    new NpgsqlDataSourceBuilder(builder.Configuration.GetConnectionString("DefaultConnection")).Build());

var app = builder.Build();
app.MapControllers();
app.Run();

[ApiController]
[Route("allgood")]
public class AllGoodController : ControllerBase
{
    private readonly NpgsqlDataSource _db;
    public AllGoodController(NpgsqlDataSource db) => _db = db;

    [HttpGet]
    public IActionResult Get() => Ok("allgood");

    [HttpGet("dbtest")]
    public async Task<IActionResult> DbTest()
    {
        await using var cmd = _db.CreateCommand("SELECT NOW()");
        var result = await cmd.ExecuteScalarAsync();
        return Ok(result?.ToString());
    }
}
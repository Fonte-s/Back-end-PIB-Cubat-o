using Backend_PIB_Cubatao.WebAPI.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddWebAPI(builder.Configuration);
var app = builder.Build();
app.UseWebAPI();
app.Run();

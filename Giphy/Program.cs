using Giphy.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string[]? allowedOrigins = builder.Configuration.GetSection("AllowedOrigins").Value.Split(';', StringSplitOptions.RemoveEmptyEntries);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<IGiphyService, GiphyService>(c =>
{
    c.BaseAddress = new Uri("https://api.giphy.com/v1/gifs/");
});
builder.Services.AddSingleton(new GiphyServiceConfiguration(builder.Configuration.GetSection("apiKeys")["Giphy"].ToString()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder => builder.WithOrigins(allowedOrigins));

app.UseAuthorization();

app.MapControllers();

app.Run();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
builder.WebHost.UseUrls("http://0.0.0.0:7090");


builder.Services.AddCors(options =>
{
    options.AddPolicy("KretaApi", policy =>
    {
        policy.WithOrigins("http://localhost:7090", "http://10.0.2.2:7090")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

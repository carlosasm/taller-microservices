using CarMicroservice.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<CarMicroservice.BusinessLogic.Interface.ICar, CarMicroservice.BusinessLogic.Car>();
builder.Services.AddSingleton<CarMicroservice.DataAccess.Interface.ICar, CarMicroservice.DataAccess.Car>();


builder.Services.AddControllers(/* x => x.Filters.Add<ApiKeyAuthFilter>() */);

builder.Services.AddScoped<ApiKeyAuthFilter>();

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

app.UseHttpsRedirection();

//app.UseMiddleware<ApiKeyAuthMiddleware>(); This line to use ApiKeyAuthMiddleware

app.UseAuthorization();

app.MapControllers();

app.Run();

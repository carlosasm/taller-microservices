var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<TallerMicroservice.BusinessLogic.Interface.ITaller, TallerMicroservice.BusinessLogic.Taller>();
builder.Services.AddSingleton<TallerMicroservice.DataAccess.Interface.ITaller, TallerMicroservice.DataAccess.Taller>();
builder.Services.AddSingleton<TallerMicroservice.BusinessLogic.Interface.ICarFromTaller, TallerMicroservice.BusinessLogic.CarFromTaller>();
builder.Services.AddSingleton<TallerMicroservice.DataAccess.Interface.ICarFromTaller, TallerMicroservice.DataAccess.CarFromTaller>();
builder.Services.AddSingleton<TallerMicroservice.DataAccess.Interface.IConnectionManager, TallerMicroservice.DataAccess.ConnectionManager>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

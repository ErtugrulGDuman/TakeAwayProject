using TakeAwayProject.Application.Features.CQRS.Handlers.AddressHandlers;
using TakeAwayProject.Application.Interfaces;
using TakeAwayProject.Persistence.Context;
using TakeAwayProject.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<OrderContext>();

#region
builder.Services.AddScoped<GetAddressQueryHandler>();
builder.Services.AddScoped<GetAddressByIdQueryHandler>();
builder.Services.AddScoped<CreateAddressCommandHandler>();
builder.Services.AddScoped<UpdateAddressCommandHandler>();
builder.Services.AddScoped<RemoveAddressCommandHandler>();
#endregion

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

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

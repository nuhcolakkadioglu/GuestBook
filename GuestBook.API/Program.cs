using AutoMapper;
using GuestBook.Business.Abstract;
using GuestBook.Business.Concrete;
using GuestBook.Business.Mappings.AutoMapper;
using GuestBook.Business.ValidationRules;
using FluentValidation;
using GuestBook.Entities.Concrete;
using GuestBook.Core.Dtos.GuestPost;
using GuestBook.DataAccess.Abstract;
using GuestBook.DataAccess.Concrete.EntitiyFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mappConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new GuestPostProfile());
});
IMapper mapper = mappConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddSingleton<IValidator<GuestPostCreateDto>, GuestPostCreateDtoValidator>();
builder.Services.AddSingleton<IValidator<GuestPostUpdateDto>, GuestPostUpdateDtoValidator>();

builder.Services.AddScoped<IGuestPostService, GuestPostManager>();
builder.Services.AddScoped<IGuestPostDal, EfGuestPostDal>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

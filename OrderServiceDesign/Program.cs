using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OrderServiceDesign.BusinessLayer.Interface;
using OrderServiceDesign.BusinessLayer.Service;
using OrderServiceDesign.DataAccessLayer;
using OrderServiceDesign.DataAccessLayer.Mapper;
using OrderServiceDesign.DataAccessLayer.Repository.Concrete;
using OrderServiceDesign.DataAccessLayer.Repository.Interface;
using OrderServiceDesign.EmailNotification.Strategy;
using OrderServiceDesign.Logger;
using OrderServiceDesign.NotificationBase.Strategy;
using OrderServiceDesign.SMSNotification.Strategy;
using System.Reflection;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add serilog services to the container and read config from appsettings
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MapperProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<ISMSSenderService, SMSSenderService>();
builder.Services.AddScoped<IEmailSenderService, EmailSenderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<INotificationTypeContext, NotificationTypeContext>();
builder.Services.AddScoped<INotificationStrategy, SMSSendStrategy>();
builder.Services.AddScoped<INotificationStrategy, EmailSendStrategy>();
builder.Services.AddScoped<ILoggerBase, LoggerBase>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));


string connectionString = "";
builder.Services.AddDbContext<OrderDBContext>(options =>
               options.UseNpgsql(connectionString), ServiceLifetime.Scoped);

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

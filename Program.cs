using PackardJAllForOneWebApi.Services.AskingQuestions;
using PackardJAllForOneWebApi.Services.GreaterOrLess;
using PackardJAllForOneWebApi.Services.MadLibs;
using PackardJAllForOneWebApi.Services.Magic8Ball;
using PackardJAllForOneWebApi.Services.OddOrEven;
using PackardJAllForOneWebApi.Services.RestaurantPicker;
using PackardJAllForOneWebApi.Services.ReverseNumbers;
using PackardJAllForOneWebApi.Services.ReverseWords;
using PackardJAllForOneWebApi.Services.SumTwoNumbers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISumTwoNumbersService, SumTwoNumbersService>();
builder.Services.AddScoped<IAskingQuestionsService, AskingQuestionsService>();
builder.Services.AddScoped<IGreaterOrLessService, GreaterOrLessService>();
builder.Services.AddScoped<IMadLibsService, MadLibsService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseWordsService, ReverseWordsService>();
builder.Services.AddScoped<IReverseNumbersService, ReverseNumbersService>();
builder.Services.AddScoped<IMagic8BallService, Magic8BallService>();
builder.Services.AddScoped<IRestaurantPickerService, RestaurantPickerService>();

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

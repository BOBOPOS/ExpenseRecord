using ExpenseRecord.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
        policy =>
        {
            policy.AllowAnyOrigin();
            policy.AllowAnyHeader();
            policy.AllowAnyMethod();
        });
});




builder.Services.AddScoped<IExpenseItemService, ExpenseItemService>();

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();

app.MapControllers();

app.Run();

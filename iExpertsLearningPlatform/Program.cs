using iExpertsLearningPlatform.Data;
using iExpertsLearningPlatform.Repositories;
using iExpertsLearningPlatform.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ─── Services ───────────────────────────────────────────────────────────────
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// InMemory Database (swap with UseSqlServer for production)
builder.Services.AddDbContext<AppDbContext>(opt =>
   // opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));            // --> If you want to connect to database, don't forget to change the connection string
    opt.UseInMemoryDatabase("iExpertsDb"));                    //--> If you want to switch to Memory

// Dependency Injection
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IContactService, ContactService>();

builder.Services.AddCors(options => {
    options.AddPolicy("AllowAngular", policy => {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// ─── Middleware Pipeline ──────────────────────────────────────────────────────
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAngular");  
app.UseAuthorization();
app.MapControllers();
app.Run();
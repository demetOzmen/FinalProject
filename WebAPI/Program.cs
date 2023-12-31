using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//CONFÝGURE SERVÝCES
builder.Services.AddControllers();
builder.Services.AddSingleton<IProductService, ProductManager>();
builder.Services.AddSingleton<IProductDal, EfProductDal>();
builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();

// CORS ayarlarýnýn eklenmesi
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
            .WithOrigins("http://localhost:3000")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});

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
app.UseCors("CorsPolicy"); // CORS politikasýnýn kullanýlmasý
app.UseAuthorization();
app.MapControllers();
app.Run();
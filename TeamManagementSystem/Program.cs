
using Microsoft.EntityFrameworkCore;
using Team.Repository.Interface;
using Team.Repository.Repository;
using TeamDataBase.Model;
using TeamDataBase.Model.TeamDbcontext;
using TeamRepository.Interface;
using TeamRepository.Repository;

namespace TeamManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region Connection String
            var connectionString = builder.Configuration.GetConnectionString("Connection");
            builder.Services.AddDbContext<TeamDbContext>(options =>
            options.UseSqlServer(connectionString));
            #endregion
            #region Independance
            builder.Services.AddScoped<IUnitOfWork<TeamDbContext>, UnitOfWork<TeamDbContext>>();
            builder.Services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            builder.Services.AddScoped<IBaseRepository<DailyStandUp>, BaseRepository<DailyStandUp>>();
           
            #endregion
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
        }
    }
}
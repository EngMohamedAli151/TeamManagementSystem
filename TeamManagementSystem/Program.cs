
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Team.Repository.Interface;
using Team.Repository.Repository;
using Team.Services.Interfaces;
using Team.Services.Services;
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
            builder.Services.AddScoped<IBaseRepository<DailyStandUp>, BaseRepository<DailyStandUp>>();
            builder.Services.AddScoped<IDailyStandUpRepository, DailyStandUpRepository>();
            builder.Services.AddScoped<IBaseRepository<DailyStandUp>, BaseRepository<DailyStandUp>>();
            builder.Services.AddScoped<IDailyStandUpServices,DailyStandUpServices >();
            builder.Services.AddScoped<IAcountServices,AcountServices >();
            #endregion

            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
             .AddEntityFrameworkStores<TeamDbContext>()
             .AddDefaultTokenProviders();

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                 ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = builder.Configuration["Jwt:Issuer"],
                ValidAudience = builder.Configuration["Jwt:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
               };
            });


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
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
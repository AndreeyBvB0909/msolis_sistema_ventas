using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DT.DBContext;
using Microsoft.EntityFrameworkCore;
using SistemaVenta.DT.Interfaces;
using SistemaVenta.DT.Implementacion;
using SistemaVenta.BusinessLogic.Interfaces;
using SistemaVenta.BusinessLogic.Implementacion;


namespace SistemaVenta.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBVENTAContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
            });
        }
    }
}

using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.BusinessLogic.EF.ApplicationLogic;
using HomeAccounting.DataSource;
using HomeAccounting.DataSource.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAccounting.CompositionRoot
{
    public class AspNetApplicationBuilder : AbstractApplicationBuilder
    {
        public AspNetApplicationBuilder(IServiceCollection services)
            :base(services)
        {
        }

        protected override void RegisterBusinessLogic()
        {
            _services.AddTransient<IAccountingService, BusinessLogic.EF.ApplicationLogic.AccountingService>();
        }

        protected override void RegisterDataSource()
        {
            _services.AddTransient<IRepository, RepositoryBasePostgre>();
            _services.AddDbContext<DomainContext>();
        }

        protected override void RegisterInfrastructure()
        {
            
        }
    }
}

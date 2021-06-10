using HomeAccounting.BusinessLogic;
using HomeAccounting.BusinessLogic.Contract;
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
            _services.AddTransient<IAccounting, AccountingService>();
        }

        protected override void RegisterDataSource()
        {
            _services.AddTransient<IRepository, RepositoryBasePostgre>();
        }

        protected override void RegisterInfrastructure()
        {
            
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;

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
            throw new NotImplementedException();
        }

        protected override void RegisterDataSource()
        {
            throw new NotImplementedException();
        }

        protected override void RegisterInfrastructure()
        {
            throw new NotImplementedException();
        }
    }
}

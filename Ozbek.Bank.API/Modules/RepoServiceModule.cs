
using Autofac;
using Ozbek.Bank.Core.Repositories;
using Ozbek.Bank.Core.UnitOfWorks;
using Ozbek.Bank.Repository;
using Ozbek.Bank.Repository.Repositories;
using Ozbek.Bank.Repository.UnitOfWorks;
using System.Reflection;
using Module = Autofac.Module;

namespace Ozbek.Bank.API.Modules
{
    public class RepoServiceModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();            

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(OzbekBankDbContext));
            
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

        }
    }
}

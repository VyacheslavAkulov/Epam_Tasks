using Ninject.Modules;
using Task_2_Akulov_Viacheslav.DAL.Interfaces;
using Task_2_Akulov_Viacheslav.DAL.Repositories;

namespace Task_2_Akulov_Viacheslav.BLL.Infrastructure
{
    /// <summary>
    /// Dependency injection module
    /// </summary>
    public class ServiceModule:NinjectModule
    {
        private string connectionString;
        /// <summary>
        /// Connection string name
        /// </summary>
        /// <param name="connection"></param>
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        /// <summary>
        /// Dependency injection beetwen IUnitOfWork and DbContextUnitOfWork
        /// </summary>
        public override void Load()
        {
            Bind<IUnitOfWork>().To<DbContextUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}

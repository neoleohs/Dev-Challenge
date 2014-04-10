using Ninject.Modules;
using Ninject.Web.Common;
using Data.EntityFramework.Context;
using Data.Interfaces.Repositories;
using Data.EntityFramework.Repositories;
using DevChallenge.Services;

namespace DevChallenge
{
    public class NinjectBootstrapper : NinjectModule
    {
        private readonly string _connectionString;

        public NinjectBootstrapper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public override void Load()
        {
            Bind<TitlesContext>().ToSelf().InRequestScope()
                .WithConstructorArgument("connectionString", _connectionString);

            Bind<ITitleRepository>().To<TitleRepository>().InRequestScope();

            Bind<ISearchService>().To<SearchService>().InRequestScope();
        }
    }
}
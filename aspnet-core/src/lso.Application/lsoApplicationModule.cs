using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using lso.Authorization;

namespace lso
{
    [DependsOn(
        typeof(lsoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class lsoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<lsoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(lsoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

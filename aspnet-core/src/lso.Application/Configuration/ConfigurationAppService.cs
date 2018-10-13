using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using lso.Configuration.Dto;

namespace lso.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : lsoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

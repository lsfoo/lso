using System.Threading.Tasks;
using lso.Configuration.Dto;

namespace lso.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

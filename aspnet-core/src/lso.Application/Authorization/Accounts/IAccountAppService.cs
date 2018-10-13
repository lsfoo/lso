using System.Threading.Tasks;
using Abp.Application.Services;
using lso.Authorization.Accounts.Dto;

namespace lso.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

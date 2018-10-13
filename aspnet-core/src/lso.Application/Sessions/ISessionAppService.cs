using System.Threading.Tasks;
using Abp.Application.Services;
using lso.Sessions.Dto;

namespace lso.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

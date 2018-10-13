using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using lso.Roles.Dto;
using lso.Users.Dto;

namespace lso.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

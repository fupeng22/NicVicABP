using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NicVicABP.Roles.Dto;
using NicVicABP.Users.Dto;

namespace NicVicABP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ScotchMe.Roles.Dto;
using ScotchMe.Users.Dto;

namespace ScotchMe.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}
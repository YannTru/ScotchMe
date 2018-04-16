using System.Threading.Tasks;
using Abp.Application.Services;
using ScotchMe.Configuration.Dto;

namespace ScotchMe.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ScotchMe.Configuration.Dto;

namespace ScotchMe.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ScotchMeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NicVicABP.Configuration.Dto;

namespace NicVicABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NicVicABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

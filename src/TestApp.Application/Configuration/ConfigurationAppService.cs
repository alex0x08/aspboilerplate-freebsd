using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TestApp.Configuration.Dto;

namespace TestApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

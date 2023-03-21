using System.Threading.Tasks;
using TestApp.Configuration.Dto;

namespace TestApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

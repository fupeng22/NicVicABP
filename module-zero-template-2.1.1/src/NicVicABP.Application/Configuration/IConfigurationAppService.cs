using System.Threading.Tasks;
using Abp.Application.Services;
using NicVicABP.Configuration.Dto;

namespace NicVicABP.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
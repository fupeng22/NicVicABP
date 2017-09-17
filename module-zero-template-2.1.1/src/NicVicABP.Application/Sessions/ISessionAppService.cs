using System.Threading.Tasks;
using Abp.Application.Services;
using NicVicABP.Sessions.Dto;

namespace NicVicABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

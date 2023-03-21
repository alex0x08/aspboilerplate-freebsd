using System.Threading.Tasks;
using Abp.Application.Services;
using TestApp.Sessions.Dto;

namespace TestApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

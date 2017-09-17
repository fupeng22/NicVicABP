using Abp.AutoMapper;
using NicVicABP.Sessions.Dto;

namespace NicVicABP.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
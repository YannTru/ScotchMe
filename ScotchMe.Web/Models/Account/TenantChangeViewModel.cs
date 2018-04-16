using Abp.AutoMapper;
using ScotchMe.Sessions.Dto;

namespace ScotchMe.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
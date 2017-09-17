using Abp.Web.Mvc.Views;

namespace NicVicABP.Web.Views
{
    public abstract class NicVicABPWebViewPageBase : NicVicABPWebViewPageBase<dynamic>
    {

    }

    public abstract class NicVicABPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected NicVicABPWebViewPageBase()
        {
            LocalizationSourceName = NicVicABPConsts.LocalizationSourceName;
        }
    }
}
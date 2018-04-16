using Abp.Web.Mvc.Views;

namespace ScotchMe.Web.Views
{
    public abstract class ScotchMeWebViewPageBase : ScotchMeWebViewPageBase<dynamic>
    {

    }

    public abstract class ScotchMeWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ScotchMeWebViewPageBase()
        {
            LocalizationSourceName = ScotchMeConsts.LocalizationSourceName;
        }
    }
}
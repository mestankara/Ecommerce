using System.Collections.Generic;
using System.Web.Mvc;

namespace MrCMS.Web.Areas.Admin.Services
{
    public interface IGetUserCultureOptions
    {
        List<SelectListItem> Get();
    }
}
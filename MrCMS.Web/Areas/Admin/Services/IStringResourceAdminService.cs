using System.Collections.Generic;
using System.Web.Mvc;
using MrCMS.Entities.Resources;
using MrCMS.Paging;
using MrCMS.Web.Areas.Admin.Models;

namespace MrCMS.Web.Areas.Admin.Services
{
    public interface IStringResourceAdminService
    {
        IPagedList<StringResource> Search(StringResourceSearchQuery searchQuery);
        void Add(StringResource resource);
        void Update(StringResource resource);
        void Delete(StringResource resource);
        List<SelectListItem> GetLanguageOptions(string key);
        List<SelectListItem> SearchLanguageOptions();
    }
}
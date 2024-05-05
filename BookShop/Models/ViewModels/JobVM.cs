using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookShop.Models.ViewModels
{
    public class JobVM
    {
        public ApplicationModel? Application { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? Categories { get; set; }
    }
}

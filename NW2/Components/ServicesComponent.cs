using Microsoft.AspNetCore.Mvc;
using NW2.Models;

namespace NW2.Components
{
    [ViewComponent(Name = "Services")]
    public class ServicesComponent : ViewComponent
    {
        private DataContext _context;
        public ServicesComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofServices = (from m in _context.Servicess

                                  select m).ToList();

            return await Task.FromResult((IViewComponentResult)View("Default", listofServices));
        }
    }

}

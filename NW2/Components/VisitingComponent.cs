using Microsoft.AspNetCore.Mvc;
using NW2.Models;

namespace NW2.Components
{
    [ViewComponent(Name = "Visiting")]
    public class VisitingComponent : ViewComponent
    {
        private DataContext _context;
        public VisitingComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listoVisiting = (from m in _context.Facts
                              
                              select m).ToList();

            return await Task.FromResult((IViewComponentResult)View("Default", listoVisiting));
        }
    }

}

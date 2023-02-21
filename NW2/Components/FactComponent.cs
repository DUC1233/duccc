using Microsoft.AspNetCore.Mvc;
using NW2.Models;

namespace NW2.Components
{
    [ViewComponent(Name ="Fact")]
    public class FactComponent : ViewComponent
    {
        private DataContext _context;
        public FactComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofFact = (from m in _context.Facts
                              
                              select m).ToList();

            return await Task.FromResult((IViewComponentResult)View("Default", listofFact));
        }
    }

}

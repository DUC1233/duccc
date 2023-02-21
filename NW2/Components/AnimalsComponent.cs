using Microsoft.AspNetCore.Mvc;
using NW2.Models;

namespace NW2.Components
{
    [ViewComponent(Name ="Animals")]
    public class AnimalsComponent : ViewComponent
    {
        private DataContext _context;
        public AnimalsComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofAnimals = (from m in _context.Animalss

                              select m).ToList();

            return await Task.FromResult((IViewComponentResult)View("Default", listofAnimals));
        }
    }

}

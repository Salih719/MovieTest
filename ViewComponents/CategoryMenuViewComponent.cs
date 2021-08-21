using Microsoft.AspNetCore.Mvc;
using MovieTest.Data;

namespace MovieTest.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepository.Categories);
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}

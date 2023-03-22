using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutMenager aboutMenager = new AboutMenager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutMenager.TGetList();
            return View(values);
        }
    }
}

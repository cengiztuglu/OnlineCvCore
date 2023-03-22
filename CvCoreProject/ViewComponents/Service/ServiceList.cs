using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {

        ServiceMenager serviceMenager = new ServiceMenager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceMenager.TGetList();
            return View(values);
        }

    }
}

using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acenta.ViewConponent.Default
{
    public class _PopulerYerler : ViewComponent
    {
        PopulerYerlerManager populerYerlerManager = new PopulerYerlerManager(new EfDestinationDal());

        public IViewComponentResult Invoke()
        {
            var values = populerYerlerManager.TGetList();
            return View(values);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.BusinessLogic;
using ASP.Models;
using ASP.ViewModel;

namespace ASP.Controllers
{
    public class FuelController : Controller
    {
        private readonly FuelBusniessLogic _businessLogic;
        public FuelController()
        {
            _businessLogic = new FuelBusniessLogic();
        }
        // GET: Fuel
        public ActionResult Index()
        {
            var model = new FuelViewModel {FuelModel = new FuelModel() };
            return View("View",model);
        }
        [HttpPost]
        public ActionResult FuelCalculate(FuelViewModel model)

        {
            if (model.FuelModel!=null&& model.FuelModel.Distance!=0)
            {
                model.FuelModel.AvgConsumption = _businessLogic.CalculateAvgConsumption(model.FuelModel.Fuel, model.FuelModel.Distance);
                model.ShowResult = true;
                return View("View", model);
            }
            else
            {
                model.ShowResult = false;
                ViewBag.ERROR = "Błędne dane";
                return View("View");

            }
        }
    }
}
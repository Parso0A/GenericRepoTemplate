using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GenericTest.Models;
using GenericTestDomain.Service;
using System.Security.Permissions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using GenericTestService;
using GenericTestDomain.Model;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace GenericTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMainService _service;
        private readonly IObjectFactory _factory;

        public HomeController(IObjectFactory factory, IMainService service)
        {
            _factory = factory;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("submit")]

        public async Task<IActionResult> Submit(ObjectType type)
        {
            var model = _factory.Create(type);
            if (model is Person)
                return PartialView("PersonListPartial", await _service.GetAllPeople());
            else if (model is Organization)
                return PartialView("OrgListPartial", await _service.GetAllOrgs());
            else if (model is Car)
                return PartialView("CarListPartial", await _service.GetAllCars());
            return Error();
        }
        [HttpGet]
        [Route("new")]
        public async Task<IActionResult> Create(ObjectType type)
        {
            var model = _factory.Create(type);
            if (model is Person)
                return PartialView("PersonCreatePartial");
            else if (model is Organization)
                return PartialView("OrganizationCreatePartial");
            else if (model is Car)
                return PartialView("CarCreatePartial");
            return Error();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePerson(Person entity)
        {
            var res = await _service.AddPerson(entity);
            return RedirectToAction("Index");
        }
        [HttpGet("editperson")]
        public async Task<IActionResult> EditPerson(Guid Id)
        {
            var model = (await _service.GetAllPeople()).First(x => x.Id == Id);
            return PartialView("PersonEditPartial", model);
        }
        [HttpPost("editperson")]
        public async Task<IActionResult> EditPerson(Person entity)
        {
            await _service.UpdatePerson(entity);
            return View("Index");
        }
        [Route("deleteperson")]
        public async Task<IActionResult> DeletePerson(Guid id)
        {
            await _service.DeletePerson((await _service.GetAllPeople()).FirstOrDefault(x => x.Id == id));
            return RedirectToAction("Index");
        }
        [Route("deletecar")]
        public async Task<IActionResult> DeleteCar(Guid id)
        {
            await _service.DeleteCar((await _service.GetAllCars()).FirstOrDefault(x => x.Id == id));
            return RedirectToAction("Index");
        }
        [HttpGet("editcar")]
        public async Task<IActionResult> EditCar(Guid Id)
        {
            var model = (await _service.GetAllCars()).First(x => x.Id == Id);
            return PartialView("CarEditPartial", model);
        }
        [HttpPost("editcar")]
        public async Task<IActionResult> EditCar(Car entity)
        {
            await _service.UpdateCar(entity);
            return View("Index");
        }
        [Route("deleteorg")]
        public async Task<IActionResult> DeleteOrganization(Guid id)
        {
            await _service.DeleteOrg((await _service.GetAllOrgs()).FirstOrDefault(x => x.Id == id));
            return RedirectToAction("Index");
        }
        [HttpGet("editorg")]
        public async Task<IActionResult> EditOrganization(Guid Id)
        {
            var model = (await _service.GetAllOrgs()).First(x => x.Id == Id);
            return PartialView("OrganizationEditPartial", model);
        }
        [HttpPost("editorg")]
        public async Task<IActionResult> EditOrganization(Organization entity)
        {
            await _service.UpdateOrg(entity);
            return View("Index");
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrganization(Organization entity)
        {
            var res = await _service.AddOrg(entity);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> CreateCar(Car entity)
        {
            var res = await _service.AddCar(entity);
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

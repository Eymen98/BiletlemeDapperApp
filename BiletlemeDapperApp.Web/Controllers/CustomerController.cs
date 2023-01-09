using BiletlemeDapperApp.Application;
using BiletlemeDapperApp.Domain.Enums;
using BiletlemeDapperApp.Infrastructure;
using BiletlemeDapperApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BiletlemeDapperApp.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IMusteriAppService _musteriAppService;
        public CustomerController(ILogger<CustomerController> logger, IMusteriAppService musteriAppService)
        {
            _logger = logger;
            _musteriAppService = musteriAppService;
        }

        public IActionResult Index()
        {
            var customerList = _musteriAppService.GetCustomerList();

            //return Ok(a);

            var customerViewModel = new CustomerViewModel() { MusteriListesi = customerList };

            return View(customerViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Cinsiyet = EnumExtensions.GetEnumerations<CinsiyetEnum>();
            ViewBag.Durum = EnumExtensions.GetEnumerations<DurumEnum>();

            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCustomerViewModel model)
        {
            if (model == null)
            {
                return View(model);
            }
            var result = _musteriAppService.InsertCustomer(new Domain.Musteri()
            {
                musteri_adi = model.MusteriAdi,
                musteri_soyadi = model.MusteriSoyadi,
                tel_no = model.TelNo,
                email = model.Email,
                cinsiyet = model.Cinsiyet,
                durum = model.Durum,
                dogum_tarihi = model.DogumTarihi,
                kayit_tarihi = DateTime.Now
            });
            if (result > 0)
            {
                return Ok(true);
            }
            else return Ok(false);
        }

        [HttpPost]
        public IActionResult Update(UpdateCustomerViewModel model)
        {
            if (model == null)
            {
                return View(model);
            }
            var result = _musteriAppService.UpdateCustomer(model.Id,new Domain.Musteri()
            {
                musteri_adi = model.MusteriAdi,
                musteri_soyadi = model.MusteriSoyadi,
                tel_no = model.TelNo,
                email = model.Email,
                cinsiyet = model.Cinsiyet,
                durum = model.Durum,
                dogum_tarihi = model.DogumTarihi,
                guncelleme_tarihi = DateTime.Now
            });
            if (result > 0)
            {
                return Ok(true);
            }
            else return Ok(false);
        }
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var result = _musteriAppService.DeleteCustomer(Id);
            if (result > 0)
            {
                return Ok(true);
            }
            else return Ok(false);
        }
        [HttpPost]
        public IActionResult CreateCustomer(CreateCustomerViewModel model)
        {
            if (model == null)
            {
                return View(model);
            }
            var result = _musteriAppService.InsertCustomer(new Domain.Musteri()
            {
                musteri_adi = model.MusteriAdi,
                musteri_soyadi = model.MusteriSoyadi,
                tel_no = model.TelNo,
                email = model.Email,
                cinsiyet = model.Cinsiyet,
                durum = model.Durum,
                dogum_tarihi = model.DogumTarihi,
                kayit_tarihi = DateTime.Now
            });
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else return BadRequest("Bir hata oluştu");
        }
    }
}
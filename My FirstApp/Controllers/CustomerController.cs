using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using My_FirstApp.Models;
using My_FirstApp.Models.ViewModels;

namespace My_FirstApp.Controllers
{
	public class CustomerController : Controller
	{
		public IActionResult Index()
		{
			Movie m = new Movie
			{
				Id = 1,
				Name = "BARBIE"
			};
			CustomerMovieVM c = new CustomerMovieVM()
			{
				movie = m,
				customers = GetAll()
			};
			return View(c);
		}
		public IActionResult Details(int? id)
		{
			var detailscustomer = GetAll().FirstOrDefault(c => c.Id == id);
			return View(detailscustomer);
		}
		private List<Customer> GetAll()
		{
			List<Customer> customers = new List<Customer>()
			{
				new Customer { Id = 1,name = "Aissatha"},

				new Customer { Id = 2,name = "Cissé"}
			};
			return customers;
		}
	}
}

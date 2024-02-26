using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using My_FirstApp.Models;

namespace My_FirstApp.Controllers
{
	public class MovieControllers
	{
		ActionResult index() 
		{
			List<Movie> movies = new List<Movie>()
			{
				new Movie{Id=1, Name="BARBIE"},

				new Movie{Id=2, Name="CASA DE PAPEL"}

			};
			return View(movies);
		}

		private ActionResult View(List<Movie> movies)
		{
			throw new NotImplementedException();
		}

		public IActionResult Edit(int id)

		{


			return Content("Test Id : " + id);
		}

		private IActionResult Content(string v)
		{
			throw new NotImplementedException();
		}
	}


}
	


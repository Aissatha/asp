namespace My_FirstApp.Models.ViewModels
{
	public class CustomerMovieVM
	{
		public CustomerMovieVM() { }
		public Movie movie { get; set; }
		public List<Customer> customers { get; set; }
	}
}

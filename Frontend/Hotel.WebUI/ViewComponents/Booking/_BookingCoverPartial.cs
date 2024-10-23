using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebUI.ViewComponents.Booking
{
	public class _BookingCoverPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

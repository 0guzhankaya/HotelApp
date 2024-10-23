using Hotel.Business.Abstract;
using Hotel.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingController : ControllerBase
	{
		private readonly IBookingService _bookingService;

		public BookingController(IBookingService bookingService)
		{
			_bookingService = bookingService;
		}

		[HttpGet]
		public IActionResult BookingList()
		{
			var values = _bookingService.TGetList();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetBooking(int id)
		{
			var values = _bookingService.TGetById(id);
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddBooking(Booking booking)
		{
			_bookingService.TInsert(booking);
			return Ok();
		}

		[HttpPut("UpdateBooking")]
		public IActionResult UpdateBooking(Booking booking)
		{
			_bookingService.TUpdate(booking);
			return Ok("Güncelleme Başarılı!");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteBooking(int id)
		{
			var values = _bookingService.TGetById(id);
			_bookingService.TDelete(values);
			return Ok("Silme İşlemi Başarılı!");
		}

		[HttpPut("ApproveBooking")]
		public IActionResult ApproveBooking (Booking booking)
		{
			_bookingService.TBookingStatusChangedApproved(booking);
			return Ok("Onaylandı!");
		}

		[HttpPut("ApproveBooking")]
		public IActionResult ApproveBookingById (int id)
		{
			_bookingService.TBookingStatusChangedApprovedById(id);
			return Ok("Onaylandı!");
		}
	}
}

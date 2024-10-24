﻿using Hotel.Business.Abstract;
using Hotel.DataAccess.Abstract;
using Hotel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Business.Concrete
{
	public class BookingManager : IBookingService
	{
		private readonly IBookingDal _bookingDal;

		public BookingManager(IBookingDal bookingDal)
		{
			_bookingDal = bookingDal;
		}

		public void TBookingStatusChangedApproved(Booking booking)
		{
			_bookingDal.BookingStatusChangedApproved(booking);
		}

		public void TBookingStatusChangedApprovedById(int id)
		{
			_bookingDal.BookingStatusChangedApprovedById(id);
		}

		public void TDelete(Booking entity)
		{
			_bookingDal.Delete(entity);
		}

		public Booking TGetById(int id)
		{
			return _bookingDal.GetById(id);
		}

		public List<Booking> TGetList()
		{
			return _bookingDal.GetList();
		}

		public void TInsert(Booking entity)
		{
			_bookingDal.Insert(entity);
		}

		public void TUpdate(Booking entity)
		{
			_bookingDal.Update(entity);
		}
	}
}

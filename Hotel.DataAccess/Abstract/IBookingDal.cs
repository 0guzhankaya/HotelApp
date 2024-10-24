﻿using Hotel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataAccess.Abstract
{
	public interface IBookingDal : IGenericDal<Booking>
	{
		void BookingStatusChangedApproved(Booking booking);
		void BookingStatusChangedApprovedById(int id);
	}
}

﻿using Hotel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Business.Abstract
{
	public interface IBookingService : IGenericService<Booking>
	{
		void TBookingStatusChangedApproved(Booking booking);
		void TBookingStatusChangedApprovedById(int id);
	}
}

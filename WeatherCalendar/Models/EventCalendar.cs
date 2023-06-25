﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCalendar.Core.Collections;
using XCalendar.Core.Models;

namespace WeatherCalendar.Models
{
	public class EventCalendar : Calendar<EventDay>
	{
		#region Properties
		public ObservableRangeCollection<Event> Events { get; set; } = new ObservableRangeCollection<Event>();

		#endregion
		#region Methods
		public override void UpdateDay(EventDay day, DateTime newDateTime)
		{
			base.UpdateDay(day, newDateTime);
			day.Events.ReplaceRange(Events.Where(x => x.DateTime.Date == newDateTime.Date));
		}
		#endregion
	}
}
﻿using System.Threading.Tasks;
using Core.Log;
using Core.Timers;
using Services;

namespace RoutingJob.Jobs
{
	public class RouteJob : TimerPeriod
	{
		private readonly IRouteService _routeService;
		public const int PeriodSeconds = 2;

		public RouteJob(IRouteService routeService, ILog log) : base("RoutingJob", PeriodSeconds * 1000, log)
		{
			_routeService = routeService;
		}

		public override async Task Execute()
		{
			while (Working && await _routeService.ProcessNextRequest())
			{

			}
		}
	}
}

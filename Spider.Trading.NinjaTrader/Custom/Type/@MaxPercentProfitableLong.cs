// 
// Copyright (C) 2006, NinjaTrader LLC <www.ninjatrader.com>.
//
#region Using declarations
using System;
using System.ComponentModel;
using System.Drawing;
using NinjaTrader.Cbi;
using NinjaTrader.Data;
using NinjaTrader.Indicator;
using NinjaTrader.Strategy;
#endregion

// This namespace holds all strategies and is required. Do not change it.
namespace NinjaTrader.Strategy
{
	/// <summary>
	/// </summary>
	[Gui.Design.DisplayName("max. % profitable (long)")]
	public class MaxPercentProfitableLong : OptimizationType
	{
		/// <summary>
		/// Return the performance value of a backtesting result.
		/// </summary>
		/// <param name="systemPerformance"></param>
		/// <returns></returns>
		public override double GetPerformanceValue(SystemPerformance systemPerformance)
		{
			if (systemPerformance.LongTrades.TradesCount == 0)
				return 0;
			else
				return (double) systemPerformance.LongTrades.WinningTrades.TradesCount / systemPerformance.LongTrades.TradesCount;
		}
	}
}

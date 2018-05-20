using System;
using System.Collections.Generic;
using System.Text;

namespace _04.HotelReservation
{
	public class PriceCalculator
	{
		public PriceCalculator(decimal pricePerDay, int numberOfDays, SeasonsMultiplier season, DiscountType discountType)
		{
			this.PricePerDay = pricePerDay;
			this.NumberOfDays = numberOfDays;
			this.Season = season;
			this.DiscountType = discountType;

			TotalPrice = this.Calculate();
		}

		private decimal PricePerDay { get; set; }
		private int NumberOfDays { get; set; }
		private SeasonsMultiplier Season { get; set; }
		private DiscountType DiscountType { get; set; }
		private double TotalPrice { get; set; }

		private double Calculate()
		{
			var price = (double)(this.NumberOfDays * this.PricePerDay);

			var priceVip = price - ((price * (int)DiscountType) / 100);

			var priceSecondTimeUser = price - ((price * (int)DiscountType) / 100);

			double totalPrice = 0;

			switch (DiscountType)
			{
				case DiscountType.VIP:
					totalPrice = priceVip;
					break;
				case DiscountType.SecondVisit:
					totalPrice = priceSecondTimeUser;
					break;
				case DiscountType.None:
					totalPrice = price;
					break;
			}

			switch (Season)
			{
				case SeasonsMultiplier.Autumn:
					totalPrice *= (int)Season;
					break;
				case SeasonsMultiplier.Spring:
					totalPrice *= (int)Season;
					break;
				case SeasonsMultiplier.Winter:
					totalPrice *= (int)Season;
					break;
				case SeasonsMultiplier.Summer:
					totalPrice *= (int)Season;
					break;
			}
			return totalPrice;
		}
	}
}
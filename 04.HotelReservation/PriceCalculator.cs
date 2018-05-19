using System;
using System.Collections.Generic;
using System.Text;

namespace _04.HotelReservation
{
	public class PriceCalculator
	{
		public PriceCalculator(decimal pricePerDay, int numberOfDays, string season, string discountType)
		{
			this.PricePerDay = pricePerDay;
			this.NumberOfDays = numberOfDays;
			this.Season = season;
			this.DiscountType = discountType;

			TotalPrice = this.Calculate();
		}

		private decimal PricePerDay { get; set; }
		private int NumberOfDays { get; set; }
		private string Season { get; set; }
		private string DiscountType { get; set; }
		private double TotalPrice { get; set; }

		private double Calculate()
		{
			var price = (double)(this.NumberOfDays * this.PricePerDay);

			var vipDiscount = price % 0.20;
			var priceVip = price - vipDiscount;

			var secondTimeDiscount = price % 0.10;
			var priceSecondTimeUser = price - secondTimeDiscount;

			double totalPrice = 0;

			switch (this.DiscountType)
			{
				case "Vip":
					totalPrice = priceVip;
					break;
				case "SecondVisit":
					totalPrice = priceSecondTimeUser;
					break;
				case "None":
					totalPrice = price;
					break;
				default:
					totalPrice = price;
					break;
			}
			return totalPrice;
		}

		public override string ToString()
		{
			var sb = new StringBuilder();

			sb.AppendLine($"{this.TotalPrice:f2}");

			var result = sb.ToString().TrimEnd();

			return result;
		}
	}
}

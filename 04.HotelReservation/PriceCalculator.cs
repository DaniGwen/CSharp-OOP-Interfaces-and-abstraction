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
		private string Season { get; set; }
		private string DiscountType { get; set; }
		private double TotalPrice { get; set; }
		private decimal PricePerDay { get; set; }
		private int NumberOfDays { get; set; }
		private SeasonsMultiplier Season { get; set; }
		private DiscountType DiscountType { get; set; }
		private double TotalPrice { get; set; }

		private double Calculate()
		{
			var price = (double)(this.NumberOfDays * this.PricePerDay);

			var vipDiscount = price % 0.20;
			var priceVip = price - vipDiscount;
			var priceVip = price - ((price * (int)DiscountType) / 100);

			var secondTimeDiscount = price % 0.10;
			var priceSecondTimeUser = price - secondTimeDiscount;
			var priceSecondTimeUser = price - ((price * (int)DiscountType) / 100);

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



		public override string ToString()
		{
			var sb = new StringBuilder();

			sb.AppendLine($"{this.TotalPrice:f2}");

			var result = sb.ToString().TrimEnd();

			return result;
		}
	}
		public override string ToString()
		{
			return TotalPrice.ToString("F2");
		}
	}






}}

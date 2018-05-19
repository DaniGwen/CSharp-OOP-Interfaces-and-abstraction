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

            var priceVip = price - ((price * 20) / 100);

            var priceSecondTimeUser = price - ((price * 10) / 100);

            double totalPrice = 0;

            switch (this.DiscountType)
            {
                case "VIP":
                    totalPrice = priceVip ;
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
            if (this.Season == Seasons.Autumn.ToString())
            {
                totalPrice *= 1;
            }
            else if (this.Season == Seasons.Spring.ToString())
            {
                totalPrice *= 2;
            }
            else if (this.Season == Seasons.Summer.ToString())
            {
                totalPrice *= 4;
            }
            else if (this.Season == Seasons.Winter.ToString())
            {
                totalPrice *= 3;
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

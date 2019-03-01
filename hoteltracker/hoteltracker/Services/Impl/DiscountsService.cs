using System;
using System.Collections.Generic;

namespace hoteltracker.Services.Impl
{
    public class DiscountsService : IDiscountsService
    {
        public List<object> discounts { get; set; }

        public List<object> getUserDiscountsList()
        {
            Console.WriteLine("Get User Discounts List");
            throw new NotImplementedException();
        }

        public List<object> getGlobalDiscountsList()
        {
            Console.WriteLine("Get Global Discounts List");
            throw new NotImplementedException();
        }

    }
}

using System.Collections.Generic;

namespace hoteltracker.Services
{
    public interface IDiscountsService
    {
        List<object> discounts { get; set; }
        List<object> getUserDiscountsList();
        List<object> getGlobalDiscountsList();
    }
}

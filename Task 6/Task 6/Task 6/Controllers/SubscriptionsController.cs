using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using Task_6.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        string customerID = "Customer_ID_HERE";
        // GET api/<ValuesController>/
        [HttpGet("plans")]
        public IActionResult GetPlans()
        {
            StripeConfiguration.ApiKey = "API_KEY_HERE";
            List<StoreProduct> storeProductList = new List<StoreProduct>();
            var options = new PriceListOptions { Limit = 100 };
            var priceSrv = new PriceService();
            StripeList<Price> prices = priceSrv.List(options);

            foreach (Price price in prices)
            {
                StoreProduct item = new StoreProduct();
                item.Price = (long)price.UnitAmount;
                item.ProductId = price.ProductId;
                item.PriceId = price.Id;
                var productSrv = new ProductService();

                Product currentProduct = productSrv.Get(price.ProductId);
                item.Name = currentProduct.Name;
                item.Description = currentProduct.Description;
                storeProductList.Add(item);
            }
            Thread.Sleep(2500);
            return Ok(storeProductList);
        }

        // POST api/<ValuesController>
        [HttpPost("subscribe")]
        public IActionResult Subscribe([FromForm] string price_id)
        {
            StripeConfiguration.ApiKey = "API_KEY_HERE";
            var options = new SubscriptionCreateOptions
            {
                Customer = "CUSTOMER_KEY_HERE",
                Items = new List<SubscriptionItemOptions>
                      {
                        new SubscriptionItemOptions
                        {
                          Price = price_id,
                        },
                      },
            };
            var service = new SubscriptionService();
            try
            {
                Subscription subscription = service.Create(options);
                if (subscription.Status.Equals("active"))
                {
                    var invService = new InvoiceService();
                    Invoice inv = invService.Get(subscription.LatestInvoiceId);
                    Thread.Sleep(2500);
                    return Ok(new { message = "Successfully created subscription, invoice " + subscription.LatestInvoiceId + " was created.", url = inv.HostedInvoiceUrl });
                }
                else
                {
                    Thread.Sleep(2500);
                    return BadRequest(new { message = "Could not create subscription" });
                }
            }
            catch (Exception ex)
            {
                Thread.Sleep(2500);
                return BadRequest(new { message = ex.Message });
            }
        }

       
    }
}

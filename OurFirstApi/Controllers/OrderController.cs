using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OurFirstApi.Models;

namespace OurFirstApi.Controllers
{
    [RoutePrefix("api/Order")]
    public class OrderController : ApiController
    {
        //public HttpResponseMessage CreateOrder(CreateOrderModel model)
        //{
        //    int orderId = orderDataAccess.Create(model.CustomerId); //Create an order - this should return an id
        //    foreach (var lineItem in model.LineItems)
        //    {
        //        orderDataAccess.AddLineItem(orderId, lineItem);
        //    }

        //    return Request.CreateResponse(HttpStatusCode.Created, new {Id = orderId});
        //}
    }
}

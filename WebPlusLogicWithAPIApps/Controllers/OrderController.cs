using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPlusLogicWithAPIApps.Business;
using WebPlusLogicWithAPIApps.Entity;
using WebPlusLogicWithAPIApps.Models;

namespace WebPlusLogicWithAPIApps.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        public ActionResult Index()
        {
            OrderViewModels model = new OrderViewModels();
            return View(model);
        }

        //
        // GET: /Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Order/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Order/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                OrderEntity orderEntity = new OrderEntity();
                orderEntity.RecipientName = collection["RecipientName"];
                orderEntity.DeliveryStreet = collection["DeliveryStreet"];
                orderEntity.DeliveryCity = collection["DeliveryCity"];
                orderEntity.DeliveryState = collection["DeliveryState"];
                orderEntity.DeliveryPostalCode = collection["DeliveryPostalCode"];
                orderEntity.Phone = collection["Phone"];

                OrderBusiness orderbusiness = new OrderBusiness();
                orderbusiness.Create(orderEntity);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        //
        // GET: /Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCC.Models;

namespace MVCC.Controllers
{
    public class CustomerController : Controller
    {
        private RepositoryCustomer _repositoryCustomers;
        public CustomerController(RepositoryCustomer order)
        {
            _repositoryCustomers = order;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            List<string> customerIds = _repositoryCustomers.GetAllCustomerId();




        CustomerIdsViewModel idsViewModel = new CustomerIdsViewModel(customerIds);
            return View(idsViewModel);
            

        }

        // GET: CustomerController/Details/5
        public ActionResult Details(string id)
        {

            Customer customer = _repositoryCustomers.FindCustomerById(id);
            List<Customer> detail = _repositoryCustomers.FindCustomerDetailByCustomerId(id);
            ViewData["Customer"] = detail;
            return View(customer);
            
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

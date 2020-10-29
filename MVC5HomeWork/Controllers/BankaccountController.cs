using MVC5HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVC5HomeWork.Controllers
{
    public class BankaccountController : Controller
    {
        // GET: Bankaccount
        private 客戶資料Entities db= new 客戶資料Entities();
        public ActionResult Index()
        {
            var data = db.客戶銀行資訊.Include(c => c.客戶資料);
            return View(data.ToList()) ;
        }
    }
}
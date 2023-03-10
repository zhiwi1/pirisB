﻿using System.Web.Mvc;
using AutoMapper;
using Services.Common;
using Services.Transaction;
using Microsoft.Practices.Unity;
using WebApplication.Infrastructure;
using Services.Common.Model;

namespace WebApplication.Controllers
{
    public class BankController : Controller
    {
        [Dependency]
        public IBankService BankService { get; set; }

        [Dependency]
        public ITransactionService TransactionService { get; set; }

        [Dependency]
        public ISystemInformationService SystemInformationService { get; set; }

        public IMapper Mapper { get; set; } = MappingRegistrar.CreareMapper();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CloseBankDay()
        {
            BankService.CloseBankDay();
            return RedirectToAction("Index");
        }

        public ActionResult CloseBankMonth()
        {
            BankService.CloseBankMonth();
            return RedirectToAction("Index");
        }

        public ActionResult CloseBankYear()
        {
            BankService.CloseBankYear();
            return RedirectToAction("Index");
        }

        public ActionResult DayTransactionsReport()
        {
            //var report = BankService.GenerateTransactionReport(SystemInformationService.CurrentBankDay);
            TransactionReportModel report = new Services.Common.Model.TransactionReportModel();
            
            return View("TransactionReport", report);
        }

        public ActionResult PreviousDayTransactionsReport()
        {
            //var report =
            //    BankService.GenerateTransactionReport(SystemInformationService.CurrentBankDay == 0
            //        ? 0
            //        : SystemInformationService.CurrentBankDay - 1);
            TransactionReportModel report = new TransactionReportModel();
            return View("TransactionReport", report);
        }

        public ActionResult AccountReport()
        {
            var report = BankService.GenerateAccountReport();
            return View("AccountReport", report);
        }
    }
}
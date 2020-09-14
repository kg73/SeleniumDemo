using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DemoApp.Models;
using static DemoApp.Models.Constants;

namespace DemoApp.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.StudentRecordList = new List<StudentRecord>();
            return View();
        }

        [HttpPost]
        public IActionResult Index(int numRecords, int selectedClass)
        {
            var selectedClassEnum = Enum.GetName(typeof(ClassSelectedEnum), (ClassSelectedEnum)selectedClass);
            var recordList = JsonConvert.DeserializeObject<List<StudentRecord>>(ExampleJson);

            var filteredRecordList = recordList.Where(x => x.StudentClass == selectedClassEnum).Take(numRecords).ToList();
            ViewBag.StudentRecordList = filteredRecordList;

            Thread.Sleep(3000);
            return View();
        }
    }
}
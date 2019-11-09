﻿using CSharpLearning.Web.Models.DataStructures;
using Microsoft.AspNetCore.Mvc;

namespace CSharpLearning.Web.Controllers
{
    [Route("data-structures")]
    public class DataStructuresController : Controller
    {
        [Route("linked-list")]
        public IActionResult LinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            return View(linkedList);
        }

        [Route("stack")]
        public IActionResult Stack()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            return View(linkedList);
        }
    }
}

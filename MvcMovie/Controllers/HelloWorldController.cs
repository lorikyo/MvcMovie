using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
		// 
	    // GET: /HelloWorld/ 
	    public ActionResult Index()
	    {
		    return View();
	    }

	    // 
	    // GET: /HelloWorld/Welcome/ 
	    public ActionResult Welcome(string name, int id = 1)
	    {
            //this is a message on master
		    ViewBag.Message = "Hello David on master" + name;
		    ViewBag.NumTimes = id;
			ViewBag.Note = "this is on the testbranch. Hey Hey 123!";
		    return View();
	    }
	}
}
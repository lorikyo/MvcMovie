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
		    ViewBag.Message = "Hello " + name + "in master branch";
		    ViewBag.NumTimes = id;
		    ViewBag.Note = "this is a special note, testing create pull request";

		    return View();
	    }
	}
}
using System;
using System.Web.Mvc;

namespace ExceptionFilterMVC5_Demo.Controllers
{
    [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideByZero")]
    [HandleError(ExceptionType = typeof(NullReferenceException), View = "NullReference")]
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new Exception("Something went wrong");
        }

        public ActionResult MethodOne()
        {
            throw new NullReferenceException();
        }

        public ActionResult MethodTwo()
        {
            throw new DivideByZeroException();
        }
    }
}
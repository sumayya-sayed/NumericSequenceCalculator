using System.Web.Mvc;
using NumericSequenceCalculator.Models;
using NumericSequenceService;
namespace NumericSequenceCalculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        // GET: Get Sequence
        [HttpGet]
        public JsonResult GetSequence(int num)
        {
            var _service = new SequenceService();

            var numSequence = new NumericSequence { GivenNumber = num };
            numSequence.AllNumbers = _service.GetAllNumbers(num);
            numSequence.OddNumbers = _service.GetOddNumbers(num);
            numSequence.EvenNumbers = _service.GetEvenNumbers(num);
            numSequence.SpecialNumber = _service.GetSpecialCode(num);
            
            numSequence.FibonacciSeries = _service.GetFibonacciSeries(num);
           
            return Json(numSequence, JsonRequestBehavior.AllowGet);
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace projeto.MVC.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/{name=Scott}&{numTimes=1}
    public string Welcome(string name, int numTimes=1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, numTimes is {numTimes}");
    }
}

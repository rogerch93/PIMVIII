using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PopularPimViii.Controllers{

  public class HelloWorldController : Controller{

    //
    //GET: /HelloWorld/

    public IActionResult index(){
      return View();
    }

    //
    //GET: /HelloWorld/Welcome/

    public string Welcome(string name, int ID = 1){
      return HtmlEncoder.Default.Encode($"Ola {name}, ID: {ID}");
    }
  }
}
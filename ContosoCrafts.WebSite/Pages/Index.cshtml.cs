using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ContosoCrafts.WebSite.Services;
using ContosoCrafts.WebSite.Models;

namespace ContosoCrafts.WebSite.Pages
{
    // declares as page model
    public class IndexModel : PageModel
    {
        // ask for Logger to log this Model as readonly
        private readonly ILogger<IndexModel> _logger;

        // ask  for our JsonFileProductService by creating  public property and register the Service to the iLogger below
        public JsonFileProductService ProductService;
        // create public property for our IEnumrable List as provided by our ProductService
        // make the setter private so only this Model can change our list
        public IEnumerable<Product> Products { get; private set; }

        // call required services (with registration in our Startup) available in our IndexModel
        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }


        /*
         * Razor pages have an idea of OnGet, OnPost, OnPut etc (such as javascript in HTML5 has),
         * so right here we can tell the model what to do if the Index page is called!
         * Obviously we wanna load an instance of our ProductService and make use of our GetProducts Method
         */
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}

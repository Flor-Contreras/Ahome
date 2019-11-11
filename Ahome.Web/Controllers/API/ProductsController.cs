namespace Paw.Web.Controllers.API
{
    using Ahome.Web.Data;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
        private readonly DataContext dataContext;

        public ProductsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            //TODO
            return Ok(this.dataContext.Products);
        }

    }
}



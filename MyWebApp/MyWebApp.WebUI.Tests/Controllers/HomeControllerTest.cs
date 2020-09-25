using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWebApp.Core.Contract;
using MyWebApp.Core.Models;
using MyWebApp.Core.ViewModels;
using MyWebApp.WebUI;
using MyWebApp.WebUI.Controllers;

namespace MyWebApp.WebUI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexPageDoesReturnProducts()
        {
            IRepository<Product> productContext = new Mocks.MockContext<Product>();
            IRepository<ProductCategory> productCategoryContext = new Mocks.MockContext<ProductCategory>();
            productContext.Insert(new Product());

            HomeController controller = new HomeController(productContext,productCategoryContext);

            var result = controller.Index() as ViewResult;
            var viewModel = (ProductListViewModel)result.ViewData.Model;
            Assert.AreEqual(1, viewModel.Products.Count());
        }
    
    }
}

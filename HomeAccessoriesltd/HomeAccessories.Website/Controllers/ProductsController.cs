using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HomeAccessories.DataAccess.Concrete.EntityFramework.Contexts;
using HomeAccessories.Entities;
using HomeAccessories.Business.Abstract;
using HomeAccessories.Entities.Complex;
using HomeAccessories.Website.ViewModels;

namespace HomeAccessories.Website.Controllers
{
  public class ProductsController : Controller
  {
    private IProductService _productService;
    private ICategoryService _categoryService;

    public ProductsController(IProductService productService, ICategoryService categoryService)
    {
      _productService = productService;
      _categoryService = categoryService;
    }

    public int PageSize = 3;
    //[AllowAnonymous]
    public ActionResult Index(int? categoryId, int page = 1)
    {
      int productCount = _productService.GetProductsCountByCategory(categoryId);
      var allProducts = _productService.GetAll().ToList();

      if (categoryId != null)
      {
        //allProducts = _productService.GetByCategory(categoryId ?? 1).ToList();
        allProducts = _productService.GetAll(new ProductFilter
        {
          CategoryId = categoryId,
          Page = page,
          PageSize = PageSize
        });
      } else
      {
        allProducts = _productService.GetAll(new ProductFilter
        {
          CategoryId = categoryId,
          Page = page,
          PageSize = PageSize
        });
      }

      
      

      return View(new ProductListViewModel
      {
        Products = allProducts,
        PagingInfo = new PagingInfo
        {
          CurrentPage = page,
          CurrentCategory = categoryId,
          TotalPageCount = (int)Math.Ceiling((decimal)productCount / PageSize),
          BaseUrl = String.Format("/Products/Index/?categoryId={0}&page=", categoryId)
        }
      });
    }



    [HttpGet]
    public ActionResult Add()
    {
      return View(new ProductAddViewModel
      {
        Categories = _categoryService.GetAll().Select(item => new SelectListItem()
        { Text = item.CategoryName, Value = item.Id.ToString() }).ToList()

      });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Add(Product product)
    {
      _productService.Add(product);
      TempData.Add("Message", "The product was successfully added");
      return RedirectToAction("Index");
    }

    [HttpGet]

    public ActionResult Update(int id)
    {
      return View(new ProductAddViewModel
      {
        Product = _productService.GetById(id),
        Categories = _categoryService.GetAll().Select(item => new SelectListItem() { Text = item.CategoryName, Value = item.Id.ToString() }).ToList()

      });
    }

    public ActionResult Details(int id)
    {
      var product = _productService.GetById(id);

      if (product != null)
      {
        return View(product);
      }
      else
      {
        return HttpNotFound();
      }
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Update(Product product)
    {
      _productService.Update(product);
      TempData.Add("Message", "The product was successfully updated");
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      _productService.Delete(new Product { ProductId = id });
      TempData.Add("Message", "The product was successfully deleted");
      return RedirectToAction("Index");
    }
  }
}

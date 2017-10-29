using HomeAccessories.Business.Abstract;
using HomeAccessories.Business.FluentValidation;
using HomeAccessories.DataAccess.Abstract;
using HomeAccessories.DataAccess.Concrete.EntityFramework.Contexts;
using HomeAccessories.Entities;
using HomeAccessories.Entities.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.Business.Concrete.Managers
{
  public class ProductManager : IProductService
  {
    private IRepositoryBase<Product> _products;    

    public ProductManager(IRepositoryBase<Product> products)
    {
      _products = products;
    }

    public List<Product> GetAll()
    {
      return _products.GetAll().ToList();
    }
    public List<Product> GetAll(ProductFilter productFilter)
    {
      int? categoryId = productFilter.CategoryId;

      if (categoryId != null)
      {
        return
          _products.GetAll()
                   .Where(p => p.CategoryId == categoryId)
                   .OrderBy(p => p.ProductId)
                   .Skip((productFilter.PageSize * productFilter.Page) ?? 1) .Take(productFilter.PageSize ?? 3).ToList();

  //      .Skip(numberOfObjectsPerPage * pageNumber)
  //.Take(numberOfObjectsPerPage);
        //return _productDal.GetList(
        //    filter: product => product.CategoryId == categoryId,
        //    orderBy: o => o.OrderBy(product => product.ProductId),
        //    page: productFilter.Page,
        //    pageSize: productFilter.PageSize
        //    );
      }
      else
      {
        //return _productDal.GetList(
        //   orderBy: o => o.OrderBy(product => product.ProductId),
        //   page: productFilter.Page,
        //   pageSize: productFilter.PageSize
        //   );
        return _products.GetAll().ToList();
      }
    }

    public Product GetById(int id)
    {
      return _products.GetById(id);
      //return _productDal.Get(p => p.ProductId == id);
    }

    public List<Product> GetByCategory(int categoryId)
    {
      return _products.GetAll().Where(p => p.CategoryId == categoryId).ToList();
      //return _productDal.GetList(p => p.CategoryId == categoryId);
    }

    public List<Product> GetByProductName(string productName)
    {
      return _products.GetAll().Where(p => p.ProductName == productName).ToList();
      //return _productDal.GetList(p => p.ProductName.Contains(productName));
    }

    public void Add(Product product)
    {
      FluentValidatorTool.Validate(new ProductValidator(), product);
      ProductNameCheck(product);
      //_productDal.Add(product);
      _products.Insert(product);
    }

    private void ProductNameCheck(Product product)
    {
      bool thereIsAnyProductNameWithTheSameName =
        _products.GetAll().Where(p => p.ProductName == product.ProductName).Any();
          //_productDal.GetList(p => p.ProductName == product.ProductName).Any();

      if (thereIsAnyProductNameWithTheSameName)
      {
        throw new Exception("There is already a product with the same name");
      }
    }

    public void Update(Product product)
    {
      FluentValidatorTool.Validate(new ProductValidator(), product);
      //ProductNameCheck(product);
      //_productDal.Update(product);
      _products.Update(product);

    }

    public void Delete(Product product)
    {
      //_productDal.Delete(product);
      _products.Delete(product);
    }

    public int GetProductsCountByCategory(int? categoryId)
    {
      //return _productDal.GetProductsCountByCategory(categoryId);
      return _products.GetAll().Where(p => p.CategoryId == categoryId).Count();
    }

  
  }
}


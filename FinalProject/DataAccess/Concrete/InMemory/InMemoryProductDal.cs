using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Telefon",UnitsInStock=12,UnitPrice=1500},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitsInStock=30,UnitPrice=3200},
                new Product{ProductId=3,CategoryId=2,ProductName="Bardak",UnitsInStock=150,UnitPrice=15},
                new Product{ProductId=4,CategoryId=1,ProductName="Klavye",UnitsInStock=12,UnitPrice=105},
                new Product{ProductId=5,CategoryId=1,ProductName="Fare",UnitsInStock=30,UnitPrice=122},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var deleteToProduct = _products.SingleOrDefault(c => c.ProductId == product.ProductId);
            _products.Remove(deleteToProduct);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {

            return (_products.Where(p => p.CategoryId == categoryId).ToList());
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(c => c.ProductId == product.ProductId);
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }
    }
}

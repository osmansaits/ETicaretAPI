using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()

            => new()

            {
                new() {Id= Guid.NewGuid(), Name= "Bardak", CreatedTime = DateTime.Now, UnitPrice = 1000, UnitsInStock =1000},
                new() {Id= Guid.NewGuid(), Name= "Tabak", CreatedTime = DateTime.Now, UnitPrice = 1000, UnitsInStock =1000},
                new() {Id= Guid.NewGuid(), Name= "Kaşık", CreatedTime = DateTime.Now, UnitPrice = 1000, UnitsInStock =10000},
                new() {Id= Guid.NewGuid(), Name= "Çatal", CreatedTime = DateTime.Now, UnitPrice = 1000, UnitsInStock =10000},
                new() {Id= Guid.NewGuid(), Name= "Tepsi", CreatedTime = DateTime.Now, UnitPrice = 1000, UnitsInStock = 500}

            };

    }
}

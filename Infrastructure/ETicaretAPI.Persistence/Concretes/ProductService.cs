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
                new() {Id= Guid.NewGuid(), Name= "Bardak", UnitPrice = 1000, UnitsInStock =1000},
                new() {Id= Guid.NewGuid(), Name= "Tabak",  UnitPrice = 1000, UnitsInStock =1000},
                new() {Id= Guid.NewGuid(), Name= "Kaşık",  UnitPrice = 1000, UnitsInStock =10000},
                new() {Id= Guid.NewGuid(), Name= "Çatal",  UnitPrice = 1000, UnitsInStock =10000},
                new() {Id= Guid.NewGuid(), Name= "Tepsi",  UnitPrice = 1000, UnitsInStock = 500}

            };

    }
}

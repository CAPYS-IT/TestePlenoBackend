using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capys.Pleno.DAL.Repositories
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public ProductEntity(int _id, string _name)
        {
            Id = _id;
            name = _name;
        }
    }

    public class ProdutosRepository
    {
        private List<ProductEntity> lstProduct = new List<ProductEntity>()
        {
            new ProductEntity(1, "Celular"),
            new ProductEntity(2, "Televisão"),
            new ProductEntity(3, "Nintendo Switch Oled")
        };

        public IEnumerable<ProductEntity> GetAllProducts()
        {
            return lstProduct;
        }

        public ProductEntity InserirProdutos(ProductEntity request)
        {
            lstProduct.Add(request);
            return request;
        }

        public void DeleteProduct(int id)
        {
            var product = lstProduct.FirstOrDefault(x => x.Id == id);

            if(product is not null)
                lstProduct.Remove(product);
        }

    }
}

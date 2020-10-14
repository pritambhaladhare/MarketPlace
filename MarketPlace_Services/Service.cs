using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MarketPlace_Repository;
using MarketPlace_DAL;
using System.Data.Entity.Core.Metadata.Edm;

namespace MarketPlace_Services
{
    public class Service 
    {

        public static readonly MarketPlaceEntities context = new MarketPlaceEntities();

        UnitOfWork uow = new UnitOfWork(context);

        public Service()
        {

        }
   

        public bool LoginCustomer(string email, string password)
        {
            List<tblUser> user = new List<tblUser>();
            var result = uow.user.GetAll();
            int count = 0;
            foreach (var item in result)
            {
                if (item.email==email && item.password == password)
                {
                    count++;
                }
            }

            return ((count ==1) ? true : false);
        }

        public void saveCustomer(tblUser user)
        {
            uow.user.Insert(user);
            uow.SaveChanges();
        }


        public List<tblProduct> GetAllProductsByName(string searchitem)
        {
            List<tblProduct> products = new List<tblProduct>();
       

            var result = from N in uow.products.GetAll()
                          where N.ProductName.ToLower().Contains(searchitem.ToLower())
                          select new
                          {
                              ProductName = N.ProductName,
                              ProductID = N.ProductID
                          };


            foreach (var item in result)
            {
                tblProduct prod = new tblProduct();
                prod.ProductName = item.ProductName;
                prod.ProductID = item.ProductID;
                products.Add(prod);
            }
            return products;
        }


        public List<tblProduct> GetProductsJson(string searchitem)
        {
            List<tblProduct> products = new List<tblProduct>();


            var result = from N in uow.products.GetAll()
                         where N.ProductName.ToLower().Contains(searchitem.ToLower())
                         select new
                         {
                             ProductName = N.ProductName,
                             ProductID = N.ProductID
                         };


            foreach (var item in result)
            {
                tblProduct prod = new tblProduct();
                prod.ProductName = item.ProductName;
                prod.ProductID = item.ProductID;
                products.Add(prod);
            }
            return products;
        }

    }
}

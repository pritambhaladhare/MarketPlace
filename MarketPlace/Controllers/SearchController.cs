using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketPlace.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace MarketPlace.Controllers
{
    public class SearchController : Controller
    {
        readonly MarketPlaceEntities db = new MarketPlaceEntities();
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchPage(string searching)
        {
            List<tblProduct> products = db.tblProducts.ToList();
            List<tblProductDetail> productDetails = db.tblProductDetails.ToList();

            var joinedOp = from p in products
                           join d in productDetails on p.ProductID equals d.ProductID
                           where p.ProductName.Contains(searching) || searching == null
                           select new FullProductClass { tblProductmodel = p, tblProductDetailmodel = d };

            var fullProduct = (from p in db.tblProducts
                               join d in db.tblProductDetails
                               on p.ProductID equals d.ProductID
                               where p.ProductName.Contains(searching) || searching == null
                               select new 
                               {
                                   ProductID = p.ProductID,
                                   ProductName = p.ProductName,
                                   CategoryID = p.CategoryID,
                                   Product_Detail_ID = d.Product_Detail_ID,
                                   ModelName = d.ModelName,
                                   ManufacturerID = d.ManufacturerID,
                                   Fan_Speed_Min = d.Fan_Speed_Min,
                                   Power_Min = d.Power_Min,
                                   Color = d.Color,
                                   Height = d.Height,
                                   Weight = d.Weight,
                                   Series = d.Series,
                                   Model_Year = d.Model_Year,
                                   Application = d.Application,
                                   Airflow = d.Airflow,
                                   Operating_Voltage_Min = d.Operating_Voltage_Min,
                                   Accessories = d.Accessories,
                                   Fan_Sweep_Diameter = d.Fan_Sweep_Diameter,
                                   Sound_Max_Speed = d.Sound_Max_Speed,
                                   Picture = d.Picture,
                                   Power_Max = d.Power_Max,
                                   Operating_Voltage_Max = d.Operating_Voltage_Max,
                                   Fan_Speed_Max = d.Fan_Speed_Max
                               }).ToList();
            return View(joinedOp);
        }

        public ActionResult Search(string searching)
        {
            /*
            string mainconn = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[tblUser]";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            List<UserClass> uc = new List<UserClass>();
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                uc.Add(new UserClass
                {
                    userID = Convert.ToInt32(dr["userID"]),
                    username = Convert.ToString(dr["username"]),
                    firstname = Convert.ToString(dr["firstname"]),
                    lastname = Convert.ToString(dr["lastname"]),
                    email = Convert.ToString(dr["email"]),
                    password = Convert.ToString(dr["password"]),
                    credential_ID = Convert.ToInt32(dr["credential_ID"]),
                    imagepath = Convert.ToString(dr["imagepath"])
                }) ;
            }
            sqlconn.Close();*/
            var fullProduct = (from p in db.tblProducts
                               join d in db.tblProductDetails
                               on p.ProductID equals d.ProductID
                               where p.ProductName.Contains(searching) || searching == null
                               select new
                               {
                                   ProductID = p.ProductID,
                                   ProductName = p.ProductName,
                                   CategoryID = p.CategoryID,
                                   Product_Detail_ID = d.Product_Detail_ID,
                                   ModelName = d.ModelName,
                                   ManufacturerID = d.ManufacturerID,
                                   Fan_Speed_Min = d.Fan_Speed_Min,
                                   Power_Min = d.Power_Min,
                                   Color = d.Color,
                                   Height = d.Height,
                                   Weight = d.Weight,
                                   Series = d.Series,
                                   Model_Year = d.Model_Year,
                                   Application = d.Application,
                                   Airflow = d.Airflow,
                                   Operating_Voltage_Min = d.Operating_Voltage_Min,
                                   Accessories = d.Accessories,
                                   Fan_Sweep_Diameter = d.Fan_Sweep_Diameter,
                                   Sound_Max_Speed = d.Sound_Max_Speed,
                                   Picture = d.Picture,
                                   Power_Max = d.Power_Max,
                                   Operating_Voltage_Max = d.Operating_Voltage_Max,
                                   Fan_Speed_Max = d.Fan_Speed_Max
                               }).ToList();
            return View(fullProduct);
            //return View(db.tblProducts.Where(x=>x.ProductName.Contains(searching) || searching == null).ToList());
        }


    }
}
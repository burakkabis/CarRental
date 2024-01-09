using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Data.SqlClient;


namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                //GetCarsByBrandId();
                //CarGetAll();
                //GetCarsByColorId();
                //BrandGetAll();
                //ColorGetAll();
                //GetCarDetails();
                //Customer customer1=new Customer();
                //customer1.UserId = 100;
                //customer1.CompanyName = "MEHMET.LLC";

                //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
                //customerManager.Add(customer1);

                //Arabayı kiralama imkanını kodlayınız. Rental-->Add
                //Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.

                //DateTime date3 = new DateTime(2022, 9, 11);
                //DateTime date4 = new DateTime(2022, 9, 12);


                //Rental rental3 =new Rental();
                //rental3.CarId = 103;
                //rental3.CustomerId = 101;
                //rental3.RentDate = date3;
                //rental3.ReturnDate = date4;



                //RentalManager rentalManager = new RentalManager(new EfRentalDal());
                //rentalManager.Add(rental3);









            };



            }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName);
            }
        }

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);

            }
        }

        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }
       
    private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(car.CarName);
            }
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName);
            }
        }

        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(car.CarName);
            }
        }

    }
    }






//Car car1=new Car();
//car1.CarId = 103;
//car1.BrandId = 103;
//car1.ColorId = 101;
//car1.CarName = "FERRARI";
//car1.ModelYear = 2020;
//car1.DailyPrice = 2200;
//car1.Description = "TURUNCU FERRARI";
//car1.UnitsInStock = 3;


//CarManager carManager = new CarManager(new EfCarDal());
//foreach (var car in carManager.GetAll().Data)
//{
//    Console.WriteLine(car.CarName);

//}

//ColorManager colorManager = new ColorManager(new EfColorDal());
//Color color1 = new Color();
//color1.ColorName = "Kahverengi";
//colorManager.Add(color1);

//BrandManager brandManager = new BrandManager(new EfBrandDal());
//Brand brand1 = new Brand();
//brand1.BrandName = "Bugatti";
//brandManager.Add(brand1);
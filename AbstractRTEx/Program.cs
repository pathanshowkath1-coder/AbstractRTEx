using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractRTEx
{
    abstract class HMWBS
    {
        public void BillDetails()
        {
            Console.WriteLine(" HMWBS Bill Details");
        }
        public abstract void GetBill( double units);
    }
    class ResidentialCustomer : HMWBS
    {
        public override void GetBill(double units)
        {
            double bill = units * 7;
            Console.WriteLine("Residential Customer Bill is"+ bill);

        }
    }
    class CommercialCustomer : HMWBS
    {
        public override void GetBill(double units)
        {
            double bill = units * 10;
            Console.WriteLine("Commercial Customer Bill is" + bill);

        }
    }
    class AgriculturalCustomer : HMWBS
    {
        public override void GetBill(double units)
        {
            double bill = units * 5;
            Console.WriteLine("Agricultural Customer Bill is" + bill);
        }
    }
    class industrialCustomer : HMWBS
    {
        public override void GetBill(double units)
        {
            double bill = units * 15;
            Console.WriteLine("Industrial Customer Bill is" + bill);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HMWBS obj = new ResidentialCustomer();
            obj.BillDetails();
            Console.WriteLine("Enter the units consumed:");
            double units = Convert.ToDouble(Console.ReadLine());
            obj.GetBill(units);
            obj = new CommercialCustomer();
            obj.GetBill(units);
            obj= new AgriculturalCustomer();
            obj.GetBill(units);
            obj = new industrialCustomer();
            obj.GetBill(units);

        }
    }
}

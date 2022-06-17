using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS
{
    class Shopping
    {
        string purchaseitem;
        int price;
        int quantity;
        int bill;
        public void accept()
        {
            purchaseitem = "Mobile";
            price = 20000;
            quantity = 4;
           
        }
        public void Getbill( )
        {
            bill= quantity * price;


            if (quantity > 0)
            {
                Console.WriteLine( "The bill is "+ bill);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public void Display()
        {
            Console.WriteLine(bill);
            Console.WriteLine( "purchase item= "+purchaseitem+""+"Quantity= "+quantity+"Price= "+price);  
        }
        static void Main(string[] args)
        {

           
            Shopping a1 = new Shopping();
         
            a1.accept();
            a1.Getbill();
            a1.Display();

            
        }
        


    }
}

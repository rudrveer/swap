using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS
{
    class This_use
    {
        int y;
        string name;
        long mobile;
       // public This_use(int y,string name,long mobile)
      //  {
       //     this.y = y;
      //      this.name = name;
      //      this.mobile = mobile;
     //   }
        public void show()
        {
            get(20, "rajesh",4567899133);
            Console.WriteLine(y+"  "+name+""+mobile);
        }
        public void get(int y,string name,long mobile)
        {
            this.y = y;
            this.name = name;
            this.mobile = mobile;
           
        }
        static void Main(string[] args)
        {
            This_use a1 = new This_use();

            a1.show();


           
        }
    }
}

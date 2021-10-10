using AnalaizerClassLibrary;
using ErrorLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //AnalaizerClass.expression = "(5+1)+5/(-5+5-5)%5" ;
            string tmpStr = "";
            for (int i = 0; i < 32; i++)
            {
                tmpStr += "+";
            }
            AnalaizerClass.expression = tmpStr;
            Console.WriteLine(AnalaizerClass.Estimate());
            //Console.WriteLine(ErrorsExpression.ERROR_01.Substring(6, 2)); 
           string tmp=new String('1' , 65537);
        }
    }
}

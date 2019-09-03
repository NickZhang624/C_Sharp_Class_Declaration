using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Mynamespace;


/*如果要引用其他library 的method 先 add reference 找到你要引用的library，然后public libray里面的class 这样子才可以引用到，
 * rebuild之后用useing 的方法就是调用了
 * public 的对立面就是internal， 但是没有表明出来，
 * 
 * 
 * Assembly就是一个装配集，显示为.Dll或者是.EXE在文件夹里面
 * 
 * 
 * 
 * Class-modifer
 * New
 * PUblic
 * protect
 * internal
 * private
 * abstract
 * sealed
 * static
     */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NamespaceClass c = new NamespaceClass();
            double res = c.Add(2.3, 3.6);
            Console.WriteLine(res);
        }
    }
}

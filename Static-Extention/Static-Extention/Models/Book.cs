using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Static_Extention.Models
{
    public class Book
    {
        public static string Name { get; set; }

        public static int Count { get; set; } = 0;

        public Book()
        {
            Count++;
        }
        
  
           public static void Test()
            {

            }
        
    }
}

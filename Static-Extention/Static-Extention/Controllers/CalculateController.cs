using ServiceLayer.Services.Interfaces;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Extention.Controllers
{
    internal class CalculateController
    {
        public void Calculate()
        {
            ICalculationService service = new CalculationService();

            var result = service.Calculate(5, 7, "*");

            Console.WriteLine(result);
        }
    }
}

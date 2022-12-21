using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        public bool Login(string username, string password)
        {
            if (username== "Cavid123" && password=="1993")
            
                return true;

                return false;


                
            
        }
    }
}

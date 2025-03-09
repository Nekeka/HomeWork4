using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class CreditCard
    {
        private readonly string CVC;
        private string GenerateCVC()
        {
            Random rnd = new Random();
            string cvc = "";
            for(int i = 0; i < 3; i++)
            {
                cvc += rnd.Next(0, 9);
            }

            return cvc;
        }

        public CreditCard()
        {
            CVC = GenerateCVC();
        }
    }
}

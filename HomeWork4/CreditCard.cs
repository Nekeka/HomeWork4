using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class CreditCard
    {
        private readonly string CVC;
        public decimal Money { get; set; }
        private string GenerateCVC()
        {
            Random rnd = new Random();
            string cvc = "";
            for(int i = 0; i < 3; i++)
            {
                cvc += rnd.Next(0, 9);
            }
            //for debug
            Console.WriteLine("your cvc code: " + cvc);
            return cvc;
        }
        //приватный конструктор вызывается в + - методах, чтобы не создавать заново cvc код, так как он рандомный
        private CreditCard(decimal money, string existCVC)
        {
            Money = money;
            CVC = existCVC;
        }

        public CreditCard(decimal money)
        {
            Money = money;
            CVC = GenerateCVC();
        }
        public static CreditCard operator +(CreditCard card, decimal count) => new(card.Money + count, card.CVC);
       
        public static CreditCard operator -(CreditCard card, decimal count) => new(card.Money + count, card.CVC);

        public static bool operator ==(CreditCard card_1, string CVC) => (card_1.CVC == CVC);
        public static bool operator !=(CreditCard card_1, string CVC) => !(card_1.CVC != CVC);
       
        public static bool operator >(CreditCard card_1, decimal count) => (card_1.Money > count);
        public static bool operator <(CreditCard card_1, decimal count) => (card_1.Money < count);

    }
}

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(202.04);
            Console.WriteLine(emp.Sallary+4);
            ///
            CreditCard card = new CreditCard(124942.03m);
            Console.WriteLine(card.Money);
            Console.WriteLine("Enter your CVC code: ");           
            if (card == Console.ReadLine())
                card = card - 4122m;
            Console.WriteLine(card.Money);
      
        }
    }
}

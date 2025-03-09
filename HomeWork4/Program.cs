namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(202.04);
            Console.WriteLine(emp.Sallary+4);

            CreditCard card = new CreditCard();
            int i = 0;
            while (i < 99999){
                Console.WriteLine(card.GenerateCVC());
                i++;
            }
        }
    }
}

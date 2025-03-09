namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee(202.04);
            //Console.WriteLine(emp.Sallary+4);
            /////
            //CreditCard card = new CreditCard(124942.03m);
            //Console.WriteLine(card.Money);
            //Console.WriteLine("Enter your CVC code: ");           
            //if (card == Console.ReadLine())
            //    card = card - 4122m;
            //Console.WriteLine(card.Money);
            /////
            Console.WriteLine("matrix test");
            Matrix A = new Matrix(3);
            Matrix T = new Matrix(3);
            Matrix B = A + T;
            
            A.Print();
            T.Print();
            Console.WriteLine(B[0, 0]);
            B.Print();

            A = new Matrix(3);
            T = new Matrix(3);
            B = A * T;
            A.Print();
            T.Print();
            B.Print();

            A = new Matrix(3);
            T = new Matrix(3);
            Console.WriteLine(A != T);

            A = A * 0;
            T = T * 0;
            Console.WriteLine(A == T);

            A.Print();
            T.Print();
        }
    }
}

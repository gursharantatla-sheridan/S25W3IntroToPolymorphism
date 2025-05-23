namespace S25W3IntroToPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method overloading
            Add(3, 4);
            Add("h", "w");

            int[] a = { 3, 4, 5 };

            Print(a);



            // method overriding
            BaseClass objBase;
            objBase = new BaseClass();
            objBase.Show();

            objBase = new DerivedClass();
            objBase.Show();

            //DerivedClass objDerived = new BaseClass();
        }

        static void Print(int[] arr)
        {
            // method body
        }

        //static void Print(params int[] arr)
        //{
        //    // method body
        //}

        static void Add(int n1, int n2)
        {
            // method body
        }

        //static int Add(int n1, int n2)
        //{
        //    return n1 + n2;
        //}

        static void Add(int n1, int n2, int n3)
        {
            // method body
        }

        static void Add(ref int n1, int n2, int n3)
        {
            // method body
        }

        static void Add(string n1, string n2)
        {
            // method body
        }
    }
}

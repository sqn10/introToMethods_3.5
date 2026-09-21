namespace introToMethods_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // may finish this??
            Console.WriteLine("Hello, World!");
            DrawCheck();
            DrawCheck();
            DrawCheck();
            DrawCheck();
            Console.WriteLine();
            DrawX();
        }

        public static void DrawCheck()
        {
            Console.WriteLine("     /");
            Console.WriteLine("    /");
            Console.WriteLine("\\  /");
            Console.WriteLine(" \\/");
        }

        public static void DrawX()
        {
            Console.WriteLine("\\    /");
            Console.WriteLine(" \\  /");
            Console.WriteLine("  \\/");
            Console.WriteLine("  /\\");
            Console.WriteLine(" /  \\");
            Console.WriteLine("/    \\");
        }
    }
}

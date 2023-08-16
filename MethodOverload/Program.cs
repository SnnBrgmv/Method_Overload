namespace MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathHelper mathHelper = new MathHelper();
            Console.WriteLine(mathHelper.PrintValue(21,27));
            Console.WriteLine(mathHelper.PrintValue(false));
            mathHelper.PrintValue("Hello","P335");   
            Console.WriteLine(mathHelper.PrintValue(3,5,6));
        }
    }
}
namespace Statics01{
    internal class Program{
        static void Main(string[] args){
            Console.WriteLine("Statistic: ");
            int[] k = { 2, 2, 2, 2, 3, 3, 3, 4, 6, 7, 8 };
            Console.WriteLine($"k= " + k.ToFormattedString());
            Console.WriteLine($"Min: {Class1.GetMin(k)}");
            Console.WriteLine($"Max: {Class1.GetMax(k)}");
            var u = Class1.GetUnique(k);
            Console.WriteLine("Unique: "+u.ToFormattedString());    
        }
    }
}

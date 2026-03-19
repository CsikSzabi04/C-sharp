namespace ca{
    internal class Program{
        static void Main(string[] args){
            Console.WriteLine("Kikötő szimulátor");
            Kikötő k = new Kikötő();
            k.Mutat();
            Console.WriteLine("Hajó száma a kikötőben: " + $"{k.HajokSzama()}"); Console.WriteLine("");

            while (k.HajokSzama() > 0){
                Console.WriteLine("\nPress space to continue!");
                Console.ReadKey();
                k.Sorsol();
                k.Mutat();
                Console.WriteLine("Hajó száma a kikötőben: " + $"{k.HajokSzama()}");
                Console.WriteLine("Lépések száma: " + $"{k.LépesekSzáma}");
                
            }
        }
    }
}

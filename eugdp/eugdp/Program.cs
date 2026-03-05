
namespace eugdp
{
    struct GPD{
        public int varos;
        public string gpd;
    }
    internal class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello, World!");
            Beolvas("..\\..\\..\\adatok.txt",out string[] orszagok, out double[]GPDnov);
        }

        private static void Beolvas(string v, out string[] orszagok, out double[] gPDnov)
        {
            throw new NotImplementedException();
        }
    }
}

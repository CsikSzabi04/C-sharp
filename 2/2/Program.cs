namespace _2{

    struct Allomas{
        public int kod;
        public string nev;
        public double atlag;
        public int meresszam;
    }
    internal class Program{
        static void Main(string[] args){
            string[] sor;

            Console.Write("Fajl tartalma: \n");
            try{
                sor = File.ReadAllLines("..\\..\\..\\adatok.txt");
            } catch (Exception exc){
                Console.WriteLine("Problema!\n");
                return;
            }

            foreach (var s in sor) Console.WriteLine(s);
            Console.WriteLine();

            Allomas[] allomas = new Allomas[sor.Length];

            for (int i = 1; i < sor.Length; i++) {
                string s = sor[i];
                string[] reszek = s.Split(' ');
                allomas[i-1].kod = int.Parse(reszek[0].Substring(1));
                allomas[i-1].nev = reszek[1].Replace('_',' ');
                allomas[i-1].meresszam = reszek.Length- 2;
                allomas[i-1].atlag = 0;
                for (int a = 2; a < reszek.Length; a++) allomas[i-1].atlag += double.Parse(reszek[a], System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("hu-HU"));
                allomas[i-1].atlag /= allomas[i-1].meresszam;



            }

        }

    }
}

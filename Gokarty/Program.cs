namespace Gokarty
{
    internal class Program
    {
        public struct Competitor
        {
            public int id;
            public string f_name;
            public string l_name;
            public bool sex;
            public byte age;
            public bool experience;
            public int rank;
        }

        static void Main(string[] args)
        {
            saveCompetitor();
        }

        static string saveData(string toWrite)
        {
            Console.Clear();
            Console.WriteLine(toWrite);
            return Console.ReadLine();
        }

        static Competitor saveCompetitor() 
        {
            Competitor anonim = new Competitor();
            anonim.id = int.Parse(saveData("Podaj id"));
            anonim.f_name = saveData("Podaj imie");
            anonim.l_name = saveData("Podaj nazwisko");
            string _sex = (saveData("Podaj plec (K/M)"));
            anonim.sex = _sex.ToUpper().StartsWith("M") ? true :
            _sex.ToUpper().StartsWith("K") ? false : true;
            anonim.age = byte.Parse(saveData("Podaj wiek"));
            string _experience = saveData("Podaj doswiadczenie (A/Z)");
            anonim.experience = _experience.ToUpper().StartsWith("A") ? true :
                _experience.ToUpper().StartsWith("Z") ? false : true;
            anonim.rank = int.Parse(saveData("Podaj ranking"));
            return anonim;
        }

    }
}
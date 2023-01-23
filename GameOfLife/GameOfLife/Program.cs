
namespace GameOfLife
{
    static class Program
    {
        static void Main(string[] args)
        {
            Player p = new();
            //Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Game Of Life!"));
            Console.WriteLine("\nGame Of Life\n");
            p = OnBoard(p);
            GameFlow(p);
            SaveScore();
            PlayAgain();
        }
        
        static Player OnBoard(Player p)
        {
            Console.WriteLine("What will you be named?");
            do
            {//Sets standart Person values;
                p.name = Console.ReadLine();
                if(p.name.Trim() == "")
                {
                    Console.WriteLine("A NAME PLEASE");
                }
            } while (p.name.Trim() == "");
            p.age = 0; p.status = "Newborn"; p.isAlive = true; p.villainry = 3;
            return p;
        }

        static void GameFlow(Player p)
        {
            Events e = new();
            do
            {
                //TODO maybe do a function that sets player age foreach "level"/"age gap"
                Console.Clear();
                StatusUpdate(p);
                e.EventPicker(p);
                Console.WriteLine("\npress button to continue");
                Console.ReadLine();

            } while (p.isAlive);
            Console.WriteLine("dead");
            return;
        }

        static void StatusUpdate(Player p)
        {
            Console.WriteLine($"Villainry: {p.villainry} IsAlive: {p.isAlive} Handicaps: ");
            if(p.handicaps != null)
            {
                foreach (string s in p.handicaps)
                {
                    Console.Write($"{s}, ");
                }
            }
            

            Console.WriteLine("\nName: " + p.name);
            Console.WriteLine("Age: " + p.age + "");
            Console.WriteLine("status: " + p.status + "\n");
            
        }
        static void SaveScore()
        {
            //save highscores in a json file
        }
        static void PlayAgain()
        {
            //get the choise to play again
        }
    }
    
}
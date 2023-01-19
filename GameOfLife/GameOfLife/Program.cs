
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
                Console.Clear();
                StatusUpdate(p);
                Console.WriteLine("deez");
                Thread.Sleep(2000);
                e.RandomEvent(p);

            } while (p.isAlive);
            return;
        }

        static void StatusUpdate(Player p)
        {
                            
        }
        static void SaveScore()
        {

        }
        static void PlayAgain()
        {

        }
    }
    
}
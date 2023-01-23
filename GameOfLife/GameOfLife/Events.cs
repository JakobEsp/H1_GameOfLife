
namespace GameOfLife
{
    internal class Events
    {
        Random rnd = new();
        public void EventPicker(Player p)
        {
            //TODO Make a random event picker inside some cases.
            switch (p.age)
            {
                case < 5:
                    BeingBorn(p);
                    p.status = (p.handicaps.Count == 0 ? "\nLiving at home with your parents. \nVery exited for your first day at school." : "\nYour asthma has caused you to become a unathletic kid. \n Not very exited for your first day of school, because of your scrawny appearance.");
                    break;
                case < 10:
                    FirstDayInSchool(p);
                    break;
                case < 20:
                    break;
                case < 30:
                    break;
                case < 40:
                    break;
                case < 50:
                    break;
                case < 60:
                    break;
                case < 80:
                    break;
                case > 80:
                    break;      
            }
            //TODO make an aging funktion. that ages the player for every event if(isAlive).
            return;
            
        }
        #region Events
        #region Born
        void BeingBorn(Player p)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int luckyNumber = rnd.Next(nums.Length);
            luckyNumber = nums[luckyNumber];
            p.villainry = luckyNumber;

            if (luckyNumber == 1 || luckyNumber == 5)
            {
                p.handicaps.Add("Asthma");
                Writeout("You've been born with asthma. Luckily the doctors found out early, so you'll be fine...?");
            }
            else
            {
                Writeout("You've been born a normal and healthy child!");
            }
            //TODO add a randomiser to pick between getting a pet and/or siblings.
            //
            int[] aging = { 5, 6, 7, 8, };
            int agingNumber = rnd.Next(aging.Length);
            p.age = p.age + aging[agingNumber];
        }
        #endregion

        #region 5-10

        void FirstDayInSchool(Player p)
        {
            Console.WriteLine("At Your First day of school: \n");
            int? choise = null;
            if(p.villainry > 3)
            {
                Writeout("An older kid from first grade accidentaly set foot on your pinky toe.\n So you do the only logical thing and punch him straight in the JAW!!\n Sadly you now have to face the consequenses :(\n");
                while(choise == null)
                {
                    choise = Choises("[1] Get sent to the principals office, apologise for your actions", "[2] Run away!");
                    if(choise == null)
                    {
                        Writeout("!! Please choose. Press 1 or 2");
                    }
                }
            }
            else
            {

            }
        }

        #endregion

        #region 10-20
        #endregion

        #region 20-30
        #endregion

        #region 30-40
        #endregion

        #region 40-50
        #endregion

        #region 50-60
        #endregion

        #region 60-80
        #endregion

        #region 80+
        #endregion

        #endregion
        public void Writeout(string s)
        {
            foreach (char c in s)
            {
                Thread.Sleep(rnd.Next(c));
                Console.Write(c);
            }
            Console.WriteLine("\n");
        }

        public int? Choises(string c1, string c2)
        {
            Console.WriteLine($"{c1}\n{c2}");
            ConsoleKey userInput = Console.ReadKey().Key;
            if (userInput == ConsoleKey.D1)
            {
                return 1;
            }
            else if (userInput == ConsoleKey.D2)
            {
                return 2;
            }
            else
            {
                return null;
            }

        }
    }
}

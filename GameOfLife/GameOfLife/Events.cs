
namespace GameOfLife
{
    internal class Events
    {
        Random rnd = new();
        public void EventPicker(Player p)
        {
            //TODO Inside cases do a random event.
            switch (p.age)
            {
                case < 5:
                    Console.WriteLine("Nutz!!");
                    BeingBorn(p);
                    break;
                case < 10:
                    p.status = (p.handicaps.Count == 0 ? "" : "");
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
            return;
            
        }
        #region Events
        void BeingBorn(Player p)
        {
            int[] nums = { 1, 2, 3, 4 };
            int luckyNumber;
            luckyNumber = rnd.Next(nums.Length);

            if (luckyNumber == 1)
            {
                p.handicaps.Add("Asthma");
                //foreach (string s in p.handicaps)
                //{
                //    Console.WriteLine(s);
                //}
                Console.WriteLine("You've been born with asthma. Luckily the doctors found out early, so you'll be fine...?");
            }
            else
            {
                Console.WriteLine("You've been born a normal and healthy child! ");
            }
            //TODO add a randomiser to pick between getting a pet and/or siblings.
            //
            int[] aging = { 5, 6, 7, 8, };
            //p.age = p.age + rnd.Next(p.villainry > 3 ?(nums.Length):(nums.Length)-1);
            int agingNumber = rnd.Next(aging.Length);
            p.age = p.age + aging[agingNumber];
        }
        #region 5-10

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
    }
}

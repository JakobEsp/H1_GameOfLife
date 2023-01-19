

namespace GameOfLife
{
    internal class Events
    {
        public void RandomEvent(Player p)
        {
            Random rnd = new();
            if (p.age < 5)
            {
                Console.WriteLine("Nutz!!");
                p.isAlive= false;
                return;
            }
            else if (p.age > 5 && p.age < 10)
            {

            }
            else if (p.age > 10 && p.age < 20)
            {

            }
            else if (p.age > 20 && p.age < 30)
            {

            }
            else if (p.age > 30 && p.age < 40)
            {

            }
            else if (p.age > 40 && p.age < 50)
            {

            }
            else if (p.age > 50 && p.age < 60)
            {

            }
            else if (p.age > 60 && p.age < 80)
            {

            }
            else if (p.age > 80)
            {

            }
        }
        #region Events

        #endregion
    }
}

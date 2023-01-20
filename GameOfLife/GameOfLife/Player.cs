
namespace GameOfLife
{
    internal class Player
    {
        public string? name { get; set; }
        public int? age { get; set; }
        public string? status { get; set; }
        public bool isAlive { get; set; }
        public int? villainry { get; set; } //Sort of a karma level determining the chances of something bad heppening to you. Anonymous to player 0 = good. 5 = bad
        public List<string>? handicaps { get; set; } = new();  
    }
}

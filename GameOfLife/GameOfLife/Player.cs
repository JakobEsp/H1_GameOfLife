
namespace GameOfLife
{
    internal class Player
    {
        public string? name { get; set; }
        public int? age { get; set; }
        public string? status { get; set; }
        public bool isAlive { get; set; }
        #region non diplayed values
        public int? villainry { get; set; }
        public string[]? handicaps { get; set; }
        #endregion
    }
}

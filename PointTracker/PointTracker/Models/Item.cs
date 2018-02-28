using SQLite;

namespace PointTracker
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Points { get; set; }
        public bool Done { get; set; }
    }
}
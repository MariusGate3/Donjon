namespace DungeonItems;

    public class Room
    {
        public int Depth { get; set; }
        public Room? Ascend { get; set; }
        public Room? LeftDescend { get; set; }
        public Room? RightDescend { get; set; }


        public Room(int depth, int maxDepth)
        {
            Depth = depth;
            Ascend = null;
            LeftDescend = depth < maxDepth ? new Room(depth + 1, maxDepth, this) : null;
            RightDescend = depth < maxDepth ? new Room(depth + 1, maxDepth, this) : null;
        }
        private Room(int depth, int maxDepth, Room ascend)
        {
            Depth = depth;
            Ascend = ascend;
            LeftDescend = depth < maxDepth ? new Room(depth + 1, maxDepth, this) : null;
            RightDescend = depth < maxDepth ? new Room(depth + 1, maxDepth, this) : null;
        }
    }
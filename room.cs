namespace DungeonItems;
    public class Room
    {
        Random random = new Random();
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
            // 1 = venstrerum, 2 = højrerum, 3 = begge.
            int r = random.Next(1, 4);
            if (r == 1) {
                LeftDescend = depth < maxDepth ? new Room(depth + 1, maxDepth, this) : null;
            } else if (r == 2) {
                RightDescend = depth < maxDepth ? new Room(depth + 1, maxDepth, this) : null;
            } else {
                LeftDescend = depth < maxDepth ? new Room(depth + 1, maxDepth, this) : null;
                RightDescend = depth < maxDepth ? new Room(depth + 1, maxDepth, this) : null;
            }
        }
    }
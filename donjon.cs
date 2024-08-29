using DungeonItems;

if (args.Length < 3) {
    Console.WriteLine("Use: ./donjon -g <n> <output>");
    return 1;
}
if (args[0] == "-g") {
    try{
        int n = int.Parse(args[1]);
        if (n < 1) {
            throw new ArgumentException($"Cannot create a dungeon with less than 1 level (tried to create with {n} levels).");
        }
        string output = args[2];

        Room entrance = new Room(0, n);
        RoomToJson.Convert(entrance, output);
    }
    catch (FormatException) {
        Console.WriteLine("Use: ./donjon -g <n> <output>, n must be an integer");
    }
    catch (ArgumentException ex)
    {
    Console.WriteLine(ex.Message);
    return 1;
    }
}
return 0;
namespace DungeonItems;
using System.Text.Json;
using System.Text.Json.Serialization;
public static class RoomToJson {
    public static void Convert (Room room, string outputPath) {
        var options = new JsonSerializerOptions {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize (room, options);
        File.WriteAllText (outputPath, jsonString);
    }
}
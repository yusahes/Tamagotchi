using System.IO;
using System.Text.Json;

public static class SaveManager
{
    private static string path = "save.json";

    public static void Save(Pet pet)
    {
        var json = JsonSerializer.Serialize(pet, pet.GetType());
        File.WriteAllText(path, json);
    }

    public static Pet Load()
    {
        if (!File.Exists(path)) return null;

        var json = File.ReadAllText(path);

        if (json.Contains("Dog"))
            return JsonSerializer.Deserialize<Dog>(json);

        return JsonSerializer.Deserialize<Cat>(json);
    }
}
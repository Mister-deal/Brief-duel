using System.Text.Json;
using System.Text.Json.Serialization;
using duel.Classes;

namespace duel;

public class GuerrierConverter : JsonConverter<Guerrier>
{
    public override Guerrier Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var jsonObject = document.RootElement;

        if (!jsonObject.TryGetProperty("Type", out var typeElement))
            throw new JsonException("Le champ 'Type' est manquant.");

        var type = typeElement.GetString();
        Guerrier guerrier = type switch
        {
            "Nain" => JsonSerializer.Deserialize<Nain>(jsonObject.GetRawText(), options),
            "Elfe" => JsonSerializer.Deserialize<Elfe>(jsonObject.GetRawText(), options),
            "Sorcier" => JsonSerializer.Deserialize<Sorcier>(jsonObject.GetRawText(), options),
            _ => throw new JsonException($"Type de guerrier inconnu : {type}")
        };

        return guerrier;
    }

    public override void Write(Utf8JsonWriter writer, Guerrier value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
    }
}
using System.Text.Json.Serialization;

public class Position
{
    public Position()
    {
        
    }

    public Position(int x_, int y_)
    {
        x = x_;
        y = y_;
    }

    [JsonPropertyName("x")]
    public int x { get; set; }

    [JsonPropertyName("y")]
    public int y { get; set; }
}

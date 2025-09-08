using System.Text.Json.Serialization; // [JsonInclude]

namespace WorkingWithJson;

public class Book
{
    // constructor to set non-nullable property
    public Book(string title)
    {
        Title = title;
    }
    // properties
    public string Title { get; set; }
    public string? Author { get; set; }
    // fields
    [JsonInclude] // include this field
    public DateOnly PublishDate;
    [JsonInclude] // include this field
    public DateTimeOffset Created;
    public ushort Pages;
}

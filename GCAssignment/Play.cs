namespace GCAssignment;

public class Play
{
    public string Title { get; }
    public string AuthorFullName { get; }
    public string Genre { get; }
    public int Year { get; }

    public Play(string title, string authorFullName, string genre, int year)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required");
        if (string.IsNullOrWhiteSpace(authorFullName)) throw new ArgumentException("Author is required");
        if (string.IsNullOrWhiteSpace(genre))
            throw new ArgumentException("Genre is required.", nameof(genre));
        if (year < 0 || year > DateTime.Now.Year) throw new ArgumentOutOfRangeException(nameof(year));

        Title = title.Trim();
        AuthorFullName = authorFullName.Trim();
        Genre = genre.Trim();
        Year = year;
    }

    public override string ToString()
        => $"{Title} ({Year}), {AuthorFullName} — {Genre}";

    ~Play()
    {
        //to show that destructor works
        Console.WriteLine($"Play '{Title}' will be finalized by GC.");
    }
}

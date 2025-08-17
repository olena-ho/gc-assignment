namespace GCAssignment;

public class Play : IDisposable
{
    public string Title { get; }
    public string AuthorFullName { get; }
    public string Genre { get; }
    public int Year { get; }
    private bool _disposed;

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
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing)
        {
            // managed cleanup (none now)
            Console.WriteLine($"Play '{Title}' disposed (via Dispose/using).");
        }
        else
        {
            // finalizer path
            Console.WriteLine($"Play '{Title}' cleaned up by finalizer.");
        }

        // unmanaged cleanup (none now)
        _disposed = true;
    }
}

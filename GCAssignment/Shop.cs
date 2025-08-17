namespace GCAssignment;

public enum ShopType
{
    Groceries,
    Household,
    Clothing,
    Footwear
}

public class Shop : IDisposable
{
    public string Name { get; }
    public string Address { get; }
    public ShopType Type { get; }

    private bool _disposed;

    public Shop(string name, string address, ShopType type)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name is required");
        if (string.IsNullOrWhiteSpace(address)) throw new ArgumentException("Address is required");
        if (!Enum.IsDefined(typeof(ShopType), type))
            throw new ArgumentOutOfRangeException(nameof(type), "Unknown shop type.");

        Name = name.Trim();
        Address = address.Trim();
        Type = type;
    }

    public override string ToString() => $"{Name} ({Type}) — {Address}";

    public void Dispose()
    {
        if (_disposed) return;

        // No resources to free right now - just demonstration
        Console.WriteLine($"Shop '{Name}' disposed.");

        _disposed = true;
    }
}


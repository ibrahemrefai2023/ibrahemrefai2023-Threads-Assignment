namespace InvoiceExport;

public sealed class CustomerFileStore
{
    readonly string _folder;

    public CustomerFileStore(string folder) => _folder = folder;

    public async Task<CustomerProfile> ReadProfile(int customerId)
    {
        string path = Path.Combine(_folder, $"customer-{customerId}.txt");
        await Task.Delay(300);
        string? text = "";
        using StreamReader reader = new(path);
        {
            while(( text = reader.ReadLine()) != null)
                Console.WriteLine(text);
        }
        //string text = File.ReadAllText(path);
        string[] parts = text?.Split('|') ?? new string[0];
        int.TryParse(parts[0], out var partOne);
        return new CustomerProfile(partOne, parts[1], parts[2]);
    }
}

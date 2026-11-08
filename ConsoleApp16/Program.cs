using ConsoleApp16;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите цену товара: ");
        var priceInput = Console.ReadLine();

        if (!decimal.TryParse(priceInput, out decimal price))
        {
            Console.WriteLine("цена должна быть числом и не может быть отрицательной");
            return;
        }

        Console.Write("Введите количество: ");
        var quantityInput = Console.ReadLine();

        if (!decimal.TryParse(quantityInput, out decimal quantity))
        {
            Console.WriteLine("количество должно быть числом и не может быть меньше 1");
            return;
        }

        Receipt receipt = CalculateRecipt(price, quantity);

        PrintReceipt(receipt);
    }
    static Receipt CalculateRecipt(decimal price, decimal quantity)
    {
        decimal sum = price * quantity;

        decimal discountPercent = 0m;

        if (sum >= 5000m)
        {
            discountPercent = 15m;
        }
        else if (sum >= 1000m)
        {
            discountPercent = 10m;
        }

        decimal total = sum * ((100 - discountPercent) / 100);

        Receipt receipt = new Receipt(price, quantity, discountPercent, sum, total);
        return receipt;
    }
    static void PrintReceipt(Receipt receipt)
    {
        Console.WriteLine($"\nДата:             {DateTime.Now:dd.MM.yyyy HH:mm}");
        Console.WriteLine($"Цена:             {receipt.Price} руб");
        Console.WriteLine($"Количество:       {receipt.Quantity}");
        Console.WriteLine($"Скидка:           {receipt.DiscountPercent}%");
        Console.WriteLine($"Итог без скидки:  {receipt.Sum} руб");
        Console.WriteLine($"Итого:            {receipt.Total} руб");
    }
}
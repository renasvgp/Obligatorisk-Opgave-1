namespace OblOpg1;

public class Car
{
    public int Id { get; set; }

    public string? model { get; set; }

    public int price { get; set; }

    public string? licensePlate { get; set; }

    public bool ValidateId()
    {
        return Id >= 1;
    }

    public bool ValidateModel()
    {
        return model?.Length >= 4;
    }

    public bool ValidatePrice()
    {
        return price > 0;
    }

    public bool ValidateLicensePlate()
    {
        return licensePlate?.Length is >= 2 and <= 7;
    }
}


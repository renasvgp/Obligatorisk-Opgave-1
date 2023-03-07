using OblOpg1;

namespace OblOpg1Test;

[TestClass]
public class CarTest
{
    [TestMethod]
    public void TestValidateId()
    {
        // Vi laver en ny bil og tester om bilens ID er gyldigt.
        // Hvis ID er 1 eller over testen gyldig.
        var car = new Car();

        car.Id = -1;
        Assert.IsFalse(car.ValidateId());

        car.Id = 0;
        Assert.IsFalse(car.ValidateId());

        car.Id = 1;
        Assert.IsTrue(car.ValidateId());
    }

    [TestMethod]
    public void TestValidateModel()
    {
        // Hvis model er minimun 4 bogstaver er testen gyldig.
        var car = new Car();

        car.model = null;
        Assert.IsFalse(car.ValidateModel());

        car.model = "";
        Assert.IsFalse(car.ValidateModel());

        car.model = "123";
        Assert.IsFalse(car.ValidateModel());

        car.model = "ABCD";
        Assert.IsTrue(car.ValidateModel());
    }

    [TestMethod]
    public void TestValidatePrice()
    {
        // Hvis price er minimum 1 er testen gyldig.
        var car = new Car();

        car.price = -1;
        Assert.IsFalse(car.ValidatePrice());

        car.price = 0;
        Assert.IsFalse(car.ValidatePrice());

        car.price = 1;
        Assert.IsTrue(car.ValidatePrice());
    }

    [TestMethod]
    public void TestValidateLicensePlate()
    {
        // Hvis License Plate er mellem 2 og 7 bogstaver er testen gyldig.
        var car = new Car();

        car.licensePlate = null;
        Assert.IsFalse(car.ValidateLicensePlate());

        car.licensePlate = "";
        Assert.IsFalse(car.ValidateLicensePlate());

        car.licensePlate = "A";
        Assert.IsFalse(car.ValidateLicensePlate());

        car.licensePlate = "AB";
        Assert.IsTrue(car.ValidateLicensePlate());

        car.licensePlate = "ABCDEFG";
        Assert.IsTrue(car.ValidateLicensePlate());

        car.licensePlate = "ABCDEFGH";
        Assert.IsFalse(car.ValidateLicensePlate());
    }
}


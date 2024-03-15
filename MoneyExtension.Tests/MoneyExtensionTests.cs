namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShoudConvertDecimalToInt()
    {
        decimal valor = 3453.43M;

        var cents = valor.ToCents();


        Assert.AreEqual(345343, cents);
    }
}
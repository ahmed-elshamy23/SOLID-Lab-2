namespace Task_3;

public interface ICreditCard
{
    void Charge();
}

public class VisaCard : ICreditCard
{
    public void Charge() => Console.WriteLine("Charging using Visa Card........");
}

public class MasterCard : ICreditCard
{
    public void Charge() => Console.WriteLine("Charging using MasterCard........");
}

public class Shopper
{
    public void Checkout(ICreditCard card)
    {
        card.Charge();
    }
}
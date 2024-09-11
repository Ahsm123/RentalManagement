namespace RentalManagement.ClassLibrary;

public class Car : IServiceable, IRentable
{
    private const int serviceInterval = 10000;
    public int mileageAtLastService;
    public string Description { get; set; }
    public bool IsAvailable { get; set; }
    public int Mileage { get; set; }
    public bool NeedsService
    {
        get
        {
            if ((Mileage - mileageAtLastService) >= serviceInterval){
                IsAvailable = false;
                return true;
            }
            return false;
        }
    }
    public int TopSpeed { get; set; }

    public Car(string description, int topSPeed, int mileage = 0)
    {
        Description = description;
        TopSpeed = topSPeed;
        Mileage = mileage;
        IsAvailable = true;
        mileageAtLastService = Mileage;
    }

    public void Drive(int distance)
    {
        Mileage += distance;
    }

    public void Rent()
    {
        if (IsAvailable == true)
        {
            IsAvailable = false;
        }
    }

    public void ResetNeedForService()
    {
        mileageAtLastService = Mileage;
    }
}

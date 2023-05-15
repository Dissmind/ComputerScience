namespace ComputerScience.DesignPetterns.Observer.WetherStationExample;


public interface IObserver
{
    public void Update(float temp, float humidity, float pressure);
}

public interface ISubject
{
    public void RegistrationObserver(IObserver o);
    public void RemoveObserver(IObserver o);
    public void NotifyObserver();
}

public class DisplayElement
{
    public void Display()
    {
        throw new NotImplementedException();
    }
}

public class WeatherData : ISubject
{
    private List<IObserver> observers;
    
    public WeatherData()
    {
        observers = new List<IObserver>();
    }

    
    private float temperature;
    private float humidity;
    private float pressure;
    
    
    
    public void RegistrationObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }

    public void NotifyObserver()
    {
        foreach (var i in observers)
        {
            i.Update(temperature, humidity, pressure);
        }
    }

    public void MeasurementChanged()
    {
        NotifyObserver();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        
        MeasurementChanged();
    } 
}
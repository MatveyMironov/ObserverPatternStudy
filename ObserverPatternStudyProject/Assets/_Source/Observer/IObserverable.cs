namespace DayCycleSystem
{
    public interface IObserverable
    {
        public void RegisterObserver(IObserver observer);

        public void RemoveObserver(IObserver observer);

        public void Notify();
    }
}
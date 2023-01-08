namespace StrategyDesignPattern
{
    // This interface handles adding, deleting and updating
    // all observers 
    public interface ISubject
    {
        public void Register(IObserver observer);
        public void UnRegister(IObserver observer);
        public void NotifyObserver();
    }
}
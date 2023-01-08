namespace StrategyDesignPattern
{
    // The Observers update method is called when the Subject changes
    public interface IObserver
    {
        public void Update(double ibmPrice, double aaplPrice, double googPrice);
    }
}
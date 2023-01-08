namespace StrategyDesignPattern
{
    // Uses the Subject interface to update all Observers

    public class StockGrabber : ISubject
    {
        // Creates an List to hold all observers
        private List<IObserver> _observers;
        private double ibmPrice;
        private double aaplPrice;
        private double googPrice;
        public StockGrabber()
        {
            _observers = new List<IObserver>();
        }
        public void NotifyObserver()
        {
            // Cycle through all observers and notifies them of
            //price changes
            foreach (var observer in _observers)
            {
                observer.Update(ibmPrice, aaplPrice, googPrice);
            }
        }

        public void Register(IObserver observer)
        {
            //Adds a new observer to the List
            _observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            // Get the index of the observer to delete
            int observerIndex = _observers.IndexOf(observer);

            // Print out message (Have to increment index to match)
            Console.WriteLine($"Observer {observerIndex} deleted");

            // Removes observer from the ArrayList
            _observers.RemoveAt(observerIndex);
        }


        public double IBMPrice
        {
            get { return ibmPrice; }
            set
            {
                ibmPrice = value;
                NotifyObserver();
            }
        }

        public double AAPLPrice
        {
            get { return aaplPrice; }
            set
            {
                aaplPrice = value;
                NotifyObserver();
            }
        }

        public double GOOGPrice
        {
            get { return googPrice; }
            set
            {
                googPrice = value;
                NotifyObserver();
            }
        }
    }
}
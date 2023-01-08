// Represents each Observer that is monitoring changes in the ISubject

using StrategyDesignPattern;

namespace ObserverDesignPattern
{
    public class StockObserver : IObserver
    {


        private double ibmPrice;
        private double aaplPrice;
        private double googPrice;

        // Static used as a counter

        private static int observerIDTracker = 0;

        // Used to track the observers

        private int observerID;

        // Will hold reference to the StockGrabber object

        private ISubject stockGrabber;

        public StockObserver(ISubject stockGrabber)
        {

            // Store the reference to the stockGrabber object so
            // I can make calls to its methods

            this.stockGrabber = stockGrabber;

            // Assign an observer ID and increment the static counter

            observerID = ++observerIDTracker;

            // Message notifies user of new observer

            Console.WriteLine("New Observer " + observerID);

            // Add the observer to the ISubjects ArrayList

            stockGrabber.Register(this);

        }

        // Called to update all observers

        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {

            this.ibmPrice = ibmPrice;
            this.aaplPrice = aaplPrice;
            this.googPrice = googPrice;

            printThePrices();

        }

        public void printThePrices()
        {

            Console.WriteLine(observerID + "\nIBM: " + ibmPrice + "\nAAPL: " +
                    aaplPrice + "\nGOOG: " + googPrice + "\n");

        }
    }
}
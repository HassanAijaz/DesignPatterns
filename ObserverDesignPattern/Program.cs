using ObserverDesignPattern;

namespace StrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the Subject object
            // It will handle updating all observers 
            // as well as deleting and adding them

            StockGrabber stockGrabber = new StockGrabber();

            // Create an Observer that will be sent updates from Subject

            StockObserver observer1 = new(stockGrabber);

            stockGrabber.IBMPrice = 197.00;
            stockGrabber.AAPLPrice = 677.60;
            stockGrabber.GOOGPrice = 676.40;

            StockObserver observer2 = new(stockGrabber);

            stockGrabber.IBMPrice = 197.00;
            stockGrabber.AAPLPrice = 677.60;
            stockGrabber.GOOGPrice = 676.40;

            // Delete one of the observers
            stockGrabber.UnRegister(observer2);
            stockGrabber.IBMPrice = 197.00;
            stockGrabber.AAPLPrice = 677.60;
            stockGrabber.GOOGPrice = 676.40;

            // Create 3 threads using the Runnable interface
            // GetTheStock implements Runnable, so it doesn't waste 
            // its one extendable class option

            var getIBM = new GetTheStocks(stockGrabber, 2, "IBM", 197.00);
            var getAAPL = new GetTheStocks(stockGrabber, 2, "AAPL", 677.60);
            var getGOOG = new GetTheStocks(stockGrabber, 2, "GOOG", 676.40);

            // Call for the code in run to execute 

            new Thread(() => getIBM.Run()).Start();
            new Thread(() => getAAPL.Run()).Start();
            new Thread(() => getGOOG.Run()).Start();
        }
    }
}
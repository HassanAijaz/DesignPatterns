namespace StrategyDesignPattern
{
    public class GetTheStocks
    {
        // Could be used to set how many seconds to wait
        // in Thread.sleep() below

        // private int startTime; 
        private string stock;
        private double price;

        // Will hold reference to the StockGrabber object
        private ISubject stockGrabber;

        public GetTheStocks(ISubject stockGrabber, int newStartTime, String newStock, double newPrice)
        {
            // Store the reference to the stockGrabber object so
            // I can make calls to its methods

            this.stockGrabber = stockGrabber;

            // startTime = newStartTime;  Not used to have variable sleep time
            stock = newStock;
            price = newPrice;
        }

        public void Run()
        {
            for (int i = 1; i <= 20; i++)
            {
                try
                {
                    // Sleep for 2 seconds
                    Thread.Sleep(2000);

                    // Use Thread.sleep(startTime * 1000); to 
                    // make sleep time variable
                }
                catch (Exception e)
                { }

                // Generates a random number between -.03 and .03
                double randNum = (new Random().Next() * (.06)) - .03;

                // Formats decimals to 2 places
                price = price + randNum;

                if (stock == "IBM") ((StockGrabber)stockGrabber).IBMPrice = price;
                if (stock == "AAPL") ((StockGrabber)stockGrabber).AAPLPrice = price;
                if (stock == "GOOG") ((StockGrabber)stockGrabber).GOOGPrice = price;

                Console.WriteLine($"{stock} : {price + randNum} {randNum}");
            }
        }
    }
}
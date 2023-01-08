namespace StrategyDesignPattern
{
    //Class used if the Animal can't fly

    class CantFly : IFlys
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}

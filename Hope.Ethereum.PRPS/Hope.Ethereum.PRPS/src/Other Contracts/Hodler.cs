namespace Hope.Ethereum.PRPS
{
    public sealed class Hodler : EthereumContract
    {
        private const string HODLER_MAINNET = "0x77D0c79c83B3A14092d5C0C12145645cC9CEdc75";
        private const string HODLER_RINKEBY = "0x23EdF403e7da17A0BE3E65CB3318638c826dEd23";

        public Hodler() : base(HODLER_MAINNET, HODLER_RINKEBY)
        {
        }
    }
}

using Hope.Ethereum.Tokens;

namespace Hope.Ethereum.PRPS
{
    public sealed class DUBI : ERC20
    {
        private const string DUBI_MAINNET = "0x9c6Fa42209169bCeA032e401188a6fc3e9C9f59c";
        private const string DUBI_RINKEBY = "0x8b069Ecf7BF230E153b8Ed903bAbf24403ccA203";

        public DUBI() : base(DUBI_MAINNET, DUBI_RINKEBY, "Decentralized Universal Basic Income", "DUBI", 18)
        {
        }
    }
}
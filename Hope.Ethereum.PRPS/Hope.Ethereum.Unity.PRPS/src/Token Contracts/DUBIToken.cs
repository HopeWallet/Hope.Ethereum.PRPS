using Hope.Ethereum.Unity.Tokens;

namespace Hope.Ethereum.Unity.PRPS
{
    public sealed class DUBIToken : ERC20
    {
        private const string DUBI_MAINNET = "";
        private const string DUBI_RINKEBY = "";

        public DUBIToken() : base(DUBI_MAINNET, DUBI_RINKEBY, "Decentralized Universal Basic Income", "DUBI", 18)
        {
        }
    }
}
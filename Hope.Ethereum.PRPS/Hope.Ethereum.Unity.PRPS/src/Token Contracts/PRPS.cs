using Hope.Ethereum.Unity.Tokens;

namespace Hope.Ethereum.Unity.PRPS
{
    public sealed class PRPS : ERC20
    {
        private const string PRPS_MAINNET = "0xd94F2778e2B3913C53637Ae60647598bE588c570";
        private const string PRPS_RINKEBY = "0x5831819C84C05DdcD2568dE72963AC9f1e6831b6";

        public PRPS() : base(PRPS_MAINNET, PRPS_RINKEBY, "Purpose", "PRPS", 18)
        {
        }
    }
}

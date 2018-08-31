using Hope.Ethereum.Unity.Tokens;

namespace Hope.Ethereum.Unity.PRPS
{
    public sealed class PRPSToken : ERC20
    {
        private const string PRPS_MAINNET = "";
        private const string PRPS_RINKEBY = "";

        public PRPSToken() : base(PRPS_MAINNET, PRPS_RINKEBY, "Purpose", "PRPS", 18)
        {
        }
    }
}

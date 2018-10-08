using Hope.Ethereum.Unity.Tokens;

namespace Hope.Ethereum.Unity.PRPS
{
    public sealed class PRPS : ERC20
    {
        private const string PRPS_MAINNET = "0xE40C374d8805b1dD58CDcEFf998A2F6920Cb52FD";
        private const string PRPS_RINKEBY = "0x5831819C84C05DdcD2568dE72963AC9f1e6831b6";

        public PRPS() : base(PRPS_MAINNET, PRPS_RINKEBY, "Purpose", "PRPS", 18)
        {
        }
    }
}

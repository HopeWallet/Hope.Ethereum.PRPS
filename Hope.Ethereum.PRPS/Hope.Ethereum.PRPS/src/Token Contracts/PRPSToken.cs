using Hope.Ethereum.Tokens;

namespace Hope.Ethereum.PRPS
{
    public sealed class PRPSToken : ERC20
    {
        public PRPSToken(string mainnetAddress, string rinkebyAddress) : base(mainnetAddress, rinkebyAddress)
        {
        }

        public PRPSToken(string mainnetAddress) : base(mainnetAddress)
        {
        }

        public PRPSToken(string mainnetAddress, string name, string symbol, int decimals) : base(mainnetAddress, name, symbol, decimals)
        {
        }

        public PRPSToken(string mainnetAddress, string rinkebyAddress, string name, string symbol, int decimals) : base(mainnetAddress, rinkebyAddress, name, symbol, decimals)
        {
        }
    }
}

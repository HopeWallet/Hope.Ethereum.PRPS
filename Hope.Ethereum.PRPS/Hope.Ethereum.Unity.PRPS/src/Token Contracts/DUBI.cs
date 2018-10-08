using Hope.Ethereum.Unity.Tokens;

namespace Hope.Ethereum.Unity.PRPS
{
    public sealed class DUBI : ERC20
    {
        private const string DUBI_MAINNET = "0xEd7fEA78C393cF7B17B152A8c2D0CD97aC31790B";
        private const string DUBI_RINKEBY = "0x8b069Ecf7BF230E153b8Ed903bAbf24403ccA203";

        public DUBI() : base(DUBI_MAINNET, DUBI_RINKEBY, "Decentralized Universal Basic Income", "DUBI", 18)
        {
        }
    }
}
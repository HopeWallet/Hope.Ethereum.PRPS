using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace Hope.Ethereum.Unity.PRPS
{
    /// <summary>
    /// Class which represents the Hodler smart contract used for locking purpose and receiving dubi.
    /// </summary>
    public sealed partial class Hodler : EthereumContract
    {
        /// <summary>
        /// Class which holds messages for interacting with the Hodler smart contract.
        /// </summary>
        public static partial class Messages
        {
            /// <summary>
            /// Function used for releasing some locked purpose.
            /// </summary>
            [Function("release")]
            public sealed class Release : FunctionMessage
            {
                /// <summary>
                /// The id of the locked purpose.
                /// </summary>
                [Parameter("uint256", "_id", 1)]
                public BigInteger Id { get; set; }
            }
        }
    }
}
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace Hope.Ethereum.PRPS
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
            /// Function used for locking some purpose into the hodler smart contract.
            /// </summary>
            [Function("hodl")]
            public sealed class Hodl : FunctionMessage
            {
                /// <summary>
                /// The id to assign to the purpose that will be locked.
                /// </summary>
                [Parameter("uint256", "_id", 1)]
                public BigInteger Id { get; set; }

                /// <summary>
                /// The amount of purpose to lock.
                /// </summary>
                [Parameter("uint256", "_value", 2)]
                public BigInteger Value { get; set; }

                /// <summary>
                /// The number of months to lock the purpose for. Only 3, 6, or 12 is valid.
                /// </summary>
                [Parameter("uint256", "_months", 3)]
                public BigInteger Months { get; set; }
            }
        }
    }
}
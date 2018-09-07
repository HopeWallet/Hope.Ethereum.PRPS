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
        /// Class which holds any queries in the Hodler smart contract.
        /// </summary>
        public static partial class Queries
        {
            /// <summary>
            /// Class which represents the query for receiving the status of locked purpose.
            /// </summary>
            [Function("getItem", typeof(Output.Item))]
            public sealed class GetItem : FunctionMessage
            {
                /// <summary>
                /// The user who locked the purpose.
                /// </summary>
                [Parameter("address", "_user", 1)]
                public string User { get; set; }

                /// <summary>
                /// The id of the locked purpose.
                /// </summary>
                [Parameter("uint256", "_id", 2)]
                public BigInteger Id { get; set; }
            }
        }
    }
}
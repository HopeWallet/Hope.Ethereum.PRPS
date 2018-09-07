using Nethereum.ABI.FunctionEncoding.Attributes;
using System.Numerics;

namespace Hope.Ethereum.PRPS
{
    /// <summary>
    /// Class which represents the Hodler smart contract used for locking purpose and receiving dubi.
    /// </summary>
    public sealed partial class Hodler : EthereumContract
    {
        /// <summary>
        /// Class which represents unique output for the Hodler smart contract.
        /// </summary>
        public static partial class Output
        {
            /// <summary>
            /// Class which contains the info for purpose locked into the hodler smart contract.
            /// </summary>
            [FunctionOutput]
            public sealed class Item : IFunctionOutputDTO
            {
                /// <summary>
                /// The id of this hodl'd item.
                /// </summary>
                [Parameter("uint256", "id", 1)]
                public BigInteger Id { get; set; }

                /// <summary>
                /// The address of whoever executed this hodl.
                /// </summary>
                [Parameter("address", "beneficiary", 2)]
                public string Beneficiary { get; set; }

                /// <summary>
                /// The amount of purpose that was locked.
                /// </summary>
                [Parameter("uint256", "value", 3)]
                public BigInteger Value { get; set; }

                /// <summary>
                /// The unix time stamp when the lock period will conclude.
                /// </summary>
                [Parameter("uint256", "releaseTime", 4)]
                public BigInteger ReleaseTime { get; set; }

                /// <summary>
                /// Whether this item has been reclaimed and the purpose no longer exists in the contract.
                /// </summary>
                [Parameter("bool", "fulfilled", 5)]
                public bool Fulfilled { get; set; }
            }
        }
    }
}
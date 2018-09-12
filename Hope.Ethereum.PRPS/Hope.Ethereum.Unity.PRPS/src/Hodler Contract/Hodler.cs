using Hope.Ethereum.Unity.Promises;
using Hope.Ethereum.Unity.Utils;
using System.Numerics;

namespace Hope.Ethereum.Unity.PRPS
{
    public sealed partial class Hodler : EthereumContract
    {
        private const string HODLER_MAINNET = "0x77D0c79c83B3A14092d5C0C12145645cC9CEdc75";
        private const string HODLER_RINKEBY = "0x23EdF403e7da17A0BE3E65CB3318638c826dEd23";

        public Hodler() : base(HODLER_MAINNET, HODLER_RINKEBY)
        {
        }

        /// <summary>
        /// Gets an item that is locked given the id.
        /// </summary>
        /// <param name="addressFrom"> The address to check for the item. </param>
        /// <param name="id"> The id which holds an item in the mapping. </param>
        public EthCallPromise<Output.Item> GetItem(string addressFrom, BigInteger id)
        {
            return ContractUtils.QueryContract<Queries.GetItem, Output.Item>(new Queries.GetItem { Id = id }, ContractAddress, addressFrom);
        }

        /// <summary>
        /// Locks a certain amount of purpose into the Hodler smart contract.
        /// </summary>
        /// <param name="privateKey"> The private key of the address sending the transaction. </param>
        /// <param name="gasLimit"> The gas limit to send with the transaction. </param>
        /// <param name="gasPrice"> The gas price to send with the transaction. </param>
        /// <param name="id"> The id of the lock function call. </param>
        /// <param name="lockAmount"> The amount of purpose to lock. </param>
        /// <param name="monthsToLock"> How many months the purpose should be locked for. </param>
        public EthTransactionPromise Hodl(string privateKey, BigInteger gasLimit, BigInteger gasPrice, BigInteger id, decimal lockAmount, int monthsToLock)
        {
            Messages.Hodl hodl = new Messages.Hodl
            {
                Id = id,
                Value = SolidityUtils.ConvertToUInt(lockAmount, 18),
                Months = monthsToLock
            };

            return ContractUtils.SendContractMessage(hodl, privateKey, ContractAddress, gasPrice, gasLimit);
        }

        /// <summary>
        /// Releases some purpose from the Hodler smart contract.
        /// </summary>
        /// <param name="privateKey"> The private key of the address sending the transaction. </param>
        /// <param name="gasLimit"> The gas limit to send with the transaction. </param>
        /// <param name="gasPrice"> The gas price to send with the transaction. </param>
        /// <param name="id"> The id of the locked purpose item. </param>
        public EthTransactionPromise Release(string privateKey, BigInteger gasLimit, BigInteger gasPrice, BigInteger id)
        {
            return ContractUtils.SendContractMessage(new Messages.Release { Id = id }, privateKey, ContractAddress, gasPrice, gasLimit);
        }
    }
}

using AElf.Sdk.CSharp.State;

namespace AElf.Contracts.FourthTestContract
{
    /// <summary>
    /// The state class of the contract, it inherits from the AElf.Sdk.CSharp.State.ContractState type. 
    /// </summary>
    public class FourthTestContractState : ContractState
    {
        // state definitions go here.

        public SingletonState<UserList> userlist { set; get; }

    }
}
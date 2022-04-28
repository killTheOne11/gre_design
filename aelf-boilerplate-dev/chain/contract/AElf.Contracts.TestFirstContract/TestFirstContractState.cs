using System;
using AElf.Sdk.CSharp.State;

namespace AElf.Contracts.TestFirstContract
{
    /// <summary>
    /// The state class of the contract, it inherits from the AElf.Sdk.CSharp.State.ContractState type. 
    /// </summary>
    public class TestFirstContractState : ContractState
    {
        // state definitions go here.
        public SingletonState<UserList> userlist { set; get; }
        public SingletonState<AadminList> adminlist { set; get; }
        
        public SingletonState<AddedProjectList>addedprojectlist { set; get; }

        public SingletonState<WaitAddProjectList> waitaddprojectlist { set; get; }
        public SingletonState<Int32> userid { set; get; }
        public SingletonState<Int32> adminid { set; get; }
        public SingletonState<Int32> handleprojectid { set; get; }
        public SingletonState<Int32> addprojectid { set; get; }
        
    }
}